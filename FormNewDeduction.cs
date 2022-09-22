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
    public partial class FormNewDeduction : Form
    {
        public FormNewDeduction()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        DataBase dataBase = new DataBase();

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormNewDeduction f;

        public static FormNewDeduction fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNewDeduction();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
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
                $"Номер_выплаты = @num AND Код_работника = @idW";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = textBox_num.Text;
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Данные отчисления уже были внесены. \nЕсли вам нужно их изменить перейдите в форму" +
                   "\"Отчисления\" в раздел редактирования данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка существования выплаты для работника в БД
        /// </summary>
        /// <returns></returns>
        public Boolean IsMoneyIn()
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            //Выполнение запроса к БД
            string mainstring = $"SELECT Номер_выплаты, Код_работника, Начислено FROM Выплаты WHERE " +
                $"Номер_выплаты = @num AND Код_работника = @idW AND Начислено = @sum ";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@num", SqlDbType.VarChar).Value = textBox_num.Text;
            command.Parameters.Add("@idW", SqlDbType.VarChar).Value = textBox_id_worker.Text;
            command.Parameters.Add("@sum", SqlDbType.VarChar).Value = textBox_plata.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {

                return true;

            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных \nВозможно данного работника не существует " +
                    "или \nТакому работнику не были назначены выплаты или" +
                    " \nВы указали неверную сумму начислений \nТакже проверьте установленный вами номер выплаты. " +
                    "Возможно он введен не верно", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id_worker = textBox_id_worker.Text;
                var num = textBox_num.Text;
                var plata = textBox_plata.Text;

                if (id_worker == "" || num == "" || plata == "")
                {
                    MessageBox.Show("Заполните все поля формы!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (IsMoneyIn() == false || IsExist() == true) return;
                else
                {
                    SqlCommand command = new SqlCommand($"INSERT INTO Отчисления(Код_работника, Номер_выплаты, Начислено) VALUES (@id_work,@num,@plata)", dataBase.getConnection());

                    command.Parameters.Add("@id_work", SqlDbType.VarChar).Value = id_worker;
                    command.Parameters.Add("@num", SqlDbType.VarChar).Value = num;
                    command.Parameters.Add("@plata", SqlDbType.VarChar).Value = plata;
                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Отчисления были успешно добавлены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Отчисления не были добавлены. Возникли ошибки. Обратитесь к главному бухгалтеру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataBase.closeConnection();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка источника данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
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

        private void textBox_plata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMoneyIn.fw.ShowForm();
        }
    }
}
