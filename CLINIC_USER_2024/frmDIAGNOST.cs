using CLINIC_USER_2024.classes;
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
    public partial class frmDIAGNOST : DevExpress.XtraEditors.XtraForm
    {
        public frmDIAGNOST()
        {
            InitializeComponent();
            CLEARDATA_DIG();
        }


        classes.clsDIAGNOIS NclsDiganois = new classes.clsDIAGNOIS();
        public void CLEARDATA_DIG()
        {
            gridControl_DIGANOC.DataSource = classes.clsDIAGNOIS.DIAGNOIS_LIST();
            gridView1.Columns.Remove(gridView1.Columns["DIG_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["DIG_NAME"].Caption = "Имя Диагнос";
            gridView1.Columns["DIG_TYPE"].Caption = "Тип Диагнос";
            gridView1.Columns["DIG_NOTE"].Caption = "Примечание";
            gridView1.Columns["DIG_CODE"].Caption = "Диагнос Код";
            gridView1.Columns["DOC_NAME"].Caption = "Достор Имя";
            txt_DIAGNO_NAME.Text = "";
            txt_DIAGNOTYPE.Text = "";
            txt_DIAGNO_NOTE.Text = "";
            txt_DocName.Text = "";
            txt_DIGNAL_CODE.Text = classes.clsDIAGNOIS.DIAGNOIS_TB.GETMAX_CODEDIG().Rows[0]["DIG_CODE"].ToString();

        }
        public void CLEARDATABOX()
        {
            if (txt_DocName.Text != "" && txt_DIGNAL_CODE.Text != "")
            {

                txt_DIGNAL_CODE.Text = "";
                txt_DIAGNO_NAME.Text = "";
                txt_DIAGNOTYPE.Text = "";
                txt_DIAGNO_NOTE.Text = "";
                txt_DocName.Text = "";
                txt_DIGNAL_CODE.Text = classes.clsDIAGNOIS.DIAGNOIS_TB.GETMAX_CODEDIG().Rows[0]["DIG_CODE"].ToString();

            }
        }
        private void gridControl_SERVICE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                clsDIAGNOIS.FINDDIGANOC(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DIG_NAME"]).ToString());
                txt_DIGNAL_CODE.Text = clsDIAGNOIS.DIG_CODE.ToString();
                txt_DIAGNO_NAME.Text = clsDIAGNOIS.DIG_NAME.ToString();
                txt_DIAGNOTYPE.Text = clsDIAGNOIS.DIG_TYPE;
                txt_DIAGNO_NOTE.Text = clsDIAGNOIS.DIG_NOTE;
                txt_DocName.Text = clsDIAGNOIS.DOC_NAME;
            }
        }

        private void frmDIAGNOST_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2COMPANY_Enter(object sender, EventArgs e)
        {


        }

        private void frmDIAGNOST_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txt_DIGNAL_CODE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {

            if (txt_DocName.Text != " " && txt_DIGNAL_CODE.Text != " ")
            {
                classes.clsDIAGNOIS.DIAGNOIS_TB.DELETE_DIAGNOS(Convert.ToInt64(classes.clsDIAGNOIS.DIG_ID));

                CLEARDATA_DIG();
            }
            else
            {
                CLEARDATA_DIG();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_DocName.Text != "" && txt_DIGNAL_CODE.Text != "")
            {
                classes.clsDIAGNOIS.DIAGNOIS_TB.INSERT_DIAGNOS(Convert.ToInt64(txt_DIGNAL_CODE.Text), txt_DIAGNO_NAME.Text.ToString(), txt_DIAGNOTYPE.Text, txt_DIAGNO_NOTE.Text, 4, txt_DocName.Text);

                CLEARDATA_DIG();

            }
            else
            {
                CLEARDATABOX();
                CLEARDATA_DIG();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_DocName.Text != "" && txt_DIGNAL_CODE.Text != "")
            {
                classes.clsDIAGNOIS.DIAGNOIS_TB.UPDATE_DIAGNOS(Convert.ToInt64(txt_DIGNAL_CODE.Text), txt_DIAGNO_NAME.Text, txt_DIAGNOTYPE.Text, txt_DIAGNO_NOTE.Text, classes.clsDIAGNOIS.CLI_ID, txt_DocName.Text, classes.clsDIAGNOIS.DIG_ID, classes.clsDIAGNOIS.DIG_ID);
                CLEARDATA_DIG();
            }
            else
            {
                CLEARDATA_DIG();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            CLEARDATA_DIG();
        }
    }
}