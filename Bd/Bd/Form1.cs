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
        Connection connection = new Connection();
        SQLiteConnection conn;

        public FormMain()
        {
            InitializeComponent();
            CreateConnection();
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void buttonStartWork_Click(object sender, EventArgs e)
        {
            if (connection.SearchEmployee(conn, textBoxInputName.Text) == 1)
            {
                FormManager formManager = new FormManager();
                formManager.Visible = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }
    }
}
