using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bd
{
    public partial class FormOffer : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormOffer(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormOffer_Load(object sender, EventArgs e)
        {
            labelRight.Text = connection.GetBudget(conn, id_fc).ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = connection.GetBudget(conn, id_fc);
            labelCenter.Text = hScrollBar1.Value.ToString();
        }

        private void buttonOffer_Click(object sender, EventArgs e)
        {
            connection.Offer(conn, id_fc, hScrollBar1.Maximum - hScrollBar1.Value);
        }
    }
}
