using System;


namespace WinFormsApp1.DBprocess.People
{
    internal class Employee : IPeople
    {
        private Person _p;
        private int _salary = 0;

        public Employee(Person person, int salary)
        {
            _p = person;
            Salary = salary;
        }
        public Employee(int id, string name, string age, string experience, string contact, string prof, int salary = 0)
        {
            _p = new Person(id, name, age, experience, contact, prof);
            Salary = salary;
        }
        public Employee(int id, string name, int age, string experience, string contact, string prof, int salary = 0)
        {
            _p = new Person(id, name, age, experience, contact, prof);
            Salary = salary;
        }

        public int Id => _p.Id;
        public string Name
        {
            get => _p.Name;
            set => _p.Name = value;
        }
        public string Age
        {
            get => _p.Age;
            set => _p.Age = value;
        }
        public string Contact
        {
            get => _p.Contact;
            set => _p.Contact = value;
        }
        public string Profession
        {
            get => _p.Profession;
            set => _p.Profession = value;
        }
        public int Salary
        {
            get => _salary;
            set { if (value > 0) _salary = value; }
        }

    }
}
