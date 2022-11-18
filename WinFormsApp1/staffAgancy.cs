using System.Data.OleDb;
using WinFormsApp1.Person;

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

            //запомнить данные
            string? name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string? age = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string? exp = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string? contact = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string? prof = dataGridView1.Rows[index].Cells[5].Value.ToString();


            int id = DataBase.AddApplicant(name, age, exp, contact, prof);
            dataGridView1.Rows[index].Cells[0].Value = id;

        }//Ready
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

            int.TryParse(id, out int Id);
            MessageBox.Show(DataBase.EditApplicant(Id, name, age, exp, contact, prof));

        }//Ready
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
            loadDatabase();
        }//Ready
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


            MessageBox.Show(DataBase.AddStaff(int.Parse(id), name, age, exp, contact, prof));
            Delete_Click(sender, e, false);

            loadDatabase();

        }//Ready
        //
        //Вспомогательные методы
        //
        private void loadDatabase()
        {
            DataBase.LoadApplicantBase(dataGridView1);
        }//Ready
        private void Delete_Click(object sender, EventArgs e, bool giveMess = true)
        {
                int index = dataGridView1.SelectedRows[0].Index;
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

        }//Ready
        bool GoodData(in int index)
        {
            
            //Проверить заполненность данных
            if (
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
        }//Ready


    }

}
