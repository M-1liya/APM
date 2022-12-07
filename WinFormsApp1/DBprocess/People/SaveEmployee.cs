using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp1.DBprocess.People
{
    internal class SaveEmployee : ISaveInDB
    {
        public bool SaveInDB(IPeople p, string conectionStr)
        {
            Employee employee = (Employee)p;

            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(conectionStr);

            //Отправляем запрос
            string cmdText =
                $"INSERT INTO Staff VALUES('{employee.Id}', '{employee.Name}', '{employee.Age}', " +
                $"{employee.Salary}, '{employee.Profession}', '{employee.Contact}')";

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
