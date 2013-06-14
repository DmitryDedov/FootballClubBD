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
    public partial class FormChangeSalary : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormChangeSalary(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormChangeSalary_Load(object sender, EventArgs e)
        {
            connection.GetNumberEmployeeOfClubForChangeSalary(conn, id_fc);
            connection.GetListEmployeeForChangeSalary(conn, id_fc);
            FillOutListBox();
        }

        private void FillOutListBox()
        {
            for (int i = 0; i < Connection.matrixID_EmployeemFirst_nameLast_nameSalary.GetLength(0); i++)
            {
                listBox.Items.Add(Connection.matrixID_EmployeemFirst_nameLast_nameSalary[i, 0] + ";" + 
                                    Connection.matrixID_EmployeemFirst_nameLast_nameSalary[i, 2] + " " + 
                                    Connection.matrixID_EmployeemFirst_nameLast_nameSalary[i, 3] + ";" + 
                                    Connection.matrixID_EmployeemFirst_nameLast_nameSalary[i, 4]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            double i = trackBar1.Value;
            i = i / 10;
            if (radioButtonUp.Checked)
                connection.ChangeSalaryOfEmployee(conn, i, listBox.SelectedIndex);
            if (radioButtonDown.Checked)
            {
                connection.ChangeSalaryOfEmployee(conn, -i, listBox.SelectedIndex);
            }
        }
    }
}
