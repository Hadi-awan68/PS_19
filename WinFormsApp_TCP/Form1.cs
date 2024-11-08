using SimpleTCP;
using System.Text;

namespace WinFormsApp_TCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;



    private void Form1_Load(object sender, EventArgs e)
{
        server = new SimpleTcpServer();
        server.Delimiter = 0x13;  // Default delimiter (ASCII 19: Ctrl+S)
        server.StringEncoder = Encoding.UTF8;
        server.DataReceived += Server_DataReceived;
}

    private void Server_DataReceived(object? sender, SimpleTCP.Message e)
    {
        // Ensure updates to the UI are done on the UI thread
        txtstatus.Invoke((MethodInvoker)delegate ()
        {
            // Append received message to the status textbox (not overwrite)
            var value = e.MessageString;
            value = value.Replace("\u0013", "");
            txtstatus.AppendText($"Received: {value}");

            // Reply to the client
            e.ReplyLine($"You said: {e.MessageString}");
        });
    }

    private void btnstart_Click(object sender, EventArgs e)
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
            txtstatus.AppendText("Server starting...\n");  // Provide feedback to user
            server.Start(ip, port);
            txtstatus.AppendText($"Server started at {ip}:{port}\n");
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

    private void btnstop_Click(object sender, EventArgs e)
    {
        try
        {
            if (server.IsStarted)
            {
                server.Stop();
                txtstatus.AppendText("Server stopped.\n");
            }
            else
            {
                MessageBox.Show("Server is not running.", "Stop Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error while stopping the server: {ex.Message}", "Stop Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
        }
    }

