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
    public partial class frmCUST_LIST : DevExpress.XtraEditors.XtraForm
    {
        public frmCUST_LIST()
        {
            InitializeComponent();
        }

        classes.clsCUST nclsCust = new classes.clsCUST();

        void CLEARDATAT()
        {
            gridContro_CUST_List.DataSource = nclsCust.CUST_LIST();
            //gridView1.DataSource = nclsCust.CUST_LIST();
        }
        private void frmCUST_LIST_Load(object sender, EventArgs e)
        {

        }
    }
}