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
    public partial class frmUSERLIST : DevExpress.XtraEditors.XtraForm
    {

        classes.clsUsers NclsUser = new classes.clsUsers();

        public frmUSERLIST()
        {
            InitializeComponent();
            USER_GGRID_LIST();
        }

        public void USER_GGRID_LIST()
        {

            if(txtUsers.Text != "")
            {

            gridControl1.DataSource = classes.clsUsers.USER_DT.GET_USER_B_NAME(txtUsers.Text);
            gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["USER_CODE"]);
            gridView1.Columns["USER_NAME"].Caption = "Имя";
            gridView1.Columns["USER_PASSWORD"].Caption = "ПАРОЛЬ";
            gridView1.Columns["USER_TYPE"].Caption = "ТИП";

            }

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

            USER_GGRID_LIST();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsers.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                classes.clsUsers.Select_User(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["USER_NAME"]).ToString());
                this.Close();
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}