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
    public partial class FormNewNumber : Form
    {
        DataBase dataBase = new DataBase();

        /// <summary>
        /// Константа длины номера карты
        /// </summary>
        private const int lengthNumberCard = 16;

        /// <summary>
        /// Константа длины CVC кода
        /// </summary>
        private const int lengthKod = 3;

        public FormNewNumber()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormNewNumber f;

        public static FormNewNumber fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNewNumber();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
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
            string mainstring = $"SELECT Код_работника, Номер_карты FROM Счет WHERE Код_работника = @idW AND Номер_карты = @card";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;
            command.Parameters.Add("@card", SqlDbType.VarChar).Value = textBox_card.Text;

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


        /// <summary>
        /// Проверка существования пользователя в БД
        /// </summary>
        /// <returns></returns>
        public Boolean isUserExist()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_работника FROM Работник WHERE Код_работника = @idW";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            var id_worker = textBox_id_worker.Text;
            var num_card = textBox_card.Text;
            var date = dateTimePicker.Text;
            var kod = textBox_kod.Text;
            CultureInfo provider = new CultureInfo("fr-FR");
            DateTime parsedDate = DateTime.ParseExact(date, "MM/yy", provider);
            DateTime now = new DateTime(2022,5,31);


            if (id_worker == "" || num_card == "" || date == "" || kod =="")
            {
                MessageBox.Show("Вы заполнили не все поля формы! Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(num_card.Length != 16) MessageBox.Show("Номер карты должен состоять из 16 цифр. Проверьте правильность введенных данных",
                 "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(kod.Length != 3) MessageBox.Show("Проверочный код должен состоять из 3 цифр. Проверьте правильность введенных данных",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(parsedDate <= now) MessageBox.Show("Срок действия карты пользователя истёк. \nЕсли это не так, то проверьте правильность введенных данных", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (isUserExist() == false || isNumber() == true)
                    return;
                else
                {

                    SqlCommand command = new SqlCommand($"INSERT INTO Счет(Код_работника, Номер_карты, Срок_действия, Проверочный_код) VALUES (@id_work,@card,@date,@kod)", dataBase.getConnection());

                    command.Parameters.Add("@id_work", SqlDbType.VarChar).Value = id_worker;
                    command.Parameters.Add("@card", SqlDbType.VarChar).Value = num_card;
                    command.Parameters.Add("@date", SqlDbType.DateTime).Value = parsedDate;
                    command.Parameters.Add("@kod", SqlDbType.VarChar).Value = kod;

                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Счет был успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Счет не был добавлен. Возникли ошибки. Обратитесь к главному бухгалтеру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataBase.closeConnection();
                }

            }
        }

        private void textBox_id_worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_card_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_kod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void textBox_card_TextChanged(object sender, EventArgs e)
        {
            if (textBox_card.Text.Length != lengthNumberCard)
            {
                textBox_card.BackColor = Color.Coral;
            }
            else
            {
                textBox_card.BackColor = Color.LightGreen;
            }
        }

        private void textBox_kod_TextChanged(object sender, EventArgs e)
        {
            if (textBox_kod.Text.Length != lengthKod)
            {
                textBox_kod.BackColor = Color.Coral;
            }
            else
            {
                textBox_kod.BackColor = Color.LightGreen;
            }
        }
    }
}
