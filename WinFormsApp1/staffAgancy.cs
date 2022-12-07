using System.Data.OleDb;
using WinFormsApp1.DBprocess;

namespace WinFormsApp1
{
    public partial class staffAgancy : Form
    {

        public staffAgancy()
        {
            InitializeComponent();
            LoadDatabase();
        }
        //
        //Кнопки панели меню
        //
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение создано для упрощения работы HR-менеджера.\nПриятного пользования!", "О Программе");
        }
        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDatabase();
        }
        private void штатСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffForm form = new staffForm();

            form.ShowDialog();
            //this.Visible = false;
            this.Show();
            LoadDatabase();

            

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!DataBase.AllDataSaved())
            {
                DataBase.SaveData();
            }
        }
        //
        //Описание кнопок
        //
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                return;
            }


            //запомнить строку
            int index = dataGridView1.SelectedRows[0].Index;
            if (!GoodData(index))
                return;

            //Проверка уникальности
            string? _id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if(_id != null)
            {
                MessageBox.Show("Вы пытаетесь добавить человека, который уже есть в списке", "Внимание!");
                return;
            }

            //запомнить данные
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();

            if(!int.TryParse(exp, out int i))
            {
                MessageBox.Show("Введите числовове значение!", "Ошибка! Поле: Стаж работы");
                return ;
            }

            foreach(var c in age)
                if(char.IsDigit(c)) a++;
            if(a < age.Length / 2)
            {
                MessageBox.Show("Некорректно указан год рождения", "Ошибка!");
                return;
            }



            int id = DataBase.AddApplicant(name, age, exp, contact, prof);
            dataGridView1.Rows[index].Cells[0].Value = id;

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
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Произошла ошибка!\nВероятно вы не добавили соискателя. Попробуйте снова", "Ошибка");
                return;
            }

            //запомнить данные
            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();

            int.TryParse(id, out int Id);
            MessageBox.Show(DataBase.EditApplicant(Id, name, age, exp, contact, prof));

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);

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
            if(dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Произошла ошибка!\nВероятно вы не добавили соискателя. Попробуйте снова", "Ошибка");
                return ;
            }


            //запомнить данные
            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();


            MessageBox.Show(DataBase.AddStaff(int.Parse(id), name, age, exp, contact, prof));
            Delete_Click(sender, e, false);

        }
        //
        //Вспомогательные методы
        //
        private void LoadDatabase()
        {
            DataBase.LoadApplicantBase(dataGridView1);
        }
        private void Delete_Click(object sender, EventArgs e, bool giveMess = true)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Произошла ошибка!\nВероятно вы не добавили соискателя. Попробуйте снова", "Ошибка");
                return;
            }

            string? id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            if (giveMess)
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Пожалуйста, выберите одну строку", "Внимание!");
                    return;
                }

                //запомнить строку

                //Проверить заполненность данных
                if (dataGridView1.Rows[index].Cells[0] == null)
                {
                    MessageBox.Show("Выберите соискателя, которого хотите удалить из списка!", "Внимание!");
                    return;
                }

                //запомнить данные
                MessageBox.Show(DataBase.DeleteApplicant(int.Parse(id)));
            }
            else
                DataBase.DeleteApplicant(int.Parse(id));

            LoadDatabase();

        }
        bool GoodData(int index)
        {
            
            //Проверить заполненность данных
            if (
                dataGridView1.Rows[index].Cells[1].Value == null || 
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные были заполнены!", "Внимание!");
                return false;
            }
            return true;
        }
        private void staffAgancy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataBase.AllDataSaved())
            {
                SaveDataDialog sd = new(this, e);
                sd.ShowDialog();
                sd.Location = new Point(0, 1000);
            }
        }

    }

}
