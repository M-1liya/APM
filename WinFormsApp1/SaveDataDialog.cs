using WinFormsApp1.DBprocess;

namespace WinFormsApp1
{
    public partial class SaveDataDialog : Form
    {
        FormClosingEventArgs eventArgs;
        bool choice = true;
        public SaveDataDialog(Form baseForm, FormClosingEventArgs e)
        {
            InitializeComponent();
            this.eventArgs = e;
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
