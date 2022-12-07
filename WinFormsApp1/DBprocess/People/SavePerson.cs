using System;
using System.Data.OleDb;


namespace WinFormsApp1.DBprocess.People
{
    internal class SavePerson : ISaveInDB
    {
        public bool SaveInDB(IPeople p, string conectionStr)
        {
            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(conectionStr);

            Person person = (Person)p;
            //Отправляем запрос
            string cmdText =
                $"INSERT INTO StaffAg VALUES('{person.Id}','{person.Name}', '{person.Age}'," +
                $" '{person.Experience}', '{person.Contact}', '{person.Profession}' )";

            try
            {
                if (!SendRequest(cmdText, dbConection))
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private bool SendRequest(in string cmdText, in OleDbConnection dbConection)
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
