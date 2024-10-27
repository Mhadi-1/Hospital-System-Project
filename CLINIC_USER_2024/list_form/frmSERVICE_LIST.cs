using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frmSERVICE_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frmSERVICE_LIST()
        {
            InitializeComponent();
            CLEAR_SERVICEDATA();
        }
        classes.clsSERVICE NclsServiceList = new classes.clsSERVICE();

        public void CLEAR_SERVICEDATA()
        {

            gridControl1SER_LIST.DataSource = NclsServiceList.FINDSER_BYNAME(txt_SER_NAME.Text);
            gridView1.Columns.Remove(gridView1.Columns["SER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_CODE"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_NOTE"]);
            gridView1.Columns["SER_NAME"].Caption = "Имя";
            gridView1.Columns["SER_TYPE"].Caption = "Тип";
            gridView1.Columns["SER_PRICE"].Caption = "Цена";


        }

        private void frmSERVICE_LIST_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1SER_LIST_Click(object sender, EventArgs e)
        {

        }

        private void txt_SER_NAME_TextChanged(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_SER_NAME.Text != "")
            {
                CLEAR_SERVICEDATA();
            }
            else
            {
                CLEAR_SERVICEDATA();
            }
        }

        private void gridControl1SER_LIST_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NclsServiceList.FINDSER_BYNAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["SER_NAME"]).ToString());
            }
        }

        private void frmSERVICE_LIST_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_SER_NAME.Text = "";
            CLEAR_SERVICEDATA();
        }
    }
}