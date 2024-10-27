using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_USER_2024.list_form
{
    public partial class frmDOCTORS_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frmDOCTORS_LIST()
        {
            InitializeComponent();
            GRIDDOCTORS_LIST();
        }

        classes.clsDOCTORS NclsDOC = new classes.clsDOCTORS();

        public void GRIDDOCTORS_LIST()
        {

            gridControl1DOCTORS.DataSource = classes.clsDOCTORS.DOCTOR_DT.DOCLIST_BY_DOC_NAME(textDOCTORS_NAME.Text);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_CODE"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_DB"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_MOBILE"]);
            gridView1.Columns["DOC_NAME"].Caption = "Имя";
            gridView1.Columns["DOC_MAJOR"].Caption = "Специальность";
            gridView1.Columns["DOC_EXP"].Caption = "Опыт";


        }

        private void gridControl1DOCTORS_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NclsDOC.DOCLIST_BY_DOC_NAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DOC_NAME"]).ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDOCTORS_NAME.Text = "";
        }

        private void textDOCTORS_NAME_TextChanged(object sender, EventArgs e)
        {
            if (textDOCTORS_NAME.Text != "")
            {
                GRIDDOCTORS_LIST();
            }
            GRIDDOCTORS_LIST();

        }

        private void gridControl1DOCTORS_Click(object sender, EventArgs e)
        {

        }

        private void frmDOCTORS_LIST_Load(object sender, EventArgs e)
        {

        }
    }
}