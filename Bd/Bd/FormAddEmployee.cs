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
    public partial class FormAddEmployee : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormAddEmployee(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            connection.AddNewEmployee(conn, id_fc, comboBoxType.Text, dateTimePickerDataStart.Value, dateTimePickerDataEnd.Value, Convert.ToInt32(textBoxPrice.Text),
                            textBoxFirst_name.Text, textBoxLast_name.Text, dateTimePickerBirthday.Value, Convert.ToInt32(textBoxSalary.Text), textBoxPlace.Text);
        }

        private void comboBoxType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
                textBoxPlace.Text = "bench";
            if (comboBoxType.SelectedIndex == 2)
                textBoxPlace.Text = "massage chair";
            if (comboBoxType.SelectedIndex == 3)
                textBoxPlace.Text = "field and around";
            if (comboBoxType.SelectedIndex == 4)
                textBoxPlace.Text = "kitchen";
        }
    }
}
