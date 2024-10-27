using System;
using System.Windows.Forms;
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;
using System.Data.SqlClient;
using CLINIC_USER_2024.classes;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.CodeParser;

namespace PatientAidApp
{
    public partial class MedicinesForm : Form
    {
        CLINIC_USER_2024.classes.clsMEDICIN NMclass = new clsMEDICIN();

        public MedicinesForm()
        {
            InitializeComponent();
          
        }

        public void FillTheMedicinesDataGridView()
        {
            DataTable dataTable = NMclass.MEDCIN_LIST();
            if (dataTable.Rows.Count == 0)
            {
                dataTable.Rows.Add(0, "No medications have been added yet for this patient.", 0, new TimeSpan());
            }
            this.medicinesDataGridView.DataSource = dataTable;
            medicinesDataGridView.Columns.Remove(medicinesDataGridView.Columns["MED_ID"]);
            medicinesDataGridView.Columns.Remove(medicinesDataGridView.Columns["MED_S_NAME"]);
            medicinesDataGridView.Columns.Remove(medicinesDataGridView.Columns["MED_SOURES"]);
            medicinesDataGridView.Columns["MED_NAME"].HeaderText = "MEDCIN NAME";
            medicinesDataGridView.Columns["MED_PRICE"].HeaderText = "PRICCE";
            medicinesDataGridView.Columns["MED_CODE"].HeaderText = "CODE";
        }

        private void MedicinesForm_Load(object sender, EventArgs e)
        {
            this.FillTheMedicinesDataGridView();
        }

        private bool IsMedicineSelected()
        {
            return this.medicinesDataGridView.SelectedRows.Count > 0;
        }

        private void AddMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    //var addMedicineForm = new AddMedicineForm(this.databaseManager, this.patientUsername, this);
        //    //addMedicineForm.Show();
        }

        private void EditMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsMedicineSelected())
            {
                var selectedMedicine = this.medicinesDataGridView.SelectedRows[0];
                int medicineID = (int)selectedMedicine.Cells[0].Value;
                string medicineName = selectedMedicine.Cells[1].Value.ToString();
                int quantity = (int)selectedMedicine.Cells[2].Value;
                var timeToTake = (TimeSpan)selectedMedicine.Cells[3].Value;
               //var editMedicineForm = new EditMedicineForm(this.databaseManager, this.patientUsername, this, medicineID, medicineName, quantity, timeToTake);
               // editMedicineForm.Show();
            }
            else
            {
                MessageBox.Show("No medicine has been selected for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DeleteMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsMedicineSelected())
            {
                var selectedMedicine = this.medicinesDataGridView.SelectedRows[0];
                int medicineID = (int)selectedMedicine.Cells[0].Value;
              //  bool result = this.databaseManager.DeleteMedicine(medicineID);
               // if (result)
               // {
               //     MessageBox.Show("The medicine has been deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               //     this.FillTheMedicinesDataGridView();
               // }
            }
            else
            {
                MessageBox.Show("No medicine has been selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void MedicinesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  this.databaseManager.CloseConnection();
        }

        private void MedicinesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void medicinesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
