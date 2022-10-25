using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class staffAgancy : Form
    {
        private int _id = 0;
        private const string _conectionStr = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=StaffAgancy.mdb";

        public staffAgancy()
        {
            InitializeComponent();
            loadDatabase();
            getID();
        }
        //
        //Кнопки панели меню
        //
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение создано для урощения работы HR-менеджера.\nПриятного пользования!", "О Программе");
        }
        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadDatabase();
        }
        private void штатСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffForm form = new staffForm();
            form.ShowDialog();
            //this.Visible = false;
            this.Show();

            

        }
        //
        //Описание кнопок
        //
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }
            //запомнить строку
            int index = dataGridView1.SelectedRows[0].Index;
            if (!GoodData(index))
                return;

            _id++;
            //запомнить данные
            string? id = _id.ToString();
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();

            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);


            //Отправляем запрос
            string cmdText = $"INSERT INTO StaffAg VALUES('{id}','{name}', '{age}', '{exp}', '{contact}', '{prof}' )";

            if (!sendRequest(cmdText, dbConection))
                MessageBox.Show("Данные не были добавлены! Попробуйте снова.", "Ошибка");
            else
            { 
                MessageBox.Show("Соискатель успешно добавлен!", "Успех");
                loadDatabase();
            }

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }

            //запомнить строку
            int index = dataGridView1.SelectedRows[0].Index;

            if (!GoodData(index)) return;

            //запомнить данные
            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();

            //создать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);

            //Отправляем запрос
            string cmdText =
                $"UPDATE StaffAg SET _Name= '{name}', _Age= {age}, _Exp= {exp}, _Contact= '{contact}', _Profession= '{prof}' WHERE id= {id}";

                if (!sendRequest(cmdText, dbConection))
                    MessageBox.Show("Данные не были изменены! Попробуйте снова.", "Ошибка");
                else
                    MessageBox.Show("Данные успешно изменены!", "Успех");

            loadDatabase();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
            loadDatabase();
        }
        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }

            //запомнить строку
            int index = dataGridView1.SelectedRows[0].Index;
            if(!GoodData(index)) return;


            //запомнить данные
            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string salary = "0";


            //сосздать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);


            //Отправить запрос
            string cmdText = $"INSERT INTO Staff VALUES('{id}', '{name}', '{age}', {salary}, '{prof}', '{contact}')";

            if (sendRequest(cmdText, dbConection))
            {
                MessageBox.Show("Соискатель успешно нанят!\nНе забудьте записать величину оклада", "Успех");
                Delete_Click(sender, e, false);
            }
            else
            {
                MessageBox.Show("Данные не были добавлены! Попробуйте снова.", "Ошибка");
            }

            loadDatabase();

        }
        //
        //Вспомогательные методы
        //
        private void loadDatabase()
        {

            OleDbConnection dbConection = new OleDbConnection(_conectionStr);
            dbConection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM StaffAg", dbConection);

            OleDbDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear();

            if (reader.HasRows != false)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add
                        (reader["id"], reader["_Name"], reader["_Age"], reader["_Exp"], reader["_Contact"], reader["_Profession"]);
                }
            }
            else
                MessageBox.Show("Не удалось получить данные!", "Ошибка!");

            reader.Close();
            dbConection.Close();
        }
        private void Delete_Click(object sender, EventArgs e, bool giveMess = true)
        {

            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }

            //запомнить строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Проверить заполненность данных
            if (dataGridView1.Rows[index].Cells[0] == null )
            {
                MessageBox.Show("Выберите соискателя, которого хотите удалить из списка!", "Внимание!");
                return;
            }

            //запомнить данные
            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();


            //создать соединение с БД
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);

            //Отправляем запрос
            string cmdText =  $"DELETE FROM StaffAg WHERE id = {id}";

            if (sendRequest(cmdText, dbConection))
            { 
                if(giveMess)
                    MessageBox.Show("Данные удалены!", "Успех"); 
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Соискатель не найден! Попробуйте снова.", "Ошибка");
            }

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
        bool GoodData(in int index)
        {
            
            //Проверить заполненность данных
            if (/*dataGridView1.Rows[index].Cells[0] == null ||*/
                dataGridView1.Rows[index].Cells[1] == null ||
                dataGridView1.Rows[index].Cells[2] == null ||
                dataGridView1.Rows[index].Cells[3] == null ||
                dataGridView1.Rows[index].Cells[4] == null ||
                dataGridView1.Rows[index].Cells[5] == null)
            {
                MessageBox.Show("Не все данные были заполнены!", "Внимание!");
                return false;
            }
            return true;
        }
        private void getID()
        {
            OleDbConnection dbConection = new OleDbConnection(_conectionStr);
            dbConection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM StaffAg", dbConection);

            checkOut(command);

            command.CommandText = "SELECT * FROM Staff";
            checkOut(command);

            void checkOut(OleDbCommand command)
            {
                OleDbDataReader reader = command.ExecuteReader();

                int i = 0;
                if (reader.HasRows != false)
                {
                    while (reader.Read())
                    {
                        i = Convert.ToInt32(reader["id"].ToString());
                        if (i > _id) _id = i;
                    }
                }
                reader.Close();

            }

            dbConection.Close();
        }


    }

}
