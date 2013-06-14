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
    public partial class FormCreateTraining : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;
        string date;

        public FormCreateTraining(int _id_fc, string _date, SQLiteConnection _conn)
        {
            InitializeComponent();
            id_fc = _id_fc;
            date = _date;
            conn = _conn;
        }

        private void FormCreateTraining_Load(object sender, EventArgs e)
        {
            labelDate.Text = date;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            connection.CreateTraining(conn, id_fc, date, textBoxTime.Text, textBoxPlace.Text);
        }
    }
}
