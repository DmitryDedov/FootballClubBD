using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bd
{
    public partial class FormCalendar : Form
    {
        public Dictionary<Point, int> calendar = new Dictionary<Point, int>();
        public FormCalendar()
        {
            InitializeComponent();
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
                        calendar.Add(new Point(x, y), number);
                        number++;
                    }
                    x += 90;
                }
                x = 20;
                y += 50;
            }
        }

        private void FillOutForm(PaintEventArgs e)
        {
            foreach (var i in calendar)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), i.Key.X, i.Key.Y, 90, 50);
                e.Graphics.DrawString(i.Value.ToString(), new Font("Arial", 12), Brushes.Black, i.Key.X + 5, i.Key.Y + 5);
            }
        }

        private void FormCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            FormCoach formCoach = new FormCoach();
            if (calendar.ContainsKey(new Point((e.X - 20) / 90 * 90 + 20, (e.Y - 40) / 50 * 50 + 40)))
                formCoach.Visible = true;
            else
                MessageBox.Show("Попади в клетку, еблан!");        
        }
    }
}
