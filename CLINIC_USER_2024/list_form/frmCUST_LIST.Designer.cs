namespace CLINIC_USER_2024.list_form
{
    partial class frmCUST_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCUST_LIST));
            btn_CLEARTEXT = new Button();
            txt_SER_NAME = new TextBox();
            labeCLINIC_CONROE = new DevExpress.XtraEditors.LabelControl();
            gridContro_CUST_List = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridContro_CUST_List).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_CLEARTEXT
            // 
            btn_CLEARTEXT.Image = (Image)resources.GetObject("btn_CLEARTEXT.Image");
            btn_CLEARTEXT.Location = new Point(264, 89);
            btn_CLEARTEXT.Name = "btn_CLEARTEXT";
            btn_CLEARTEXT.Size = new Size(56, 40);
            btn_CLEARTEXT.TabIndex = 14;
            btn_CLEARTEXT.TextAlign = ContentAlignment.MiddleLeft;
            btn_CLEARTEXT.UseVisualStyleBackColor = true;
            // 
            // txt_SER_NAME
            // 
            txt_SER_NAME.Location = new Point(336, 96);
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
            labeCLINIC_CONROE.Location = new Point(368, 8);
            labeCLINIC_CONROE.Name = "labeCLINIC_CONROE";
            labeCLINIC_CONROE.Size = new Size(280, 40);
            labeCLINIC_CONROE.TabIndex = 12;
            labeCLINIC_CONROE.Text = "  Список (Пациенты)\r\n";
            // 
            // gridContro_CUST_List
            // 
            gridContro_CUST_List.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridContro_CUST_List.Location = new Point(48, 152);
            gridContro_CUST_List.MainView = gridView1;
            gridContro_CUST_List.Name = "gridContro_CUST_List";
            gridContro_CUST_List.Size = new Size(872, 467);
            gridContro_CUST_List.TabIndex = 11;
            gridContro_CUST_List.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridContro_CUST_List;
            gridView1.Name = "gridView1";
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(168, 85);
            button3.Name = "button3";
            button3.Size = new Size(80, 48);
            button3.TabIndex = 59;
            button3.UseVisualStyleBackColor = true;
            // 
            // frmCUST_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 660);
            Controls.Add(button3);
            Controls.Add(btn_CLEARTEXT);
            Controls.Add(txt_SER_NAME);
            Controls.Add(labeCLINIC_CONROE);
            Controls.Add(gridContro_CUST_List);
            Name = "frmCUST_LIST";
            Text = "frmCUST_LIST";
            Load += frmCUST_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)gridContro_CUST_List).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CLEARTEXT;
        private TextBox txt_SER_NAME;
        private DevExpress.XtraEditors.LabelControl labeCLINIC_CONROE;
        private DevExpress.XtraGrid.GridControl gridContro_CUST_List;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button button3;
    }
}