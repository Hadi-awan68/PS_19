namespace WinFormsApp_client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtport = new Label();
            txthost = new Label();
            txtMessage = new TextBox();
            txtStatus = new TextBox();
            btnsend = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(38, 118);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(157, 23);
            btnConnect.TabIndex = 9;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "172.19.201.5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "5368";
            // 
            // txtport
            // 
            txtport.AutoSize = true;
            txtport.Location = new Point(37, 66);
            txtport.Name = "txtport";
            txtport.Size = new Size(29, 15);
            txtport.TabIndex = 5;
            txtport.Text = "Port";
            // 
            // txthost
            // 
            txthost.AutoSize = true;
            txthost.Location = new Point(37, 24);
            txthost.Name = "txthost";
            txthost.Size = new Size(32, 15);
            txthost.TabIndex = 4;
            txthost.Text = "Host";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(262, 16);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(193, 125);
            txtMessage.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(461, 16);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(193, 125);
            txtStatus.TabIndex = 11;
            // 
            // btnsend
            // 
            btnsend.Location = new Point(262, 161);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(157, 23);
            btnsend.TabIndex = 12;
            btnsend.Text = "Send";
            btnsend.UseVisualStyleBackColor = true;
            btnsend.Click += btnsend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsend);
            Controls.Add(txtStatus);
            Controls.Add(txtMessage);
            Controls.Add(btnConnect);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtport);
            Controls.Add(txthost);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label txtport;
        private Label txthost;
        private TextBox txtMessage;
        private TextBox txtStatus;
        private Button btnsend;
    }
}
