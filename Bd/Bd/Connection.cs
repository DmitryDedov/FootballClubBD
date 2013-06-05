using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Bd
{
    public class Connection
    {
        public static string[,] matrixSelectValues, matrixSelectValuesTemp;
        public static string[] arrayNameColumn, arrayGetValues, arrayCheckBox;
        SQLiteTransaction tr;

        public SQLiteConnection ConnectionWithBase()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = C:\Users\Dmitry\YandexDisk\vgu\2_cource\PrBD\basa.db3;");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return connection;
        }

        public void CloseConnection(SQLiteConnection connection)
        {
            connection.Close();
        }

        public void SelectCommandAllValuesForComboBox(SQLiteConnection connection, string nameTable)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Select * " + "from " + nameTable;
            SQLiteDataReader sqReader = command.ExecuteReader();

            matrixSelectValuesTemp = new string[100, sqReader.FieldCount];
            int i = 0;
            while (sqReader.Read())
            {
                int j = 0;
                while (j < sqReader.FieldCount)
                {
                    matrixSelectValuesTemp[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
            }
        }

        public void SelectCommand(SQLiteConnection connection, string nameTable)
        {
            string strCommon = "";
            int j = 0;
            foreach (var i in arrayCheckBox)
            {
                if (arrayCheckBox.Length - 1 != j)
                    strCommon += i + ",";
                else
                    strCommon += i;
                j++;
            }
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Select " + strCommon + " from " + nameTable;
            SQLiteDataReader sqReader = command.ExecuteReader();

            matrixSelectValues = new string[100, sqReader.FieldCount];
            int k = 0;
            while (sqReader.Read())
            {
                j = 0;
                while (j < sqReader.FieldCount)
                {
                    matrixSelectValues[k, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                k++;
            }
        }

        public void InsertValues(SQLiteConnection connection, string nameTable)
        {
            string strCommon = Form2.id.ToString() + ", ";
            int j = 0;
            foreach (var i in arrayGetValues)
            {
                if (arrayGetValues.Length - 1 != j)
                    strCommon += "'" + i + "',";
                else
                    strCommon += "'" + i + "'";
                j++;
            }
            SQLiteCommand com = new SQLiteCommand("INSERT INTO " + nameTable + " VALUES (" + strCommon + ")", connection);
            com.ExecuteNonQuery();
        }

        public void UpdateValues(SQLiteConnection connection, string nameTable, string updateColumn, int currentID, string updateValue)
        {
            SQLiteCommand com = new SQLiteCommand("update " + nameTable + " set " + updateColumn + " = " + updateValue + " where " + arrayNameColumn[0] + "=" + (++currentID).ToString(), connection);
            com.ExecuteNonQuery();
        }

        public void DeleteValues(SQLiteConnection connection, string nameTable, int currentID)
        {
            SQLiteCommand com = new SQLiteCommand("delete from " + nameTable + " where " + arrayNameColumn[0] + "= " + (++currentID).ToString(), connection);
            com.ExecuteNonQuery();
        }

        public void CommitOperation(SQLiteConnection connection)
        {
            tr = connection.BeginTransaction();
            tr.Commit();
            SelectCommandAllValuesForComboBox(connection, Form2.nameTable);
        }

        public void RollbackOperation(SQLiteConnection connection)
        {
            tr = connection.BeginTransaction();
            tr.Rollback();
        }

        //public void GetListTable(SQLiteConnection connection)
        //{
        //    SQLiteCommand command = new SQLiteCommand(connection);
        //    command.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY name;";
        //    SQLiteDataReader sqReader = command.ExecuteReader();

        //    //arrayListNameTable = new string[20];
        //    int i = 0;

        //    while (sqReader.Read())
        //    {
        //        //arrayListNameTable[i] = sqReader.GetValue(0).ToString();
        //        i += 1;
        //    }
        //    //Array.Resize(ref arrayListNameTable, i);
        //}

        public void GetColumnsTable(SQLiteConnection connection, string nameTable)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Pragma table_info(" + nameTable + ")";
            SQLiteDataReader sqReader = command.ExecuteReader();
            arrayNameColumn = new string[20];
            int i = 0;
            while (sqReader.Read())
            {
                arrayNameColumn[i] = sqReader.GetValue(1).ToString();
                i += 1;
            }
            Array.Resize(ref arrayNameColumn, i);
        }
    }
}
