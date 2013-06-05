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
    public partial class Form3 : Form
    {
        Connection connection = new Connection();
        SQLiteConnection conn;
        Label[] arrayLabel;
        CheckBox[] arrayCheckBox;
        string nameTable;
        public static int indexStart;

        public Form3()
        {
            InitializeComponent();
            conn = connection.ConnectionWithBase();
        }

        private void comboBoxTypeOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arrayLabel != null)
                HideLabel();
            if (arrayCheckBox != null)
                HideCheckBox();
            if (comboBoxTypeOperation.SelectedIndex == 0)
            {
                nameTable = "FootballClub";
                Form2.countColumns = 4;
                indexStart = 1;
            }
            if (comboBoxTypeOperation.SelectedIndex == 1)
            {
                nameTable = "Contract";
                Form2.countColumns = 4;
                indexStart = 3;
            }
            if (comboBoxTypeOperation.SelectedIndex == 2)
            {
                nameTable = "Employee";
                Form2.countColumns = 5;
                indexStart = 3;
            }
            if (comboBoxTypeOperation.SelectedIndex == 3)
            {
                nameTable = "Sponsors";
                Form2.countColumns = 2;
                indexStart = 2;
            }
            arrayLabel = new Label[Form2.countColumns];
            arrayCheckBox = new CheckBox[Form2.countColumns];
            connection.GetColumnsTable(conn, nameTable);
            AddLabelOnForm();
            AddCheckBoxOnForm();
        }

        private void HideLabel()
        {
            foreach (var i in arrayLabel)
            {
                i.Visible = false;
            }
            arrayLabel = null;
        }

        private void HideCheckBox()
        {
            foreach (var i in arrayCheckBox)
            {
                i.Visible = false;
            }
            arrayCheckBox = null;
        }

        private void AddLabelOnForm()
        {
            int x = 20, y = 60;
            int j = 0;
            for (int i = indexStart; i < Connection.arrayNameColumn.Length; i++)
            {
                arrayLabel[j] = new Label();
                arrayLabel[j].Text = Connection.arrayNameColumn[i];
                arrayLabel[j].Parent = this;
                arrayLabel[j].Location = new Point(x, y);
                arrayLabel[j].Visible = true;
                y += 30; 
                j++;
            }
        }

        private void AddCheckBoxOnForm()
        {
            int x = 150, y = 60;
            int j = 0;
            for (int i = indexStart; i < Connection.arrayNameColumn.Length; i++)
            {
                arrayCheckBox[j] = new CheckBox();
                arrayCheckBox[j].Parent = this;
                arrayCheckBox[j].Location = new Point(x, y);
                arrayCheckBox[j].Visible = true;
                y += 30;
                j++;
            }
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            FillArrarCheckBox();
        }

        private void FillArrarCheckBox()
        {
            Connection.arrayCheckBox = new string[Form2.countColumns];
            int j = indexStart, index = 0;
            foreach (var i in arrayCheckBox)
            {
                if (i.Checked)
                {
                    Connection.arrayCheckBox[index] = Connection.arrayNameColumn[j];
                    index++;
                }
                j++;
            }
            if (index == 0)
            {
                MessageBox.Show("Выберите необходимые столбцы!");
                return;
            }
            Array.Resize(ref Connection.arrayCheckBox, index);
            connection.SelectCommand(conn, nameTable);
            FillHeadTable();
            FillTableValues();
        }

        private void FillHeadTable()
        {
            foreach (var i in Connection.arrayCheckBox)
            {
                dataGridView1.Columns.Add(i, i);
            }
        }

        private void FillTableValues()
        {
            for (int i = 0; i < Connection.matrixSelectValues.GetLength(0); i++)
            {
                if (Connection.matrixSelectValues[i, 0] != null)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < Connection.matrixSelectValues.GetLength(1); j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = Connection.matrixSelectValues[i, j];
                    }
                }
                else
                    break;
            }
        }

    }
}
