namespace CLINIC_USER_2024
{
    partial class frmDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            groupBox2 = new GroupBox();
            button1 = new Button();
            dTP_DOC = new DevExpress.XtraEditors.DateEdit();
            btn_Save = new Button();
            btn_Edit = new Button();
            btn_clear = new Button();
            btn_DELETE = new Button();
            cmb_USER_NAME = new ComboBox();
            cmb_USER_ID = new ComboBox();
            lbl_USER_NAME = new DevExpress.XtraEditors.LabelControl();
            txt_DOC_NAME = new DevExpress.XtraEditors.TextEdit();
            labelControl17 = new DevExpress.XtraEditors.LabelControl();
            lbl_DOC_ADDERSS = new DevExpress.XtraEditors.LabelControl();
            lbl_DOC_NUMBER = new DevExpress.XtraEditors.LabelControl();
            lbl_DOC_DATE = new DevExpress.XtraEditors.LabelControl();
            lbl_DOC_EXP = new DevExpress.XtraEditors.LabelControl();
            lbltxt_DOC_MAJOR = new DevExpress.XtraEditors.LabelControl();
            lbltxt_DOC_NAME = new DevExpress.XtraEditors.LabelControl();
            txtlblDOC = new DevExpress.XtraEditors.LabelControl();
            txt_DOC_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            txt_DOC_NUMBER = new DevExpress.XtraEditors.TextEdit();
            txt_DOC_MAJOR = new DevExpress.XtraEditors.TextEdit();
            txt_DOC_EXP = new DevExpress.XtraEditors.TextEdit();
            txt_DOC_CODE = new DevExpress.XtraEditors.TextEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_DOC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTP_DOC.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_NAME.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_ADDRESS.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_NUMBER.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_MAJOR.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_EXP.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_CODE.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dTP_DOC);
            groupBox2.Controls.Add(btn_Save);
            groupBox2.Controls.Add(btn_Edit);
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_DELETE);
            groupBox2.Controls.Add(cmb_USER_NAME);
            groupBox2.Controls.Add(cmb_USER_ID);
            groupBox2.Controls.Add(lbl_USER_NAME);
            groupBox2.Controls.Add(txt_DOC_NAME);
            groupBox2.Controls.Add(labelControl17);
            groupBox2.Controls.Add(lbl_DOC_ADDERSS);
            groupBox2.Controls.Add(lbl_DOC_NUMBER);
            groupBox2.Controls.Add(lbl_DOC_DATE);
            groupBox2.Controls.Add(lbl_DOC_EXP);
            groupBox2.Controls.Add(lbltxt_DOC_MAJOR);
            groupBox2.Controls.Add(lbltxt_DOC_NAME);
            groupBox2.Controls.Add(txtlblDOC);
            groupBox2.Controls.Add(txt_DOC_ADDRESS);
            groupBox2.Controls.Add(txt_DOC_NUMBER);
            groupBox2.Controls.Add(txt_DOC_MAJOR);
            groupBox2.Controls.Add(txt_DOC_EXP);
            groupBox2.Controls.Add(txt_DOC_CODE);
            groupBox2.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(16, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 520);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные Врача";
            groupBox2.RightToLeftChanged += groupBox1_Enter;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Constantia", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.user;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(8, 376);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 33;
            button1.Text = "ПОЛЬЗОВАТЕЛЯ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dTP_DOC
            // 
            dTP_DOC.EditValue = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            dTP_DOC.Location = new Point(200, 248);
            dTP_DOC.Name = "dTP_DOC";
            dTP_DOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_DOC.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_DOC.Size = new Size(296, 26);
            dTP_DOC.TabIndex = 31;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(8, 440);
            btn_Save.Margin = new Padding(3, 3, 2, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(1);
            btn_Save.Size = new Size(96, 40);
            btn_Save.TabIndex = 30;
            btn_Save.Text = "Save\r\n";
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            btn_Save.Paint += btn_Save_Paint;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Image = Properties.Resources.editIcone;
            btn_Edit.ImageAlign = ContentAlignment.MiddleRight;
            btn_Edit.Location = new Point(120, 440);
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
            btn_clear.Location = new Point(360, 440);
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
            btn_DELETE.Location = new Point(232, 440);
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
            cmb_USER_NAME.Location = new Point(304, 376);
            cmb_USER_NAME.Name = "cmb_USER_NAME";
            cmb_USER_NAME.Size = new Size(208, 30);
            cmb_USER_NAME.TabIndex = 26;
            cmb_USER_NAME.SelectedIndexChanged += cmb_USER_NAME_SelectedIndexChanged;
            // 
            // cmb_USER_ID
            // 
            cmb_USER_ID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_ID.FormattingEnabled = true;
            cmb_USER_ID.Location = new Point(200, 376);
            cmb_USER_ID.Name = "cmb_USER_ID";
            cmb_USER_ID.Size = new Size(88, 30);
            cmb_USER_ID.TabIndex = 25;
            cmb_USER_ID.SelectedIndexChanged += cmb_USER_ID_SelectedIndexChanged;
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
            // txt_DOC_NAME
            // 
            txt_DOC_NAME.Location = new Point(200, 120);
            txt_DOC_NAME.Name = "txt_DOC_NAME";
            txt_DOC_NAME.Size = new Size(296, 26);
            txt_DOC_NAME.TabIndex = 1;
            txt_DOC_NAME.EditValueChanged += textEdit23_EditValueChanged;
            // 
            // labelControl17
            // 
            labelControl17.Location = new Point(0, 0);
            labelControl17.Name = "labelControl17";
            labelControl17.Size = new Size(0, 19);
            labelControl17.TabIndex = 2;
            // 
            // lbl_DOC_ADDERSS
            // 
            lbl_DOC_ADDERSS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DOC_ADDERSS.Appearance.Options.UseFont = true;
            lbl_DOC_ADDERSS.Location = new Point(16, 328);
            lbl_DOC_ADDERSS.Name = "lbl_DOC_ADDERSS";
            lbl_DOC_ADDERSS.Size = new Size(59, 24);
            lbl_DOC_ADDERSS.TabIndex = 19;
            lbl_DOC_ADDERSS.Text = " Адрес";
            lbl_DOC_ADDERSS.Click += labelControl9_Click;
            // 
            // lbl_DOC_NUMBER
            // 
            lbl_DOC_NUMBER.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DOC_NUMBER.Appearance.Options.UseFont = true;
            lbl_DOC_NUMBER.Location = new Point(16, 288);
            lbl_DOC_NUMBER.Name = "lbl_DOC_NUMBER";
            lbl_DOC_NUMBER.Size = new Size(157, 24);
            lbl_DOC_NUMBER.TabIndex = 18;
            lbl_DOC_NUMBER.Text = "Номер Телефона";
            lbl_DOC_NUMBER.Click += labelControl10_Click;
            // 
            // lbl_DOC_DATE
            // 
            lbl_DOC_DATE.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DOC_DATE.Appearance.Options.UseFont = true;
            lbl_DOC_DATE.Location = new Point(16, 248);
            lbl_DOC_DATE.Name = "lbl_DOC_DATE";
            lbl_DOC_DATE.Size = new Size(142, 24);
            lbl_DOC_DATE.TabIndex = 17;
            lbl_DOC_DATE.Text = "Дата Рождения";
            lbl_DOC_DATE.Click += labelControl11_Click;
            // 
            // lbl_DOC_EXP
            // 
            lbl_DOC_EXP.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_DOC_EXP.Appearance.Options.UseFont = true;
            lbl_DOC_EXP.Location = new Point(16, 200);
            lbl_DOC_EXP.Name = "lbl_DOC_EXP";
            lbl_DOC_EXP.Size = new Size(57, 24);
            lbl_DOC_EXP.TabIndex = 16;
            lbl_DOC_EXP.Text = " Опыт";
            lbl_DOC_EXP.Click += labelControl12_Click;
            // 
            // lbltxt_DOC_MAJOR
            // 
            lbltxt_DOC_MAJOR.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_DOC_MAJOR.Appearance.Options.UseFont = true;
            lbltxt_DOC_MAJOR.Location = new Point(16, 160);
            lbltxt_DOC_MAJOR.Name = "lbltxt_DOC_MAJOR";
            lbltxt_DOC_MAJOR.Size = new Size(147, 24);
            lbltxt_DOC_MAJOR.TabIndex = 14;
            lbltxt_DOC_MAJOR.Text = "Специальность ";
            lbltxt_DOC_MAJOR.Click += labelControl14_Click;
            // 
            // lbltxt_DOC_NAME
            // 
            lbltxt_DOC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_DOC_NAME.Appearance.Options.UseFont = true;
            lbltxt_DOC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_DOC_NAME.Location = new Point(16, 120);
            lbltxt_DOC_NAME.Name = "lbltxt_DOC_NAME";
            lbltxt_DOC_NAME.Size = new Size(99, 24);
            lbltxt_DOC_NAME.TabIndex = 13;
            lbltxt_DOC_NAME.Text = "Имя Врача";
            lbltxt_DOC_NAME.UseMnemonic = false;
            lbltxt_DOC_NAME.Click += labelControl15_Click;
            // 
            // txtlblDOC
            // 
            txtlblDOC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblDOC.Appearance.Options.UseFont = true;
            txtlblDOC.Location = new Point(16, 80);
            txtlblDOC.Name = "txtlblDOC";
            txtlblDOC.Size = new Size(94, 24);
            txtlblDOC.TabIndex = 12;
            txtlblDOC.Text = "Врача Код";
            txtlblDOC.Click += labelControl16_Click;
            // 
            // txt_DOC_ADDRESS
            // 
            txt_DOC_ADDRESS.Location = new Point(200, 328);
            txt_DOC_ADDRESS.Name = "txt_DOC_ADDRESS";
            txt_DOC_ADDRESS.Size = new Size(296, 26);
            txt_DOC_ADDRESS.TabIndex = 11;
            txt_DOC_ADDRESS.EditValueChanged += textEdit13_EditValueChanged;
            // 
            // txt_DOC_NUMBER
            // 
            txt_DOC_NUMBER.Location = new Point(200, 288);
            txt_DOC_NUMBER.Name = "txt_DOC_NUMBER";
            txt_DOC_NUMBER.Size = new Size(296, 26);
            txt_DOC_NUMBER.TabIndex = 7;
            txt_DOC_NUMBER.EditValueChanged += textEdit17_EditValueChanged;
            // 
            // txt_DOC_MAJOR
            // 
            txt_DOC_MAJOR.Location = new Point(200, 160);
            txt_DOC_MAJOR.Name = "txt_DOC_MAJOR";
            txt_DOC_MAJOR.Size = new Size(296, 26);
            txt_DOC_MAJOR.TabIndex = 1;
            txt_DOC_MAJOR.EditValueChanged += textEdit19_EditValueChanged;
            // 
            // txt_DOC_EXP
            // 
            txt_DOC_EXP.Location = new Point(200, 200);
            txt_DOC_EXP.Name = "txt_DOC_EXP";
            txt_DOC_EXP.Size = new Size(296, 26);
            txt_DOC_EXP.TabIndex = 4;
            txt_DOC_EXP.EditValueChanged += textEdit20_EditValueChanged;
            // 
            // txt_DOC_CODE
            // 
            txt_DOC_CODE.Location = new Point(200, 80);
            txt_DOC_CODE.Name = "txt_DOC_CODE";
            txt_DOC_CODE.Size = new Size(296, 26);
            txt_DOC_CODE.TabIndex = 0;
            txt_DOC_CODE.EditValueChanged += textEdit24_EditValueChanged;
            // 
            // gridControl1
            // 
            gridControl1.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1.Location = new Point(576, 40);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(832, 520);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            gridControl1.DoubleClick += gridControl1_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.MasterRowGetChildList += gridView1_MasterRowGetChildList;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 658);
            Controls.Add(gridControl1);
            Controls.Add(groupBox2);
            Name = "frmDoctor";
            Text = "frmDoctor";
            Load += frmDoctor_Load;
            Paint += frmDoctor_Paint;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_DOC.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTP_DOC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_NAME.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_ADDRESS.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_NUMBER.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_MAJOR.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_EXP.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_DOC_CODE.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cmb_USER_NAME;
        private ComboBox cmb_USER_ID;
        private DevExpress.XtraEditors.LabelControl lbl_USER_NAME;
        private DevExpress.XtraEditors.TextEdit txt_DOC_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_ADDERSS;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_NUMBER;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_DATE;
        private DevExpress.XtraEditors.LabelControl lbl_DOC_EXP;
        private DevExpress.XtraEditors.LabelControl lbltxt_DOC_MAJOR;
        private DevExpress.XtraEditors.LabelControl lbltxt_DOC_NAME;
        private DevExpress.XtraEditors.LabelControl txtlblDOC;
        private DevExpress.XtraEditors.TextEdit txt_DOC_ADDRESS;
        private DevExpress.XtraEditors.TextEdit txt_DOC_NUMBER;
        private DevExpress.XtraEditors.TextEdit txt_DOC_MAJOR;
        private DevExpress.XtraEditors.TextEdit txt_DOC_EXP;
        private DevExpress.XtraEditors.TextEdit txt_DOC_CODE;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button btn_DELETE;
        private Button btn_Save;
        private Button btn_Edit;
        private Button btn_clear;
        private DevExpress.XtraEditors.DateEdit dTP_DOC;
        private Button button1;
    }
}