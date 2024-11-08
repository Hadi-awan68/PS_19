namespace WinFormsApp_TCP
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
            txthost = new Label();
            txtport = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnstart = new Button();
            btnstop = new Button();
            txtstatus = new TextBox();
            SuspendLayout();
            // 
            // txthost
            // 
            txthost.AutoSize = true;
            txthost.Location = new Point(43, 27);
            txthost.Name = "txthost";
            txthost.Size = new Size(32, 15);
            txthost.TabIndex = 0;
            txthost.Text = "Host";
            // 
            // txtport
            // 
            txtport.AutoSize = true;
            txtport.Location = new Point(43, 69);
            txtport.Name = "txtport";
            txtport.Size = new Size(29, 15);
            txtport.TabIndex = 1;
            txtport.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "5368";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "172.19.201.5";
            // 
            // btnstart
            // 
            btnstart.Location = new Point(44, 121);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(75, 23);
            btnstart.TabIndex = 3;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // btnstop
            // 
            btnstop.Location = new Point(143, 121);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(75, 23);
            btnstop.TabIndex = 3;
            btnstop.Text = "Stop";
            btnstop.UseVisualStyleBackColor = true;
            btnstop.Click += btnstop_Click;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(346, 12);
            txtstatus.Multiline = true;
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(311, 125);
            txtstatus.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtstatus);
            Controls.Add(btnstop);
            Controls.Add(btnstart);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtport);
            Controls.Add(txthost);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txthost;
        private Label txtport;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnstart;
        private Button btnstop;
        private TextBox txtstatus;
    }
}
