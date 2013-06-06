using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bd
{
    public partial class FormCoach : Form
    {
        public FormCoach()
        {
            InitializeComponent();
        }

        private void FormCoach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void FormCoach_Load(object sender, EventArgs e)
        {
            
        }
    }
}
