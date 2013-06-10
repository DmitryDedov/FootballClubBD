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
    public partial class FormAddSponsor : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;

        public FormAddSponsor(int _id_fc)
        {
            InitializeComponent();
            CreateConnection();
            id_fc = _id_fc;
        }

        private void CreateConnection()
        {
            conn = connection.ConnectionWithBase();
        }

        private void FormAddSponsor_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddSponsor_Click(object sender, EventArgs e)
        {
            connection.AddNewSponsor(conn, id_fc, "Sponsor", dateTimePickerDataStart.Value, dateTimePickerDataEnd.Value, Convert.ToInt32(textBoxPrice.Text),
                textBoxName.Text, textBoxCountry.Text);

        }
    }
}
