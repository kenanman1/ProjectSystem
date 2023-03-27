using MailKit.Security;
using MimeKit;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProjectSystem
{
    public partial class Registration : Form
    {
        Random random = new Random();
        static int number;
        public Registration()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MailAddress mail = null;
            MailAddress.TryCreate(textBoxMail.Text, out mail);
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text)
                && (!string.IsNullOrWhiteSpace(textBoxName.Text)) && mail != null)
            {
                var search = await Database.SearchLoginAsync(textBoxLogin.Text);
                if (search)
                    MessageBox.Show("Login already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    await Database.CreateAccountAsync(textBoxLogin.Text, textBoxPassword.Text, textBoxMail.Text, textBoxName.Text);
                    MessageBox.Show("Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
            else
                MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

}
