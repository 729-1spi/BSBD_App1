using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{

 
    public partial class FormNumber : Form
    {
        /// <summary>
        /// Константа длины номера карты
        /// </summary>
        private const int lengthNumberCard = 16;

        /// <summary>
        /// Константа длины CVC кода
        /// </summary>
        private const int lengthKod = 3;

        /// <summary>
        /// Константа цвета поля по умолчанию
        /// </summary>
        private  Color defoltColor = SystemColors.Window;

        private DateTime dateTime = new DateTime(2030, 1, 01);

        DataBase database = new DataBase();
        int SelectedRow;
        public FormNumber()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormNumber f;

        public static FormNumber fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNumber();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        /// <summary>
        /// Создание столбцов в DataGridView
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Номер_счета", "Номер счета");
            dataGridView1.Columns.Add("Код_работника", "Код работника");
            dataGridView1.Columns.Add("Номер_карты", "Номер карты");
            dataGridView1.Columns.Add("Срок_действия", "Срок действия");
            dataGridView1.Columns.Add("Проверочный_код", "Проверочный код");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "MM'/'yy";

           dataGridView1.Columns[5].Visible = false;

        }
        /// <summary>
        /// Функция очистки данных
        /// </summary>
        private void clearFields()
        {
            textbox_id.Text = "";
            textbox_id_worker.Text = "";
            textbox_card.Text = "";
            dateTimePicker.Text = "";
            textbox_kod.Text = "";

        }

        /// <summary>
        /// Функция присваивания типов данных конкретному значению столбца
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt64(2), record.GetDateTime(3), record.GetString(4),RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM Счет";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void FormNumber_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDatagrid(dataGridView1);
        }

        /// <summary>
        /// Метод сопоставления данных из DataGridView в Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Enabled = true;
            SelectedRow = e.RowIndex;
            //Сортировка данных
            if (e.RowIndex >= 0)
            {
                
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                    textbox_id.Text = row.Cells[0].Value.ToString();
                    textbox_id_worker.Text = row.Cells[1].Value.ToString();
                    textbox_card.Text = row.Cells[2].Value.ToString();
                   
                    dateTimePicker.Text = row.Cells[3].Value.ToString();
                    
                    textbox_kod.Text = row.Cells[4].Value.ToString();
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
            SetDefaultColor();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormNewNumber.fw.ShowForm();
        }

        /// <summary>
        /// Функция поиска по DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string search = $"SELECT * FROM Счет WHERE CONCAT (Номер_счета, Код_работника) LIKE  '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(search, database.getConnection());

            database.openConnection();

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
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        /// <summary>
        /// Проверка существования пользователя в БД
        /// </summary>
        /// <returns></returns>
        public Boolean isUserExist()
        {
            DataBase dataBase = new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_работника FROM Работник WHERE Код_работника = @idW";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textbox_id_worker.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {

                return true;

            }
            else
            {
                MessageBox.Show("Работника с данным кодом не существует. Проверьте правильность введенных данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void DeleteNumber()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при удалении данных

                if (rowstate == RowState.Deleted)
                {
                    try
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); //Перевод значения из ячейки в текстовый формат
                        var deletequery = $"DELETE FROM Счет WHERE Номер_счета = {id}";

                        var command = new SqlCommand(deletequery, database.getConnection());
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Удаление счета завершилось с ошибкой. Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
            }
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
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при изменении данных

                if (rowstate == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var id_worker = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var number_card = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var date = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var kod = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    CultureInfo provider = new CultureInfo("fr-FR");
                    DateTime parsedDate = DateTime.ParseExact(date,"MM/yy",provider);
                    DateTime now = new DateTime(2022, 5, 31);

                    if (parsedDate <= now)
                    {
                        MessageBox.Show("Срок действия карты пользователя истёк. \nЕсли это не так, то проверьте правильность введенных данных", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var changequery = $"UPDATE Счет SET Код_работника = '{id_worker}', Номер_карты = '{number_card}', Срок_действия = '{parsedDate}', Проверочный_код = '{kod}' WHERE Номер_счета = '{id}'";

                        var command = new SqlCommand(changequery, database.getConnection());
                        command.ExecuteNonQuery();
                    }

                }
            }
            database.closeConnection();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (panel2.Enabled == false) MessageBox.Show("Вы не выбрали строку для удаления. \nЧтобы выбрать строку кликните по ней один раз",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Вы уверены, что хотите удалить данную строку?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteRow();
                clearFields();
                DeleteNumber();
                RefreshDatagrid(dataGridView1);
                SetDefaultColor();
            }
        }
        /// <summary>
        /// Проверка существования данного счета в БД
        /// </summary>
        /// <returns></returns>
        public Boolean isNumber()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_работника, Номер_карты, Срок_действия, Проверочный_код FROM Счет WHERE" +
                $" Код_работника = @idW AND Номер_карты = @card AND Срок_действия = @date AND Проверочный_код = @code";

            SqlCommand command = new SqlCommand(mainstring, database.getConnection());
            var date = dateTimePicker.Text;
            CultureInfo provider = new CultureInfo("fr-FR");
            DateTime parsedDate = DateTime.ParseExact(date, "MM/yy", provider);
            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textbox_id_worker.Text;
            command.Parameters.Add("@card", SqlDbType.VarChar).Value = textbox_card.Text;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = parsedDate;
            command.Parameters.Add("@code", SqlDbType.VarChar).Value = textbox_kod.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Работник с таким номером карты уже существует. Проверьте правильность введенных данных",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {

                return false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var id = textbox_id.Text;
            var id_worker = textbox_id_worker.Text;
            var number_card = textbox_card.Text;
            var date = dateTimePicker.Text;
            var kod = textbox_kod.Text;

            if (id == "" || id_worker == "" || number_card == "" || date == "" || kod == "")
            {
                MessageBox.Show("Заполните все поля формы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (number_card.Length != 16) MessageBox.Show("Номер карты должен состоять из 16 цифр. Проверьте правильность введенных данных",
                 "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (kod.Length != 3) MessageBox.Show("Проверочный код должен состоять из 3 цифр. Проверьте правильность введенных данных",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (isNumber() == true) return;
            else
            {
                Change();

            }

            newUpdate();
            RefreshDatagrid(dataGridView1);
            clearFields();
            SetDefaultColor();
        }

        /// <summary>
        /// Метод измения данных в DataGridView в зависимости от ввода данных в TextBox
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textbox_id.Text;
            var id_worker = textbox_id_worker.Text;
            var number_card = textbox_card.Text;
            var date = dateTimePicker.Text;
            var kod = textbox_kod.Text;

            // Проверка данных при измении данных в строке
            // Проверка изменения данных в атрибуте Логин

            if (id_worker != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() && isUserExist() == false) return;
            else
            {
                if ((id_worker != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString()) && (id == dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString()) ||
                    id_worker == dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString())

                {
                    //Проверка значения id

                    if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, id_worker, number_card, date, kod);
                        dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                    }
                }
                else
                {
                    MessageBox.Show("Возникла непредвиденная ошибка ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Если роль не выбрана например
                }
            }     

        }

        private void textbox_id_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textbox_id_worker.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textbox_card.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_kod.Text = "";
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void textbox_id_worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number !=8)
            {
                e.Handled = true;
            }
        }

        private void textbox_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textbox_kod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Событие при любом изменении в текстбоксе номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_card_TextChanged(object sender, EventArgs e)
        {
            if (textbox_card.Text.Length != lengthNumberCard)
            {
                textbox_card.BackColor = Color.Coral;
            }
            else
            {
                textbox_card.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Событие при любом изменении в текстбоксе CVC номера карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_kod_TextChanged(object sender, EventArgs e)
        {
            if (textbox_kod.Text.Length != lengthKod)
            {
                textbox_kod.BackColor = Color.Coral;
            }
            else
            {
                textbox_kod.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Задает дефолтные значения / блокирует панель
        /// </summary>
        private void SetDefaultColor ()
        {
            textbox_id_worker.BackColor = defoltColor;
            textbox_card.BackColor = defoltColor;
            textbox_kod.BackColor = defoltColor;
            dateTimePicker.CalendarMonthBackground = defoltColor;
            panel2.Enabled = false;
        }

        private void pictureBox_search_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_search, "Поиск осуществляется по номеру счета и коду работника");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void FormNumber_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
            FormNewNumber.fw.Close();
        }
    }
}
