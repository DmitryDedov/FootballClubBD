using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bd
{
    public partial class FormCalendar : Form
    {
        public Dictionary<Point, DateTime> calendar = new Dictionary<Point, DateTime>();
        int typeUser, id_fc;
        string date;
        Connection connection = new Connection();
        SQLiteConnection conn;

        public FormCalendar(int _typeUser, int _id_fc, SQLiteConnection _conn)
        {
            InitializeComponent();
            typeUser = _typeUser;
            id_fc = _id_fc;
            conn = _conn;
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {
            FillOutCalendar();
        }

        private void FormCalendar_Paint(object sender, PaintEventArgs e)
        {
            FillOutForm(e);
        }

        private void FillOutCalendar()
        {
            int x = 20, y = 40, number = 1, start = 3, end = 31;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((j + 1 + 2 * i >= start) && (number <= end))
                    {
                        calendar.Add(new Point(x, y), Convert.ToDateTime(number.ToString() + ".5.2013"));
                        number++;
                    }
                    x += 90;
                }
                x = 20;
                y += 50;
            }
        }
        /// <summary>
        /// нарисовать на форме календарь: квадратики + дни
        /// </summary>
        /// <param name="e"></param>
        private void FillOutForm(PaintEventArgs e)
        {
            foreach (var i in calendar)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), i.Key.X, i.Key.Y, 90, 50);
                e.Graphics.DrawString(i.Value.Day.ToString(), new Font("Arial", 12), Brushes.Black, i.Key.X + 5, i.Key.Y + 5);
                if (connection.CheckTraining(conn, i.Value.ToString("yyyy-MM-dd"), id_fc))
                {
                    e.Graphics.DrawImage(Bd.Properties.Resources.training, i.Key.X + 3, i.Key.Y + 23);
                }
            }
        }

        private void FormCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            buttonCreateTraining.Visible = false;
            buttonChangeTraining.Visible = false;
            buttonDeleteTraining.Visible = false;

            date = calendar[new Point((e.X - 20) / 90 * 90 + 20, (e.Y - 40) / 50 * 50 + 40)].ToString("yyyy-MM-dd");
            if (connection.CheckTraining(conn, calendar[new Point((e.X - 20) / 90 * 90 + 20, (e.Y - 40) / 50 * 50 + 40)].ToString("yyyy-MM-dd"), id_fc))
            {
                buttonChangeTraining.Visible = true;
                buttonDeleteTraining.Visible = true;
            }
            else
                buttonCreateTraining.Visible = true;
        }

        private void buttonCreateTraining_Click(object sender, EventArgs e)
        {
            FormCreateTraining formCreateTraining = new FormCreateTraining(id_fc, date, conn);
            formCreateTraining.Visible = true;
        }

        private void buttonDeleteTraining_Click(object sender, EventArgs e)
        {
            connection.DeleteTraining(conn, id_fc, date);
        }

        private void buttonChangeTraining_Click(object sender, EventArgs e)
        {
            FormChangeTraining formChangeTraining = new FormChangeTraining(conn, id_fc, date);
            formChangeTraining.Visible = true;
        }

        private void buttonCreateMatch_Click(object sender, EventArgs e)
        {
            FormCreateMath formCreateMatch = new FormCreateMath(conn, id_fc, date);
            formCreateMatch.Visible = true;
        }
    }
}
