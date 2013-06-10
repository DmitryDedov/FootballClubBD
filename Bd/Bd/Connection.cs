using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Bd
{
    public class Connection
    {
        public static string[,] matrixSelectValues, matrixSelectValuesTemp;
        public static string[,] matrixID_EmployeeTypeNameSurname, matrixID_ContractID_SponsorName;
        public static string[] arrayNameColumn, arrayGetValues, arrayCheckBox;
        SQLiteTransaction tr;

        public SQLiteConnection ConnectionWithBase()
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source = C:\Users\Dmitry\YandexDisk\vgu\2_cource\PrBD\basa3.db3;");
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

        public int SearchEmployee(SQLiteConnection connection, string name, string password)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Select ID_Manager from Managers where Name = " + "'" + name + "' and Password = " + "'" + password + "'";
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                return 1;  // 1 - manager
            }

            command = new SQLiteCommand(connection);
            command.CommandText = "Select ID_Employee from Employee where First_name = " + "'" + name + "'";
            sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                return Convert.ToInt32(sqReader.GetValue(0));
            }
            return -1;
        }

        public int CheckUser(SQLiteConnection connection, string name, string password)
        {
            object s = "";
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Select ID_FC from Managers where Name = " + "'" + name + "' and Password = " + "'" + password + "'";
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                s = sqReader.GetValue(0); 
            }

            return Convert.ToInt32(s);
        }

        public void AddNewEmployee(SQLiteConnection connection, int id_fc, string type, DateTime data_start, DateTime data_end, int price,
                                    string first_name, string last_name, DateTime birthday, int salary, string place)
        {
            try
            {
                long id_contract;
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Contracts (Id_FC, Type, Data_Start, Date_End, Price) " +
                                        "values (@id_fc, @type, @data_start, @data_end, @price); select last_insert_rowid();";
                command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
                command.Parameters.Add(new SQLiteParameter("@type", type));
                command.Parameters.Add(new SQLiteParameter("@data_start", data_start));
                command.Parameters.Add(new SQLiteParameter("@data_end", data_end));
                command.Parameters.Add(new SQLiteParameter("@price", price));
                id_contract = (long)command.ExecuteScalar();

                command = new SQLiteCommand(connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Employees (ID_Contract, First_Name, Last_Name, Birthday, Salary, Place, Password) " +
                                                                "values (@id_contract, @first_name, @last_name, @birthday, @salary, @place, null)";
                command.Parameters.Add(new SQLiteParameter("@id_contract", id_contract));
                command.Parameters.Add(new SQLiteParameter("@first_name", first_name));
                command.Parameters.Add(new SQLiteParameter("@last_name", last_name));
                command.Parameters.Add(new SQLiteParameter("@birthday", birthday));
                command.Parameters.Add(new SQLiteParameter("@salary", salary));
                command.Parameters.Add(new SQLiteParameter("@place", place));
                command.ExecuteNonQuery();
            }
            catch
            {

            }
        }

        public void AddNewSponsor(SQLiteConnection connection, int id_fc, string type, DateTime data_start, DateTime data_end, int price,
                            string name, string country)
        {
            try
            {
                long id_contract;
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Contracts (Id_FC, Type, Data_Start, Date_End, Price) " +
                                        "values (@id_fc, @type, @data_start, @data_end, @price); select last_insert_rowid();";
                command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
                command.Parameters.Add(new SQLiteParameter("@type", type));
                command.Parameters.Add(new SQLiteParameter("@data_start", data_start));
                command.Parameters.Add(new SQLiteParameter("@data_end", data_end));
                command.Parameters.Add(new SQLiteParameter("@price", price));
                id_contract = (long)command.ExecuteScalar();

                command = new SQLiteCommand(connection);
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Sponsors (ID_Contract, Name, Country) " +
                                                                "values (@id_contract, @name, @country)";
                command.Parameters.Add(new SQLiteParameter("@id_contract", id_contract));
                command.Parameters.Add(new SQLiteParameter("@name", name));
                command.Parameters.Add(new SQLiteParameter("@country", country));
                command.ExecuteNonQuery();
            }
            catch
            {
                RollbackOperation(connection);
            }
        }

        public void ShowAllEmployeeOfClub(SQLiteConnection connection, int id_fc)
        {
            int i = 0, j = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select ID_Contract, Type, ID_Employee, First_name, Last_name from Contracts join Employees using (ID_Contract) where ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                while (j < sqReader.FieldCount)
                {
                    matrixID_EmployeeTypeNameSurname[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public void GetNumbetEmployeeOfClub(SQLiteConnection connection, int id_fc)
        {
            int size = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select count(ID_Contract) from Contracts where Type <> 'Sponsor' and ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                size = Convert.ToInt32(sqReader.GetValue(0));
            }
            matrixID_EmployeeTypeNameSurname = new string[size, 5];
        }

        public void GetNumbetSponsorOfClub(SQLiteConnection connection, int id_fc)
        {
            int size = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select count(ID_Contract) from Contracts where Type = 'Sponsor' and ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                size = Convert.ToInt32(sqReader.GetValue(0));
            }
            matrixID_ContractID_SponsorName = new string[size, 3];
        }

        public void ShowAllSponsorOfClub(SQLiteConnection connection, int id_fc)
        {
            int i = 0, j = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select ID_Contract, ID_Sponsors, Name from Contracts join Sponsors using (ID_Contract) where ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                while (j < sqReader.FieldCount)
                {
                    matrixID_ContractID_SponsorName[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public void DeleteEmployee(SQLiteConnection connection, int index)
        {
            SQLiteCommand com = new SQLiteCommand("delete from Employees where ID_Employee = " + matrixID_EmployeeTypeNameSurname[index, 2], connection);
            com.ExecuteNonQuery();

            com = new SQLiteCommand("delete from Contracts where ID_Contract = " + matrixID_EmployeeTypeNameSurname[index, 0], connection);
            com.ExecuteNonQuery();
        }

        public void DeleteSponsor(SQLiteConnection connection, int index)
        {
            SQLiteCommand com = new SQLiteCommand("delete from Sponsors where ID_Sponsors = " + matrixID_ContractID_SponsorName[index, 1], connection);
            com.ExecuteNonQuery();

            com = new SQLiteCommand("delete from Contracts where ID_Contract = " + matrixID_ContractID_SponsorName[index, 0], connection);
            com.ExecuteNonQuery();
        }
    }
}
