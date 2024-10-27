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

namespace CLINIC_USER_2024.Manin_Forms
{
    public partial class FRM_DOCTO_MAIN : DevExpress.XtraEditors.XtraForm
    {
        public FRM_DOCTO_MAIN()
        {
            InitializeComponent();
        }

        private void btnEdite_DOCTOR_Click(object sender, EventArgs e)
        {
            frmDoctor frmDoc = new frmDoctor();
            frmDoc.Show();
        }

        private void FRM_DOCTO_MAIN_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {
            frmDOCTORS_LIST FrmDOC_List = new frmDOCTORS_LIST();
            FrmDOC_List.Show();
        }

        private void Red(object sender, EventArgs e)
        {

        }
    }
}