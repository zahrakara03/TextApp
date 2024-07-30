using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Media;
using System.Net;
using System.Net.Sockets;

namespace TextApp
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        static readonly TcpConnection serverConnection = new TcpConnection();
        static readonly TcpConnection clientConnection = new TcpConnection();

        enum Tcp
        {
            LISTEN,
            INITIAL_CONNECT,
            CONNECT,
            IDLE,
            SENDING,
            RECEIVING,
            DISCONNECT,
            RECONNECT,
            CLOSE
        }

        static Tcp serverState = Tcp.LISTEN;
        static Tcp clientState = Tcp.CONNECT;

        static volatile bool serverStartButtonFlag = false;
        static volatile bool clientStartButtonFlag = false;
        static volatile bool sendingStringFilledFlag = false;
        static volatile bool tcpConnectedFlag = false;

        static volatile string sendingString = "";
        static volatile string receivingString = "";

        static volatile int port = 0;
        static volatile string ip = "";

        // SERVER LOOP (LISTENER)
        void TcpServerLoop()
        {
            try
            {
                bool closeFlag = false;
                sendingStringFilledFlag = false;
                sendingString = "";
                receivingString = "";

                serverTextboxBig.Invoke((MethodInvoker)delegate {
                    serverTextboxBig.Text = "";
                });

                serverState = Tcp.LISTEN;

                while (!closeFlag)
                {
                    if (!serverStartButtonFlag)
                    {
                        serverState = Tcp.CLOSE;
                    }

                    switch (serverState)
                    {
                        case Tcp.LISTEN:
                            serverTextboxBig.Invoke((MethodInvoker)delegate {
                                serverStartButton.Enabled = false;
                                serverSendButton1.Enabled = false;
                                //serverSendButton2.Enabled = false;
                                serverTextboxBig.AppendText("Waiting for a client..." + Environment.NewLine);
                                serverTextboxBig.ScrollToCaret();
                            });

                            if (serverConnection.TryListen(port, out string remoteEndpointAddress))
                            {
                                serverTextboxBig.Invoke((MethodInvoker)delegate {
                                    serverStartButton.Enabled = true;
                                    serverSendButton1.Enabled = true;
                                    //serverSendButton2.Enabled = true;
                                    serverTextboxBig.AppendText("Connected to " + remoteEndpointAddress + Environment.NewLine);
                                    serverTextboxBig.ScrollToCaret();
                                });

                                if (serverConnection.TryReadingData())
                                {
                                    tcpConnectedFlag = true;
                                    serverState = Tcp.IDLE;
                                }
                                else
                                {
                                    serverState = Tcp.DISCONNECT;
                                }
                            }
                            else
                            {
                                serverState = Tcp.DISCONNECT;
                            }
                            break;

                        case Tcp.IDLE:
                            if (serverConnection.TcpIsConnected)
                            {
                                if (sendingStringFilledFlag)
                                {
                                    serverState = Tcp.SENDING;
                                }
                                else
                                {
                                    serverState = Tcp.RECEIVING;
                                }
                            }
                            else
                            {
                                serverState = Tcp.DISCONNECT;
                            }
                            break;

                        case Tcp.SENDING:
                            if (serverConnection.TrySend(sendingString))
                            {
                                serverTextboxBig.Invoke((MethodInvoker)delegate {
                                    serverTextboxBig.AppendText("Sending: " + sendingString + Environment.NewLine);
                                    serverTextboxBig.ScrollToCaret();
                                });

                                sendingString = "";
                                sendingStringFilledFlag = false;
                                serverState = Tcp.IDLE;
                            }
                            else
                            {
                                serverState = Tcp.DISCONNECT;
                            }
                            break;

                        case Tcp.RECEIVING:
                            receivingString = serverConnection.GetReceivedString();

                            if (receivingString != null)
                            {
                                serverTextboxBig.Invoke((MethodInvoker)delegate {
                                    serverTextboxBig.AppendText("Receiving: " + receivingString + Environment.NewLine);
                                    serverTextboxBig.ScrollToCaret();
                                });

                                receivingString = null;
                            }
                            serverState = Tcp.IDLE;
                            break;

                        case Tcp.DISCONNECT:
                            sendingString = "";
                            receivingString = "";
                            sendingStringFilledFlag = false;
                            tcpConnectedFlag = false;

                            serverTextboxBig.Invoke((MethodInvoker)delegate {
                                serverStartButton.Enabled = false;
                                serverSendButton1.Enabled = false;
                                //serverSendButton2.Enabled = false;
                                serverTextboxBig.AppendText("Problem occurred! Reconnecting..." + Environment.NewLine);
                                serverTextboxBig.ScrollToCaret();
                            });

                            serverConnection.Disconnect();

                            serverState = Tcp.LISTEN;
                            break;

                        case Tcp.CLOSE:
                            sendingString = "";
                            receivingString = "";
                            sendingStringFilledFlag = false;
                            tcpConnectedFlag = false;

                            serverTextboxBig.Invoke((MethodInvoker)delegate {
                                serverTextboxBig.AppendText("Disconnected..." + Environment.NewLine);
                                serverTextboxBig.ScrollToCaret();
                            });

                            serverConnection.Dispose();
                            closeFlag = true;
                            break;

                        default:
                            serverState = Tcp.CLOSE;
                            break;
                    }
                    Thread.Sleep(1); //for decreasing the CPU usage
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLEASE RESTART! TcpServerLoop-thread error: \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLIENT LOOP
        void TcpClientLoop()
        {
            try
            {
                bool closeFlag = false;
                sendingString = "";
                receivingString = "";

                clientTextboxBig.Invoke((MethodInvoker)delegate {
                    clientTextboxBig.Text = "";
                });

                clientState = Tcp.INITIAL_CONNECT;

                while (!closeFlag)
                {
                    if (!clientStartButtonFlag)
                    {
                        clientState = Tcp.CLOSE;
                    }

                    switch (clientState)
                    {
                        case Tcp.INITIAL_CONNECT:
                            clientTextboxBig.Invoke((MethodInvoker)delegate {
                                clientStartButton.Enabled = false;
                                clientSendButton1.Enabled = false;
                                //clientSendButton2.Enabled = false;
                                clientTextboxBig.AppendText("Connecting..." + Environment.NewLine);
                                clientTextboxBig.ScrollToCaret();
                            });

                            if (clientConnection.TryConnect(ip, port))
                            {
                                clientTextboxBig.Invoke((MethodInvoker)delegate {
                                    clientStartButton.Enabled = true;
                                    clientSendButton1.Enabled = true;
                                    //clientSendButton2.Enabled = true;
                                    clientTextboxBig.AppendText("Connected!" + Environment.NewLine);
                                    clientTextboxBig.ScrollToCaret();
                                });

                                if (clientConnection.TryReadingData())
                                {
                                    tcpConnectedFlag = true;
                                    clientState = Tcp.IDLE;
                                }
                                else
                                {
                                    clientState = Tcp.RECONNECT;
                                }
                            }
                            else
                            {
                                clientState = Tcp.RECONNECT;
                            }
                            break;

                        case Tcp.CONNECT:
                            if (clientConnection.TryConnect(ip, port))
                            {
                                if (clientConnection.TryReadingData())
                                {
                                    clientTextboxBig.Invoke((MethodInvoker)delegate { 
                                    
                                        clientStartButton.Enabled = true;
                                        clientSendButton1.Enabled = true;
                                        //clientSendButton2.Enabled = true;
                                        clientTextboxBig.AppendText("Connected" + Environment.NewLine);
                                        clientTextboxBig.ScrollToCaret();
                                    });

                                    tcpConnectedFlag = true;
                                    clientState = Tcp.IDLE;
                                }
                                else
                                {
                                    clientState = Tcp.DISCONNECT;
                                }
                            }
                            else
                            {
                                clientState = Tcp.DISCONNECT;
                            }
                            break;
                        case Tcp.IDLE:
                            if (clientConnection.TcpIsConnected)
                            {
                                if (sendingStringFilledFlag)
                                {
                                    clientState = Tcp.SENDING;
                                }
                                else
                                {
                                    clientState = Tcp.RECEIVING;
                                }
                            }
                            else
                            {
                                clientState = Tcp.RECONNECT;
                            }
                            break;

                        case Tcp.SENDING:
                            if (clientConnection.TrySend(sendingString))
                            {
                                clientTextboxBig.Invoke((MethodInvoker)delegate {
                                    clientTextboxBig.AppendText("Sending: " + sendingString + Environment.NewLine);
                                    clientTextboxBig.ScrollToCaret();
                                });

                                sendingString = "";
                                sendingStringFilledFlag = false;
                                clientState = Tcp.IDLE;
                            }
                            else
                            {
                                clientState = Tcp.RECONNECT;
                            }
                            break;

                        case Tcp.RECEIVING:
                            receivingString = clientConnection.GetReceivedString();

                            if (receivingString != null)
                            {
                                clientTextboxBig.Invoke((MethodInvoker)delegate {
                                    clientTextboxBig.AppendText("Receiving: " + receivingString + Environment.NewLine);
                                    clientTextboxBig.ScrollToCaret();
                                });

                                receivingString = null;
                            }
                            clientState = Tcp.IDLE;
                            break;

                        case Tcp.RECONNECT:
                            sendingString = "";
                            receivingString = "";
                            sendingStringFilledFlag = false;
                            tcpConnectedFlag = false;

                            clientTextboxBig.Invoke((MethodInvoker)delegate {
                                clientStartButton.Enabled = false;
                                clientSendButton1.Enabled = false;
                                //clientSendButton2.Enabled = false;
                                clientTextboxBig.AppendText("Problem occurred! Reconnecting..." + Environment.NewLine);
                                clientTextboxBig.ScrollToCaret();
                            });

                            clientConnection.Disconnect();

                            clientState = Tcp.CONNECT;
                            break;

                        case Tcp.DISCONNECT:
                            clientConnection.Disconnect();

                            clientState = Tcp.CONNECT;
                            break;

                        case Tcp.CLOSE:
                            sendingString = "";
                            receivingString = "";
                            sendingStringFilledFlag = false;
                            tcpConnectedFlag = false;

                            clientTextboxBig.Invoke((MethodInvoker)delegate {
                                clientTextboxBig.AppendText("Disconnected..." + Environment.NewLine);
                                clientTextboxBig.ScrollToCaret();
                            });

                            clientConnection.Disconnect();
                            closeFlag = true;
                            break;

                        default:
                            clientState = Tcp.CLOSE;
                            break;
                    }
                    Thread.Sleep(1); //for decreasing the CPU usage
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLEASE RESTART! TcpClientLoop-thread error: \n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serverStartButton_Click(object sender, EventArgs e)
        {
            serverStartButtonFlag = !serverStartButtonFlag;

            Thread TcpServerThread = new Thread(TcpServerLoop)
            {
                IsBackground = true
            };

            if (serverStartButtonFlag)
            {
                serverStartButton.Text = "Close";

                port = int.Parse(serverPort.Text);

                serverPort.Enabled = false;
                clientTab.Enabled = false;
                serverSendButton1.Enabled = true;
                //serverSendButton2.Enabled = true;

                TcpServerThread.Start();
            }
            else
            {
                serverStartButton.Text = "Listen";

                if (TcpServerThread.IsAlive)
                {
                    TcpServerThread.Join();
                }

                clientTab.Enabled = true;
                serverPort.Enabled = true;
                serverSendButton1.Enabled = false;
                //serverSendButton2.Enabled = false;
            }
        }

        private void clientStartButton_Click(object sender, EventArgs e)
        {
            clientStartButtonFlag = !clientStartButtonFlag;

            Thread TcpClientThread = new Thread(TcpClientLoop)
            {
                IsBackground = true
            };

            if (clientStartButtonFlag)
            {
                clientStartButton.Text = "Disconnect";

                port = int.Parse(clientPort.Text);
                ip = clientIP.Text;

                clientPort.Enabled = false;
                clientIP.Enabled = false;
                serverTab.Enabled = false;
                clientSendButton1.Enabled = true;
                //clientSendButton2.Enabled = true;

                TcpClientThread.Start();
            }
            else
            {
                clientStartButton.Text = "Connect";

                if (TcpClientThread.IsAlive)
                {
                    TcpClientThread.Join();
                }

                serverTab.Enabled = true;
                clientPort.Enabled = true;
                clientIP.Enabled = true;
                clientSendButton1.Enabled = false;
                //clientSendButton2.Enabled = false;
            }
        }

        private void serverSendButton1_Click(object sender, EventArgs e)
        {
            if (!sendingStringFilledFlag && tcpConnectedFlag)
            {
                sendingString = serverSendTextbox1.Text;
                if (sendingString != null && sendingString != "")
                {
                    sendingStringFilledFlag = true;
                }
            }
        }

        private void serverSendButton2_Click(object sender, EventArgs e)
        {

            if (!sendingStringFilledFlag && tcpConnectedFlag)
            {
                //sendingString = serverSendTextbox2.Text;
                if (sendingString != null && sendingString != "")
                {
                    sendingStringFilledFlag = true;
                }
            }
        }

        private void clientSendButton1_Click(object sender, EventArgs e)
        {
            if (!sendingStringFilledFlag && tcpConnectedFlag)
            {
                sendingString = clientSendTextbox1.Text;
                if (sendingString != null && sendingString != "")
                {
                    sendingStringFilledFlag = true;
                }
            }
        }

        private void clientSendButton2_Click(object sender, EventArgs e)
        {
            if (!sendingStringFilledFlag && tcpConnectedFlag)
            {
                //sendingString = clientSendTextbox2.Text;
                if (sendingString != null && sendingString != "")
                {
                    sendingStringFilledFlag = true;
                }
            }
        }

        private void pbxLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void pbxMenu2_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
        }
    }
}
