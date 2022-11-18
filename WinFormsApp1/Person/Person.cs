using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace WinFormsApp1.Person
{
    internal class Person
    {
        private int _id;
        private string _name;
        private string _age;
        private string _experience;
        private string _contact;
        private string _prof;
        private int _salary;

        public Person(int id, string name, string age, string experience, string contact, string prof, int salary = 0)
        {
            _id = id;
            _name = name;
            _age = age;
            _experience = experience;
            _contact = contact;
            _prof = prof;
        }

        public Person(int id, string name, int age, string experience, string contact, string prof, int salary = 0)
            :this(id, name, "age", experience, contact, prof, salary)
        {
            _age = (DateTime.Now.Year - age).ToString() + " г.";
        }

        public int Id => _id;
        public string Name 
        {
            get => _name;
            set => _name = value;
        } 
        public string Age 
        {
            get => _age;
            set => _age = value + " г.";
        }
        public string Experience
        {
            get => _experience;
            set => _experience = value;
        }
        public string Contact
        {
            get => _contact;
            set => _contact = value;
        }
        public string Profession
        {
            get => _prof;
            set => _prof = value;
        }
        public int Salary
        {
            get => _salary;
            set { if(value > 0) _salary = value; }
        }

        public bool SaveAsApplicant(in string _conectionStr)
        {

            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);


            //Отправляем запрос
            string cmdText = $"INSERT INTO StaffAg VALUES('{Id}','{Name}', '{Age}', '{Experience}', '{Contact}', '{Profession}' )";

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
        public bool SaveAsStaff(in string _conectionStr)
        {

            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);


            //Отправляем запрос
            string cmdText = $"INSERT INTO Staff VALUES('{Id}', '{Name}', '{Age}', {Salary}, '{Profession}', '{Contact}')";

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

            try
            {
                if (command.ExecuteNonQuery() == 1)
                    answer = true;
            }
            catch (Exception)
            {
                throw;
            }

            dbConection.Close();
            return answer;

        }
    }
}
