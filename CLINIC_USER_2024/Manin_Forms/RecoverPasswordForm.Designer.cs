namespace PatientAidApp
{
    partial class RecoverPasswordForm
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
            loginButton = new Button();
            recoverPasswordButton = new Button();
            newPasswordTextBox = new TextBox();
            label3 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            reenterNewPasswordTextBox = new TextBox();
            label4 = new Label();
            showPasswordCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(920, 702);
            loginButton.Margin = new Padding(5, 6, 5, 6);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 54);
            loginButton.TabIndex = 13;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // recoverPasswordButton
            // 
            recoverPasswordButton.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recoverPasswordButton.Location = new Point(483, 783);
            recoverPasswordButton.Margin = new Padding(5, 6, 5, 6);
            recoverPasswordButton.Name = "recoverPasswordButton";
            recoverPasswordButton.Size = new Size(200, 54);
            recoverPasswordButton.TabIndex = 12;
            recoverPasswordButton.Text = "Recover";
            recoverPasswordButton.UseVisualStyleBackColor = true;
            recoverPasswordButton.Click += RecoverPasswordButton_Click;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(427, 475);
            newPasswordTextBox.Margin = new Padding(5, 6, 5, 6);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(322, 31);
            newPasswordTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(455, 379);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(234, 38);
            label3.TabIndex = 10;
            label3.Text = "New password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(427, 283);
            usernameTextBox.Margin = new Padding(5, 6, 5, 6);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(322, 31);
            usernameTextBox.TabIndex = 9;
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
            label1.Location = new Point(372, 42);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 53);
            label1.TabIndex = 7;
            label1.Text = "Recover Password";
            // 
            // reenterNewPasswordTextBox
            // 
            reenterNewPasswordTextBox.Location = new Point(427, 667);
            reenterNewPasswordTextBox.Margin = new Padding(5, 6, 5, 6);
            reenterNewPasswordTextBox.Name = "reenterNewPasswordTextBox";
            reenterNewPasswordTextBox.PasswordChar = '*';
            reenterNewPasswordTextBox.Size = new Size(322, 31);
            reenterNewPasswordTextBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(427, 571);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(289, 38);
            label4.TabIndex = 14;
            label4.Text = "Re-enter password:";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Old English Text MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheckBox.ForeColor = SystemColors.Control;
            showPasswordCheckBox.Location = new Point(118, 563);
            showPasswordCheckBox.Margin = new Padding(5, 6, 5, 6);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(247, 42);
            showPasswordCheckBox.TabIndex = 16;
            showPasswordCheckBox.Text = "Show password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // RecoverPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1140, 887);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(reenterNewPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(loginButton);
            Controls.Add(recoverPasswordButton);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecoverPasswordForm";
            Text = "Patient aid app";
            FormClosing += RecoverPasswordForm_FormClosing;
            FormClosed += RecoverPasswordForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button recoverPasswordButton;
        private TextBox newPasswordTextBox;
        private Label label3;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
        private TextBox reenterNewPasswordTextBox;
        private Label label4;
        private CheckBox showPasswordCheckBox;
    }
}