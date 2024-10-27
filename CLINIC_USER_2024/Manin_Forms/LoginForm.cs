using System;
using System.Windows.Forms;
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;
using System.Data.SqlClient;
using CLINIC_USER_2024.classes;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.CodeParser;

namespace PatientAidApp
{
    public partial class LoginForm : Form
    {
        //private readonly DatabaseManager databaseManager;
        public LoginForm()
        {
            InitializeComponent();
            //  this.databaseManager = databaseManager;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text, password = this.passwordTextBox.Text;
            string usertype = textBox1.Text;
          //  CLINIC_USER_2024.classes.clsUsers.USER_DT.LOGIN_INSEART(this.usernameTextBox.Text, this.passwordTextBox.Text, usertype, 4);
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
            bool result = CLINIC_USER_2024.classes.clsUsers.CHICK_LOGIN(username, password,usertype);
            if (!result)
            {
                MessageBox.Show("Patient account does not exist.\nLogin failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                var medicinesForm = new MedicinesForm();
                medicinesForm.Show();
            }
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var recoverPasswordForm = new RecoverPasswordForm();
            recoverPasswordForm.Show();
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.databaseManager.CloseConnection();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
