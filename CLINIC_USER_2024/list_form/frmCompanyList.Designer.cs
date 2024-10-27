namespace CLINIC_USER_2024.list_form
{
    partial class frmCompanyList
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            button1 = new Button();
            textCOM_NAME = new TextBox();
            gridControl1COMpanyList = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridControl1COMpanyList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(304, 16);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(320, 34);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "           Список компании";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.x_button;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(120, 76);
            button1.Name = "button1";
            button1.Size = new Size(152, 35);
            button1.TabIndex = 5;
            button1.Text = "Прозрачный";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textCOM_NAME
            // 
            textCOM_NAME.Location = new Point(288, 80);
            textCOM_NAME.Name = "textCOM_NAME";
            textCOM_NAME.Size = new Size(416, 27);
            textCOM_NAME.TabIndex = 4;
            textCOM_NAME.TextChanged += textCOM_NAME_TextChanged;
            // 
            // gridControl1COMpanyList
            // 
            gridControl1COMpanyList.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1COMpanyList.Location = new Point(56, 136);
            gridControl1COMpanyList.MainView = gridView1;
            gridControl1COMpanyList.Name = "gridControl1COMpanyList";
            gridControl1COMpanyList.Size = new Size(856, 440);
            gridControl1COMpanyList.TabIndex = 6;
            gridControl1COMpanyList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1COMpanyList.Click += gridControl1COMpanyList_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1COMpanyList;
            gridView1.Name = "gridView1";
            // 
            // frmCompanyList
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 632);
            Controls.Add(gridControl1COMpanyList);
            Controls.Add(button1);
            Controls.Add(textCOM_NAME);
            Controls.Add(labelControl1);
            Name = "frmCompanyList";
            Text = "frmCompanyList";
            ((System.ComponentModel.ISupportInitialize)gridControl1COMpanyList).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Button button1;
        private TextBox textCOM_NAME;
        private DevExpress.XtraGrid.GridControl gridControl1COMpanyList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}