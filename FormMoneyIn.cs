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
    public partial class FormMoneyIn : Form
    {
        public FormMoneyIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }
        DataBase database = new DataBase();
        int SelectedRow;

        /// <summary>
        /// Константа цвета поля по умолчанию
        /// </summary>
        private Color defoltColor = SystemColors.Window;

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormMoneyIn f;

        public static FormMoneyIn fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMoneyIn();
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
            dataGridView1.Columns.Add("Номер_выплаты", "Номер выплаты");
            dataGridView1.Columns.Add("Код_работника", "Код работника");
            dataGridView1.Columns.Add("Оклад", "Оклад");
            dataGridView1.Columns.Add("Стим_выплаты", "Стимулирующие выплаты");
            dataGridView1.Columns.Add("Ком_выплаты", "Компенсационные выплаты");
            dataGridView1.Columns.Add("Доплаты", "Доплаты");
            dataGridView1.Columns.Add("Прочие_выплаты", "Прочие выплаты");
            dataGridView1.Columns.Add("Р_коэф", "Районный коэффициент");
            dataGridView1.Columns.Add("Начислено", "Начислено");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[2].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#0.00 руб.";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "#0.00 руб.";



            dataGridView1.Columns[9].Visible = false;

        }

        /// <summary>
        /// Функция очистки данных
        /// </summary>
        private void clearFields()
        {
            textbox_Id.Text = "";
            textbox_Id_worker.Text = "";
            textbox_Oklad.Text = "";
            textbox_Kom.Text = "";
            textBox_Stim.Text = "";
            textBox_Dop.Text = "";
            textBox_Proch.Text = "";
            textBox_R.Text = "";

        }
        /// <summary>
        /// Функция присваивания типов данных конкретному значению столбца
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDecimal(2), 
                record.GetDecimal(3), record.GetDecimal(4), record.GetDecimal(5), 
                record.GetDecimal(6), record.GetDecimal(7), record.GetDecimal(8), 
                RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM Выплаты";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormNewMoneyIn.fw.ShowForm();
        }

        private void FormMoneyIn_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDatagrid(dataGridView1);
            panel2.Enabled = false;
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
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                textbox_Id.Text = row.Cells[0].Value.ToString();
                textbox_Id_worker.Text = row.Cells[1].Value.ToString();
                textbox_Oklad.Text = row.Cells[2].Value.ToString();
                textBox_Stim.Text = row.Cells[3].Value.ToString();
                textbox_Kom.Text = row.Cells[4].Value.ToString();
                textBox_Dop.Text = row.Cells[5].Value.ToString();
                textBox_Proch.Text = row.Cells[6].Value.ToString();
                textBox_R.Text = row.Cells[7].Value.ToString();


            }
        }
        /// <summary>
        /// Функция поиска по DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string search = $"SELECT * FROM Выплаты WHERE Код_работника" +
                $" LIKE  '%" + textBox_search.Text + "%'";

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
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
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
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textbox_Id_worker.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {

                return true;

            }
            else
            {
                MessageBox.Show("Работника с данным кодом не существует. " +
                    "Проверьте правильность введенных данных", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
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
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при изменении данных

                if (rowstate == RowState.Modified)
                {
                    try
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var id_worker = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var oklad = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var stim = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var kom = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var dop = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var proch = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var r = dataGridView1.Rows[index].Cells[7].Value.ToString();
                        var sum = dataGridView1.Rows[index].Cells[8].Value.ToString();

                        if (stim == "0.00") stim = "0";
                        if (kom == "0.00") kom = "0";
                        if (dop == "0.00") dop = "0";
                        if (proch == "0.00") proch = "0";
                        if (r == "1.00") r = "1";

                        var changequery = $"UPDATE Выплаты SET Код_работника = '{id_worker}', " +
                            $"Оклад = {oklad}, Стим_выплаты = {stim}, Ком_выплаты = {kom}, Доплаты = {dop}," +
                            $" Прочие_выплаты = {proch}, Р_коэф = {r} WHERE Номер_выплаты = '{id}'";

                        var changequery1 = $"UPDATE Отчисления SET Код_работника = '{id_worker}', " +
                            $"Начислено = {sum} WHERE Номер_выплаты = '{id}'";
                        var changequery2 = $"UPDATE История_заработной_платы SET Код_работника = '{id_worker}'," +
                            $" Начислено = {sum} WHERE Номер_выплаты = '{id}'";
                        var command = new SqlCommand(changequery, database.getConnection());
                        var command1 = new SqlCommand(changequery1, database.getConnection());
                        var command2 = new SqlCommand(changequery2, database.getConnection());
                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                    }
                    catch
                    {
                     MessageBox.Show("Неверный формат ввода числовых данных в поля. " +
                     "\nВозможно при указании значений вы ввели несколько раз подряд \"...\". " +
                     "\nПроверьте правильность введенных данных!!!", "Ошибка",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }
            database.closeConnection();
        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDatagrid(dataGridView1);
            clearFields();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        public void DeleteMoney()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при удалении данных

                if (rowstate == RowState.Deleted)
                {
                    try
                    {
                        //Перевод значения из ячейки в числовой формат
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value); 
                        var deletequery = $"DELETE FROM Выплаты WHERE Номер_выплаты = {id}";
                        var query = $"DELETE FROM Отчисления WHERE Номер_выплаты = {id}";

                        var command = new SqlCommand(deletequery, database.getConnection());
                        var command1 = new SqlCommand(query, database.getConnection());

                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Для того,чтобы удалить выплату необходимо" +
                            " удалить все истории зарплаты работников, " +
                            "связанные с этой выплатой!" +
                            "\nТолько после этого вы можете удалить " +
                            "выплату", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                       
                    
                    
                }
            }
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel2.Enabled == false) MessageBox.Show("Вы не выбрали строку" +
                " для удаления. \nЧтобы выбрать строку кликните по ней один раз",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Вы уверены, что хотите удалить " +
                    "данную строку?", "Внимание", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteRow();
                    clearFields();
                    DeleteMoney();
                    RefreshDatagrid(dataGridView1);
                }
            }
            catch
            {
                MessageBox.Show("Удаление завершилось с ошибкой. Возможно нет данных для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var oklad = textbox_Oklad.Text;
            try
            {
                if (panel2.Enabled == false)
                {
                    MessageBox.Show("Для того, чтобы сохранить изменения их нужно сначала внести." +
                        "\nКликните по нужной ячейке и в панели редактирования измените значения." +
                        "\nПлмните, что от изменения данных в форме зависят изменения в форме \"Отчисления\" и \"История заработной платы\"",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (oklad == "")
                {
                    MessageBox.Show("Заполните обязательное поле \"Оклад\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (isUserExist() == false) return;
                else if (Convert.ToDecimal(oklad) < 13890) MessageBox.Show("Оклад не может быть меньше установленного МРОТ на 2022 г \nМРОТ на 2022 г. = 13890 руб.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Change();
                    
                }
                newUpdate();
                RefreshDatagrid(dataGridView1);
                clearFields();                
                SetDefaultColor();

            }
            catch
            {
                MessageBox.Show("Неверный формат данных в поля. " +
                            "\nВозможно при указании значений вы ввели несколько раз подряд \"...\". " +
                            "\nПроверьте правильность введенных данных!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        /// <summary>
        /// Задает дефолтные значения / блокирует панель
        /// </summary>
        private void SetDefaultColor()
        {
            textbox_Id_worker.BackColor = defoltColor;
            textbox_Oklad.BackColor = defoltColor;
            textBox_Stim.BackColor = defoltColor;
            textbox_Kom.BackColor = defoltColor;
            textBox_Proch.BackColor = defoltColor;
            textBox_Dop.BackColor = defoltColor;
            textBox_R.BackColor = defoltColor;
            panel2.Enabled = false;
        }


        /// <summary>
        /// Метод измения данных в DataGridView в зависимости от ввода данных в TextBox
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textbox_Id.Text;
            var id_worker = textbox_Id_worker.Text;
            var oklad = textbox_Oklad.Text;
            var stim = textBox_Stim.Text;
            var kom = textbox_Kom.Text;
            var dop = textBox_Dop.Text;
            var proch = textBox_Proch.Text;
            var r = textBox_R.Text;
            
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
                        try
                        {
                            if (stim == "") stim = "0.00";
                            if (kom == "") kom = "0.00";
                            if (dop == "") dop = "0.00";
                            if (proch == "") proch = "0.00";
                            if (r == "") r = "1.00";
                            if (Convert.ToDecimal(r) < 1 || Convert.ToDecimal(r) > 2) MessageBox.Show("Значение районного коэффициента не может быть меньше 1 и больше 2. \nПроверьте правильность вводимых данных",
                   "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                            {
                                var sum = (Convert.ToDecimal(oklad) + Convert.ToDecimal(stim) + Convert.ToDecimal(kom) +
                   Convert.ToDecimal(dop) + Convert.ToDecimal(proch)) * Convert.ToDecimal(r);
                                dataGridView1.Rows[selectedRowIndex].SetValues(id, id_worker, oklad, stim, kom, dop, proch, r, sum);
                                dataGridView1.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Неверный формат ввода числовых данных в поля. " +
                           "\nВозможно при указании значений вы ввели несколько раз подряд \"...\". " +
                           "\nПроверьте правильность введенных данных!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Возникла непредвиденная ошибка ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Если роль не выбрана например
                }
            }

        }

        private void textbox_Oklad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number !=46)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textbox_Oklad.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_Stim.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_Kom.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_Dop.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_Proch.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox_R.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textbox_Id_worker.Text = "";
        }

        private void FormMoneyIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
            FormNewMoneyIn.fw.Close();
        }
    }
}
