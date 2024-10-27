using System;
using System.Windows.Forms;

namespace PatientAidApp
{
    public partial class AddMedicineForm : Form
    {
        private readonly DatabaseManager databaseManager;
        private readonly string patientUsername;
        private readonly MedicinesForm medicinesForm;
        public AddMedicineForm(DatabaseManager databaseManager, string patientUsername, MedicinesForm medicinesForm)
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
            this.patientUsername = patientUsername;
            this.medicinesForm = medicinesForm;
        }

        private void AddMedicineButton_Click(object sender, EventArgs e)
        {
            string medicineName = this.medicineNameTextBox.Text;
            int quantity = (int)this.quantityNumericUpDown.Value;
            var timeToTake = this.timeToTakeTimePicker.Value.TimeOfDay;
            if (string.IsNullOrEmpty(medicineName))
            {
                MessageBox.Show("The medicine name field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = this.databaseManager.AddMedicine(medicineName, quantity, timeToTake, this.patientUsername);
            if (result)
            {
                MessageBox.Show("The medicine has been added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.medicinesForm.FillTheMedicinesDataGridView();
            }
        }

        private void AddMedicineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void medicineNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
