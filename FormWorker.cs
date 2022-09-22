using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{
    public partial class FormWorker : Form
    {
        DataBase database = new DataBase();
        int SelectedRow;
        public FormWorker()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormWorker f;

        public static FormWorker fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormWorker();
                return f;
            }
        }


        /// <summary>
        /// Создание столбцов в DataGridView
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Код_работника", "Код работника");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Дата_трудоустройства", "Дата трудоустройства");
            dataGridView1.Columns.Add("Должность", "Должность");
            dataGridView1.Columns.Add("Пол", "Пол");
            dataGridView1.Columns.Add("Семейное_положение", "Семейное положение");
            dataGridView1.Columns.Add("Дети", "Дети");
            dataGridView1.Columns.Add("Кол_детей", "Кол-во детей");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[4].DefaultCellStyle.Format = "MM'/'yy";

            dataGridView1.Columns[10].Visible = false;

        }
        /// <summary>
        /// Функция очистки данных
        /// </summary>
        private void clearFields()
        {
            textBox1.Text = "";
            textBox_SecondName.Text = "";
            textBox_Name.Text = "";
            textBox_Dad.Text = "";
            dateTimePicker1.Text = "";
            textBox_Dol.Text = "";
            comboBox_pol.Text = "";
            comboBox_sem.Text = "";
            comboBox_child.Text = "";
            textBox_NumChild.Text = "";

        }

        /// <summary>
        /// Функция присваивания типов данных конкретному значению столбца
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),record.GetDateTime(4),record.GetString(5),record.GetString(6),
                record.GetString(7), record.GetString(8), record.GetInt32(9),RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM Работник";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel2.Enabled == false) MessageBox.Show("Вы не выбрали строку для удаления. \nЧтобы выбрать строку кликните по ней один раз",
                 "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Вы уверены, что хотите удалить данную строку?", "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteRow();
                    clearFields();
                    Delete();
                    RefreshDatagrid(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Неверное удаление. Возможно нет данных для удаления","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            try {
                CreateColumns();
                RefreshDatagrid(dataGridView1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDatagrid(dataGridView1);
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewWorker.fw.ShowForm();
        }

        /// <summary>
        /// Функция поиска по DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string search = $"SELECT * FROM Работник WHERE CONCAT (Код_работника, Фамилия) " +
                $"LIKE  '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(search, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Enabled = true;
            SelectedRow = e.RowIndex;
            //Сортировка данных
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox_SecondName.Text = row.Cells[1].Value.ToString();
                    textBox_Name.Text = row.Cells[2].Value.ToString();
                    textBox_Dad.Text = row.Cells[3].Value.ToString();
                    dateTimePicker1.Text = row.Cells[4].Value.ToString();
                    textBox_Dol.Text = row.Cells[5].Value.ToString();
                    comboBox_pol.Text = row.Cells[6].Value.ToString();
                    comboBox_sem.Text = row.Cells[7].Value.ToString();
                    comboBox_child.Text = row.Cells[8].Value.ToString();
                    textBox_NumChild.Text = row.Cells[9].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Сохраните изменения для повторного редактирования");
                }
                
            }
        }

        /// <summary>
        /// Присваивание значения удаления определенному столбцу
        /// </summary>
        private void deleteRow()
        {
            //Индекс строки, в которой находимся
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            //Если строка пустая, в той ячейке, где создали отдельное поле
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
        }

        public void Delete()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[10].Value;

                if (rowstate == RowState.Existed)
                    continue;
                //Указание действий при удалении данных

                if (rowstate == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deletequery = $"DELETE FROM Работник WHERE Код_работника = {id}";

                    var command = new SqlCommand(deletequery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }
            database.closeConnection();
        }
        /// <summary>
        /// Функция для изменения данных в БД
        /// </summary>
        private void newUpdate()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[10].Value;

                if (rowstate == RowState.Existed)
                    continue;

               
                //Указание действий при изменении данных

                if (rowstate == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var second_name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var dad = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    CultureInfo provider = new CultureInfo("fr-FR");
                    DateTime parsedDate = DateTime.ParseExact(date, "MM/yy", provider);
                    DateTime now = new DateTime(2022, 6, 10);
                    var dol = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var pol = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var sem = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var child = dataGridView1.Rows[index].Cells[8].Value.ToString();
                    var num_child = dataGridView1.Rows[index].Cells[9].Value.ToString();

                    if (parsedDate > now)
                    {
                        MessageBox.Show("Вы не можете указать дату " +
                            "трудоустройства в будущем времени.", 
                            "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var changequery = $"UPDATE Работник SET Фамилия = '{second_name}', " +
                            $"Имя = '{name}', Отчество = '{dad}', " +
                            $"Дата_трудоустройства = '{parsedDate}'" +
                            $", Должность = '{dol}', Пол = '{pol}', " +
                            $"Семейное_положение = '{sem}', Дети = '{child}', " +
                            $"Кол_детей = '{num_child}' WHERE Код_работника = '{id}'";

                        var command = new SqlCommand(changequery, database.getConnection());
                        command.ExecuteNonQuery();
                    }

                }
            }
            database.closeConnection();
        }

        /// <summary>
        /// Метод измения данных в DataGridView в зависимости от ввода данных в TextBox
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox1.Text;
            var second_name = textBox_SecondName.Text;
            var name = textBox_Name.Text;
            var dad = textBox_Dad.Text;
            var date = dateTimePicker1.Text;
            var dol =textBox_Dol.Text;
            var pol = comboBox_pol.Text;
            var sem =comboBox_sem.Text;
            var child = comboBox_child.Text;
            var num_child = textBox_NumChild.Text;

            if (second_name == "" || name == ""  || pol == "" || sem == "" || dol == ""  || child == "" || date == "")
            {
                MessageBox.Show("Заполните все обязательные поля формы! \nОбязательные поля помечены знаком *", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Проверка данных при измении данных в строке
                // Проверка изменения данных в атрибуте Логин

                if ((child == "есть" && num_child == "0")||(child == "есть" && num_child == "")) MessageBox.Show("Укажите количество детей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if ((child == "нет" && num_child != "0")&&(child == "нет" && num_child != "")) MessageBox.Show("Вы указали, что у работника нет детей.\nОставьте поле \"Количество детей\" пустым или укажите значение 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if ((pol.Equals("мужской") && sem.Equals("замужем")) || ((pol.Equals("мужской") && sem.Equals("не замужем")))) MessageBox.Show("Вы указали пол работника мужской," +
                  "следовательно, в поле  \"Семейное положение\" вы можете указать только значения \"холост\" или \"женат\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if ((pol.Equals("женский") && sem.Equals("холост")) || ((pol.Equals("женский") && sem.Equals("женат")))) MessageBox.Show("Вы указали пол работника женский," +
                      "следовательно, в поле  \"Семейное положение\" вы можете указать только значения \"не замужем\" или \"замужем\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                     //Проверка значения id
                     if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                     {
                            dataGridView1.Rows[selectedRowIndex].SetValues(id, second_name, name, dad, date, dol, pol, sem, child, num_child);
                            dataGridView1.Rows[selectedRowIndex].Cells[10].Value = RowState.Modified;
                     }
                    else
                    {
                        MessageBox.Show("Возникла непредвиденная ошибка ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Если роль не выбрана например
                    }
                }

            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Change();
                newUpdate();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void pictureBox_Clear_login_Click(object sender, EventArgs e)
        {
            textBox_SecondName.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_Dad.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox_Dol.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_NumChild.Text = "";
        }

        private void textBox_SecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success 
                && e.KeyChar !=8 && e.KeyChar !=45)
            {
                e.Handled = true;
            }
        }

        private void textBox_Dol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8 && number != 45 && !Char.IsDigit(number) && number !=32)
            {
                e.Handled = true;
            }
        }

        private void textBox_NumChild_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
         if
           (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "мужской")
            e.CellStyle.BackColor = Color.LightGreen;
         else
            e.CellStyle.BackColor = Color.LightCoral;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox1, "Поиск осуществляется по коду работника и его фамилии");
        }
    }
}
