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
    public partial class Form2 : Form
    {
        Label[] arrayLabel;
        ComboBox[] arrayComboBox;
        public static string nameTable, updateColumn, updateValue;
        public static int id, countColumns;
        int currentID;
        SQLiteConnection conn;
        Connection connection = new Connection();

        public Form2()
        {
            InitializeComponent();
            conn = connection.ConnectionWithBase();
        }

        private void buttonEditing_Click(object sender, EventArgs e)
        {
            if (CheckComboBoxIsEmpty(comboBoxTypeOperation))
                MessageBox.Show("Выберите операцию!");
            else
                AddToolBoxOnForm();
        }

        private bool CheckComboBoxIsEmpty(ComboBox cb)
        {
            return cb.Text == "";
        }

        private void comboBoxTypeOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (arrayLabel != null)
                HideLabel();
            if (arrayComboBox != null)
                HideComboBox();
            if (comboBoxTypeOperation.SelectedIndex == 0)
            {
                nameTable = "FootballClub";
                countColumns = 4;
                Form3.indexStart = 1;
            }
            if (comboBoxTypeOperation.SelectedIndex == 1)
            {
                nameTable = "Contract";
                countColumns = 6;
                Form3.indexStart = 1;
            }
            connection.GetColumnsTable(conn, nameTable);
            connection.SelectCommandAllValuesForComboBox(conn, nameTable);
            id = GetLastID();
        }

        private void AddToolBoxOnForm()
        {
            AddLabelOnForm();
            AddComboBoxOnForm();
        }

        private void AddComboBoxOnForm()
        {
            arrayComboBox = new ComboBox[countColumns];
            int x = 120, y = 100;
            int j = 0;
            for (int i = Form3.indexStart; i < Connection.arrayNameColumn.Length; i++)
            {
                arrayComboBox[j] = new ComboBox();
                arrayComboBox[j].Parent = this;
                arrayComboBox[j].Location = new Point(x, y);
                FillComboBox(arrayComboBox[j], i);
                arrayComboBox[j].Visible = true;
                y += 30;
                j++;
            }
        }

        private void FillComboBox(ComboBox arrayComboBox, int index)
        {
            for (int i = 0; i < id - 1; i++)
            {
                arrayComboBox.Items.Add(Connection.matrixSelectValuesTemp[i, index]);
            }
        }

        private void AddLabelOnForm()
        {
            arrayLabel = new Label[countColumns];
            int x = 12, y = 100;
            int j = 0;
            for (int i = Form3.indexStart; i < Connection.arrayNameColumn.Length; i++)
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

        private int GetLastID()
        {
            int id = 0;
            for (int i = 0; i < Connection.matrixSelectValuesTemp.Length; i++)
            {
                if (Connection.matrixSelectValuesTemp[i, 0] == null)
                {
                    id = ++i;
                    break;
                }
            }
            return id;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FillArrayValues();
        }

        private void FillArrayValues()
        {
            Connection.arrayGetValues = new string[countColumns];
            int j = 0;
            foreach (var i in arrayComboBox)
            {
                if (CheckComboBoxIsEmpty(i))
                {
                    MessageBox.Show("Заполните все данные!");
                    return;
                }
                Connection.arrayGetValues[j] = i.Text;
                j++;
            }
            connection.InsertValues(conn, nameTable);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            FillHeadTable();
            FillTableValues();
        }

        private void FillHeadTable()
        {
            foreach (var i in Connection.arrayNameColumn)
            {
                dataGridView1.Columns.Add(i, i);
            }
        }

        private void FillTableValues()
        {
            for (int i = 0; i < Connection.matrixSelectValuesTemp.GetLength(0); i++)
            {
                if (Connection.matrixSelectValuesTemp[i, 0] != null)
                {
                    dataGridView1.Rows.Add();
                    for (int j = 0; j < Connection.matrixSelectValuesTemp.GetLength(1); j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = Connection.matrixSelectValuesTemp[i, j];
                    }
                }
                else
                    break;
            }
        }
    
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetID();
        }

        private void GetID()
        {
            int count = 0;
            currentID = arrayComboBox[0].SelectedIndex;
            if (arrayComboBox[0].SelectedIndex != -1)
            {
                for (int i = 1; i < arrayComboBox.Length; i++)
                {
                    if ((arrayComboBox[i].Text != "") && (count < 2))
                    {
                        count++;
                        updateColumn = arrayLabel[i].Text;
                        updateValue = "'" + arrayComboBox[i].Text + "'";
                        connection.UpdateValues(conn, nameTable, updateColumn, currentID, updateValue);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите параметры правильно!");
                return;
            }
            if (updateColumn == "")
            {
                MessageBox.Show("Введите параметры правильно!");
                return;
            }
            connection.UpdateValues(conn, nameTable, updateColumn, currentID, updateValue);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            GetValuesForDelete();
        }

        private void GetValuesForDelete()
        {
            if (arrayComboBox[0].SelectedIndex != -1)
                currentID = arrayComboBox[0].SelectedIndex;
            else
            {
                MessageBox.Show("Введите параметры правильно!");
                return;
            }
            for (int i = 1; i < arrayComboBox.Length; i++)
            {
                if (arrayComboBox[i].SelectedIndex != -1)
                {
                    MessageBox.Show("Введите параметры правильно!");
                    return;
                }
            }
            connection.DeleteValues(conn, nameTable, currentID);
        }

        private void HideLabel()
        {
            foreach (var i in arrayLabel)
            {
                i.Visible = false;
            }
            arrayLabel = null;
        }

        private void HideComboBox()
        {
            foreach (var i in arrayComboBox)
            {
                i.Visible = false;
            }
            arrayComboBox = null;
        }

        private void FillLableTableOnForm(SQLiteConnection conn, string nameTable)
        {
            //arrayTextBox = new TextBox[100];
            connection.GetColumnsTable(conn, nameTable);
            //Connection.arrayInsertValues = new string[Connection.arrayNameColumn.Length];
            int x = 20;
            int y = 100;
            int j = 0;
            foreach (var i in Connection.arrayNameColumn)
            {
                Label label = new Label();
                label.Text = i;
                label.Parent = this;
                label.Location = new Point(x, y);
                label.Visible = true;
                x += 100;

                //arrayTextBox[j] = new TextBox();
                //arrayTextBox[j].Parent = this;
                //arrayTextBox[j].Location = new Point(x, y);
                //arrayTextBox[j].Visible = true;

                x -= 100;
                y += 30;
                j++;
            }
            //Array.Resize(ref arrayTextBox, j);
        }

        private void FillLabelAndCheckBoxTableOnForm()
        {
            //arrayCheckBox = new CheckBox[100];
            connection.GetColumnsTable(conn, nameTable);
            int x = 20;
            int y = 100;
            int j = 0;
            foreach (var i in Connection.arrayNameColumn)
            {
                Label label = new Label();
                label.Text = i;
                label.Parent = this;
                label.Location = new Point(x, y);
                label.Visible = true;
                x += 100;

                //arrayCheckBox[j] = new CheckBox();
                //arrayCheckBox[j].Parent = this;
                //arrayCheckBox[j].Location = new Point(x, y);
                //arrayCheckBox[j].Visible = true;

                x -= 100;
                y += 30;
                j++;
            }
            //Array.Resize(ref arrayCheckBox, j);
        }

        //private void FillArrayBoolSelect()
        //{
        //    //Connection.arrayListCheckSelect = new string[Connection.arrayNameColumn.Length];
        //    //int j = 0;
        //    //foreach (var i in arrayCheckBox)
        //    //{
        //    //    if (i.Checked)
        //   //     {
        //   //         Connection.arrayListCheckSelect[j] = Connection.arrayNameColumn[j];
        //   //     }
        //   //     else
        //   //         Connection.arrayListCheckSelect[j] = "false";
        //   //     j++;
        //    //}
        //}

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            FillLableTableOnForm(conn, nameTable);
        }

        private void FillArrayInsertValues()
        {
            int j = 0;
            //foreach (var i in arrayTextBox)
            //{
           //     Connection.arrayInsertValues[j] = i.Text;
           //     j++;
           // }
        }

        public void AddColumn()
        {
            //for (int i = 0; i < Connection.matrixSelectValues.GetLength(1); i++)
            //{
            //    dataGridView1.Columns.Add("", "");
            //}

            AddValues();
        }

        public void AddValues()
        {
            //for (int i = 0; i < Connection.matrixSelectValues.GetLength(0); i++)
            //{
            //    if (Connection.matrixSelectValues[i, 0] != null)
            //    {
            //        dataGridView1.Rows.Add();
            //        for (int j = 0; j < Connection.matrixSelectValues.GetLength(1); j++)
            //        {
            //            dataGridView1.Rows[i].Cells[j].Value = Connection.matrixSelectValues[i, j];
            //        }
            //    }
            //    else
            //        break;
            //}
        }

        private void buttonSelectDo_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            //qFillArrayBoolSelect();
            connection.SelectCommand(conn, nameTable);
            AddColumn();
        }

        private void buttonInsertDo_Click(object sender, EventArgs e)
        {
            FillArrayInsertValues();
            connection.InsertValues(conn, nameTable);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            connection.CommitOperation(conn);
        }

        private void buttonRoalback_Click(object sender, EventArgs e)
        {
            connection.RollbackOperation(conn);
        }
    }
}
