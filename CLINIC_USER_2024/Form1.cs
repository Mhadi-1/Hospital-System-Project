
using CLINIC_USER_2024.DataSet1TableAdapters;
using System.Data;
using System.Data.SqlClient;
using CLINIC_USER_2024.classes;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraLayout.Filtering.Templates;

namespace CLINIC_USER_2024
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string LOG_USER_NAME;
        string LOG_USER_PASSWORD;
        string LOG_USER_TYPE;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblUsser_type(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            cmbUserName.DataSource = classes.clsUsers.USER_DT.GetData();
            cmbUserName.ValueMember = "USER_NAME";
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void CHICK_LOGIN()
        {
            classes.clsUsers.USER_LOGIN(cmbUserName.Text, txtUserPassword.Text, lblUserType.Text);
            if (classes.clsUsers.USER_ID == 0)
            {
                MessageBox.Show("WRONG USER NAME/PASSWORD");

            }
            else
            {
                classes.clsUsers.USER_ID = 0;
                LOG_USER_NAME = cmbUserName.Text;
                LOG_USER_PASSWORD = txtUserPassword.Text;
                LOG_USER_TYPE = lblUserType.Text;
                frmMain frmmainmenu = new frmMain();
                frmmainmenu.Show();
                this.Hide();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            CHICK_LOGIN();
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classes.clsUsers.USER_DT.GET_USER_B_NAME(cmbUserName.Text).Rows.Count > 0)
            {
                lblUserType.Text = classes.clsUsers.USER_DT.GET_USER_B_NAME(cmbUserName.Text).Rows[0][4].ToString();
            }
        }

        private void txtUserPassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUserPassword_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyData == Keys.Enter)
            {
                CHICK_LOGIN();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}