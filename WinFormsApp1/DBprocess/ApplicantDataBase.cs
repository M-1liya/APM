using System;
using System.Data.OleDb;
using System.Xml.Linq;
using WinFormsApp1.DBprocess.People;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.DBprocess
{
    internal class ApplicantDataBase: IApplicantDataBase
    {
        private static int _id = -1;
        private const string _conectionStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=StaffAgancy.mdb";
        private static List<Person> Applicants = new();

        //
        //Элементы управления для базы StaffAg
        //

        public int Add(string name, string age, string experience, string contact, string profession)
        {
            if (_id == -1) GetID();
            Person applicant;

            if (int.TryParse(age, out int intAge) && intAge < 200)
            {
                applicant = new Person(_id, name, intAge, experience, contact, profession);
                _id++;
            }
            else
            {
                applicant = new Person(_id, name, age, experience, contact, profession);
                _id++;
            }

            Applicants.Add(applicant);
            return applicant.Id;
        }
        public string Edit(int id, string name, string age, string experience, string contact, string profession)
        {
            bool find = false;
            foreach (Person person in Applicants)
            {
                if (person.Id == id)        //Ищем в списке
                {
                    person.Name = name;
                    person.Age = age;
                    person.Experience = experience;
                    person.Contact = contact;
                    person.Profession = profession;
                    find = true;
                    return "Успех";
                }
            }
                            //Если в списке нет, то обращаемся к базе
            if (!find)
            {
                OleDbConnection dbConection = new OleDbConnection(_conectionStr);
                string cmdText =
                    $"UPDATE StaffAg SET _Name= '{name}', _Age= '{age}', _Exp= {experience}, _Contact= '{contact}', _Profession= '{profession}' WHERE id= {id}";
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
            bool find = false;
            foreach (Person person in Applicants)
            {
                if(person.Id == Id)
                {
                    Applicants.Remove(person);

                    return "Успех";
                }
            }

            if(!find)
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
            return "Ошибка";
        }
        public void Load(DataGridView dataGrid)
        {
            //Запрос в базу данных
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);
            dbConection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM StaffAg", dbConection);

            OleDbDataReader reader = command.ExecuteReader();

            dataGrid.Rows.Clear();

            if (reader.HasRows != false)
            {
                while (reader.Read())
                {
                    dataGrid.Rows.Add
                        (reader["id"], reader["_Name"], reader["_Age"], reader["_Exp"], reader["_Contact"], reader["_Profession"]);
                }
            }
            else
                MessageBox.Show("Не удалось получить данные!", "Ошибка!");

            reader.Close();
            dbConection.Close();

            //Потом не сохраненные данные
            foreach(var a in Applicants)
            {
                dataGrid.Rows.Add(a.Id, a.Name, a.Age, a.Experience, a.Contact, a.Profession);
            }
        }

        //
        //Вспомогательные методы
        //

        public void SaveData()
        {
            ISaveInDB saveInDB = new SavePerson();
            foreach (var people in Applicants)
            {
                saveInDB.SaveInDB(people, _conectionStr);

            }
            Applicants.Clear();
        }
        private static void GetID()
        {
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);
            dbConection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM StaffAg", dbConection);

            checkOut(command);

            command.CommandText = "SELECT * FROM Staff";
            checkOut(command);

            void checkOut(OleDbCommand command)
            {
                OleDbDataReader reader = command.ExecuteReader();

                int i = 0;
                if (reader.HasRows != false)
                {
                    while (reader.Read())
                    {
                        i = Convert.ToInt32(reader["id"].ToString());
                        if (i > _id) _id = i;
                    }
                }
                reader.Close();

            }
            _id++;
            dbConection.Close();
        }
        public  bool AllDataSaved()
        {
            if (Applicants.Count == 0)
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
