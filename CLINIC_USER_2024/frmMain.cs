using CLINIC_USER_2024.Manin_Forms;
using DevExpress.XtraBars;
using PatientAidApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLINIC_USER_2024
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void ShowFormDoctors()
        {
            FRM_DOCTO_MAIN FRM_DOCTORS = new FRM_DOCTO_MAIN();
            fluentDesignFormContainer1.Controls.Clear();
            FRM_DOCTORS.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(FRM_DOCTORS);
            FRM_DOCTORS.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FRM_DOCTORS.Dock = DockStyle.Fill;
            FRM_DOCTORS.Show();
        }
        public void ShowFormMedcin()
        {
            MedicinesForm FRM_MEDCIN = new MedicinesForm();
            fluentDesignFormContainer1.Controls.Clear();
            FRM_MEDCIN.TopLevel = false;
            fluentDesignFormContainer1.Controls.Add(FRM_MEDCIN);
            FRM_MEDCIN.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FRM_MEDCIN.Dock = DockStyle.Fill;
            FRM_MEDCIN.Show();
        }
        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {
            ShowFormDoctors();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 FORM_LOGIN = new Form1();
            FORM_LOGIN.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
