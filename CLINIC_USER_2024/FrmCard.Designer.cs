namespace CLINIC_USER_2024
{
    partial class FrmCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCard));
            gridControl_CARD = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox2COMPANY = new GroupBox();
            button1 = new Button();
            cmb_USER_NAME = new ComboBox();
            cmb_USER_I = new ComboBox();
            dTP_CARD = new DevExpress.XtraEditors.DateEdit();
            txt_CARD_NOTES = new TextBox();
            txt_CARD_STATE = new TextBox();
            txt_CARD_NAME = new TextBox();
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
            txt_CARD_CODE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl_CARD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            groupBox2COMPANY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_CARD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CARD.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_CARD_CODE.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl_CARD
            // 
            gridControl_CARD.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_CARD.Location = new Point(632, 48);
            gridControl_CARD.MainView = gridView1;
            gridControl_CARD.Name = "gridControl_CARD";
            gridControl_CARD.Size = new Size(864, 520);
            gridControl_CARD.TabIndex = 11;
            gridControl_CARD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl_CARD.Click += gridControl_DIGANOC_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_CARD;
            gridView1.Name = "gridView1";
            // 
            // groupBox2COMPANY
            // 
            groupBox2COMPANY.BackColor = Color.Transparent;
            groupBox2COMPANY.Controls.Add(button1);
            groupBox2COMPANY.Controls.Add(cmb_USER_NAME);
            groupBox2COMPANY.Controls.Add(cmb_USER_I);
            groupBox2COMPANY.Controls.Add(dTP_CARD);
            groupBox2COMPANY.Controls.Add(txt_CARD_NOTES);
            groupBox2COMPANY.Controls.Add(txt_CARD_STATE);
            groupBox2COMPANY.Controls.Add(txt_CARD_NAME);
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
            groupBox2COMPANY.Controls.Add(txt_CARD_CODE);
            groupBox2COMPANY.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2COMPANY.ForeColor = Color.Black;
            groupBox2COMPANY.Location = new Point(28, 48);
            groupBox2COMPANY.Name = "groupBox2COMPANY";
            groupBox2COMPANY.Size = new Size(592, 528);
            groupBox2COMPANY.TabIndex = 12;
            groupBox2COMPANY.TabStop = false;
            groupBox2COMPANY.Text = "Данные Страхование";
            groupBox2COMPANY.Enter += groupBox2COMPANY_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkCyan;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(32, 304);
            button1.Name = "button1";
            button1.Size = new Size(176, 42);
            button1.TabIndex = 43;
            button1.Text = "Страховая компания";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // cmb_USER_NAME
            // 
            cmb_USER_NAME.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_NAME.FormattingEnabled = true;
            cmb_USER_NAME.Location = new Point(344, 312);
            cmb_USER_NAME.Name = "cmb_USER_NAME";
            cmb_USER_NAME.Size = new Size(192, 30);
            cmb_USER_NAME.TabIndex = 42;
            // 
            // cmb_USER_I
            // 
            cmb_USER_I.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_I.FormattingEnabled = true;
            cmb_USER_I.Location = new Point(240, 312);
            cmb_USER_I.Name = "cmb_USER_I";
            cmb_USER_I.Size = new Size(88, 30);
            cmb_USER_I.TabIndex = 41;
            // 
            // dTP_CARD
            // 
            dTP_CARD.EditValue = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            dTP_CARD.Location = new Point(240, 184);
            dTP_CARD.Name = "dTP_CARD";
            // 
            // 
            // 
            dTP_CARD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            // 
            // 
            // 
            dTP_CARD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_CARD.Size = new Size(296, 26);
            dTP_CARD.TabIndex = 40;
            // 
            // txt_CARD_NOTES
            // 
            txt_CARD_NOTES.Location = new Point(240, 264);
            txt_CARD_NOTES.Multiline = true;
            txt_CARD_NOTES.Name = "txt_CARD_NOTES";
            txt_CARD_NOTES.Size = new Size(296, 32);
            txt_CARD_NOTES.TabIndex = 39;
            // 
            // txt_CARD_STATE
            // 
            txt_CARD_STATE.Location = new Point(240, 224);
            txt_CARD_STATE.Multiline = true;
            txt_CARD_STATE.Name = "txt_CARD_STATE";
            txt_CARD_STATE.Size = new Size(296, 32);
            txt_CARD_STATE.TabIndex = 38;
            // 
            // txt_CARD_NAME
            // 
            txt_CARD_NAME.Location = new Point(240, 144);
            txt_CARD_NAME.Multiline = true;
            txt_CARD_NAME.Name = "txt_CARD_NAME";
            txt_CARD_NAME.Size = new Size(296, 32);
            txt_CARD_NAME.TabIndex = 36;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(40, 264);
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
            btn_Save.Location = new Point(40, 384);
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
            btn_Edit.Location = new Point(152, 384);
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
            btn_clear.Location = new Point(392, 384);
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
            btn_DELETE.Location = new Point(264, 384);
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
            lbl_CLINIC_NOTES.Location = new Point(40, 224);
            lbl_CLINIC_NOTES.Name = "lbl_CLINIC_NOTES";
            lbl_CLINIC_NOTES.Size = new Size(98, 24);
            lbl_CLINIC_NOTES.TabIndex = 16;
            lbl_CLINIC_NOTES.Text = "Состояние";
            // 
            // lbltxt_CLINIC_ADDRESS
            // 
            lbltxt_CLINIC_ADDRESS.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_ADDRESS.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_ADDRESS.Location = new Point(40, 184);
            lbltxt_CLINIC_ADDRESS.Name = "lbltxt_CLINIC_ADDRESS";
            lbltxt_CLINIC_ADDRESS.Size = new Size(41, 24);
            lbltxt_CLINIC_ADDRESS.TabIndex = 14;
            lbltxt_CLINIC_ADDRESS.Text = "дата";
            lbltxt_CLINIC_ADDRESS.Click += lbltxt_CLINIC_ADDRESS_Click;
            // 
            // lbltxt_CLINIC_NAME
            // 
            lbltxt_CLINIC_NAME.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbltxt_CLINIC_NAME.Appearance.Options.UseFont = true;
            lbltxt_CLINIC_NAME.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            lbltxt_CLINIC_NAME.Location = new Point(40, 144);
            lbltxt_CLINIC_NAME.Name = "lbltxt_CLINIC_NAME";
            lbltxt_CLINIC_NAME.Size = new Size(45, 24);
            lbltxt_CLINIC_NAME.TabIndex = 13;
            lbltxt_CLINIC_NAME.Text = "Имя ";
            lbltxt_CLINIC_NAME.UseMnemonic = false;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(40, 104);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(35, 24);
            txtlblCLINIC.TabIndex = 12;
            txtlblCLINIC.Text = "Код";
            // 
            // txt_CARD_CODE
            // 
            txt_CARD_CODE.Location = new Point(240, 104);
            txt_CARD_CODE.Name = "txt_CARD_CODE";
            txt_CARD_CODE.Size = new Size(296, 26);
            txt_CARD_CODE.TabIndex = 0;
            // 
            // FrmCard
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 616);
            Controls.Add(groupBox2COMPANY);
            Controls.Add(gridControl_CARD);
            Name = "FrmCard";
            Text = "FrmCard";
            Load += FrmCard_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl_CARD).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            groupBox2COMPANY.ResumeLayout(false);
            groupBox2COMPANY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_CARD.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CARD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_CARD_CODE.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_CARD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private GroupBox groupBox2COMPANY;
        private TextBox txt_CARD_NOTES;
        private TextBox txt_CARD_STATE;
        private TextBox txt_CARD_NAME;
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
        private DevExpress.XtraEditors.TextEdit txt_CARD_CODE;
        private DevExpress.XtraEditors.DateEdit dTP_CARD;
        private Button button1;
        private ComboBox cmb_USER_NAME;
        private ComboBox cmb_USER_I;
    }
}