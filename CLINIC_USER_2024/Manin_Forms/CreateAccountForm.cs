using System;
using System.Windows.Forms;

namespace PatientAidApp
{
    public partial class CreateAccountForm : Form
    {
        private readonly DatabaseManager databaseManager;
        public CreateAccountForm()
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
        }

        private void Login()
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text, password = this.passwordTextBox.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("The username field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("The password field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (username.Length > 50)
            {
                MessageBox.Show("Username should not exceed 50 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8 || password.Length > 32)
            {
                MessageBox.Show("Password should be between 8 and 32 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            password = Encryption.EncryptWithMD5(password);
            bool result = this.databaseManager.CreateAccount(username, password);
            if (!result)
            {
                MessageBox.Show("Username already exists.\nPatient account creation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Patient account created successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Login();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPasswordCheckBox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '*';
            }
        }

        private void CreateAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.databaseManager.CloseConnection();
        }

        private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
