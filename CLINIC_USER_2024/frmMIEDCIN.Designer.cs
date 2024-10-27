namespace CLINIC_USER_2024
{
    partial class frmMIEDCIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMIEDCIN));
            gridControl_MEDCIN = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2COMPANY = new GroupBox();
            txt_MED_PRICE = new TextBox();
            txt_SOURCE = new TextBox();
            txt_MED_SOURCE_NAME = new TextBox();
            txt_MED_NAME = new TextBox();
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
            txt_MEDIC_CODE = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl_MEDCIN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            groupBox2COMPANY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_MEDIC_CODE.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl_MEDCIN
            // 
            gridControl_MEDCIN.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_MEDCIN.Location = new Point(672, 96);
            gridControl_MEDCIN.MainView = gridView1;
            gridControl_MEDCIN.Name = "gridControl_MEDCIN";
            gridControl_MEDCIN.Size = new Size(864, 536);
            gridControl_MEDCIN.TabIndex = 12;
            gridControl_MEDCIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl_MEDCIN.Click += gridControl_MEDCIN_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_MEDCIN;
            gridView1.Name = "gridView1";
            // 
            // groupBox2COMPANY
            // 
            groupBox2COMPANY.BackColor = Color.Transparent;
            groupBox2COMPANY.Controls.Add(txt_MED_PRICE);
            groupBox2COMPANY.Controls.Add(txt_SOURCE);
            groupBox2COMPANY.Controls.Add(txt_MED_SOURCE_NAME);
            groupBox2COMPANY.Controls.Add(txt_MED_NAME);
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
            groupBox2COMPANY.Controls.Add(txt_MEDIC_CODE);
            groupBox2COMPANY.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2COMPANY.ForeColor = Color.Black;
            groupBox2COMPANY.Location = new Point(48, 96);
            groupBox2COMPANY.Name = "groupBox2COMPANY";
            groupBox2COMPANY.Size = new Size(592, 536);
            groupBox2COMPANY.TabIndex = 13;
            groupBox2COMPANY.TabStop = false;
            groupBox2COMPANY.Text = "Данные Лекарство";
            // 
            // txt_MED_PRICE
            // 
            txt_MED_PRICE.Location = new Point(200, 248);
            txt_MED_PRICE.Multiline = true;
            txt_MED_PRICE.Name = "txt_MED_PRICE";
            txt_MED_PRICE.Size = new Size(296, 32);
            txt_MED_PRICE.TabIndex = 39;
            // 
            // txt_SOURCE
            // 
            txt_SOURCE.Location = new Point(200, 208);
            txt_SOURCE.Multiline = true;
            txt_SOURCE.Name = "txt_SOURCE";
            txt_SOURCE.Size = new Size(296, 32);
            txt_SOURCE.TabIndex = 38;
            // 
            // txt_MED_SOURCE_NAME
            // 
            txt_MED_SOURCE_NAME.Location = new Point(200, 168);
            txt_MED_SOURCE_NAME.Multiline = true;
            txt_MED_SOURCE_NAME.Name = "txt_MED_SOURCE_NAME";
            txt_MED_SOURCE_NAME.Size = new Size(296, 32);
            txt_MED_SOURCE_NAME.TabIndex = 37;
            // 
            // txt_MED_NAME
            // 
            txt_MED_NAME.Location = new Point(200, 128);
            txt_MED_NAME.Multiline = true;
            txt_MED_NAME.Name = "txt_MED_NAME";
            txt_MED_NAME.Size = new Size(296, 32);
            txt_MED_NAME.TabIndex = 36;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(16, 256);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(47, 24);
            labelControl1.TabIndex = 35;
            labelControl1.Text = "Цена";
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(32, 336);
            btn_Save.Margin = new Padding(3, 3, 2, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(1);
            btn_Save.Size = new Size(96, 40);
            btn_Save.TabIndex = 30;
            btn_Save.Text = "Save\r\n";
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Image = Properties.Resources.editIcone;
            btn_Edit.ImageAlign = ContentAlignment.MiddleRight;
            btn_Edit.Location = new Point(144, 336);
            btn_Edit.Margin = new Padding(3, 3, 2, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Padding = new Padding(1);
            btn_Edit.Size = new Size(96, 40);
            btn_Edit.TabIndex = 29;
            btn_Edit.Text = "Edit";
            btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.Image = Properties.Resources.x_button;
            btn_clear.ImageAlign = ContentAlignment.MiddleRight;
            btn_clear.Location = new Point(384, 336);
            btn_clear.Margin = new Padding(3, 3, 2, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Padding = new Padding(1);
            btn_clear.Size = new Size(104, 40);
            btn_clear.TabIndex = 28;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_DELETE
            // 
            btn_DELETE.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DELETE.Image = Properties.Resources.trashIcone;
            btn_DELETE.ImageAlign = ContentAlignment.MiddleRight;
            btn_DELETE.Location = new Point(256, 336);
            btn_DELETE.Margin = new Padding(3, 3, 2, 3);
            btn_DELETE.Name = "btn_DELETE";
            btn_DELETE.Padding = new Padding(1);
            btn_DELETE.Size = new Size(112, 40);
            btn_DELETE.TabIndex = 27;
            btn_DELETE.Text = "Delete";
            btn_DELETE.TextAlign = ContentAlignment.MiddleLeft;
            btn_DELETE.UseVisualStyleBackColor = true;
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
            lbl_CLINIC_NOTES.Location = new Point(16, 216);
            lbl_CLINIC_NOTES.Name = "lbl_CLINIC_NOTES";
            lbl_CLINIC_NOTES.Size = new Size(97, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Источник ";
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(16, 176);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(170, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "Научное название";
            lbltxt_CLINIC_ADDRESS.Click += lbltxt_CLINIC_ADDRESS_Click;
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(16, 136);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(141, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Имя Лекарство";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            lbltxt_CLINIC_NAME.Click += lbltxt_CLINIC_NAME_Click;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(16, 96);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(136, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Лекарство Код";
            // 
            // txt_MEDIC_CODE
            // 
            txt_MEDIC_CODE.Location = new Point(200, 88);
            txt_MEDIC_CODE.Name = "txt_MEDIC_CODE";
            txt_MEDIC_CODE.Size = new Size(296, 26);
            txt_MEDIC_CODE.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(472, -8);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(648, 56);
            labelControl2.TabIndex = 14;
            labelControl2.Text = "      Добавление - изменение Лекарство\r\n";
            // 
            // frmMIEDCIN
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 669);
            Controls.Add(labelControl2);
            Controls.Add(groupBox2COMPANY);
            Controls.Add(gridControl_MEDCIN);
            Name = "frmMIEDCIN";
            Text = "frmMIEDCIN";
            ((System.ComponentModel.ISupportInitialize)gridControl_MEDCIN).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            groupBox2COMPANY.ResumeLayout(false);
            groupBox2COMPANY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_MEDIC_CODE.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_MEDCIN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GroupBox groupBox2COMPANY;
        private TextBox txt_MED_PRICE;
        private TextBox txt_SOURCE;
        private TextBox txt_MED_SOURCE_NAME;
        private TextBox txt_MED_NAME;
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
        private DevExpress.XtraEditors.TextEdit txt_MEDIC_CODE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}