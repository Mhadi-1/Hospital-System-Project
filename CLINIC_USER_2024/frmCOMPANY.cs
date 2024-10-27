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
    public partial class frmCOMPANY : DevExpress.XtraEditors.XtraForm
    {
        classes.clsCOMPANY NclsCompany = new classes.clsCOMPANY();

        public frmCOMPANY()
        {
            InitializeComponent();

        }
        void COMPANY_LIST()
        {
            gridControl_SERVICE.DataSource = NclsCompany.COMAPANY_LIST();
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["COM_CODE"].Caption = "Компании Код";
            gridView1.Columns["COM_NAME"].Caption = "Компании Имя";
            gridView1.Columns["COM_ADDRESS"].Caption = "Компании Адрес";
            gridView1.Columns["COM_MOBILE"].Caption = "Компании Номер";
            gridView1.Columns["COM_STATE"].Caption = "Статус";
            cmb_COM_STATE.Text = classes.clsCOMPANY.COM_STATE;
            txt_COM_CODE.Text = "";
            txt_COM_CODE.Text = classes.clsCOMPANY.COMPANY_DT.GeMAXCODE_COMAPNY().Rows[0]["COM_CODE"].ToString();
            txt_COM_NAME.Text = "";
            text_COM_ADDRESS.Text = "";
            text_COM_NUMBER.Text = "";


        }

        private void cmb_COM_STATE_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmCOMPANY_Load(object sender, EventArgs e)
        {
            COMPANY_LIST();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            COMPANY_LIST();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_COM_CODE.Text != "" && txt_COM_NAME.Text != "")
            {
                classes.clsCOMPANY.COMPANY_DT.InsertCOMPANY(Convert.ToUInt64(txt_COM_CODE.Text), txt_COM_NAME.Text, text_COM_ADDRESS.Text, text_COM_NUMBER.Text, cmb_COM_STATE.Text, Convert.ToUInt64(classes.clsCOMPANY.CLI_ID));
                COMPANY_LIST();
            }
            else
            {
                COMPANY_LIST();
            }
        }

        private void gridControl_COMPANY_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NclsCompany.GETCOMPANY_BY_NAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["COM_NAME"]).ToString());

                cmb_COM_STATE.Text = classes.clsCOMPANY.COM_STATE;
                txt_COM_CODE.Text = classes.clsCOMPANY.COM_CODE.ToString();
                txt_COM_NAME.Text = classes.clsCOMPANY.COM_NAME.ToString();
                text_COM_ADDRESS.Text = classes.clsCOMPANY.COM_ADDERSS.ToString(); ;
                text_COM_NUMBER.Text = classes.clsCOMPANY.COM_MOBILE.ToString();
            }
        }

        private void txt_COM_NAME_EditValueChanged(object sender, EventArgs e)
        {
            //if (gridView1.RowCount > 0 && txt_COM_NAME.Text != "")
            //{
            //    gridControl_COMPANY.DataSource = classes.clsCOMPANY.COMPANY_DT.GetCOMPANY_BY_NAME(txt_COM_NAME.Text);
            //}
            //else
            //{
            //    COMPANY_LIST();
            //}
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_COM_NAME.Text != "")
            {
                classes.clsCOMPANY.COMPANY_DT.UpdateCOMPANY(Convert.ToUInt64(txt_COM_CODE.Text), txt_COM_NAME.Text, text_COM_ADDRESS.Text, text_COM_NUMBER.Text, cmb_COM_STATE.Text, Convert.ToUInt64(classes.clsCOMPANY.CLI_ID), Convert.ToUInt64(classes.clsCOMPANY.COM_ID), Convert.ToUInt64(classes.clsCOMPANY.COM_ID));
                COMPANY_LIST();
            }
            else
            {
                COMPANY_LIST();
            }
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_COM_NAME.Text != "" && txt_COM_CODE.Text != "")
            {
                classes.clsCOMPANY.COMPANY_DT.DeleteCOMAPNY(classes.clsCOMPANY.COM_ID);
                COMPANY_LIST();
            }
            else
            {
                COMPANY_LIST();
            }
        }

        private void groupBox2COMPANY_Enter(object sender, EventArgs e)
        {

        }

        private void gridControl_SERVICE_Click(object sender, EventArgs e)
        {

        }
    }
}