using DevExpress.Charts.Native;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors.Helpers;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraMap;
using DevExpress.XtraPivotGrid.FilterDropDown;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;
using System.Data.SqlClient;
using CLINIC_USER_2024.classes;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraLayout.Filtering.Templates;
using CLINIC_USER_2024.list_form;

namespace CLINIC_USER_2024
{
    public partial class frmAPOINTMENT : DevExpress.XtraEditors.XtraForm
    {
        public frmAPOINTMENT()
        {
            InitializeComponent();
        }

        classes.clsAPO nclsApoi = new classes.clsAPO();
        classes.clsCUST nclsCUST = new classes.clsCUST();
        classes.clsDOCTORS mclsDOC = new classes.clsDOCTORS();



        public void ClearData()
        {


            gridControl_APO.DataSource = nclsApoi.APO_LIST();
            gridView1.Columns.Remove(gridView1.Columns["APO_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["APO_NAME"]);
            gridView1.Columns.Remove(gridView1.Columns["CUST_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["APO_NOTE"]);
            gridView1.Columns["APO_CODE"].Caption = "код встречи";
            gridView1.Columns["APO_DATE"].Caption = "назначенная встречи";
            gridView1.Columns["APO_TIME"].Caption = "время встречи";
            DataTable dt = new DataTable();
            dt = mclsDOC.DOCTORS_LIST();
            cmbDOC_ID.DataSource = dt;
            cmbDOC_ID.ValueMember = "DOC_ID";
            comb_DOC_NAME.DataSource = dt;
            comb_DOC_NAME.ValueMember = "DOC_NAME";

            cmd_cust_ID.DataSource = nclsApoi.APO_LIST();
            cmd_cust_ID.ValueMember = "CUST_ID";
            cmd_cust_name.DataSource = classes.clsUsers.USER_DT.GetData();

            cmd_cust_name.ValueMember = "USER_NAME";




        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {
            frmDOCTORS_LIST DOC_LIS = new frmDOCTORS_LIST();
            DOC_LIS.ShowDialog();
            cmbDOC_ID.Text = classes.clsDOCTORS.DOC_ID.ToString();
        }

        private void frmAPOINTMENT_Load(object sender, EventArgs e)
        {
            ClearData();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl_APO_Click(object sender, EventArgs e)
        {

        }

        private void gridControl_APO_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl_APO_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}