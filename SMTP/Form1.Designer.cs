namespace SMTP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSmtp = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.chkSsl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(110, 20);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(180, 23);
            this.txtSmtpServer.TabIndex = 0;
            this.txtSmtpServer.Text = "://gmail.com";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(340, 20);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "465";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(280, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(110, 140);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(280, 23);
            this.txtTo.TabIndex = 4;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(110, 175);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(280, 23);
            this.txtSubject.TabIndex = 5;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(110, 210);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(280, 120);
            this.txtBody.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(110, 345);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(280, 35);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Надіслати лист";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSmtp
            // 
            this.lblSmtp.Location = new System.Drawing.Point(15, 23);
            this.lblSmtp.Name = "lblSmtp";
            this.lblSmtp.Size = new System.Drawing.Size(90, 20);
            this.lblSmtp.Text = "SMTP Сервер:";
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(300, 23);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(40, 20);
            this.lblPort.Text = "Порт:";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(15, 58);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(90, 20);
            this.lblUser.Text = "Логін (Email):";
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(15, 93);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(90, 20);
            this.lblPass.Text = "Пароль:";
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(15, 143);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(90, 20);
            this.lblTo.Text = "Кому:";
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(15, 178);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(90, 20);
            this.lblSubject.Text = "Тема:";
            // 
            // lblBody
            // 
            this.lblBody.Location = new System.Drawing.Point(15, 213);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(90, 20);
            this.lblBody.Text = "Текст листа:";
            // 
            // chkSsl
            // 
            this.chkSsl.Checked = true;
            this.chkSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSsl.Location = new System.Drawing.Point(110, 115);
            this.chkSsl.Name = "chkSsl";
            this.chkSsl.Size = new System.Drawing.Size(100, 20);
            this.chkSsl.Text = "Увімкнути SSL";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(415, 400);
            this.Controls.Add(this.chkSsl);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblSmtp);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtSmtpServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Поштовий Клієнт";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSmtp;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.CheckBox chkSsl;
    }
}
