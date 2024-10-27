namespace CLINIC_USER_2024
{
    partial class frmAPOINTMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPOINTMENT));
            groupBox1 = new GroupBox();
            cmd_cust_name = new ComboBox();
            cmd_cust_ID = new ComboBox();
            comb_DOC_NAME = new ComboBox();
            cmbDOC_ID = new ComboBox();
            btn_Save = new Button();
            btn_Edit = new Button();
            btn_clear = new Button();
            btn_DELETE = new Button();
            masked_APO = new MaskedTextBox();
            label_DOC_LIST = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            textBox4 = new TextBox();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            text_NOTS = new TextBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            dTP_APO = new DevExpress.XtraEditors.DateEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textBox1 = new TextBox();
            txtlblCLINIC = new DevExpress.XtraEditors.LabelControl();
            xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textBox2 = new TextBox();
            gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            gridControl_APO = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_APO.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTP_APO.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).BeginInit();
            gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl_APO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmd_cust_name);
            groupBox1.Controls.Add(cmd_cust_ID);
            groupBox1.Controls.Add(comb_DOC_NAME);
            groupBox1.Controls.Add(cmbDOC_ID);
            groupBox1.Controls.Add(btn_Save);
            groupBox1.Controls.Add(btn_Edit);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(btn_DELETE);
            groupBox1.Controls.Add(masked_APO);
            groupBox1.Controls.Add(label_DOC_LIST);
            groupBox1.Controls.Add(labelControl6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(labelControl5);
            groupBox1.Controls.Add(text_NOTS);
            groupBox1.Controls.Add(labelControl4);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.Controls.Add(dTP_APO);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtlblCLINIC);
            groupBox1.Location = new Point(8, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 496);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "данные о встрече";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmd_cust_name
            // 
            cmd_cust_name.FormattingEnabled = true;
            cmd_cust_name.Location = new Point(344, 80);
            cmd_cust_name.Name = "cmd_cust_name";
            cmd_cust_name.Size = new Size(208, 27);
            cmd_cust_name.TabIndex = 61;
            cmd_cust_name.UseWaitCursor = true;
            // 
            // cmd_cust_ID
            // 
            cmd_cust_ID.FormattingEnabled = true;
            cmd_cust_ID.Location = new Point(184, 80);
            cmd_cust_ID.Name = "cmd_cust_ID";
            cmd_cust_ID.Size = new Size(155, 27);
            cmd_cust_ID.TabIndex = 60;
            cmd_cust_ID.UseWaitCursor = true;
            // 
            // comb_DOC_NAME
            // 
            comb_DOC_NAME.FormattingEnabled = true;
            comb_DOC_NAME.Location = new Point(352, 352);
            comb_DOC_NAME.Name = "comb_DOC_NAME";
            comb_DOC_NAME.Size = new Size(200, 27);
            comb_DOC_NAME.TabIndex = 59;
            comb_DOC_NAME.UseWaitCursor = true;
            // 
            // cmbDOC_ID
            // 
            cmbDOC_ID.FormattingEnabled = true;
            cmbDOC_ID.Location = new Point(176, 352);
            cmbDOC_ID.Name = "cmbDOC_ID";
            cmbDOC_ID.Size = new Size(163, 27);
            cmbDOC_ID.TabIndex = 58;
            cmbDOC_ID.UseWaitCursor = true;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderColor = SystemColors.Highlight;
            btn_Save.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btn_Save.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.Image = (Image)resources.GetObject("btn_Save.Image");
            btn_Save.ImageAlign = ContentAlignment.MiddleRight;
            btn_Save.Location = new Point(24, 424);
            btn_Save.Margin = new Padding(3, 3, 2, 3);
            btn_Save.Name = "btn_Save";
            btn_Save.Padding = new Padding(1);
            btn_Save.Size = new Size(96, 32);
            btn_Save.TabIndex = 57;
            btn_Save.Text = "Save\r\n";
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Image = Properties.Resources.editIcone;
            btn_Edit.ImageAlign = ContentAlignment.MiddleRight;
            btn_Edit.Location = new Point(136, 424);
            btn_Edit.Margin = new Padding(3, 3, 2, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Padding = new Padding(1);
            btn_Edit.Size = new Size(96, 32);
            btn_Edit.TabIndex = 56;
            btn_Edit.Text = "Edit";
            btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_clear.Image = Properties.Resources.x_button;
            btn_clear.ImageAlign = ContentAlignment.MiddleRight;
            btn_clear.Location = new Point(376, 424);
            btn_clear.Margin = new Padding(3, 3, 2, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Padding = new Padding(1);
            btn_clear.Size = new Size(104, 32);
            btn_clear.TabIndex = 55;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_DELETE
            // 
            btn_DELETE.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DELETE.Image = Properties.Resources.trashIcone;
            btn_DELETE.ImageAlign = ContentAlignment.MiddleRight;
            btn_DELETE.Location = new Point(248, 424);
            btn_DELETE.Margin = new Padding(3, 3, 2, 3);
            btn_DELETE.Name = "btn_DELETE";
            btn_DELETE.Padding = new Padding(1);
            btn_DELETE.Size = new Size(112, 32);
            btn_DELETE.TabIndex = 54;
            btn_DELETE.Text = "Delete";
            btn_DELETE.TextAlign = ContentAlignment.MiddleLeft;
            btn_DELETE.UseVisualStyleBackColor = true;
            // 
            // masked_APO
            // 
            masked_APO.Location = new Point(184, 216);
            masked_APO.Mask = "00:00";
            masked_APO.Name = "masked_APO";
            masked_APO.Size = new Size(368, 27);
            masked_APO.TabIndex = 53;
            masked_APO.TextAlign = HorizontalAlignment.Center;
            masked_APO.ValidatingType = typeof(DateTime);
            // 
            // label_DOC_LIST
            // 
            label_DOC_LIST.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_DOC_LIST.Appearance.Options.UseFont = true;
            label_DOC_LIST.Location = new Point(8, 360);
            label_DOC_LIST.Name = "label_DOC_LIST";
            label_DOC_LIST.Size = new Size(97, 24);
            label_DOC_LIST.TabIndex = 50;
            label_DOC_LIST.Text = "Имя врача";
            label_DOC_LIST.Click += labelControl7_Click;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(8, 312);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(129, 24);
            labelControl6.TabIndex = 49;
            labelControl6.Text = "Комментарии";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 27);
            textBox4.TabIndex = 48;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.Location = new Point(8, 264);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(136, 32);
            labelControl5.TabIndex = 47;
            labelControl5.Text = "Название";
            // 
            // text_NOTS
            // 
            text_NOTS.Location = new Point(184, 264);
            text_NOTS.Name = "text_NOTS";
            text_NOTS.Size = new Size(368, 27);
            text_NOTS.TabIndex = 46;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(8, 216);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(135, 24);
            labelControl4.TabIndex = 45;
            labelControl4.Text = "Время встречи";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(8, 168);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(168, 24);
            labelControl3.TabIndex = 43;
            labelControl3.Text = "Назначенная дата";
            // 
            // dTP_APO
            // 
            dTP_APO.EditValue = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            dTP_APO.Location = new Point(200, 168);
            dTP_APO.Name = "dTP_APO";
            dTP_APO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_APO.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_APO.Size = new Size(344, 26);
            dTP_APO.TabIndex = 42;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(8, 120);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(35, 24);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Код";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 27);
            textBox1.TabIndex = 14;
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(8, 80);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(133, 24);
            txtlblCLINIC.TabIndex = 13;
            txtlblCLINIC.Text = "Имя пациента";
            // 
            // xtraScrollableControl1
            // 
            xtraScrollableControl1.Location = new Point(576, 0);
            xtraScrollableControl1.Name = "xtraScrollableControl1";
            xtraScrollableControl1.Size = new Size(112, 34);
            xtraScrollableControl1.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(424, 0);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(648, 56);
            labelControl2.TabIndex = 15;
            labelControl2.Text = "      Добавление - изменение встреча\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(848, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 27);
            textBox2.TabIndex = 58;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // gridSplitContainer1
            // 
            gridSplitContainer1.Dock = DockStyle.Fill;
            gridSplitContainer1.Grid = null;
            gridSplitContainer1.Location = new Point(0, 0);
            gridSplitContainer1.Name = "gridSplitContainer1";
            gridSplitContainer1.Size = new Size(1491, 652);
            gridSplitContainer1.TabIndex = 59;
            // 
            // gridControl_APO
            // 
            gridControl_APO.Font = new Font("Constantia", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl_APO.Location = new Point(656, 144);
            gridControl_APO.MainView = gridView1;
            gridControl_APO.Name = "gridControl_APO";
            gridControl_APO.Size = new Size(792, 472);
            gridControl_APO.TabIndex = 59;
            gridControl_APO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl_APO;
            gridView1.Name = "gridView1";
            // 
            // frmAPOINTMENT
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 652);
            Controls.Add(gridControl_APO);
            Controls.Add(textBox2);
            Controls.Add(labelControl2);
            Controls.Add(xtraScrollableControl1);
            Controls.Add(groupBox1);
            Name = "frmAPOINTMENT";
            Text = "frmAPOINTMENT";
            Load += frmAPOINTMENT_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dTP_APO.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTP_APO.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).EndInit();
            gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl_APO).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl txtlblCLINIC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label_DOC_LIST;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private TextBox textBox4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private TextBox text_NOTS;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dTP_APO;
        private MaskedTextBox masked_APO;
        private Button btn_Save;
        private Button btn_Edit;
        private Button btn_clear;
        private Button btn_DELETE;
        private TextBox textBox2;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl_APO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ComboBox cmbDOC_ID;
        private ComboBox comb_DOC_NAME;
        private ComboBox cmd_cust_name;
        private ComboBox cmd_cust_ID;
    }
}