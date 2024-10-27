using CLINIC_USER_2024.classes;
using CLINIC_USER_2024.list_form;
using DevExpress.Charts.Native;
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
    public partial class frmCLINIC : DevExpress.XtraEditors.XtraForm
    {

        classes.clsCLINIC NclsCLINIC = new classes.clsCLINIC();
        classes.clsUsers NclsUser = new classes.clsUsers();

        public frmCLINIC()
        {
            InitializeComponent();
            CLEARDATA_CLI();
            GetUsersCMBOX();
        }

        public void GetUsersCMBOX()
        {
            cmb_USER_I.DataSource = NclsUser.User_List(); ;
            cmb_USER_I.ValueMember = "USER_ID";
            cmb_USER_NAME.DataSource = cmb_USER_I.DataSource;
            cmb_USER_NAME.ValueMember = "USER_NAME";

            cmb_USER_I.Text = classes.clsUsers.USER_ID.ToString();
            cmb_USER_NAME.Text = classes.clsUsers.USER_NAME;
        }

        public void CLEARDATA_CLI()
        {
            gridControl1.DataSource = NclsCLINIC.CLINIC_LIST();
            if (gridView1.RowCount > 0)
            {

                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLI_NOTE"]);
                gridView1.Columns["CLI_NAME"].Caption = "Клиники Имя";
                gridView1.Columns["CLI_CODE"].Caption = "Kлиники Код";
                gridView1.Columns["CLI_LOC"].Caption = "Клиники Адрес";
                txt_CLINIC_CODE.Text = classes.clsCLINIC.CLINIC_DT.GETMAX_CLINIC_CODE().Rows[0]["CLI_CODE"].ToString();

                text__CLINIC_NAME.Text = "";
                txt_CLINIC_ADDRESS.Text = "";
                txt_CLINIC_NOTES.Text = "";


            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_CLINIC_CODE.Text != "" && text__CLINIC_NAME.Text != "")
            {
                classes.clsCLINIC.CLINIC_DT.UpdateCLINIC(Convert.ToInt64(txt_CLINIC_CODE.Text), txt_CLINIC_ADDRESS.Text, txt_CLINIC_NOTES.Text, text__CLINIC_NAME.Text, classes.clsCLINIC.CLI_ID, classes.clsCLINIC.CLI_ID);
                CLEARDATA_CLI();
            }
            else
            {
                CLEARDATA_CLI();
            }
        }

        private void txt_CLINIC_CODE_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void text__CLINIC_NAME_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_CLINIC_ADDRESS_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_CLINIC_NOTES_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtlblCLINIC_Click(object sender, EventArgs e)
        {

        }

        private void lbltxt_CLINIC_NAME_Click(object sender, EventArgs e)
        {

        }

        private void lbltxt_CLINIC_ADDRESS_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CLINIC_NOTES_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUSERLIST frmUSERS_LIST = new frmUSERLIST();
            frmUSERS_LIST.ShowDialog();
        }

        private void cmb_USER_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_USER_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_CLINIC_CODE.Text != "" && text__CLINIC_NAME.Text != "")
            {
                classes.clsCLINIC.CLINIC_DT.INSEARTNEWCLINIC(Convert.ToInt32(txt_CLINIC_CODE.Text), txt_CLINIC_ADDRESS.Text, txt_CLINIC_NOTES.Text, text__CLINIC_NAME.Text);
                CLEARDATA_CLI();
            }
            else
            {
                CLEARDATA_CLI();
            }
        }

        private void frmCLINIC_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            CLEARDATA_CLI();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                NclsCLINIC.SELECTCLINAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["CLI_NAME"]).ToString());

                txt_CLINIC_CODE.Text = classes.clsCLINIC.CLI_CODE.ToString();
                txt_CLINIC_ADDRESS.Text = classes.clsCLINIC.CLI_LOC.ToString();
                txt_CLINIC_NOTES.Text = classes.clsCLINIC.CLI_NOTE;
                text__CLINIC_NAME.Text = classes.clsCLINIC.CLI_NAME;
            }
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if (txt_CLINIC_CODE.Text != "" && text__CLINIC_NAME.Text != "")
            {
                classes.clsCLINIC.CLINIC_DT.DeleteCLINIC(Convert.ToUInt64(classes.clsCLINIC.CLI_ID));
                CLEARDATA_CLI();
            }
            else
            {
                CLEARDATA_CLI();
            }
        }
    }
}