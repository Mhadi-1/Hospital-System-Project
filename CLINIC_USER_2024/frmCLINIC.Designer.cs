namespace CLINIC_USER_2024
{
    partial class frmCLINIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLINIC));
            groupBox2 = new GroupBox();
            text__CLINIC_NAME = new DevExpress.XtraEditors.TextEdit();
            button1 = new Button();
            btn_Save = new Button();
            btn_Edit = new Button();
            btn_clear = new Button();
            btn_DELETE = new Button();
            cmb_USER_NAME = new ComboBox();
            cmb_USER_I = new ComboBox();
            lbl_USER_NAME = new DevExpress.XtraEditors.LabelControl();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            lbl_CLINIC_NOTES = new DevExpress.XtraEditors.LabelControl();
            lbltxt_CLINIC_ADDRESS = new DevExpress.XtraEditors.LabelControl();
            lbltxt_CLINIC_NAME = new DevExpress.XtraEditors.LabelControl();
            txtlblCLINIC = new DevExpress.XtraEditors.LabelControl();
            txt_CLINIC_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            txt_CLINIC_NOTES = new DevExpress.XtraEditors.TextEdit();
            txt_CLINIC_CODE = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)text__CLINIC_NAME.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_ADDRESS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_NOTES.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_CODE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(text__CLINIC_NAME);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btn_Save);
            groupBox2.Controls.Add(btn_Edit);
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_DELETE);
            groupBox2.Controls.Add(cmb_USER_NAME);
            groupBox2.Controls.Add(cmb_USER_I);
            groupBox2.Controls.Add(lbl_USER_NAME);
            groupBox2.Controls.Add(labelControl17);
            groupBox2.Controls.Add(lbl_CLINIC_NOTES);
            groupBox2.Controls.Add(lbltxt_CLINIC_ADDRESS);
            groupBox2.Controls.Add(lbltxt_CLINIC_NAME);
            groupBox2.Controls.Add(txtlblCLINIC);
            groupBox2.Controls.Add(txt_CLINIC_ADDRESS);
            groupBox2.Controls.Add(txt_CLINIC_NOTES);
            groupBox2.Controls.Add(txt_CLINIC_CODE);
            groupBox2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(32, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 472);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные клиники";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // text__CLINIC_NAME
            // 
            text__CLINIC_NAME.Location = new Point(200, 128);
            text__CLINIC_NAME.Name = "text__CLINIC_NAME";
            text__CLINIC_NAME.Size = new Size(296, 26);
            text__CLINIC_NAME.TabIndex = 34;
            text__CLINIC_NAME.EditValueChanged += text__CLINIC_NAME_EditValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.user;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(16, 280);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 33;
            button1.Text = "ПОЛЬЗОВАТЕЛЯ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(16, 344);
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
            btn_Edit.Location = new Point(128, 344);
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
            btn_clear.Location = new Point(368, 344);
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
            btn_DELETE.Location = new Point(240, 344);
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
            // cmb_USER_NAME
            // 
            cmb_USER_NAME.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_NAME.FormattingEnabled = true;
            cmb_USER_NAME.Location = new Point(312, 280);
            cmb_USER_NAME.Name = "cmb_USER_NAME";
            cmb_USER_NAME.Size = new Size(208, 30);
            cmb_USER_NAME.TabIndex = 26;
            cmb_USER_NAME.SelectedIndexChanged += cmb_USER_NAME_SelectedIndexChanged;
            // 
            // cmb_USER_I
            // 
            cmb_USER_I.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_I.FormattingEnabled = true;
            cmb_USER_I.Location = new Point(208, 280);
            cmb_USER_I.Name = "cmb_USER_I";
            cmb_USER_I.Size = new Size(88, 30);
            cmb_USER_I.TabIndex = 25;
            cmb_USER_I.SelectedIndexChanged += cmb_USER_ID_SelectedIndexChanged;
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
            lbl_CLINIC_NOTES.Size = new Size(129, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Kомментарий";
            lbl_CLINIC_NOTES.Click += lbl_CLINIC_NOTES_Click;
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(16, 168);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(142, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "Клиники Адрес";
            lbltxt_CLINIC_ADDRESS.Click += lbltxt_CLINIC_ADDRESS_Click;
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(16, 128);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(128, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Клиники Имя";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            lbltxt_CLINIC_NAME.Click += lbltxt_CLINIC_NAME_Click;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(16, 88);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(123, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Kлиники Код";
            txtlblCLINIC.Click += txtlblCLINIC_Click;
            // 
            // txt_CLINIC_ADDRESS
            // 
            txt_CLINIC_ADDRESS.Location = new Point(200, 168);
            txt_CLINIC_ADDRESS.Name = "txt_CLINIC_ADDRESS";
            txt_CLINIC_ADDRESS.Size = new Size(296, 26);
            txt_CLINIC_ADDRESS.TabIndex = 1;
            txt_CLINIC_ADDRESS.EditValueChanged += txt_CLINIC_ADDRESS_EditValueChanged;
            // 
            // txt_CLINIC_NOTES
            // 
            txt_CLINIC_NOTES.Location = new Point(200, 208);
            txt_CLINIC_NOTES.Name = "txt_CLINIC_NOTES";
            txt_CLINIC_NOTES.Size = new Size(296, 26);
            txt_CLINIC_NOTES.TabIndex = 4;
            txt_CLINIC_NOTES.EditValueChanged += txt_CLINIC_NOTES_EditValueChanged;
            // 
            // txt_CLINIC_CODE
            // 
            txt_CLINIC_CODE.Location = new Point(200, 88);
            txt_CLINIC_CODE.Name = "txt_CLINIC_CODE";
            txt_CLINIC_CODE.Size = new Size(296, 26);
            txt_CLINIC_CODE.TabIndex = 0;
            txt_CLINIC_CODE.EditValueChanged += txt_CLINIC_CODE_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(408, 0);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(648, 56);
            labelControl1.TabIndex = 5;
            labelControl1.Text = "      Добавление - изменение клиник";
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            gridControl1.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1.Location = new Point(632, 88);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(792, 472);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            gridControl1.DoubleClick += gridControl1_DoubleClick;
            // 
            // frmCLINIC
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 648);
            Controls.Add(labelControl1);
            Controls.Add(groupBox2);
            Controls.Add(gridControl1);
            Name = "frmCLINIC";
            Text = "frmCLINIC";
            Load += frmCLINIC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)text__CLINIC_NAME.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_ADDRESS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_NOTES.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_CLINIC_CODE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button button1;
        private DevExpress.XtraEditors.DateEdit dTP_DOC;
        private Button btn_Save;
        private Button btn_Edit;
        private Button btn_clear;
        private Button btn_DELETE;
        private ComboBox cmb_USER_NAME;
        private ComboBox cmb_USER_I;
        private DevExpress.XtraEditors.LabelControl lbl_USER_NAME;
        private DevExpress.XtraEditors.TextEdit txt_DOC_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_ADDERSS;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_NUMBER;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_DATE;
        private DevExpress.XtraEditors.LabelControl lbl_CLINIC_NOTES;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_ADDRESS;
        private DevExpress.XtraEditors.LabelControl lbltxt_CLINIC_NAME;
        private DevExpress.XtraEditors.LabelControl txtlblCLINIC;
        private DevExpress.XtraEditors.TextEdit txt_DOC_ADDRESS;
        private DevExpress.XtraEditors.TextEdit txt_DOC_NUMBER;
        private DevExpress.XtraEditors.TextEdit txt_CLINIC_ADDRESS;
        private DevExpress.XtraEditors.TextEdit txt_CLINIC_NOTES;
        private DevExpress.XtraEditors.TextEdit txt_CLINIC_CODE;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit text__CLINIC_NAME;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}