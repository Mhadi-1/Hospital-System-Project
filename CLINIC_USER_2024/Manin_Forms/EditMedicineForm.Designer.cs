namespace PatientAidApp
{
    partial class EditMedicineForm
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
            timeToTakeTimePicker = new DateTimePicker();
            quantityNumericUpDown = new NumericUpDown();
            label4 = new Label();
            editMedicineButton = new Button();
            label3 = new Label();
            medicineNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // timeToTakeTimePicker
            // 
            timeToTakeTimePicker.CustomFormat = "HH:mm";
            timeToTakeTimePicker.Format = DateTimePickerFormat.Custom;
            timeToTakeTimePicker.Location = new Point(475, 667);
            timeToTakeTimePicker.Margin = new Padding(5, 6, 5, 6);
            timeToTakeTimePicker.Name = "timeToTakeTimePicker";
            timeToTakeTimePicker.Size = new Size(214, 31);
            timeToTakeTimePicker.TabIndex = 34;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(525, 475);
            quantityNumericUpDown.Margin = new Padding(5, 6, 5, 6);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            quantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(117, 31);
            quantityNumericUpDown.TabIndex = 33;
            quantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(473, 571);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 38);
            label4.TabIndex = 32;
            label4.Text = "Time to take:";
            // 
            // editMedicineButton
            // 
            editMedicineButton.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editMedicineButton.Location = new Point(483, 783);
            editMedicineButton.Margin = new Padding(5, 6, 5, 6);
            editMedicineButton.Name = "editMedicineButton";
            editMedicineButton.Size = new Size(200, 54);
            editMedicineButton.TabIndex = 31;
            editMedicineButton.Text = "Edit";
            editMedicineButton.UseVisualStyleBackColor = true;
            editMedicineButton.Click += EditMedicineButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(503, 379);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 38);
            label3.TabIndex = 30;
            label3.Text = "Quantity:";
            // 
            // medicineNameTextBox
            // 
            medicineNameTextBox.Location = new Point(420, 283);
            medicineNameTextBox.Margin = new Padding(5, 6, 5, 6);
            medicineNameTextBox.Name = "medicineNameTextBox";
            medicineNameTextBox.Size = new Size(322, 31);
            medicineNameTextBox.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Old English Text MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(458, 187);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 38);
            label2.TabIndex = 28;
            label2.Text = "Medicine name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(423, 42);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 53);
            label1.TabIndex = 27;
            label1.Text = "Edit Medicine";
            // 
            // EditMedicineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1140, 887);
            Controls.Add(timeToTakeTimePicker);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(label4);
            Controls.Add(editMedicineButton);
            Controls.Add(label3);
            Controls.Add(medicineNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "EditMedicineForm";
            Text = "Patient aid app";
            FormClosing += EditMedicineForm_FormClosing;
            Load += EditMedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker timeToTakeTimePicker;
        private NumericUpDown quantityNumericUpDown;
        private Label label4;
        private Button editMedicineButton;
        private Label label3;
        private TextBox medicineNameTextBox;
        private Label label2;
        private Label label1;
    }
}