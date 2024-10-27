using System;
using System.Windows.Forms;

namespace PatientAidApp
{
    public partial class RecoverPasswordForm : Form
    {
        private readonly DatabaseManager databaseManager;
        public RecoverPasswordForm()
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text, newPassword = this.newPasswordTextBox.Text,
                reenterNewPassword = this.reenterNewPasswordTextBox.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("The username field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("The new password field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(reenterNewPassword))
            {
                MessageBox.Show("The confirmation password field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword.Length < 8 || newPassword.Length > 32)
            {
                MessageBox.Show("Password should be between 8 and 32 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != reenterNewPassword)
            {
                MessageBox.Show("Password confirmation does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newPassword = Encryption.EncryptWithMD5(newPassword);
            bool result = this.databaseManager.RecoverPassword(username, newPassword);
            if (!result)
            {
                MessageBox.Show("Patient username does not exist.\nPassword recovery failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password recovered successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPasswordCheckBox.Checked)
            {
                this.newPasswordTextBox.PasswordChar = '\0';
                this.reenterNewPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.newPasswordTextBox.PasswordChar = '*';
                this.reenterNewPasswordTextBox.PasswordChar = '*';
            }
        }

        private void RecoverPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.databaseManager.CloseConnection();
        }

        private void RecoverPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
