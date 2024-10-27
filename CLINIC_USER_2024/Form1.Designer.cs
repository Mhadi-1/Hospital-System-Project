namespace CLINIC_USER_2024
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            cmbUserName = new ComboBox();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            label3 = new Label();
            lblUserType = new Label();
            label1 = new Label();
            txtUserPassword = new DevExpress.XtraEditors.TextEdit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUserPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.None;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(cmbUserName);
            groupBox1.Controls.Add(pictureEdit1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblUserType);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUserPassword);
            groupBox1.ForeColor = SystemColors.InfoText;
            groupBox1.Location = new Point(40, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1016, 472);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SING IN";
            groupBox1.UseCompatibleTextRendering = true;
            groupBox1.UseWaitCursor = true;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbUserName
            // 
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(481, 112);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(334, 33);
            cmbUserName.TabIndex = 8;
            cmbUserName.UseWaitCursor = true;
            cmbUserName.SelectedIndexChanged += cmbUserName_SelectedIndexChanged;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(48, 64);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new Size(400, 352);
            pictureEdit1.TabIndex = 7;
            pictureEdit1.UseWaitCursor = true;
            pictureEdit1.EditValueChanged += pictureEdit1_EditValueChanged;
            // 
            // btnLogin
            // 
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Location = new Point(484, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(328, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN ";
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(840, 168);
            label3.Name = "label3";
            label3.Size = new Size(152, 22);
            label3.TabIndex = 5;
            label3.Text = "USER PASSWORD";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserType.ForeColor = SystemColors.HotTrack;
            lblUserType.Location = new Point(598, 216);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(100, 22);
            lblUserType.TabIndex = 4;
            lblUserType.Text = "USER TYPE";
            lblUserType.TextAlign = ContentAlignment.MiddleLeft;
            lblUserType.UseWaitCursor = true;
            lblUserType.Click += lblUsser_type;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(840, 112);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 3;
            label1.Text = "USER NAME\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(480, 168);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Properties.PasswordChar = '*';
            txtUserPassword.Size = new Size(336, 26);
            txtUserPassword.TabIndex = 1;
            txtUserPassword.UseWaitCursor = true;
            txtUserPassword.EditValueChanged += txtUserPassword_EditValueChanged;
            txtUserPassword.KeyDown += txtUserPassword_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1112, 594);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUserPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtUserPassword;
        private Label label1;
        private Label label3;
        private Label lblUserType;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private ComboBox cmbUserName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}