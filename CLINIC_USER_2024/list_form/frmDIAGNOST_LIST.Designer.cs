namespace CLINIC_USER_2024.list_form
{
    partial class frmDIAGNOST_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDIAGNOST_LIST));
            txt_SER_NAME = new TextBox();
            labeCLINIC_CONROE = new DevExpress.XtraEditors.LabelControl();
            gridControl1SER_LIST = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridControl1SER_LIST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_SER_NAME
            // 
            txt_SER_NAME.Location = new Point(260, 71);
            txt_SER_NAME.Name = "txt_SER_NAME";
            txt_SER_NAME.Size = new Size(432, 27);
            txt_SER_NAME.TabIndex = 13;
            // 
            // labeCLINIC_CONROE
            // 
            labeCLINIC_CONROE.Appearance.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeCLINIC_CONROE.Appearance.ForeColor = Color.LightSeaGreen;
            labeCLINIC_CONROE.Appearance.Options.UseFont = true;
            labeCLINIC_CONROE.Appearance.Options.UseForeColor = true;
            labeCLINIC_CONROE.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labeCLINIC_CONROE.Location = new Point(336, 0);
            labeCLINIC_CONROE.Name = "labeCLINIC_CONROE";
            labeCLINIC_CONROE.Size = new Size(280, 40);
            labeCLINIC_CONROE.TabIndex = 12;
            labeCLINIC_CONROE.Text = "  Список (Диагноз)\r\n";
            // 
            // gridControl1SER_LIST
            // 
            gridControl1SER_LIST.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1SER_LIST.Location = new Point(40, 136);
            gridControl1SER_LIST.MainView = gridView1;
            gridControl1SER_LIST.Name = "gridControl1SER_LIST";
            gridControl1SER_LIST.Size = new Size(872, 440);
            gridControl1SER_LIST.TabIndex = 11;
            gridControl1SER_LIST.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1SER_LIST;
            gridView1.Name = "gridView1";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(184, 64);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 58;
            button2.UseVisualStyleBackColor = true;
            // 
            // frmDIAGNOST_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 607);
            Controls.Add(button2);
            Controls.Add(txt_SER_NAME);
            Controls.Add(labeCLINIC_CONROE);
            Controls.Add(gridControl1SER_LIST);
            Name = "frmDIAGNOST_LIST";
            Text = "frmDIAGNOST_LIST";
            ((System.ComponentModel.ISupportInitialize)gridControl1SER_LIST).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_SER_NAME;
        private DevExpress.XtraEditors.LabelControl labeCLINIC_CONROE;
        private DevExpress.XtraGrid.GridControl gridControl1SER_LIST;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button button2;
    }
}