using System;
using System.Windows.Forms;

namespace PatientAidApp
{
    public partial class EditMedicineForm : Form
    {
        private readonly DatabaseManager databaseManager;
        private readonly string patientUsername, medicineName;
        private readonly MedicinesForm medicinesForm;
        private int medicineID, quantity;
        private TimeSpan timeToTake;
        public EditMedicineForm(DatabaseManager databaseManager, string patientUsername, MedicinesForm medicinesForm, int medicineID, string medicineName, int quantity, TimeSpan timeToTake)
        {
            InitializeComponent();
            this.databaseManager = databaseManager;
            this.patientUsername = patientUsername;
            this.medicinesForm = medicinesForm;
            this.medicineID = medicineID;
            this.medicineName = medicineName;
            this.quantity = quantity;
            this.timeToTake = timeToTake;
        }

        private void EditMedicineForm_Load(object sender, EventArgs e)
        {
            this.medicineNameTextBox.Text = this.medicineName;
            this.quantityNumericUpDown.Value = this.quantity;
            this.timeToTakeTimePicker.Value = DateTime.Today.Add(this.timeToTake);
        }

        private void EditMedicineButton_Click(object sender, EventArgs e)
        {
            string medicineName = this.medicineNameTextBox.Text;
            int quantity = (int)this.quantityNumericUpDown.Value;
            var timeToTake = this.timeToTakeTimePicker.Value.TimeOfDay;
            if (this.medicineName == medicineName && this.quantity == quantity && TimeSpan.Compare(this.timeToTake, timeToTake) == 0)
            {
                MessageBox.Show("You have not edited any information about the selected medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(medicineName))
            {
                MessageBox.Show("The medicine name field should not be left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = this.databaseManager.EditMedicine(this.medicineID, medicineName, quantity, timeToTake);
            if (result)
            {
                MessageBox.Show("The medicine has been edited successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.medicinesForm.FillTheMedicinesDataGridView();
            }
        }

        private void EditMedicineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
