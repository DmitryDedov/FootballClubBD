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
    public partial class FormCleanSponsor : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormCleanSponsor(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormCleanSponsor_Load(object sender, EventArgs e)
        {
            connection.GetNumbetSponsorOfClub(conn, id_fc);
            connection.ShowAllSponsorOfClub(conn, id_fc);
            FillOutListBox();
        }

        private void FillOutListBox()
        {
            for (int i = 0; i < Connection.matrixID_ContractID_SponsorName.GetLength(0); i++)
            {
                listBox.Items.Add(Connection.matrixID_ContractID_SponsorName[i, 2]);
            }
        }

        private void buttonDeleteSponsor_Click(object sender, EventArgs e)
        {
            connection.DeleteSponsor(conn, listBox.SelectedIndex);

            connection.GetNumbetSponsorOfClub(conn, id_fc);
            connection.ShowAllSponsorOfClub(conn, id_fc);
            FillOutListBox();
        }
    }
}
