using CLINIC_USER_2024.classes;
using CLINIC_USER_2024.list_form;
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

namespace CLINIC_USER_2024
{
    public partial class frmSERVICE : DevExpress.XtraEditors.XtraForm
    {
        classes.clsSERVICE NclsService = new classes.clsSERVICE();

        public frmSERVICE()
        {
            InitializeComponent();
            CLEARDATASERVICE();
        }

        public void CLEARDATASERVICE()
        {
            gridControl_SERVICE.DataSource = NclsService.SERVICE_LIST();
            gridView1.Columns.Remove(gridView1.Columns["SER_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["SER_NOTE"]);
            gridView1.Columns["SER_TYPE"].Caption = "Тип";
            gridView1.Columns["SER_NAME"].Caption = "Имя";
            gridView1.Columns["SER_CODE"].Caption = "Код";
            gridView1.Columns["SER_PRICE"].Caption = "Цена";

            txt_SER_CODE.Text = "";
            txt_SER_CODE.Text = classes.clsSERVICE.SERVICE_DT.GETMAX_SER_CODE().ToString();
            txt_SER_NAME.Text = "";
            text_SER_TYPE.Text = "";
            text_SER_PRICE.Text = "";
            text_NOTES.Text = "";


        }

        public void FILLCOLUMS_DATA()
        {
            if (gridView1.RowCount > 0)
            {

                NclsService.FINDSER_BYNAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["SER_NAME"]).ToString());

                txt_SER_CODE.Text = classes.clsSERVICE.SER_CODE.ToString();
                txt_SER_NAME.Text = classes.clsSERVICE.SER_NAME;
                text_SER_TYPE.Text = classes.clsSERVICE.SER_TYPE;
                text_SER_PRICE.Text = classes.clsSERVICE.SER_PRICE.ToString();
                text_NOTES.Text = classes.clsSERVICE.SER_NOTE;
            }
            else
            {
                CLEARDATASERVICE();
            }

        }

        public bool DELETESERVICE(string SER_NAME, string SER_CODE)
        {
            NclsService.FINDSER_BYNAME(txt_SER_NAME.Text);

            if (txt_SER_NAME.Text != " " && txt_SER_CODE.Text != " ")
            {
                classes.clsSERVICE.SERVICE_DT.DELETESERVICE(Convert.ToUInt64(txt_SER_CODE.Text));
                return true;
            }

            return false;

        }


        private void frmSERVICE_Load(object sender, EventArgs e)
        {

            FILLCOLUMS_DATA();
        }

        private void lbltxt_CLINIC_NAME_Click(object sender, EventArgs e)
        {

        }

        private void labelCOMPANY_NAME_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SER_CODE.Text != "" && txt_SER_NAME.Text != "")
            {
                classes.clsSERVICE.SERVICE_DT.ADDSERVICETOTABLE(Convert.ToUInt64(txt_SER_CODE.Text), txt_SER_NAME.Text, text_SER_TYPE.Text, text_SER_PRICE.Text, text_NOTES.Text, classes.clsSERVICE.CLI_ID);
                CLEARDATASERVICE();
            }
            else
            {
                CLEARDATASERVICE();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_SER_CODE.Text != "" && txt_SER_NAME.Text != "")
            {
                classes.clsSERVICE.SERVICE_DT.UPDATESERVICE(Convert.ToUInt64(txt_SER_CODE.Text), txt_SER_NAME.Text, text_SER_TYPE.Text, text_SER_PRICE.Text, text_NOTES.Text, classes.clsSERVICE.CLI_ID, classes.clsSERVICE.SER_ID, clsSERVICE.SER_ID);
                CLEARDATASERVICE();
            }
            else
            {
                CLEARDATASERVICE();
            }
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if (DELETESERVICE(txt_SER_NAME.Text, txt_SER_CODE.Text))
            {
                CLEARDATASERVICE();
                ///MessageBox.Show("SERVICE DELETED SUCSSFULLY");
            }
            else
            {
                CLEARDATASERVICE();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            CLEARDATASERVICE();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSERVICE_LIST frmservice = new frmSERVICE_LIST();
            frmservice.ShowDialog();
       
            
        }
    }
}