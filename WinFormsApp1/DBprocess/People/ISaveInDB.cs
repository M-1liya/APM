using System;


namespace WinFormsApp1.DBprocess.People
{
    internal interface ISaveInDB
    {
        bool SaveInDB(IPeople p, string conectionStr);
    }
}
