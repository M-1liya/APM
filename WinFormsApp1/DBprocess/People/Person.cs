namespace WinFormsApp1.DBprocess.People
{
    internal class Person : IPeople
    {
        private int _id;
        private string _name;
        private string _age;
        private string _experience;
        private string _contact;
        private string _prof;


        public Person(int id, string name, string age, string experience, string contact, string prof)
        {
            _id = id;
            _name = name;
            Age = age;
            _experience = experience;
            _contact = contact;
            _prof = prof;
        }

        public Person(int id, string name, int age, string experience, string contact, string prof)
            : this(id, name, "age", experience, contact, prof)
        {
            Age = (DateTime.Now.Year - age).ToString();
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
            set
            {
                value = value.Replace("г.", "");
                _age = value + "г.";
            }
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

    }
}
