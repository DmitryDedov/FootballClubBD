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
    public partial class FormChangeTraining : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;
        string date;

        public FormChangeTraining(SQLiteConnection _conn, int _id_fc, string _date)
        {
            InitializeComponent();
            conn = _conn;
            id_fc = _id_fc;
            date = _date;
        }

        private void FormChangeTraining_Load(object sender, EventArgs e)
        {
            textBoxOldTime.Text = connection.GetTimeTrainingWhichNeedChange(conn, date, id_fc);
            textBoxOldPlace.Text = connection.GetPlaceTrainingWhichNeedChange(conn, date, id_fc);
            textBoxOldTime.Enabled = false;
            textBoxOldPlace.Enabled = false;
            textBoxNewTime.Enabled = false;
            textBoxNewPlace.Enabled = false;
        }

        private void radioButtonChangeTime_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOldPlace.Enabled = false;
            textBoxNewPlace.Enabled = false;

            textBoxNewTime.Enabled = true;
            textBoxOldTime.Enabled = true;
        }

        private void radioButtonChangePlace_CheckedChanged(object sender, EventArgs e)
        {
            textBoxOldTime.Enabled = false;
            textBoxNewTime.Enabled = false;

            textBoxNewPlace.Enabled = true;
            textBoxOldPlace.Enabled = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxNewTime.Enabled)
                connection.ChangeTimeTraining(conn, date, id_fc, textBoxNewTime.Text);
            else
                connection.ChangePlaceTraining(conn, date, id_fc, textBoxNewPlace.Text);
        }
    }
}
