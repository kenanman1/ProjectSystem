using ClassLibrary1;

namespace ProjectSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Registration();
            form.ShowDialog();
        }

        private void buttonHideShow_Click(object sender, EventArgs e)
        {
            switch (buttonHideShow.Text)
            {
                case "hide":
                    textBoxPassword.UseSystemPasswordChar = true;
                    buttonHideShow.Text = "show";
                    break;
                case "show":
                    textBoxPassword.UseSystemPasswordChar = false;
                    buttonHideShow.Text = "hide";
                    break;
            }
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "admin")
            {
                Form form = new AdminForm();
                Hide();
                form.ShowDialog();
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textBoxPassword.Text) && !string.IsNullOrWhiteSpace(textBoxLogin.Text))
                {
                    var user = await Database.SearchUserAsync(textBoxLogin.Text, textBoxPassword.Text);
                    if (user != null)
                    {
                        Form form = new MainForm();
                        Settings1.Default.UserId = user.Id;
                        Hide();
                        form.ShowDialog();
                    }
                    else
                        MessageBox.Show("Incorrect password or login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Enter all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}