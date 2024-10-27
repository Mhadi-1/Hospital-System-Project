namespace CLINIC_USER_2024
{
    partial class frmDIAGNOST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDIAGNOST));
            labelCOMPANY_NAME = new DevExpress.XtraEditors.LabelControl();
            groupBox2COMPANY = new GroupBox();
            txt_DIAGNO_NOTE = new TextBox();
            txt_DIAGNOTYPE = new TextBox();
            txt_DIAGNO_NAME = new TextBox();
            txt_DocName = new TextBox();
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
            txt_DIGNAL_CODE = new DevExpress.XtraEditors.TextEdit();
            gridControl_DIGANOC = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2COMPANY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_DIGNAL_CODE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl_DIGANOC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labelCOMPANY_NAME
            // 
            labelCOMPANY_NAME.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCOMPANY_NAME.Appearance.ForeColor = Color.LightSeaGreen;
            labelCOMPANY_NAME.Appearance.Options.UseFont = true;
            labelCOMPANY_NAME.Appearance.Options.UseForeColor = true;
            labelCOMPANY_NAME.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCOMPANY_NAME.Location = new Point(416, 0);
            labelCOMPANY_NAME.Name = "labelCOMPANY_NAME";
            labelCOMPANY_NAME.Size = new Size(648, 72);
            labelCOMPANY_NAME.TabIndex = 8;
            labelCOMPANY_NAME.Text = "      Добавить - Изменить Диагноз";
            // 
            // groupBox2COMPANY
            // 
            groupBox2COMPANY.BackColor = Color.Transparent;
            groupBox2COMPANY.Controls.Add(txt_DIAGNO_NOTE);
            groupBox2COMPANY.Controls.Add(txt_DIAGNOTYPE);
            groupBox2COMPANY.Controls.Add(txt_DIAGNO_NAME);
            groupBox2COMPANY.Controls.Add(txt_DocName);
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
            groupBox2COMPANY.Controls.Add(txt_DIGNAL_CODE);
            groupBox2COMPANY.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2COMPANY.ForeColor = Color.Black;
            groupBox2COMPANY.Location = new Point(32, 100);
            groupBox2COMPANY.Name = "groupBox2COMPANY";
            groupBox2COMPANY.Size = new Size(592, 504);
            groupBox2COMPANY.TabIndex = 11;
            groupBox2COMPANY.TabStop = false;
            groupBox2COMPANY.Text = "Данные Диагноз";
            groupBox2COMPANY.Enter += groupBox2COMPANY_Enter;
            // 
            // txt_DIAGNO_NOTE
            // 
            txt_DIAGNO_NOTE.Location = new Point(200, 248);
            txt_DIAGNO_NOTE.Multiline = true;
            txt_DIAGNO_NOTE.Name = "txt_DIAGNO_NOTE";
            txt_DIAGNO_NOTE.Size = new Size(296, 32);
            txt_DIAGNO_NOTE.TabIndex = 39;
            // 
            // txt_DIAGNOTYPE
            // 
            txt_DIAGNOTYPE.Location = new Point(200, 208);
            txt_DIAGNOTYPE.Multiline = true;
            txt_DIAGNOTYPE.Name = "txt_DIAGNOTYPE";
            txt_DIAGNOTYPE.Size = new Size(296, 32);
            txt_DIAGNOTYPE.TabIndex = 38;
            // 
            // txt_DIAGNO_NAME
            // 
            txt_DIAGNO_NAME.Location = new Point(200, 168);
            txt_DIAGNO_NAME.Multiline = true;
            txt_DIAGNO_NAME.Name = "txt_DIAGNO_NAME";
            txt_DIAGNO_NAME.Size = new Size(296, 32);
            txt_DIAGNO_NAME.TabIndex = 37;
            // 
            // txt_DocName
            // 
            txt_DocName.Location = new Point(200, 128);
            txt_DocName.Multiline = true;
            txt_DocName.Name = "txt_DocName";
            txt_DocName.Size = new Size(296, 32);
            txt_DocName.TabIndex = 36;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(16, 248);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(136, 24);
            labelControl1.TabIndex = 35;
            labelControl1.Text = "Имя Пациента";
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(32, 344);
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
            btn_Edit.Location = new Point(144, 344);
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
            btn_clear.Location = new Point(384, 344);
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
            btn_DELETE.Location = new Point(256, 344);
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
            lbl_CLINIC_NOTES.Size = new Size(118, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Диагноз Тип";
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(16, 168);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(127, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "Диагноз Имя ";
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(16, 128);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(109, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Имя Варача";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(16, 88);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(117, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Диагноз Код";
            // 
            // txt_DIGNAL_CODE
            // 
            txt_DIGNAL_CODE.Location = new Point(200, 88);
            txt_DIGNAL_CODE.Name = "txt_DIGNAL_CODE";
            txt_DIGNAL_CODE.Size = new Size(296, 26);
            txt_DIGNAL_CODE.TabIndex = 0;
            txt_DIGNAL_CODE.EditValueChanged += txt_DIGNAL_CODE_EditValueChanged;
            // 
            // gridControl_DIGANOC
            // 
            gridControl_DIGANOC.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_DIGANOC.Location = new Point(640, 104);
            gridControl_DIGANOC.MainView = gridView1;
            gridControl_DIGANOC.Name = "gridControl_DIGANOC";
            gridControl_DIGANOC.Size = new Size(864, 496);
            gridControl_DIGANOC.TabIndex = 10;
            gridControl_DIGANOC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl_DIGANOC.Click += gridControl_SERVICE_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_DIGANOC;
            gridView1.Name = "gridView1";
            // 
            // frmDIAGNOST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 698);
            Controls.Add(groupBox2COMPANY);
            Controls.Add(gridControl_DIGANOC);
            Controls.Add(labelCOMPANY_NAME);
            Name = "frmDIAGNOST";
            Text = "frmDIAGNOST";
            Load += frmDIAGNOST_Load;
            DoubleClick += frmDIAGNOST_DoubleClick;
            groupBox2COMPANY.ResumeLayout(false);
            groupBox2COMPANY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_DIGNAL_CODE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl_DIGANOC).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelCOMPANY_NAME;
        private GroupBox groupBox2COMPANY;
        private Button button1;
        private DevExpress.XtraEditors.TextEdit text_NOTES;
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
        private DevExpress.XtraEditors.TextEdit txt_DIGNAL_CODE;
        private DevExpress.XtraGrid.GridControl gridControl_DIGANOC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private TextBox txt_DIAGNO_NOTE;
        private TextBox txt_DIAGNOTYPE;
        private TextBox txt_DIAGNO_NAME;
        private TextBox txt_DocName;
    }
}