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
    public partial class FormDeductions : Form
    {
        DataBase database = new DataBase();
        int SelectedRow;
        public FormDeductions()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }
        /// <summary>
        /// Константа цвета поля по умолчанию
        /// </summary>
        private Color defoltColor = SystemColors.Window;

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormDeductions f;

        public static FormDeductions fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormDeductions();
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
            textBox_id_worker.Text = "";
            textBox_num.Text = "";
            textbox_plata.Text = "";

        }

        /// <summary>
        /// Создание столбцов в DataGridView
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Номер_отчисления", "Номер отчисления");
            dataGridView1.Columns.Add("Код_работника", "Код работника");
            dataGridView1.Columns.Add("Номер_выплаты", "Номер выплаты");
            dataGridView1.Columns.Add("Начислено", "Начислено");
            dataGridView1.Columns.Add("Мед_отчисл", "Медицинские отчисления");
            dataGridView1.Columns.Add("Соц_отчисл", "Социальные отчисления");
            dataGridView1.Columns.Add("Пенс_отчисл", "Пенсионные отчисления");
            dataGridView1.Columns.Add("ФСС_отчисл", "ФСС отчисления");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[3].DefaultCellStyle.Format = "#0.00 руб.";
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
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetDecimal(3), record.GetDecimal(4), 
                record.GetDecimal(5), record.GetDecimal(6), record.GetDecimal(7), RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM Отчисления";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
       
        private void btn_New_Click(object sender, EventArgs e)
        {
            FormNewDeduction.fw.ShowForm();
        }

        private void FormDeductions_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDatagrid(dataGridView1);
        }

        private void textbox_id_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод сопоставления данных из DataGridView в Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                    textbox_id.Text = row.Cells[0].Value.ToString();
                    textBox_id_worker.Text = row.Cells[1].Value.ToString();
                    textBox_num.Text = row.Cells[2].Value.ToString();
                    textbox_plata.Text = row.Cells[3].Value.ToString();
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

            string search = $"SELECT * FROM Отчисления WHERE Код_работника LIKE  '%" + textBox_search.Text + "%'";

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
        public void DeleteDeduct()
        {
            database.openConnection();
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
                    var deletequery = $"DELETE FROM Отчисления WHERE Номер_отчисления = {id}";

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
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при изменении данных

                if (rowstate == RowState.Modified)
                {
                    try
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var id_worker = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var num = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var plata = dataGridView1.Rows[index].Cells[3].Value.ToString();

                        var changequery = $"UPDATE Отчисления SET Код_работника = '{id_worker}', Номер_выплаты = '{num}', Начислено = {plata} WHERE Номер_отчисления = '{id}'";

                        var command = new SqlCommand(changequery, database.getConnection());
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Неверный формат ввода числовых данных в поля. " +
                            "\nВозможно при указании значений вы ввели несколько раз подряд \"...\". " +
                            "\nПроверьте правильность введенных данных!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (panel2.Enabled == false) MessageBox.Show("Вы не выбрали строку для удаления. \nЧтобы выбрать строку кликните по ней один раз",
                 "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Вы уверены, что хотите удалить данную строку?", "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteRow();
                    clearFields();
                    DeleteDeduct();
                    RefreshDatagrid(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Удаление завершилось с ошибкой. Возможно нет данных для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        /// <summary>
        /// Метод измения данных в DataGridView в зависимости от ввода данных в TextBox
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textbox_id.Text;
            var id_worker = textBox_id_worker.Text;
            var num = textBox_num.Text;
            var plata = textbox_plata.Text;

            // Проверка данных при измении данных в строке
            // Проверка изменения данных в атрибуте Логин
            try
            {
                if ((id_worker != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() && IsMoneyIn() == false) ||
                   (id_worker == dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() && IsMoneyIn() == false))
                {
                    return;
                }
                else
                {
                    if ((id_worker != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString()) && (id == dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString()) ||
                        id_worker == dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString())

                    {
                        //Проверка значения id

                        if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                        {
                            dataGridView1.Rows[selectedRowIndex].SetValues(id, id_worker, num, plata);
                            dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Проверьте правильность введенных данных.\nВозможно вы не выбрали ячейку, которую нужно отредактировать", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Если роль не выбрана например
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат ввода числовых данных в поля. " +
                           "\nВозможно при указании значений вы ввели несколько раз подряд \"...\". " +
                           "\nПроверьте правильность введенных данных!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       

        }
        /// <summary>
        /// Проверка существования отчисления для работника в БД
        /// </summary>
        /// <returns></returns>
        public Boolean IsExist()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Номер_выплаты, Код_работника FROM Отчисления WHERE " +
                $"Номер_выплаты = @num AND Код_работника = @idW AND Начислено = @plata";

            SqlCommand command = new SqlCommand(mainstring, database.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = textBox_num.Text;
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;
            command.Parameters.Add("@plata", SqlDbType.VarChar).Value = textbox_plata.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Данные отчисления уже были внесены. \nВозможно вы не внесли измененения в панели редактирования" +
                    "\nПовторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }
            else
            {
                return false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var id = textbox_id.Text;
                var id_worker = textBox_id_worker.Text;
                var num = textBox_num.Text;
                var plata = textbox_plata.Text;
                if(panel2.Enabled == false)
                {
                    MessageBox.Show("Для того, чтобы сохранить изменения их нужно сначала внести." +
                        "\nКликните по нужной ячейке и в панели редактирования измените значения." +
                        "\nДанные в форме зависят от формы \"Выплаты\", будьте внимательны при внесении изменений!", 
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (id_worker == "" || num == "" || plata == "")
                {
                    MessageBox.Show("Заполните все поля формы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsExist() == true) return;
                else
                {
                    Change();
                    //clearFields();
                }
                newUpdate();
                RefreshDatagrid(dataGridView1);
                clearFields();
                SetDefaultColor();
            }
            catch
            {
                MessageBox.Show("Ошибка источника данных. \nПроверьте правильность введенных данных" +
                    "\nВозможно вы ввели несколько ряд подряд \"...\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        /// <summary>
        /// Задает дефолтные значения / блокирует панель
        /// </summary>
        private void SetDefaultColor()
        {
            textbox_id.BackColor = defoltColor;
            textBox_id_worker.BackColor = defoltColor;
            textBox_num.BackColor = defoltColor;
            textbox_plata.BackColor = defoltColor;
            panel2.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_worker_KeyPress(object sender, KeyPressEventArgs e)
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
            textBox_id_worker.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_num.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textbox_plata.Text = "";
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void pictureBox_search_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_search, "Поиск осуществляется по коду работника");
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMoneyIn.fw.ShowForm();
        }

        private void FormDeductions_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
            FormNewDeduction.fw.Close();

           
        }
    }
}
