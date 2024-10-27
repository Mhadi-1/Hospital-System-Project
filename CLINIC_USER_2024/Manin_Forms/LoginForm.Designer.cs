namespace PatientAidApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createAccountButton = new Button();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            label3 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            recoverPasswordButton = new Button();
            showPasswordCheckBox = new CheckBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // createAccountButton
            // 
            createAccountButton.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountButton.Location = new Point(920, 510);
            createAccountButton.Margin = new Padding(5, 6, 5, 6);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(200, 54);
            createAccountButton.TabIndex = 13;
            createAccountButton.Text = "Create account";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += CreateAccountButton_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(483, 590);
            loginButton.Margin = new Padding(5, 6, 5, 6);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 54);
            loginButton.TabIndex = 12;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(427, 475);
            passwordTextBox.Margin = new Padding(5, 6, 5, 6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(322, 31);
            passwordTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(492, 379);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(167, 38);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(427, 283);
            usernameTextBox.Margin = new Padding(5, 6, 5, 6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(322, 31);
            usernameTextBox.TabIndex = 9;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(492, 187);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(500, 46);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 53);
            label1.TabIndex = 7;
            label1.Text = "Log in";
            // 
            // recoverPasswordButton
            // 
            recoverPasswordButton.Font = new Font("Old English Text MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            recoverPasswordButton.Location = new Point(920, 575);
            recoverPasswordButton.Margin = new Padding(5, 6, 5, 6);
            recoverPasswordButton.Name = "recoverPasswordButton";
            recoverPasswordButton.Size = new Size(200, 54);
            recoverPasswordButton.TabIndex = 14;
            recoverPasswordButton.Text = "Forget password";
            recoverPasswordButton.UseVisualStyleBackColor = true;
            recoverPasswordButton.Click += RecoverPasswordButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Old English Text MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckBox.ForeColor = SystemColors.Control;
            showPasswordCheckBox.Location = new Point(118, 460);
            showPasswordCheckBox.Margin = new Padding(5, 6, 5, 6);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(247, 42);
            showPasswordCheckBox.TabIndex = 15;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 328);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 31);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1140, 694);
            Controls.Add(textBox1);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(recoverPasswordButton);
            Controls.Add(createAccountButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LoginForm";
            Text = "Patient aid app";
            FormClosing += LoginForm_FormClosing;
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createAccountButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
        private Button recoverPasswordButton;
        private CheckBox showPasswordCheckBox;
        private TextBox textBox1;
    }
}