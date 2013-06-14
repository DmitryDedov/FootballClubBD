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
    public partial class FormCreateMath : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        int id_fc;
        string date;

        public FormCreateMath(SQLiteConnection _conn, int _id_fc, string _date)
        {
            InitializeComponent();
            conn = _conn;
            id_fc = _id_fc;
            date = _date;
        }

        private void FormCreateMath_Load(object sender, EventArgs e)
        {
            labelDate.Text = date;
            connection.GetNumberTurnirsOfClubs(conn, id_fc);
            connection.GetAllTurnursOfClubs(conn, id_fc);
            FillOutComboBoxTurnir();
        }

        private void FillOutComboBoxTurnir()
        {
            for (int i = 0; i < Connection.matrixTurnirsID_TurnirName.GetLength(0); i++)
                comboBoxTurnir.Items.Add(Connection.matrixTurnirsID_TurnirName[i, 1]);
        }

        private void comboBoxTurnir_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.GetNumberClubsOfTurnir(conn, id_fc, Convert.ToInt32(Connection.matrixTurnirsID_TurnirName[comboBoxTurnir.SelectedIndex, 0]));
            connection.GetClubsOfTurnir(conn, id_fc, Convert.ToInt32(Connection.matrixTurnirsID_TurnirName[comboBoxTurnir.SelectedIndex, 0]));
            FillOutComboBoxClubOpponent();
        }

        private void FillOutComboBoxClubOpponent()
        {
            for (int i = 0; i < Connection.matrixClubsOfTurnirID_FCName.GetLength(0); i++)
               comboBoxClubOpponent.Items.Add(Connection.matrixClubsOfTurnirID_FCName[i, 1]);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            connection.CreateMatch(conn, Convert.ToInt32(Connection.matrixTurnirsID_TurnirName[comboBoxTurnir.SelectedIndex, 0]), date, 
                                    textBoxTime.Text, id_fc, Convert.ToInt32(Connection.matrixClubsOfTurnirID_FCName[comboBoxClubOpponent.SelectedIndex, 0])); 
        }
    }
}
