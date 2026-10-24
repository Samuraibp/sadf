using System.Net;
using System.Net.Mail;

namespace SMTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtSmtpServer.Text = "smtp.gmail.com";
            txtPort.Text = "587";
            chkSsl.Checked = true;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtTo.Text) ||
                string.IsNullOrWhiteSpace(txtSmtpServer.Text) ||
                string.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show(
                    "Заполните все обязательные поля.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPort.Text, out int port) ||
                port < 1 || port > 65535)
            {
                MessageBox.Show(
                    "Введите корректный порт от 1 до 65535.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _ = new MailAddress(txtUsername.Text);
                _ = new MailAddress(txtTo.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Введите корректный адрес отправителя и получателя.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnSend.Enabled = false;
            btnSend.Text = "Отправка...";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(txtUsername.Text.Trim());
                    mail.To.Add(new MailAddress(txtTo.Text.Trim()));
                    mail.Subject = txtSubject.Text;
                    mail.Body = txtBody.Text;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.UseDefaultCredentials = false;

                        smtp.Credentials = new NetworkCredential(
                            txtUsername.Text.Trim(),
                            txtPassword.Text.Trim());

                        smtp.EnableSsl = true;
                        smtp.Timeout = 15000;

                        await smtp.SendMailAsync(mail);
                    }
                }

                MessageBox.Show(
                    "Письмо успешно отправлено!",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBody.Clear();
                txtSubject.Clear();
            }
            catch (Exception ex)
            {
                string error = ex.ToString();

                MessageBox.Show(
                    error,
                    "Подробная ошибка SMTP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnSend.Enabled = true;
                btnSend.Text = "Надіслати лист";
            }
        }
    }
}
