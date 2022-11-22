using WinFormsApp1.Person;

namespace WinFormsApp1
{
    public partial class SaveDataDialog : Form
    {
        Form baseForm;
        FormClosingEventArgs eventArgs;
        bool choice = true;
        public SaveDataDialog(Form baseForm, FormClosingEventArgs e)
        {
            InitializeComponent();
            //label1.Text = "Вы хотите сохранить изменения?\n\nПри нажатии  \"Не сохранять\" последние изменения будут утеряны!";
            this.baseForm = baseForm;
            this.eventArgs = e;
            this.Location = new Point(670, 430);
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase.SaveData();
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

        private void SaveDataDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            eventArgs.Cancel = choice;

        }

    }
}
