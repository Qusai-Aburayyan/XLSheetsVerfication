using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelProject {
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm {
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                //activeForm.Close();
                activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void btnOpenMainBranchForm_Click(object sender, EventArgs e)
        {
            openChildForm(FormMainBranch.GetMainForm());
        }

        private void btnOpenSubBranchForm_Click(object sender, EventArgs e)
        {
            openChildForm(FormSubBranch.GetSubBranchForm());
        }

        private void btnOpenResultsForm_Click(object sender, EventArgs e)
        {
            
            openChildForm(new FormResult());
        }
    }
}
