namespace CLINIC_USER_2024.list_form
{
    partial class frmSERVICE_LIST
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
            gridControl1SER_LIST = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btn_CLEARTEXT = new Button();
            txt_SER_NAME = new TextBox();
            labeCLINIC_CONROE = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1SER_LIST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1SER_LIST
            // 
            gridControl1SER_LIST.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1SER_LIST.Location = new Point(24, 160);
            gridControl1SER_LIST.MainView = gridView1;
            gridControl1SER_LIST.Name = "gridControl1SER_LIST";
            gridControl1SER_LIST.Size = new Size(872, 440);
            gridControl1SER_LIST.TabIndex = 7;
            gridControl1SER_LIST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1SER_LIST.Click += gridControl1SER_LIST_Click;
            gridControl1SER_LIST.DoubleClick += gridControl1SER_LIST_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1SER_LIST;
            gridView1.Name = "gridView1";
            // 
            // btn_CLEARTEXT
            // 
            btn_CLEARTEXT.Image = Properties.Resources.x_button;
            btn_CLEARTEXT.ImageAlign = ContentAlignment.MiddleRight;
            btn_CLEARTEXT.Location = new Point(84, 100);
            btn_CLEARTEXT.Name = "btn_CLEARTEXT";
            btn_CLEARTEXT.Size = new Size(152, 35);
            btn_CLEARTEXT.TabIndex = 10;
            btn_CLEARTEXT.Text = "Прозрачный";
            btn_CLEARTEXT.TextAlign = ContentAlignment.MiddleLeft;
            btn_CLEARTEXT.UseVisualStyleBackColor = true;
            btn_CLEARTEXT.Click += button1_Click;
            // 
            // txt_SER_NAME
            // 
            txt_SER_NAME.Location = new Point(248, 104);
            txt_SER_NAME.Name = "txt_SER_NAME";
            txt_SER_NAME.Size = new Size(432, 27);
            txt_SER_NAME.TabIndex = 9;
            txt_SER_NAME.TextChanged += txt_SER_NAME_TextChanged;
            // 
            // labeCLINIC_CONROE
            // 
            labeCLINIC_CONROE.Appearance.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeCLINIC_CONROE.Appearance.ForeColor = Color.LightSeaGreen;
            labeCLINIC_CONROE.Appearance.Options.UseFont = true;
            labeCLINIC_CONROE.Appearance.Options.UseForeColor = true;
            labeCLINIC_CONROE.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labeCLINIC_CONROE.Location = new Point(320, 24);
            labeCLINIC_CONROE.Name = "labeCLINIC_CONROE";
            labeCLINIC_CONROE.Size = new Size(280, 40);
            labeCLINIC_CONROE.TabIndex = 8;
            labeCLINIC_CONROE.Text = "  Список (SERVICES)\r\n";
            // 
            // frmSERVICE_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 648);
            Controls.Add(btn_CLEARTEXT);
            Controls.Add(txt_SER_NAME);
            Controls.Add(labeCLINIC_CONROE);
            Controls.Add(gridControl1SER_LIST);
            Name = "frmSERVICE_LIST";
            Text = "frmSERVICE_LIST";
            FormClosed += frmSERVICE_LIST_FormClosed;
            Load += frmSERVICE_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1SER_LIST).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1SER_LIST;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button btn_CLEARTEXT;
        private TextBox txt_SER_NAME;
        private DevExpress.XtraEditors.LabelControl labeCLINIC_CONROE;
    }
}