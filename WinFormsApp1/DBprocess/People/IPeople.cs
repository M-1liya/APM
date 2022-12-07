using System;

namespace WinFormsApp1.DBprocess.People
{
    interface IPeople
    {
        int Id { get; }
        string Name { get; set; }
        string Age { get; set; }
        string Contact { get; set; }
        string Profession { get; set; }
    }
}
