using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bd
{
    public partial class FormMain : Form
    {
        //Connection connection = new Connection();
        //SQLiteConnection conn;

        string password = "1";
        public FormMain()
        {
            InitializeComponent();
            //CreateConnection();
        }

        private void CreateConnection()
        {
            //conn = connection.ConnectionWithBase();
            //FillComboBox(conn);
        }

        private void FillComboBox(SQLiteConnection conn)
        {
            //connection.GetListTable(conn);
            //foreach (var i in Connection.arrayListNameTable)
            //{
                //comboBoxMain.Items.Add(i);
            //}
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            //string nameTable = comboBoxMain.SelectedItem.ToString();
            //Form2 form2 = new Form2(nameTable, conn);
            //form2.Show();
        }

        private void buttonStartWork_Click(object sender, EventArgs e)
        {
            if (radioButtonCoach.Checked)
            {
                FormCalendar formCalendar = new FormCalendar();
                formCalendar.Show();
            }
            if (radioButtonAdmin.Checked)
            {
                if (CheckPassword(textBoxInputPassword.Text))
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                    MessageBox.Show("Пароль неправильный!");
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            labelInputPassword.Show();
            textBoxInputPassword.Show();
        }

        private bool CheckPassword(string str)
        {
            return str.Equals(password);
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            labelInputPassword.Visible = false;
            textBoxInputPassword.Visible = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInputPassword_TextChanged(object sender, EventArgs e)
        {
            //textBoxInputPassword.PasswordChar = '*';
        }
    }
}
