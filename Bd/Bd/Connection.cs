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
        public static string[,] matrixID_EmployeeTypeNameSurname, matrixID_ContractID_SponsorName, matrixID_EmployeemFirst_nameLast_nameSalary, matrixTurnirsID_TurnirName,
                                matrixClubsOfTurnirID_FCName;
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
        /// <summary>
        /// метод, которые позволяет узнать какой человек залогинился на сайте
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="name">имя этого человека</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        public int SearchEmployee(SQLiteConnection connection, string name, string password)
        {
            string str;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Select ID_Manager from Managers where Name = " + "'" + name + "' and Password = " + "'" + password + "'";
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                return 1;  // 1 - manager
            }

            command = new SQLiteCommand(connection);
            command.CommandText = "select Type from Contracts join Employees using (ID_Contract) where First_Name = '" + name + "' and Password = '" + password + "';";
            sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                str = sqReader.GetValue(0).ToString();
                if (str == "Coach")
                    return 2;  // 2 - coahc
            }
            return -1;
        }
        /// <summary>
        /// возвращает айди клуба, к которому принадлежит менеджер
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int CheckManager(SQLiteConnection connection, string name, string password)
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

        public int CheckCoachOrPlayer(SQLiteConnection connection, string name, string password)
        {
            object s = "";
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select ID_FC from Contracts join Employees using (ID_Contract) where First_Name = '" + name + "' and Password = '" + password + "'";
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
            command.CommandText = "select ID_Contract, Type, ID_Employee, First_name, Last_name from Contracts join Employees using (ID_Contract) where ID_FC = " + 
                                    id_fc.ToString();
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

        public int GetBudget(SQLiteConnection connection, int id_fc)
        {
            int budget = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select Budget from FootballClubs where ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                budget = Convert.ToInt32(sqReader.GetValue(0));
            }
            return budget;
        }

        public void Offer(SQLiteConnection connection, int id_fc, int offerValue)
        {
            SQLiteCommand com = new SQLiteCommand("update FootballClubs set Budget = " + offerValue.ToString() + " where ID_FC = " + id_fc.ToString(), connection);
            com.ExecuteNonQuery();
        }

        public void GetListEmployeeForChangeSalary(SQLiteConnection connection, int id_fc)
        {
            int i = 0, j = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select Type, ID_Employee, First_name, Last_name, Salary from Contracts join Employees using (ID_Contract) where ID_FC = " + 
                                    id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                while (j < sqReader.FieldCount)
                {
                    matrixID_EmployeemFirst_nameLast_nameSalary[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public void GetNumberEmployeeOfClubForChangeSalary(SQLiteConnection connection, int id_fc)
        {
            int size = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "select count(ID_Contract) from Contracts where Type <> 'Sponsor' and ID_FC = " + id_fc.ToString();
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                size = Convert.ToInt32(sqReader.GetValue(0));
            }
            matrixID_EmployeemFirst_nameLast_nameSalary = new string[size, 5];
        }

        public void ChangeSalaryOfEmployee(SQLiteConnection connection, double percent, int index)
        {
            SQLiteCommand com = new SQLiteCommand("update Employees set Salary = " + 
                                                    Math.Round(Convert.ToInt32(matrixID_EmployeemFirst_nameLast_nameSalary[index, 4]) * (1 + percent)) + 
                                                    " where ID_Employee = " + matrixID_EmployeemFirst_nameLast_nameSalary[index, 1], connection);
            com.ExecuteNonQuery();
        }

        public bool CheckTraining(SQLiteConnection connection, string date, int id_fc)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select ID_Routine from Routine where Date = @date and ID_FC = @id_fc";
            command.Parameters.Add(new SQLiteParameter("@date", date));
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                return true;
            }
            return false;
        }

        public void CreateTraining(SQLiteConnection connection, int id_fc, string date, string time, string place)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Routine (Date, Time, Place, ID_FC, Type) values (@date, @time, @place, @id_fc, 'Training');";
            command.Parameters.Add(new SQLiteParameter("@date", date));
            command.Parameters.Add(new SQLiteParameter("@time", time));
            command.Parameters.Add(new SQLiteParameter("@place", place));
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.ExecuteNonQuery();

            tr = connection.BeginTransaction();
            tr.Commit();
        }

        public void DeleteTraining(SQLiteConnection connection, int id_fc, string date)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from Routine where ID_FC = @id_fc and Date = @date";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@date", date));
            command.ExecuteNonQuery();
        }

        public string GetTimeTrainingWhichNeedChange(SQLiteConnection connection, string date, int id_fc)
        {
            string s;
            DateTime dt = DateTime.Now;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select Time from Routine where Date = @date and ID_FC = @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@date", date));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                dt = Convert.ToDateTime(sqReader.GetValue(0));
            }
            s = dt.ToString("H:mm");
            return s;
        }

        public string GetPlaceTrainingWhichNeedChange(SQLiteConnection connection, string date, int id_fc)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select Place from Routine where Date = @date and ID_FC = @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@date", date));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                return sqReader.GetValue(0).ToString();
            }
            return null;
        }

        public void ChangeTimeTraining(SQLiteConnection connection, string date, int id_fc, string time)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "update Routine set Time = @time where Date = @date and ID_FC = @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@date", date));
            command.Parameters.Add(new SQLiteParameter("@time", time));
            command.ExecuteNonQuery();
        }

        public void ChangePlaceTraining(SQLiteConnection connection, string date, int id_fc, string place)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "update Routine set Place = @place where Date = @date and ID_FC = @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@date", date));
            command.Parameters.Add(new SQLiteParameter("@place", place));
            command.ExecuteNonQuery();
        }

        public void GetNumberTurnirsOfClubs(SQLiteConnection connection, int id_fc)
        {
            int size = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(Name) from Turnirs where ID_Turnir in (select ID_Turnir from [Turnirs-Club] where ID_FC = @id_fc)";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                size = Convert.ToInt32(sqReader.GetValue(0));
            }
            matrixTurnirsID_TurnirName = new string[size, 2];
        }

        public void GetAllTurnursOfClubs(SQLiteConnection connection, int id_fc)
        {
            int i = 0, j = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select ID_Turnir, Name from Turnirs where ID_Turnir in (select ID_Turnir from [Turnirs-Club] where ID_FC = @id_fc)";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                while (j < sqReader.FieldCount)
                {
                    matrixTurnirsID_TurnirName[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public void GetNumberClubsOfTurnir(SQLiteConnection connection, int id_fc, int id_turnir)
        {
            int size = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select count(ID_FC) from [Turnirs-Club] join FootballClubs using (ID_FC) where ID_Turnir = @id_turnir and ID_FC <> @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@id_turnir", id_turnir));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                size = Convert.ToInt32(sqReader.GetValue(0));
            }
            matrixClubsOfTurnirID_FCName = new string[size, 2];
        }

        public void GetClubsOfTurnir(SQLiteConnection connection, int id_fc, int id_turnir)
        {
            int i = 0, j = 0;
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "select ID_FC, Name from [Turnirs-Club] join FootballClubs using (ID_FC) where ID_Turnir = @id_turnir and ID_FC <> @id_fc";
            command.Parameters.Add(new SQLiteParameter("@id_fc", id_fc));
            command.Parameters.Add(new SQLiteParameter("@id_turnir", id_turnir));
            SQLiteDataReader sqReader = command.ExecuteReader();
            while (sqReader.Read())
            {
                while (j < sqReader.FieldCount)
                {
                    matrixClubsOfTurnirID_FCName[i, j] = sqReader.GetValue(j).ToString();
                    j++;
                }
                i++;
                j = 0;
            }
        }

        public void CreateMatch(SQLiteConnection connection, int id_turnir, string data_match, string time_match, int id_fc_host, int id_fc_guest)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into Matches (ID_Turnir, Data_Match, Time_Match, ID_FC_Host, ID_FC_Guest, MatchExists) " +
                                    "values (@id_turnir, @data_match, @time_match, @id_fc_host, @id_fc_guest, 'false')";
            command.Parameters.Add(new SQLiteParameter("@id_turnir", id_turnir));
            command.Parameters.Add(new SQLiteParameter("@data_match", data_match));
            command.Parameters.Add(new SQLiteParameter("@time_match", time_match));
            command.Parameters.Add(new SQLiteParameter("@id_fc_host", id_fc_host));
            command.Parameters.Add(new SQLiteParameter("@id_fc_guest", id_fc_guest));
            command.ExecuteNonQuery();
        }
    }
}
