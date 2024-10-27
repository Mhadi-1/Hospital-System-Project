namespace CLINIC_USER_2024.list_form
{
    partial class frmCLINIC_LIST
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
            labeCLINIC_CONROE = new DevExpress.XtraEditors.LabelControl();
            button1 = new Button();
            txt_CLINIC_NAME = new TextBox();
            gridControl1CLINIC_LIST = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridControl1CLINIC_LIST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labeCLINIC_CONROE
            // 
            labeCLINIC_CONROE.Appearance.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeCLINIC_CONROE.Appearance.ForeColor = Color.LightSeaGreen;
            labeCLINIC_CONROE.Appearance.Options.UseFont = true;
            labeCLINIC_CONROE.Appearance.Options.UseForeColor = true;
            labeCLINIC_CONROE.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labeCLINIC_CONROE.Location = new Point(344, 8);
            labeCLINIC_CONROE.Name = "labeCLINIC_CONROE";
            labeCLINIC_CONROE.Size = new Size(288, 34);
            labeCLINIC_CONROE.TabIndex = 3;
            labeCLINIC_CONROE.Text = "           Список Клиники\r\n";
            labeCLINIC_CONROE.Click += labeCLINIC_CONROE_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.x_button;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(136, 60);
            button1.Name = "button1";
            button1.Size = new Size(152, 35);
            button1.TabIndex = 5;
            button1.Text = "Прозрачный";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_CLINIC_NAME
            // 
            txt_CLINIC_NAME.Location = new Point(304, 64);
            txt_CLINIC_NAME.Name = "txt_CLINIC_NAME";
            txt_CLINIC_NAME.Size = new Size(432, 27);
            txt_CLINIC_NAME.TabIndex = 4;
            txt_CLINIC_NAME.TextChanged += txt_CLINIC_NAME_TextChanged;
            // 
            // gridControl1CLINIC_LIST
            // 
            gridControl1CLINIC_LIST.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1CLINIC_LIST.Location = new Point(56, 120);
            gridControl1CLINIC_LIST.MainView = gridView1;
            gridControl1CLINIC_LIST.Name = "gridControl1CLINIC_LIST";
            gridControl1CLINIC_LIST.Size = new Size(856, 440);
            gridControl1CLINIC_LIST.TabIndex = 6;
            gridControl1CLINIC_LIST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1CLINIC_LIST.Click += gridControl1DOCTORS_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1CLINIC_LIST;
            gridView1.Name = "gridView1";
            // 
            // frmCLINIC_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 595);
            Controls.Add(gridControl1CLINIC_LIST);
            Controls.Add(button1);
            Controls.Add(txt_CLINIC_NAME);
            Controls.Add(labeCLINIC_CONROE);
            Name = "frmCLINIC_LIST";
            Text = "frmCLINIC_LIST";
            ((System.ComponentModel.ISupportInitialize)gridControl1CLINIC_LIST).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labeCLINIC_CONROE;
        private Button button1;
        private TextBox txt_CLINIC_NAME;
        private DevExpress.XtraGrid.GridControl gridControl1CLINIC_LIST;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}