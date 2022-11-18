using System.Data.OleDb;
using WinFormsApp1.Person;

namespace WinFormsApp1
{
    public partial class staffForm : Form
    {

        private const string _conectionStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=StaffAgancy.mdb";
        public staffForm()
        {
            InitializeComponent();
            LoadDatabase();
        }
        //
        //Кнопки панели меню
        //
        private void кадровоеАгенствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение создано для упрощения работы HR-менеджера.\nПриятного пользования!", "О Программе");
        }
        //
        //Описание кнопок
        //
        private void buttonRemove_Click(object sender, EventArgs e) 
        {
            // Снала добавить в базу соискателей,
            // затем удалить из штата сотрудников

            if (dataGridViewSF.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridViewSF.SelectedRows[0].Index;
            if (!GoodData(index)) return;


            //запомнить данные
            string? id = dataGridViewSF.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridViewSF.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridViewSF.Rows[index].Cells[2].Value.ToString();
            string? exp = "0";
            string? prof = dataGridViewSF.Rows[index].Cells[4].Value.ToString();
            string? contact = dataGridViewSF.Rows[index].Cells[5].Value.ToString();


            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);


            //Отправить запрос
            string cmdText = $"INSERT INTO StaffAg VALUES('{id}', '{name}', '{age}', '{exp}', '{contact}', '{prof}' )";

            if (sendRequest(cmdText, dbConection))
            {
                MessageBox.Show("Сотрудник уволен!", "Выполнено");

                //Очистить поля
                cmdText = $"DELETE FROM Staff WHERE id = {id}";
                if(sendRequest(cmdText, dbConection))
                    dataGridViewSF.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Произошла ошибка! Попробуйте снова.", "Ошибка");
            }

        }
        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }//Ready
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSF.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }

            int index = dataGridViewSF.SelectedRows[0].Index;
            if (!GoodData(index)) return;

            string? id = dataGridViewSF.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridViewSF.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridViewSF.Rows[index].Cells[2].Value.ToString();
            string? salary = dataGridViewSF.Rows[index].Cells[3].Value.ToString();
            string? prof = dataGridViewSF.Rows[index].Cells[4].Value.ToString();
            string? contact = dataGridViewSF.Rows[index].Cells[5].Value.ToString();


            string SAL = "";
            if (salary != null) // Получение из строки денежного формата целое значение
            {
                foreach(char s in salary)
                {
                    if (char.IsDigit(s)) SAL += s;
                    if (char.IsPunctuation(s)) break;
                }
            }

            int.TryParse(id, out int Id);
            int.TryParse(SAL, out int Salary);

            DataBase.EditStaff(Id, name, age, contact, prof, Salary);

        }
        //
        //Вспомогательные методы
        //
        bool GoodData(in int index)
        {


            //Проверить заполненность данных
            if (dataGridViewSF.Rows[index].Cells[0] == null ||
                dataGridViewSF.Rows[index].Cells[1] == null ||
                dataGridViewSF.Rows[index].Cells[2] == null ||
                dataGridViewSF.Rows[index].Cells[3] == null ||
                dataGridViewSF.Rows[index].Cells[4] == null ||
                dataGridViewSF.Rows[index].Cells[5] == null)
            {
                MessageBox.Show("Не все данные были заполнены!", "Внимание!");
                return false;
            }
            return true;
        }
        bool sendRequest(in string cmdText, in OleDbConnection dbConection)
        {
            dbConection.Open();
            OleDbCommand command = new OleDbCommand(cmdText, dbConection);
            bool answer = false;

            try
            {
                if (command.ExecuteNonQuery() == 1)
                    answer = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }

            dbConection.Close();
            return answer;

        }
        void LoadDatabase()
        {
            DataBase.LoadStaffBase(dataGridViewSF);
        }

    }

}
