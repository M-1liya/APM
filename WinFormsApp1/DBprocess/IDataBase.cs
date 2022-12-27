using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DBprocess
{
    internal interface IApplicantDataBase
    {
        string Delete(int id);
        void Load(DataGridView dataGrid);
    }

    internal interface IApplicantDataBase : IApplicantDataBase
    {
        int Add(string name, string age, string experience, string contact, string profession, int id);
        string Edit(int id, string name, string age, string experience, string contact, string profession);
    }

    internal interface IStaffDataBase : IApplicantDataBase
    {
        string Add(int id, string name, string age, string experience, string contact, string profession);
        string Edit(int id, string name, string age, string contact, string profession, int salary);
    }
}
