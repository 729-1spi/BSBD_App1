using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{

    enum RowState
    {
        Existed,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class FormAccountant : Form
    {
        DataBase database = new DataBase();
        int SelectedRow;

        ClassMD5 mD5 = new ClassMD5();
        public FormAccountant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Константа цвета поля по умолчанию
        /// </summary>
        private Color defoltColor = SystemColors.Window;

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormAccountant f;

        public static FormAccountant fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAccountant();
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
            dataGridView1.Columns.Add("Код_бухгалтера", "Код бухгалтера");
            dataGridView1.Columns.Add("Логин", "Логин");
            dataGridView1.Columns.Add("Пароль", "Пароль");
            dataGridView1.Columns.Add("Роль", "Роль");
            dataGridView1.Columns.Add("isNew", String.Empty);

            dataGridView1.Columns[4].Visible = false;

        }

        /// <summary>
        /// Функция очистки данных
        /// </summary>
        private void clearFields()
        {
            textBox_id.Text = "";
            textBox_login.Text = "";
            textBox_password.Text = "";
            comboBox_rule.Text = "";

        }

        /// <summary>
        /// Функция присваивания типов данных конкретному значению столбца
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataReader record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),record.GetString(3),RowState.ModifiedNew);
        }

        /// <summary>
        /// Вывод всех строк из БД
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDatagrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string querystring = $"SELECT * FROM Бухгалтер";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void FormAccountant_Load(object sender, EventArgs e)
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
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_login.Text = row.Cells[1].Value.ToString();
                textBox_password.Text = row.Cells[2].Value.ToString();
                comboBox_rule.Text = row.Cells[3].Value.ToString();

            }
        }

        /// <summary>
        /// Обновление данных в DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDatagrid(dataGridView1);
            clearFields();
            SetDefaultColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrAc registr = new FormRegistrAc();
            registr.ShowForm();
        }

        /// <summary>
        /// Функция поиска по DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string search = $"SELECT * FROM Бухгалтер WHERE CONCAT (Код_бухгалтера, Логин) LIKE  '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(search, database.getConnection());

            database.openConnection();

            SqlDataReader read = command.ExecuteReader();

            while(read.Read())
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
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
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
           string mainstring = $"SELECT Код_бухгалтера, Логин, Пароль, Роль FROM Бухгалтер WHERE Логин = @uL";
       
           SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());
       
           //Покрытие данных для безопасности (заглушки)
           command.Parameters.Add("@uL", SqlDbType.VarChar).Value = textBox_login.Text;
       
           adapter.SelectCommand = command;
           adapter.Fill(table);
       
           //Проверка существования пользователя и его роли
           if (table.Rows.Count == 1)
           {                
               
             MessageBox.Show("Аккаунт с данным логином уже существует. Введите другой логин", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             return true;                  
       
           }
           else
           {
               return false;
           }
       }

        /// <summary>
        /// Функция для изменения данных в БД
        /// </summary>
        private void newUpdate()
        {
            database.openConnection();
            for(int index = 0; index < dataGridView1.Rows.Count;index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при изменении данных

                if (rowstate == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var login = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var password = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var rule = dataGridView1.Rows[index].Cells[3].Value.ToString();

                    var changequery = $"UPDATE Бухгалтер SET Логин = '{login}', Пароль = '{password}', Роль = '{rule}' WHERE Код_бухгалтера = '{id}'";

                    var command = new SqlCommand(changequery, database.getConnection());
                    command.ExecuteNonQuery();
                    
                }
            }
            database.closeConnection();
        }
        
        /// <summary>
        /// Функция поиска данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        public void DeleteAcc()
        {
            database.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                //Значение поля RowState
                var rowstate = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowstate == RowState.Existed)
                    continue;

                //Указание действий при удалении данных

                if (rowstate == RowState.Deleted)
                {
                    try
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        if (id == 15) MessageBox.Show("Вы не можете удалить главного бухгалтера","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        else
                        {
                            var deletequery = $"DELETE FROM Бухгалтер WHERE Код_бухгалтера = {id}";

                            var command = new SqlCommand(deletequery, database.getConnection());
                            command.ExecuteNonQuery();
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Удаление строки завершилось с ошибкой. Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
            }
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
                    DeleteAcc();
                    RefreshDatagrid(dataGridView1);
                    SetDefaultColor();
                }
            }
            catch
            {
                MessageBox.Show("Удаление строки завершилось с ошибкой. Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        /// <summary>
        /// Задает дефолтные значения / блокирует панель
        /// </summary>
        private void SetDefaultColor()
        {
            textBox_login.BackColor = defoltColor;
            textBox_password.BackColor = defoltColor;
            comboBox_rule.BackColor = defoltColor;
            panel2.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var id = textBox_id.Text;
            var login = textBox_login.Text;
            var password = mD5.hashPassword(textBox_password.Text);
            var rule = comboBox_rule.Text;
            if (login == "" || password == "D41D8CD98F00B204E9800998ECF8427E" || rule == "")
            {
                MessageBox.Show("Заполните все поля формы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Change();
                newUpdate();
                clearFields();
                RefreshDatagrid(dataGridView1);
                SetDefaultColor();
            }
            

        }

        /// <summary>
        /// Метод измения данных в DataGridView в зависимости от ввода данных в TextBox
        /// </summary>
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var login = textBox_login.Text;
            var password = mD5.hashPassword(textBox_password.Text);
            var rule = comboBox_rule.Text;
            
            // Проверка данных при измении данных в строке
            // Проверка изменения данных в атрибуте Логин

            if (login != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() && isUserExist()) return;
            else
            {
                if ((login != dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString()) && (id == dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString())||
                    login == dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString())

                {
                    //Проверка значения id

                    if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        dataGridView1.Rows[selectedRowIndex].SetValues(id, login, password, rule);
                        dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка источника данных. Проверьте правильность введенных данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Если роль не выбрана например
                }
            }
                
            
 
        }

        /// <summary>
        /// Функция очистки всех данных в TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void pictureBox_Clear_pass_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
        }

        private void pictureBox_Clear_login_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char login = e.KeyChar;
            if (((login < 32) || (login > 45)) && (login != 47) && ((login <= 58) || (login > 63)) && ((login < 91) || (login >= 97)) && (login < 123) || ((login >= 192) && (login <= 255)) ||
                ((login >= 1040) && (login <= 1103)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void pictureBox_inf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В поле \"Пароль\" находится значение хеша пароля. \nДля того, чтобы изменить данные очистите поле \"Пароль\". " +
                "\nЗатем введите необходимое значение и нажмите кнопку \"Сохранить изменения\". " +
                "\nДалее просмотрите значение хеша. Если хеш пароля отличается от прежнего, следовательно, пароль успешно изменен.", 
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pictureBox_search, "Поиск осуществляется по коду бухгалтера и его логину");
        }

        private void FormAccountant_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы уверены, что хотите закрыть форму?", "Внимание", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes;
            FormRegistrAc.fw.Close();
        }

        /// <summary>
        /// Запрет ввода символов для предотвращения SQL-инъекций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pass = e.KeyChar;
            if (pass == 34 || pass == 39 || pass ==44 || pass == 96 || pass == 32 || pass == 47 ||
                pass == 37 || pass == 95 || ((pass >= 1040) && (pass <= 1103)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
