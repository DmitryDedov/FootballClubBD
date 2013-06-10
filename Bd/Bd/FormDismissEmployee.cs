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
    public partial class FormDismissEmployee : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormDismissEmployee(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormDismissEmployee_Load(object sender, EventArgs e)
        {
            connection.GetNumbetEmployeeOfClub(conn, id_fc);
            connection.ShowAllEmployeeOfClub(conn, id_fc);
            FillOutListBox();
        }

        private void FillOutListBox()
        {
            for (int i = 0; i < Connection.matrixID_EmployeeTypeNameSurname.GetLength(0); i++)
            {
                listBox.Items.Add(Connection.matrixID_EmployeeTypeNameSurname[i, 1] + ";" + Connection.matrixID_EmployeeTypeNameSurname[i, 3] + " " + Connection.matrixID_EmployeeTypeNameSurname[i, 4]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.DeleteEmployee(conn, listBox.SelectedIndex);

            connection.GetNumbetEmployeeOfClub(conn, id_fc);
            connection.ShowAllEmployeeOfClub(conn, id_fc);
            FillOutListBox();
        }
    }
}
