namespace CLINIC_USER_2024.list_form
{
    partial class frmUSERLIST
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
            colorDialog1 = new ColorDialog();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtUsers = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsers.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Font = new Font("Constantia", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gridControl1.Location = new Point(88, 120);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(848, 440);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.DoubleClick += labelControl1_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // txtUsers
            // 
            txtUsers.Location = new Point(344, 64);
            txtUsers.Name = "txtUsers";
            txtUsers.Size = new Size(352, 26);
            txtUsers.TabIndex = 1;
            txtUsers.EditValueChanged += labelControl1_Click;
            txtUsers.Click += labelControl1_Click;
            txtUsers.Enter += labelControl1_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(296, 8);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(440, 32);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "                СПИСОК ПОЛЬЗОВАТЕЛЕЙ";
            labelControl2.Click += labelControl2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.x_button1;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(176, 56);
            button1.Name = "button1";
            button1.Size = new Size(152, 40);
            button1.TabIndex = 4;
            button1.Text = "Прозрачный";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmUSERLIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 646);
            Controls.Add(button1);
            Controls.Add(labelControl2);
            Controls.Add(txtUsers);
            Controls.Add(gridControl1);
            Name = "frmUSERLIST";
            Text = "frmUSERLIST";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsers.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtUsers;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Button button1;
    }
}