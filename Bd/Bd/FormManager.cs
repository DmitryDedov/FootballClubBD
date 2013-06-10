using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bd
{
    public partial class FormManager : Form
    {
        int id_fc;
        public FormManager(int _id_fc)
        {
            InitializeComponent();
            id_fc = _id_fc;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee(id_fc);
            formAddEmployee.Visible = true;
        }

        private void sponsorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSponsor formAddSponsor = new FormAddSponsor(id_fc);
            formAddSponsor.Visible = true;
        }

        private void toolStripButtonDismissEmployee_Click(object sender, EventArgs e)
        {
            FormDismissEmployee formDismissEmployee = new FormDismissEmployee(id_fc);
            formDismissEmployee.Visible = true;
        }

        private void toolStripButtonCleanSponsor_Click(object sender, EventArgs e)
        {
            FormCleanSponsor formCleanSponsor = new FormCleanSponsor(id_fc);
            formCleanSponsor.Visible = true;
        }
    }
}
