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
    public partial class frmCLINIC_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frmCLINIC_LIST()
        {
            InitializeComponent();
            CLINICLIST();
        }

        classes.clsCLINIC NclsClinic = new classes.clsCLINIC();

        public void CLINICLIST()
        {
            gridControl1CLINIC_LIST.DataSource = NclsClinic.CLINIC_LIST();
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_NOTE"]);
            gridView1.Columns["CLI_NAME"].Caption = "Клиники Имя";
            gridView1.Columns["CLI_CODE"].Caption = "Kлиники Код";
            gridView1.Columns["CLI_LOC"].Caption = "Клиники Адрес";
        }

        private void gridControl1DOCTORS_Click(object sender, EventArgs e)
        {

        }

        private void labeCLINIC_CONROE_Click(object sender, EventArgs e)
        {

        }

        private void txt_CLINIC_NAME_TextChanged(object sender, EventArgs e)
        {
            gridControl1CLINIC_LIST.DataSource = NclsClinic.CLINIC_LIST();

            if (gridView1.RowCount > 0 && txt_CLINIC_NAME.Text != "")
            {
                gridControl1CLINIC_LIST.DataSource = classes.clsCLINIC.CLINIC_DT.GETCLINICBY_NAME(txt_CLINIC_NAME.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_CLINIC_NAME.Text = "";
        }
    }
}