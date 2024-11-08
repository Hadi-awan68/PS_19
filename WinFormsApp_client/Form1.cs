using SimpleTCP;
using System.Text;

namespace WinFormsApp_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text = e.MessageString;

            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic input validation for IP address and port
                string ipText = textBox2.Text;
                string portText = textBox1.Text;



                if (string.IsNullOrWhiteSpace(ipText) || string.IsNullOrWhiteSpace(portText))
                {
                    MessageBox.Show("Please provide both IP address and port number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse the IP address
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipText);

                // Convert and validate the port
                int port = Convert.ToInt32(portText);
                if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Please enter a valid port number between 0 and 65535.", "Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Start the server
                txtStatus.AppendText("Server starting...\n");  // Provide feedback to user
                client.Connect(ip.ToString(), port);
                txtStatus.AppendText($"Server started at {ip}:{port}\n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid IP address or port format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnsend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}


