namespace CLINIC_USER_2024
{
    partial class frmCOMPANY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCOMPANY));
            labelCOMPANY_NAME = new DevExpress.XtraEditors.LabelControl();
            gridControl_SERVICE = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2COMPANY = new GroupBox();
            cmb_COM_STATE = new ComboBox();
            text_COM_NUMBER = new DevExpress.XtraEditors.TextEdit();
            text_COM_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            txt_COM_NAME = new DevExpress.XtraEditors.TextEdit();
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
            txt_COM_CODE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl_SERVICE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            groupBox2COMPANY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)text_COM_NUMBER.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)text_COM_ADDRESS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_COM_NAME.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_COM_CODE.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelCOMPANY_NAME
            // 
            labelCOMPANY_NAME.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCOMPANY_NAME.Appearance.ForeColor = Color.LightSeaGreen;
            labelCOMPANY_NAME.Appearance.Options.UseFont = true;
            labelCOMPANY_NAME.Appearance.Options.UseForeColor = true;
            labelCOMPANY_NAME.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCOMPANY_NAME.Location = new Point(328, 0);
            labelCOMPANY_NAME.Name = "labelCOMPANY_NAME";
            labelCOMPANY_NAME.Size = new Size(832, 64);
            labelCOMPANY_NAME.TabIndex = 6;
            labelCOMPANY_NAME.Text = "      Добавление - изменение Страховые компании\r\n";
            // 
            // gridControl_SERVICE
            // 
            gridControl_SERVICE.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_SERVICE.Location = new Point(616, 96);
            gridControl_SERVICE.MainView = gridView1;
            gridControl_SERVICE.Name = "gridControl_SERVICE";
            gridControl_SERVICE.Size = new Size(832, 488);
            gridControl_SERVICE.TabIndex = 7;
            gridControl_SERVICE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl_SERVICE.Click += gridControl_SERVICE_Click;
            gridControl_SERVICE.DoubleClick += gridControl_COMPANY_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_SERVICE;
            gridView1.Name = "gridView1";
            // 
            // groupBox2COMPANY
            // 
            groupBox2COMPANY.BackColor = Color.Transparent;
            groupBox2COMPANY.Controls.Add(cmb_COM_STATE);
            groupBox2COMPANY.Controls.Add(text_COM_NUMBER);
            groupBox2COMPANY.Controls.Add(text_COM_ADDRESS);
            groupBox2COMPANY.Controls.Add(txt_COM_NAME);
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
            groupBox2COMPANY.Controls.Add(txt_COM_CODE);
            groupBox2COMPANY.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2COMPANY.ForeColor = Color.Black;
            groupBox2COMPANY.Location = new Point(24, 96);
            groupBox2COMPANY.Name = "groupBox2COMPANY";
            groupBox2COMPANY.Size = new Size(584, 488);
            groupBox2COMPANY.TabIndex = 8;
            groupBox2COMPANY.TabStop = false;
            groupBox2COMPANY.Text = "Данные Компании";
            groupBox2COMPANY.Enter += groupBox2COMPANY_Enter;
            // 
            // cmb_COM_STATE
            // 
            cmb_COM_STATE.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_COM_STATE.FormattingEnabled = true;
            cmb_COM_STATE.Location = new Point(200, 248);
            cmb_COM_STATE.Name = "cmb_COM_STATE";
            cmb_COM_STATE.Size = new Size(296, 30);
            cmb_COM_STATE.TabIndex = 39;
            cmb_COM_STATE.SelectedIndexChanged += cmb_COM_STATE_SelectedIndexChanged;
            // 
            // text_COM_NUMBER
            // 
            text_COM_NUMBER.Location = new Point(200, 208);
            text_COM_NUMBER.Name = "text_COM_NUMBER";
            text_COM_NUMBER.Size = new Size(296, 26);
            text_COM_NUMBER.TabIndex = 38;
            // 
            // text_COM_ADDRESS
            // 
            text_COM_ADDRESS.Location = new Point(200, 168);
            text_COM_ADDRESS.Name = "text_COM_ADDRESS";
            text_COM_ADDRESS.Size = new Size(296, 26);
            text_COM_ADDRESS.TabIndex = 37;
            // 
            // txt_COM_NAME
            // 
            txt_COM_NAME.Location = new Point(200, 128);
            txt_COM_NAME.Name = "txt_COM_NAME";
            txt_COM_NAME.Size = new Size(296, 26);
            txt_COM_NAME.TabIndex = 36;
            txt_COM_NAME.EditValueChanged += txt_COM_NAME_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(16, 248);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(67, 24);
            labelControl1.TabIndex = 35;
            labelControl1.Text = "Статус ";
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(24, 312);
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
            btn_Edit.Location = new Point(136, 312);
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
            btn_clear.Location = new Point(376, 312);
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
            btn_DELETE.Location = new Point(248, 312);
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
            lbl_CLINIC_NOTES.Size = new Size(163, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Компании Номер";
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(16, 168);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(155, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "Компании Адрес";
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(16, 128);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(141, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Компании Имя";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(16, 88);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(136, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Компании Код";
            // 
            // txt_COM_CODE
            // 
            txt_COM_CODE.Location = new Point(200, 88);
            txt_COM_CODE.Name = "txt_COM_CODE";
            txt_COM_CODE.Size = new Size(296, 26);
            txt_COM_CODE.TabIndex = 0;
            // 
            // frmCOMPANY
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 654);
            Controls.Add(groupBox2COMPANY);
            Controls.Add(gridControl_SERVICE);
            Controls.Add(labelCOMPANY_NAME);
            Name = "frmCOMPANY";
            Text = "frmCOMPANY";
            Load += frmCOMPANY_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl_SERVICE).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            groupBox2COMPANY.ResumeLayout(false);
            groupBox2COMPANY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)text_COM_NUMBER.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)text_COM_ADDRESS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_COM_NAME.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_COM_CODE.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelCOMPANY_NAME;
        private DevExpress.XtraGrid.GridControl gridControl_SERVICE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GroupBox groupBox2COMPANY;
        private DevExpress.XtraEditors.TextEdit text__CLINIC_NAME;
        private Button button1;
        private ComboBox cmb_COM_STATE;
        private ComboBox cmb_USER_I;
        private DevExpress.XtraEditors.LabelControl lbl_USER_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lbl_CLINIC_NOTES;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_ADDRESS;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_NAME;
        private DevExpress.XtraEditors.LabelControl txtlblCLINIC;
        private DevExpress.XtraEditors.TextEdit txt_CLINIC_ADDRESS;
        private DevExpress.XtraEditors.TextEdit txt_CLINIC_NOTES;
        private DevExpress.XtraEditors.TextEdit txt_COM_CODE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit text_COM_NUMBER;
        private DevExpress.XtraEditors.TextEdit text_COM_ADDRESS;
        private DevExpress.XtraEditors.TextEdit txt_COM_NAME;
        private Button btn_Save;
        private Button btn_Edit;
        private Button btn_clear;
        private Button btn_DELETE;
    }
}