using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_TCP
{
    public partial class Form1 : Form
    {
        private SimpleTcpServer server;  // Declare the server instance

        public Form1()
        {
            InitializeComponent();
            // Initialize the SimpleTcpServer
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;   // Use UTF-8 encoding for communication
            server.Delimiter = 0x13;               // Set custom delimiter (Ctrl+S)

            // Initializing Radio Buttons to reflect server status
            rbServerRunning.Checked = false;
            rbServerStopped.Checked = true;

            // Attach event handlers to buttons and controls
            btnstart.Click += BtnStart_Click;
            btnstop.Click += BtnStop_Click;

            // Initialize the server settings and UI components
            SetupUI();
        }

        private void SetupUI()
        {
            txtstatus.Clear();
        }

        // Event Handler for Data Received from Client
        // Inside the Server_DataReceived event handler
        private void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {
            txtstatus.Invoke((MethodInvoker)delegate ()
            {
                var value = e.MessageString;
                value = value.Replace("\u0013", "");
                txtstatus.AppendText($"Received from client: {value}\n");

                // Send a reply to this client
                e.ReplyLine($"Server received: {value}");
            });
        }


        // Event Handler for Start Button - Start the Server
        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = textBox2.Text;  // Get IP from textBox2
                int port = Convert.ToInt32(textBox1.Text);  // Get port from textBox1

                // Validate IP address and port
                if (string.IsNullOrWhiteSpace(ip) || port < 0 || port > 65535)
                {
                    MessageBox.Show("Please enter a valid IP and port number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Start the server
                server.Start(System.Net.IPAddress.Parse(ip), port);
                txtstatus.AppendText($"Server started at {ip}:{port}\n");

                // Update radio buttons based on server status
                rbServerRunning.Checked = true;
                rbServerStopped.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting the server: {ex.Message}", "Server Start Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event Handler for Stop Button - Stop the Server
        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();  // Stop the server
                txtstatus.AppendText("Server stopped.\n");

                // Update radio buttons based on server status
                rbServerStopped.Checked = true;
                rbServerRunning.Checked = false;
            }
            else
            {
                MessageBox.Show("Server is not running.", "Server Stop Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btn_SendServer_Click(object sender, EventArgs e)
        {
            string messageToSend = txt_SendServer.Text.Trim();  // Get the message from txt_SendServer

            if (string.IsNullOrEmpty(messageToSend))
            {
                MessageBox.Show("Please enter a message to send.", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the server is running
            if (server.IsStarted)
            {
                server.BroadcastLine(messageToSend);  // Send message to all connected clients
                txtstatus.AppendText($"Sent to client(s): {messageToSend}\n");
            }
            else
            {
                MessageBox.Show("The server is not running.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
