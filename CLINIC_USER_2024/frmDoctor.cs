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
using CLINIC_USER_2024.DataSet1TableAdapters;
using CLINIC_USER_2024.classes;
using CLINIC_USER_2024.list_form;

namespace CLINIC_USER_2024
{
    public partial class frmDoctor : DevExpress.XtraEditors.XtraForm
    {
        classes.clsDOCTORS NclDoctor = new classes.clsDOCTORS();
        classes.clsUsers NclUsers = new classes.clsUsers();

        public frmDoctor()
        {
            InitializeComponent();
            GetData_Doctors();
        }
        public void GetData_Doctors()
        {
            gridControl1.DataSource = NclDoctor.DOCTORS_LIST();
            if (gridView1.RowCount > 0)
            {
                gridView1.Columns.Remove(gridView1.Columns["DOC_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["USER_ID"]);
                gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
                gridView1.Columns["DOC_CODE"].Caption = "Код Номер";
                gridView1.Columns["DOC_NAME"].Caption = "Имя";
                gridView1.Columns["DOC_MAJOR"].Caption = "Специальность";
                gridView1.Columns["DOC_EXP"].Caption = "Опыт";
                gridView1.Columns["DOC_DB"].Caption = "Дата Рождиния";
                gridView1.Columns["DOC_MOBILE"].Caption = "Номер Телефон";
                gridView1.Columns["DOC_ADDRESS"].Caption = "Адрес";

            }


            cmb_USER_ID.DataSource = NclUsers.User_List(); ;
            cmb_USER_ID.ValueMember = "USER_ID";
            cmb_USER_NAME.DataSource = cmb_USER_ID.DataSource;
            cmb_USER_NAME.ValueMember = "USER_NAME";
            txt_DOC_CODE.Text = classes.clsDOCTORS.DOCTOR_DT.MAX_ORDER_DOC_CODE().Rows[0]["DOC_CODE"].ToString();
        }
        public void Inseart_DOCT_Data()
        {

            if (txt_DOC_CODE.Text != "" && txt_DOC_CODE.Text != "")
            {
                classes.clsDOCTORS.DOCTOR_DT.InsertDOCTOR(Convert.ToUInt16(txt_DOC_CODE.Text), txt_DOC_NAME.Text, txt_DOC_MAJOR.Text,
                txt_DOC_EXP.Text, Convert.ToDateTime(dTP_DOC.DateTime.ToString("yyy/MM/dd")), txt_DOC_NUMBER.Text, txt_DOC_ADDRESS.Text, 1);
                GetData_Doctors();

            }
            else
            {
                MessageBox.Show("Пожалуйста,введите правильные данные");
                GetData_Doctors();
            }
        }
        public void ClearDataFrom_Doct_cmb()
        {
            txt_DOC_NAME.Text = "";
            txt_DOC_MAJOR.Text = "";
            txt_DOC_EXP.Text = "";
            txt_DOC_ADDRESS.Text = "";
            txt_DOC_NUMBER.Text = "";
            dTP_DOC.Text = "";

        }
        public void Fill_DOC_Columns()
        {
            if (gridView1.RowCount > 0)
            {
                NclDoctor.DOCLIST_BY_DOC_NAME(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DOC_NAME"]).ToString());

                txt_DOC_CODE.Text = classes.clsDOCTORS.DOC_CODE.ToString();
                txt_DOC_NAME.Text = classes.clsDOCTORS.DOC_NAME;
                txt_DOC_MAJOR.Text = classes.clsDOCTORS.DOC_MAJOR;
                txt_DOC_EXP.Text = classes.clsDOCTORS.DOC_EXP;
                dTP_DOC.EditValue = DateTime.Now;
                txt_DOC_NUMBER.Text = classes.clsDOCTORS.DOC_MOBILE;
                txt_DOC_ADDRESS.Text = classes.clsDOCTORS.DOC_ADDRESS;
                cmb_USER_ID.Text = classes.clsDOCTORS.USER_ID.ToString();

            }
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textEdit22_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textEdit14_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit18_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit13_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit17_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit20_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit19_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit23_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void textEdit24_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {
        }

        private void labelControl12_Click(object sender, EventArgs e)
        {
        }

        private void labelControl10_Click(object sender, EventArgs e)
        {
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_DOC_NAME.Text != "" && txt_DOC_CODE.Text != "")
            {
                Inseart_DOCT_Data();
                ClearDataFrom_Doct_cmb();

            }
            else
            {
                MessageBox.Show("Пожалуйста,введите правильные данные");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearDataFrom_Doct_cmb();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Fill_DOC_Columns();

        }

        private void frmDoctor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_DOC_NAME.Text != "" && txt_DOC_CODE.Text != "")
            {
                classes.clsDOCTORS.DOCTOR_DT.Update_DOCTOR(Convert.ToInt16(txt_DOC_CODE.Text), txt_DOC_NAME.Text, txt_DOC_MAJOR.Text, txt_DOC_EXP.Text,
                     Convert.ToDateTime(dTP_DOC.DateTime.ToString("yyy/MM/dd")), txt_DOC_NUMBER.Text, txt_DOC_ADDRESS.Text, classes.clsDOCTORS.CLI_ID, classes.clsDOCTORS.DOC_ID, classes.clsDOCTORS.DOC_ID);
                GetData_Doctors();
                ClearDataFrom_Doct_cmb();
            }
            else
            {
                GetData_Doctors();
                ClearDataFrom_Doct_cmb();
            }
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 && txt_DOC_NAME.Text != "" && txt_DOC_CODE.Text != "")
            {
                classes.clsDOCTORS.DOCTOR_DT.Delete_DOCTOR(classes.clsDOCTORS.DOC_ID);
                GetData_Doctors();
                ClearDataFrom_Doct_cmb();
            }
            else
            {
                GetData_Doctors();
                ClearDataFrom_Doct_cmb();
            }
        }

        private void btn_Save_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUSERLIST frmUSERS_LIST = new frmUSERLIST();
            frmUSERS_LIST.ShowDialog();
            cmb_USER_ID.Text = classes.clsUsers.USER_ID.ToString();
            cmb_USER_NAME.Text = classes.clsUsers.USER_NAME;
        }

        private void cmb_USER_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_USER_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}