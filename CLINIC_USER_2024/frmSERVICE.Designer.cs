namespace CLINIC_USER_2024
{
    partial class frmSERVICE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSERVICE));
            labelCOMPANY_NAME = new DevExpress.XtraEditors.LabelControl();
            gridControl_SERVICE = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2COMPANY = new GroupBox();
            text_NOTES = new DevExpress.XtraEditors.TextEdit();
            text_SER_PRICE = new DevExpress.XtraEditors.TextEdit();
            text_SER_TYPE = new DevExpress.XtraEditors.TextEdit();
            txt_SER_NAME = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btn_Save = new Button();
            btn_Edit = new Button();
            btn_clear = new Button();
            btn_DELETE = new Button();
            lbl_USER_NAME = new DevExpress.XtraEditors.LabelControl();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            lbl_CLINIC_NOTES = new DevExpress.XtraEditors.LabelControl();
            lbltxt_CLINIC_ADDRESS = new DevExpress.XtraEditors.LabelControl();
            lbltxt_CLINIC_NAME = new DevExpress.XtraEditors.LabelControl();
            txtlblCLINIC = new DevExpress.XtraEditors.LabelControl();
            txt_SER_CODE = new DevExpress.XtraEditors.TextEdit();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridControl_SERVICE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            groupBox2COMPANY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)text_NOTES.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)text_SER_PRICE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)text_SER_TYPE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_SER_NAME.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_SER_CODE.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelCOMPANY_NAME
            // 
            labelCOMPANY_NAME.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCOMPANY_NAME.Appearance.ForeColor = Color.LightSeaGreen;
            labelCOMPANY_NAME.Appearance.Options.UseFont = true;
            labelCOMPANY_NAME.Appearance.Options.UseForeColor = true;
            labelCOMPANY_NAME.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCOMPANY_NAME.Location = new Point(376, -8);
            labelCOMPANY_NAME.Name = "labelCOMPANY_NAME";
            labelCOMPANY_NAME.Size = new Size(832, 64);
            labelCOMPANY_NAME.TabIndex = 7;
            labelCOMPANY_NAME.Text = "      ДОБАВИТЬ - УДАЛИТЬ - ОБНОВИТЬ- УСЛУГИ\r\n";
            labelCOMPANY_NAME.Click += labelCOMPANY_NAME_Click;
            // 
            // gridControl_SERVICE
            // 
            gridControl_SERVICE.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_SERVICE.Location = new Point(624, 108);
            gridControl_SERVICE.MainView = gridView1;
            gridControl_SERVICE.Name = "gridControl_SERVICE";
            gridControl_SERVICE.Size = new Size(864, 496);
            gridControl_SERVICE.TabIndex = 8;
            gridControl_SERVICE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl_SERVICE.DoubleClick += frmSERVICE_Load;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_SERVICE;
            gridView1.Name = "gridView1";
            // 
            // groupBox2COMPANY
            // 
            groupBox2COMPANY.BackColor = Color.Transparent;
            groupBox2COMPANY.Controls.Add(button1);
            groupBox2COMPANY.Controls.Add(text_NOTES);
            groupBox2COMPANY.Controls.Add(text_SER_PRICE);
            groupBox2COMPANY.Controls.Add(text_SER_TYPE);
            groupBox2COMPANY.Controls.Add(txt_SER_NAME);
            groupBox2COMPANY.Controls.Add(labelControl1);
            groupBox2COMPANY.Controls.Add(btn_Save);
            groupBox2COMPANY.Controls.Add(btn_Edit);
            groupBox2COMPANY.Controls.Add(btn_clear);
            groupBox2COMPANY.Controls.Add(btn_DELETE);
            groupBox2COMPANY.Controls.Add(lbl_USER_NAME);
            groupBox2COMPANY.Controls.Add(labelControl17);
            groupBox2COMPANY.Controls.Add(lbl_CLINIC_NOTES);
            groupBox2COMPANY.Controls.Add(lbltxt_CLINIC_ADDRESS);
            groupBox2COMPANY.Controls.Add(lbltxt_CLINIC_NAME);
            groupBox2COMPANY.Controls.Add(txtlblCLINIC);
            groupBox2COMPANY.Controls.Add(txt_SER_CODE);
            groupBox2COMPANY.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2COMPANY.ForeColor = Color.Black;
            groupBox2COMPANY.Location = new Point(16, 104);
            groupBox2COMPANY.Name = "groupBox2COMPANY";
            groupBox2COMPANY.Size = new Size(592, 504);
            groupBox2COMPANY.TabIndex = 9;
            groupBox2COMPANY.TabStop = false;
            groupBox2COMPANY.Text = "Данные Услуга";
            // 
            // text_NOTES
            // 
            text_NOTES.Location = new Point(200, 248);
            text_NOTES.Name = "text_NOTES";
            text_NOTES.Size = new Size(296, 26);
            text_NOTES.TabIndex = 39;
            // 
            // text_SER_PRICE
            // 
            text_SER_PRICE.Location = new Point(200, 208);
            text_SER_PRICE.Name = "text_SER_PRICE";
            text_SER_PRICE.Size = new Size(296, 26);
            text_SER_PRICE.TabIndex = 38;
            // 
            // text_SER_TYPE
            // 
            text_SER_TYPE.Location = new Point(200, 168);
            text_SER_TYPE.Name = "text_SER_TYPE";
            text_SER_TYPE.Size = new Size(296, 26);
            text_SER_TYPE.TabIndex = 37;
            // 
            // txt_SER_NAME
            // 
            txt_SER_NAME.Location = new Point(200, 128);
            txt_SER_NAME.Name = "txt_SER_NAME";
            txt_SER_NAME.Size = new Size(296, 26);
            txt_SER_NAME.TabIndex = 36;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(16, 248);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(117, 24);
            labelControl1.TabIndex = 35;
            labelControl1.Text = "Примечание";
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(80, 344);
            btn_Save.Margin = new Padding(3, 3, 2, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(1);
            btn_Save.Size = new Size(96, 40);
            btn_Save.TabIndex = 30;
            btn_Save.Text = "Save\r\n";
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Image = Properties.Resources.editIcone;
            btn_Edit.ImageAlign = ContentAlignment.MiddleRight;
            btn_Edit.Location = new Point(192, 344);
            btn_Edit.Margin = new Padding(3, 3, 2, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Padding = new Padding(1);
            btn_Edit.Size = new Size(96, 40);
            btn_Edit.TabIndex = 29;
            btn_Edit.Text = "Edit";
            btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.Image = Properties.Resources.x_button;
            btn_clear.ImageAlign = ContentAlignment.MiddleRight;
            btn_clear.Location = new Point(432, 344);
            btn_clear.Margin = new Padding(3, 3, 2, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Padding = new Padding(1);
            btn_clear.Size = new Size(104, 40);
            btn_clear.TabIndex = 28;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_DELETE
            // 
            btn_DELETE.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DELETE.Image = Properties.Resources.trashIcone;
            btn_DELETE.ImageAlign = ContentAlignment.MiddleRight;
            btn_DELETE.Location = new Point(304, 344);
            btn_DELETE.Margin = new Padding(3, 3, 2, 3);
            btn_DELETE.Name = "btn_DELETE";
            btn_DELETE.Padding = new Padding(1);
            btn_DELETE.Size = new Size(112, 40);
            btn_DELETE.TabIndex = 27;
            btn_DELETE.Text = "Delete";
            btn_DELETE.TextAlign = ContentAlignment.MiddleLeft;
            btn_DELETE.UseVisualStyleBackColor = true;
            btn_DELETE.Click += btn_DELETE_Click;
            // 
            // lbl_USER_NAME
            // 
            lbl_USER_NAME.Appearance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_USER_NAME.Appearance.Options.UseFont = true;
            lbl_USER_NAME.Location = new Point(16, 368);
            lbl_USER_NAME.Name = "lbl_USER_NAME";
            lbl_USER_NAME.Size = new Size(0, 22);
            lbl_USER_NAME.TabIndex = 32;
            // 
            // labelControl17
            // 
            labelControl17.Location = new Point(0, 0);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new Size(0, 19);
            labelControl17.TabIndex = 2;
            // 
            // lbl_CLINIC_NOTES
            // 
            lbl_CLINIC_NOTES.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CLINIC_NOTES.Appearance.Options.UseFont = true;
            lbl_CLINIC_NOTES.Location = new Point(16, 208);
            lbl_CLINIC_NOTES.Name = "lbl_CLINIC_NOTES";
            lbl_CLINIC_NOTES.Size = new Size(47, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Цена";
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(16, 168);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(36, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "Тип";
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(16, 128);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(40, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Имя";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            lbltxt_CLINIC_NAME.Click += lbltxt_CLINIC_NAME_Click;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(16, 88);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(102, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Услуга Код";
            // 
            // txt_SER_CODE
            // 
            txt_SER_CODE.Location = new Point(200, 88);
            txt_SER_CODE.Name = "txt_SER_CODE";
            txt_SER_CODE.Size = new Size(296, 26);
            txt_SER_CODE.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.user;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(8, 288);
            button1.Name = "button1";
            button1.Size = new Size(176, 38);
            button1.TabIndex = 40;
            button1.Text = "SER_LISTSCREEN\r\n";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // frmSERVICE
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 677);
            Controls.Add(groupBox2COMPANY);
            Controls.Add(gridControl_SERVICE);
            Controls.Add(labelCOMPANY_NAME);
            Name = "frmSERVICE";
            Text = "frmSERVICE";
            Load += frmSERVICE_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl_SERVICE).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            groupBox2COMPANY.ResumeLayout(false);
            groupBox2COMPANY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)text_NOTES.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)text_SER_PRICE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)text_SER_TYPE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_SER_NAME.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_SER_CODE.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelCOMPANY_NAME;
        private DevExpress.XtraGrid.GridControl gridControl_SERVICE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GroupBox groupBox2COMPANY;
        private DevExpress.XtraEditors.TextEdit text_SER_PRICE;
        private DevExpress.XtraEditors.TextEdit text_SER_TYPE;
        private DevExpress.XtraEditors.TextEdit txt_SER_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Button btn_Save;
        private Button btn_Edit;
        private Button btn_clear;
        private Button btn_DELETE;
        private DevExpress.XtraEditors.LabelControl lbl_USER_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lbl_CLINIC_NOTES;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_ADDRESS;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_NAME;
        private DevExpress.XtraEditors.LabelControl txtlblCLINIC;
        private DevExpress.XtraEditors.TextEdit txt_SER_CODE;
        private DevExpress.XtraEditors.TextEdit text_NOTES;
        private Button button1;
    }
}