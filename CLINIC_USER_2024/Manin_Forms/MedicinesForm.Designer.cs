namespace PatientAidApp
{
    partial class MedicinesForm
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
            menuStrip = new MenuStrip();
            addMedicineToolStripMenuItem = new ToolStripMenuItem();
            editMedicineToolStripMenuItem = new ToolStripMenuItem();
            deleteMedicineToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            medicinesDataGridView = new DataGridView();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medicinesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { addMedicineToolStripMenuItem, editMedicineToolStripMenuItem, deleteMedicineToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1307, 50);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // addMedicineToolStripMenuItem
            // 
            addMedicineToolStripMenuItem.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            addMedicineToolStripMenuItem.Size = new Size(212, 42);
            addMedicineToolStripMenuItem.Text = "Add medicine";
            addMedicineToolStripMenuItem.Click += AddMedicineToolStripMenuItem_Click;
            // 
            // editMedicineToolStripMenuItem
            // 
            editMedicineToolStripMenuItem.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            editMedicineToolStripMenuItem.Name = "editMedicineToolStripMenuItem";
            editMedicineToolStripMenuItem.Size = new Size(218, 42);
            editMedicineToolStripMenuItem.Text = "Edit medicine";
            editMedicineToolStripMenuItem.Click += EditMedicineToolStripMenuItem_Click;
            // 
            // deleteMedicineToolStripMenuItem
            // 
            deleteMedicineToolStripMenuItem.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            deleteMedicineToolStripMenuItem.Size = new Size(248, 42);
            deleteMedicineToolStripMenuItem.Text = "Delete medicine";
            deleteMedicineToolStripMenuItem.Click += DeleteMedicineToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(412, 96);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(454, 53);
            label1.TabIndex = 1;
            label1.Text = "The patient's medicines";
            // 
            // medicinesDataGridView
            // 
            medicinesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            medicinesDataGridView.BackgroundColor = Color.Cornsilk;
            medicinesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicinesDataGridView.Location = new Point(20, 167);
            medicinesDataGridView.Margin = new Padding(5, 6, 5, 6);
            medicinesDataGridView.Name = "medicinesDataGridView";
            medicinesDataGridView.RowHeadersWidth = 62;
            medicinesDataGridView.Size = new Size(1267, 696);
            medicinesDataGridView.TabIndex = 2;
            medicinesDataGridView.CellContentClick += medicinesDataGridView_CellContentClick;
            // 
            // MedicinesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1307, 887);
            Controls.Add(medicinesDataGridView);
            Controls.Add(label1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MedicinesForm";
            Text = "Patient aid app";
            FormClosing += MedicinesForm_FormClosing;
            FormClosed += MedicinesForm_FormClosed;
            Load += MedicinesForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medicinesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem addMedicineToolStripMenuItem;
        private ToolStripMenuItem editMedicineToolStripMenuItem;
        private ToolStripMenuItem deleteMedicineToolStripMenuItem;
        private Label label1;
        private DataGridView medicinesDataGridView;
    }
}