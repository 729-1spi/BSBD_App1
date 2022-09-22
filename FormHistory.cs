using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{
    public partial class FormHistory : Form
    {
        DataBase dataBase = new DataBase();
        int SelectedRow;
        /// <summary>
        /// Константа цвета поля по умолчанию
        /// </summary>
        private Color defoltColor = SystemColors.Window;

        public FormHistory()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormHistory f;

        public static FormHistory fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormHistory();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        /// <summary>
        /// Функция очистки данных
        /// </summary>
        private void clearFields()
        {
            textbox_id.Text = "";
            textBox_num.Text = "";
            textBox_id_worker.Text = "";
            textBox_id_acc.Text = "";
            textBox_child.Text = "";
            textbox_plata.Text = "";

        }


        /// <summary>
        /// Создание столбцов в DataGridView
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Код_истории_зп", "Код истории заработной платы");
            dataGridView1.Columns.Add("Номер_выплаты", "Номер выплаты");
            dataGridView1.Columns.Add("Код_работника", "Код работника");
            dataGridView1.Columns.Add("Код_бухгалтера", "Код бухгалтера");
            dataGridView1.Columns.Add("Начислено", "Начислено");
            dataGridView1.Columns.Add("Вычет_на_детей", "Вычет на детей");
            dataGridView1.Columns.Add("НДФЛ", "НДФЛ");
            dataGridView1.Columns.Add("Итоговая_зп", "Итоговая зарплата работника");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[4].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "#0.00 руб.";

            dataGridView1.Columns[8].Visible = false;
        }


        /// <summary>
        /// Функция присваивания типов данных конкретному значению столбца
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetDecimal(4), record.GetDecimal(5),
                record.GetDecimal(6), record.GetDecimal(7), RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM История_заработной_платы";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        /// <summary>
        /// Проверка существования бухгалтера в БД
        /// </summary>
        /// <returns></returns>
        public Boolean IsAccount()
        {
            DataBase dataBase = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_бухгалтера FROM Бухгалтер WHERE " +
                $"Код_бухгалтера = @idAcc";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@idAcc", SqlDbType.VarChar).Value = textBox_id_acc.Text;



            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {

                return true;

            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных \nДанного бухгалтера не существует! \nОбратитесь к главному бухгалтеру",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                var num = textBox_num.Text;
                var id_worker = textBox_id_worker.Text;
                var id_acc = textBox_id_acc.Text;
                var plata = textbox_plata.Text;
                var child = textBox_child.Text;

                if (child == "")
                {
                    child = "0";

                }
                var child2 = Convert.ToDecimal(child);
                if (num == "" || id_worker == "" || id_acc == "" || plata == "")
                {
                    MessageBox.Show("Заполните все обязательные поля формы! \nОбязательные поля формы помечены знаком \"*\"" +
                        "\nЕсли вы не ввели значения в поле \"Вычет на детей\" то в данном поле по умолчанию устанавливается значение 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsMoneyIn() == false || IsExist() == true || IsAccount() == false) return;
                else if (IsChild() == true && child2 < 1400)
                {
                    MessageBox.Show("Работник, которого вы выбрали имеет детей. Значение в поле " +
        "\"Вычет на детей\" должно быть не менее 1400", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (IsChild() == false && child2 != 0)
                {
                    MessageBox.Show("Работник, которого вы выбрали не имеет детей. Не заполняйте поле " +
        "\"Вычет на детей\" или укажите значение 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand command = new SqlCommand($"INSERT INTO История_заработной_платы(Номер_выплаты,Код_работника, Код_бухгалтера, Начислено, Вычет_на_детей) VALUES (@num,@id_work,@id_acc,@plata, @child)", dataBase.getConnection());

                    command.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                    command.Parameters.Add("@id_work", SqlDbType.VarChar).Value = id_worker;
                    command.Parameters.Add("@id_acc", SqlDbType.VarChar).Value = id_acc;
                    command.Parameters.Add("@plata", SqlDbType.VarChar).Value = plata;
                    command.Parameters.Add("@child", SqlDbType.VarChar).Value = child;
                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("История заработной платы была успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("История заработной платы не была добавлена. Возникли ошибки. Обратитесь к главному бухгалтеру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataBase.closeConnection();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка источника данных. \nПроверьте правильность введенных данных" +
                   "\nВозможно вы ввели несколько ряд подряд \"...\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDatagrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            //Сортировка данных
            if (e.RowIndex >= 0)
            {

                try
                {
                    DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                    row.Cells[0].Value.ToString();
                    row.Cells[1].Value.ToString();
                    row.Cells[2].Value.ToString();
                    row.Cells[3].Value.ToString();
                    row.Cells[4].Value.ToString();
                    row.Cells[5].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("Неверный формат данных. \nСохраните данные перед их повторным изменением", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDatagrid(dataGridView1);
            clearFields();
        }

        /// <summary>
        /// Функция поиска по DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string search = $"SELECT * FROM История_заработной_платы WHERE CONCAT(Номер_выплаты,Код_работника ) LIKE  '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(search, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgv, read);
            }
            read.Close();

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
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
        }

        /// <summary>
        /// Проверка существования выплаты для работника в БД
        /// </summary>
        /// <returns></returns>
        public Boolean IsMoneyIn()
        {
            DataBase dataBase = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Номер_выплаты, Код_работника, Начислено FROM Выплаты WHERE " +
                $"Номер_выплаты = @num AND Код_работника = @idW AND Начислено = @sum ";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = textBox_num.Text;
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;
            command.Parameters.Add("@sum", SqlDbType.VarChar).Value = textbox_plata.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {

                return true;

            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных \nВозможно данному работнику не были назначены выплаты" +
                    " или вы указали неверную сумму начислений", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// Функция удаления данных из БД
        /// </summary>
        public void DeleteHistory()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowstate == RowState.Existed)
                    continue;
                //Указание действий при удалении данных

                if (rowstate == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); //Перевод значения из ячейки в текстовый формат
                    var deletequery = $"DELETE FROM История_заработной_платы WHERE Код_истории_зп = {id}";

                    var command = new SqlCommand(deletequery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btn_Del_Click(object sender, EventArgs e)
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
                    DeleteHistory();
                    RefreshDatagrid(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Удаление строки завершилось с ошибкой. Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// Проверка существования детей у работника
        /// </summary>
        /// <returns></returns>
        public Boolean IsChild()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_работника, Дети FROM Работник WHERE " +
                $"Код_работника = @work AND Дети = 'есть'";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@work", SqlDbType.VarChar).Value = textBox_id_worker.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {                
                return true;
            }
            else
            {   
                return false;
            }
        }
        
       
       
        /// <summary>
        /// Проверка существования истории заработной платы для работника в БД
        /// </summary>
        /// <returns></returns>
        public Boolean IsExist()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Номер_выплаты,Код_работника,Начислено, Вычет_на_детей FROM История_заработной_платы WHERE " +
                $"Номер_выплаты = @num AND Код_работника = @work AND Начислено = @plata AND Вычет_на_детей = @child";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = textBox_num.Text;
            command.Parameters.Add("@work", SqlDbType.VarChar).Value = textBox_id_worker.Text;
            command.Parameters.Add("@plata", SqlDbType.VarChar).Value = textbox_plata.Text;
            command.Parameters.Add("@child", SqlDbType.VarChar).Value = textBox_child.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Данная история заработной платы уже была составлена. \nВозможно вы не внесли измененения в панели редактирования" +
                    "\nПовторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }
            else
            {
                return false;
            }
        }

        private void pictureBox_search_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_search, "Поиск осуществляется по номеру выплаты и коду работника");
        }

        private void textbox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textbox_plata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textbox_id.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_id_worker.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_id_acc.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_plata.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_child.Text = "";
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMoneyIn.fw.ShowForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void FormHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox_num.Text = "";
        }
    }
}
