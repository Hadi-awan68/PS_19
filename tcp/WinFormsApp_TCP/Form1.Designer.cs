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
            label1 = new Label();
            btn_SendServer = new Button();
            label2 = new Label();
            txt_SendServer = new TextBox();
            rbServerRunning = new RadioButton();
            rbServerStopped = new RadioButton();
            SuspendLayout();
            // 
            // txthost
            // 
            txthost.AutoSize = true;
            txthost.BorderStyle = BorderStyle.Fixed3D;
            txthost.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txthost.Location = new Point(40, 86);
            txthost.Name = "txthost";
            txthost.Size = new Size(53, 28);
            txthost.TabIndex = 0;
            txthost.Text = "Host";
            // 
            // txtport
            // 
            txtport.AutoSize = true;
            txtport.BorderStyle = BorderStyle.Fixed3D;
            txtport.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtport.Location = new Point(40, 131);
            txtport.Name = "txtport";
            txtport.Size = new Size(46, 25);
            txtport.TabIndex = 1;
            txtport.Text = "Port";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(112, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "5368";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(112, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "172.19.201.5";
            // 
            // btnstart
            // 
            btnstart.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstart.Location = new Point(40, 174);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(75, 36);
            btnstart.TabIndex = 3;
            btnstart.Text = "Start";
            btnstart.UseVisualStyleBackColor = true;
            // 
            // btnstop
            // 
            btnstop.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstop.Location = new Point(121, 174);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(75, 36);
            btnstop.TabIndex = 3;
            btnstop.Text = "Stop";
            btnstop.UseVisualStyleBackColor = true;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(393, 296);
            txtstatus.Multiline = true;
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(382, 125);
            txtstatus.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 35);
            label1.TabIndex = 5;
            label1.Text = "TCP\\IP Communication";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_SendServer
            // 
            btn_SendServer.BackgroundImageLayout = ImageLayout.None;
            btn_SendServer.DialogResult = DialogResult.No;
            btn_SendServer.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SendServer.Location = new Point(302, 197);
            btn_SendServer.Name = "btn_SendServer";
            btn_SendServer.Size = new Size(75, 32);
            btn_SendServer.TabIndex = 6;
            btn_SendServer.Text = "Send";
            btn_SendServer.UseVisualStyleBackColor = true;
            btn_SendServer.Click += btn_SendServer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 354);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 7;
            label2.Text = "Received";
            // 
            // txt_SendServer
            // 
            txt_SendServer.Location = new Point(393, 145);
            txt_SendServer.Multiline = true;
            txt_SendServer.Name = "txt_SendServer";
            txt_SendServer.Size = new Size(382, 125);
            txt_SendServer.TabIndex = 4;
            // 
            // rbServerRunning
            // 
            rbServerRunning.AutoSize = true;
            rbServerRunning.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbServerRunning.Location = new Point(393, 86);
            rbServerRunning.Name = "rbServerRunning";
            rbServerRunning.Size = new Size(148, 27);
            rbServerRunning.TabIndex = 8;
            rbServerRunning.TabStop = true;
            rbServerRunning.Text = "Server_Started";
            rbServerRunning.UseVisualStyleBackColor = true;
            // 
            // rbServerStopped
            // 
            rbServerStopped.AutoSize = true;
            rbServerStopped.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbServerStopped.Location = new Point(620, 83);
            rbServerStopped.Name = "rbServerStopped";
            rbServerStopped.Size = new Size(155, 27);
            rbServerStopped.TabIndex = 8;
            rbServerStopped.TabStop = true;
            rbServerStopped.Text = "Server_Stopped";
            rbServerStopped.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbServerStopped);
            Controls.Add(rbServerRunning);
            Controls.Add(label2);
            Controls.Add(btn_SendServer);
            Controls.Add(label1);
            Controls.Add(txt_SendServer);
            Controls.Add(txtstatus);
            Controls.Add(btnstop);
            Controls.Add(btnstart);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtport);
            Controls.Add(txthost);
            Name = "Form1";
            Text = "Server";
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
        private Label label1;
        private Button btn_SendServer;
        private Label label2;
        private TextBox txt_SendServer;
        private RadioButton rbServerRunning;
        private RadioButton rbServerStopped;
    }
}
