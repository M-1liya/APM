using WinFormsApp1.Person;

namespace WinFormsApp1
{
    public partial class SaveDataDialog : Form
    {
        Form baseForm;
        public SaveDataDialog(Form baseForm)
        {
            InitializeComponent();
            //label1.Text = "Вы хотите сохранить изменения?\n\nПри нажатии  \"Не сохранять\" последние изменения будут утеряны!";
            this.baseForm = baseForm;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataBase.SaveData();
            baseForm.Close();
            this.Close();
        }
        private void buttonDontSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
