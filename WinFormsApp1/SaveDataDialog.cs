using WinFormsApp1.DBprocess;

namespace WinFormsApp1
{
    public partial class SaveDataDialog : Form
    {
        IApplicantDataBase ApDataBase = new ApplicantDataBase();
        IStaffDataBase StaffDataBase = new StaffDataBase();

        FormClosingEventArgs eventArgs;

        //Если choice == true то диалоговое окно закроется и продолжится работа в главном окне
        bool choice = true;

        public SaveDataDialog(Form baseForm, FormClosingEventArgs e)
        {
            InitializeComponent();
            this.eventArgs = e;
        }


        //Кнопки
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ApDataBase.SaveData();
            StaffDataBase.SaveData();
            choice = false;
            eventArgs.Cancel = false;
            this.Close();
        }
        private void buttonDontSave_Click(object sender, EventArgs e)
        {
            choice = false;
            eventArgs.Cancel = false;
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            choice = true;
            eventArgs.Cancel = true;
            this.Close();
        }
        
        //Закрытие окна
        private void SaveDataDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventArgs.Cancel = choice;
        }

    }
}
