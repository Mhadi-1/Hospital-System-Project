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
    public partial class frmCompanyList : DevExpress.XtraEditors.XtraForm
    {
        classes.clsCOMPANY NclsCompany = new classes.clsCOMPANY();
        public frmCompanyList()
        {
            InitializeComponent();
            COMPANYLIST();
        }

        public void COMPANYLIST()
        {
            gridControl1COMpanyList.DataSource = NclsCompany.COMAPANY_LIST();
            gridView1.Columns.Remove(gridView1.Columns["COM_ID"]);
            gridView1.Columns.Remove(gridView1.Columns["CLI_ID"]);
            gridView1.Columns["COM_CODE"].Caption = "Компании Код";
            gridView1.Columns["COM_NAME"].Caption = "Компании Имя";
            gridView1.Columns["COM_ADDRESS"].Caption = "Компании Адрес";
            gridView1.Columns["COM_MOBILE"].Caption = "Компании Номер";
            gridView1.Columns["COM_STATE"].Caption = "Статус";
        }

        private void textCOM_NAME_TextChanged(object sender, EventArgs e)
        {
            if (textCOM_NAME.Text != "" && gridView1.Columns.Count > 0)
            {
                gridControl1COMpanyList.DataSource = NclsCompany.GETCOMPANY_BY_NAME(textCOM_NAME.Text);
            }
            else
            {
                COMPANYLIST();
            }
        }

        private void gridControl1COMpanyList_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCOM_NAME.Text = "";
        }
    }
}