using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DBprocess.People;

namespace WinFormsApp1.DBprocess
{
    internal class StaffDataBase : IStaffDataBase
    {
        private static int _id = -1;
        private const string _conectionStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=StaffAgancy.mdb";
        private static List<Employee> Staff = new();

        //
        //Элементы управления для базы Staff
        //

        public string Add(int id, string name, string age, string experience, string contact, string profession)
        {

            Employee _staff;

            if (int.TryParse(age, out int intAge) && intAge < 200)
            {
                _staff = new Employee(id, name, intAge, experience, contact, profession);

            }
            else
            {
                _staff = new Employee(id, name, age, experience, contact, profession);

            }

            Staff.Add(_staff);
            return "Успех";
        }
        public string Edit(int id, string name, string age, string contact, string profession, int salary)
        {
            bool find = false;
            foreach (Employee employee in Staff)  //Ищем в списке
            {
                if (employee.Id == id)
                {
                    employee.Name = name;
                    employee.Age = age;
                    employee.Salary = salary;
                    employee.Contact = contact;
                    employee.Profession = profession;
                    find = true;
                    return "Успех";
                }

            }
            //Если в списке нет, то обращаемся к базе
            if (!find)
            {
                OleDbConnection dbConection = new OleDbConnection(_conectionStr);
                string cmdText =
                    $"UPDATE Staff SET _Name= '{name}', _Age= '{age}', _Salary= {salary}, _Profession= '{profession}', _Contact= '{contact}' WHERE id= {id}";

                try
                {
                    if (SendRequest(cmdText, dbConection))
                        return "Успех";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return "Ошибка";
        }
        public string Delete(int Id)
        {
            foreach (Employee employee in Staff)
            {
                bool find = false;

                if (employee.Id == Id)
                {
                    Staff.Remove(employee);
                    find = true;
                    return "Успех";
                }

                //Если нет в списке, то обращаемся к базе данных
                if (!find)
                {
                    OleDbConnection dbConection = new OleDbConnection(_conectionStr);
                    string cmdText = $"DELETE FROM StaffAg WHERE id = {Id}";

                    try
                    {
                        if (SendRequest(cmdText, dbConection))
                            return "Успех";
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }

                }
            }
            return "Ошибка";

        }
        public void Load(DataGridView dataGrid)
        {
            //Запрос в базу данных
            dataGrid.Rows.Clear();

            OleDbConnection dbConection = new OleDbConnection(_conectionStr);
            dbConection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Staff", dbConection);

            OleDbDataReader reader = command.ExecuteReader();

            dataGrid.Rows.Clear();

            if (reader.HasRows != false)
            {
                while (reader.Read())
                {
                    dataGrid.Rows.Add
                        (reader["id"], reader["_Name"], reader["_Age"], reader["_Salary"], reader["_Profession"], reader["_Contact"]);
                }
            }
            else
                MessageBox.Show("Не удалось получить данные!", "Ошибка!");

            reader.Close();
            dbConection.Close();

            //Потом не сохраненные данные
            foreach (var s in Staff)
            {
                dataGrid.Rows.Add(s.Id, s.Name, s.Age, s.Salary, s.Profession, s.Contact);
            }
        }
        public void SaveData()
        {
            ISaveInDB saveInDB = new SaveEmployee();

            foreach (var people in Staff)
                saveInDB.SaveInDB(people, _conectionStr);

            Staff.Clear();
        }


        public bool AllDataSaved()
        {
            if (Staff.Count == 0)
                return true;
            else
                return false;
        }
        private static bool SendRequest(in string cmdText, in OleDbConnection dbConection)
        {
            dbConection.Open();
            OleDbCommand command = new OleDbCommand(cmdText, dbConection);
            bool answer = false;

            if (command.ExecuteNonQuery() == 1)
                answer = true;

            dbConection.Close();
            return answer;

        }



    }
}
