namespace CLINIC_USER_2024.list_form
{
    partial class frmDOCTORS_LIST
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
            textDOCTORS_NAME = new TextBox();
            label1 = new Label();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            button1 = new Button();
            gridControl1DOCTORS = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)gridControl1DOCTORS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // textDOCTORS_NAME
            // 
            textDOCTORS_NAME.Location = new Point(280, 72);
            textDOCTORS_NAME.Name = "textDOCTORS_NAME";
            textDOCTORS_NAME.Size = new Size(416, 27);
            textDOCTORS_NAME.TabIndex = 0;
            textDOCTORS_NAME.TextChanged += textDOCTORS_NAME_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Constantia", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.LightSeaGreen;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(328, 8);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(288, 34);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "           Список врачей";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.x_button;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(112, 68);
            button1.Name = "button1";
            button1.Size = new Size(152, 35);
            button1.TabIndex = 3;
            button1.Text = "Прозрачный";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gridControl1DOCTORS
            // 
            gridControl1DOCTORS.Font = new Font("Constantia", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gridControl1DOCTORS.Location = new Point(48, 128);
            gridControl1DOCTORS.MainView = gridView1;
            gridControl1DOCTORS.Name = "gridControl1DOCTORS";
            gridControl1DOCTORS.Size = new Size(856, 440);
            gridControl1DOCTORS.TabIndex = 4;
            gridControl1DOCTORS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1DOCTORS.Click += gridControl1DOCTORS_Click;
            gridControl1DOCTORS.DoubleClick += gridControl1DOCTORS_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1DOCTORS;
            gridView1.Name = "gridView1";
            // 
            // frmDOCTORS_LIST
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 619);
            Controls.Add(gridControl1DOCTORS);
            Controls.Add(button1);
            Controls.Add(labelControl1);
            Controls.Add(label1);
            Controls.Add(textDOCTORS_NAME);
            Name = "frmDOCTORS_LIST";
            Tag = "";
            Text = "frmDOCTORS_LIST";
            Load += frmDOCTORS_LIST_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1DOCTORS).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDOCTORS_NAME;
        private Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1DOCTORS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}