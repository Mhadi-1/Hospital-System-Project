namespace CLINIC_USER_2024.list_form
{
    partial class frmAPO_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPO_LIST));
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            dTP_CUST = new DevExpress.XtraEditors.DateEdit();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            cmb_USER_NAME = new ComboBox();
            cmb_COMPSNYNAME = new ComboBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtlblCLINIC = new DevExpress.XtraEditors.LabelControl();
            labelCOMPANY_NAME = new DevExpress.XtraEditors.LabelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CUST.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CUST.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelControl2);
            groupBox1.Controls.Add(labelControl3);
            groupBox1.Controls.Add(dateEdit1);
            groupBox1.Controls.Add(dTP_CUST);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(cmb_USER_NAME);
            groupBox1.Controls.Add(cmb_COMPSNYNAME);
            groupBox1.Controls.Add(labelControl1);
            groupBox1.Controls.Add(txtlblCLINIC);
            groupBox1.Location = new Point(48, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1120, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(936, 72);
            button3.Name = "button3";
            button3.Size = new Size(80, 48);
            button3.TabIndex = 58;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1040, 76);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 57;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.x_button;
            button1.Location = new Point(872, 76);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(592, 104);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(25, 24);
            labelControl2.TabIndex = 55;
            labelControl2.Text = "До";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(592, 64);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(26, 24);
            labelControl3.TabIndex = 54;
            labelControl3.Text = "От";
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            dateEdit1.Location = new Point(632, 104);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Size = new Size(188, 26);
            dateEdit1.TabIndex = 53;
            // 
            // dTP_CUST
            // 
            dTP_CUST.EditValue = new DateTime(2024, 3, 5, 0, 0, 0, 0);
            dTP_CUST.Location = new Point(632, 64);
            dTP_CUST.Name = "dTP_CUST";
            dTP_CUST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_CUST.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dTP_CUST.Size = new Size(188, 26);
            dTP_CUST.TabIndex = 52;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(272, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 30);
            comboBox1.TabIndex = 51;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(136, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(112, 30);
            comboBox2.TabIndex = 50;
            // 
            // cmb_USER_NAME
            // 
            cmb_USER_NAME.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_USER_NAME.FormattingEnabled = true;
            cmb_USER_NAME.Location = new Point(272, 64);
            cmb_USER_NAME.Name = "cmb_USER_NAME";
            cmb_USER_NAME.Size = new Size(288, 30);
            cmb_USER_NAME.TabIndex = 49;
            cmb_USER_NAME.SelectedIndexChanged += cmb_USER_NAME_SelectedIndexChanged;
            // 
            // cmb_COMPSNYNAME
            // 
            cmb_COMPSNYNAME.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_COMPSNYNAME.FormattingEnabled = true;
            cmb_COMPSNYNAME.Location = new Point(136, 64);
            cmb_COMPSNYNAME.Name = "cmb_COMPSNYNAME";
            cmb_COMPSNYNAME.Size = new Size(112, 30);
            cmb_COMPSNYNAME.TabIndex = 48;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(24, 104);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(68, 24);
            labelControl1.TabIndex = 15;
            labelControl1.Text = "Доктор";
            // 
            // txtlblCLINIC
            // 
            txtlblCLINIC.Appearance.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtlblCLINIC.Appearance.Options.UseFont = true;
            txtlblCLINIC.Location = new Point(24, 64);
            txtlblCLINIC.Name = "txtlblCLINIC";
            txtlblCLINIC.Size = new Size(96, 24);
            txtlblCLINIC.TabIndex = 14;
            txtlblCLINIC.Text = "Пациента ";
            // 
            // labelCOMPANY_NAME
            // 
            labelCOMPANY_NAME.Appearance.Font = new Font("Constantia", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCOMPANY_NAME.Appearance.ForeColor = Color.LightSeaGreen;
            labelCOMPANY_NAME.Appearance.Options.UseFont = true;
            labelCOMPANY_NAME.Appearance.Options.UseForeColor = true;
            labelCOMPANY_NAME.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelCOMPANY_NAME.Location = new Point(464, 16);
            labelCOMPANY_NAME.Name = "labelCOMPANY_NAME";
            labelCOMPANY_NAME.Size = new Size(320, 56);
            labelCOMPANY_NAME.TabIndex = 8;
            labelCOMPANY_NAME.Text = "      Список встреч";
            labelCOMPANY_NAME.Click += labelCOMPANY_NAME_Click;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(52, 296);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1112, 408);
            gridControl1.TabIndex = 9;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // frmAPO_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 792);
            Controls.Add(gridControl1);
            Controls.Add(labelCOMPANY_NAME);
            Controls.Add(groupBox1);
            Name = "frmAPO_LIST";
            Text = "frmAPO_LIST";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CUST.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dTP_CUST.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelCOMPANY_NAME;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl txtlblCLINIC;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox cmb_USER_NAME;
        private ComboBox cmb_COMPSNYNAME;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dTP_CUST;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}