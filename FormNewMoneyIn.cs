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
    public partial class FormNewMoneyIn : Form
    {
        DataBase dataBase = new DataBase();
        public FormNewMoneyIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            

        }

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormNewMoneyIn f;

        public static FormNewMoneyIn fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNewMoneyIn();
                return f;
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
                MessageBox.Show("Работника с данным кодом не существует. Проверьте правильность введенных данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var id_worker = textbox_Id_worker.Text;
                var oklad = textbox_Oklad.Text;
                var stim = textBox_Stim.Text;
                var kom = textbox_Kom.Text;
                var dop = textBox_Dop.Text;
                var proch = textBox_Proch.Text;
                var r = textBox_R.Text;

                if (stim == "") stim = "0";
                if (kom == "") kom = "0";
                if (dop == "") dop = "0";
                if (proch == "") proch = "0";
                if (r == "") r = "1";
                if (id_worker == "" || oklad == "")
                {
                    MessageBox.Show("Вы не заполнили все обязательные поля формы! \nОбязательные поля помечены знаком \"*\" Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (Convert.ToDecimal(r) < 1 || Convert.ToDecimal(r) > 2) MessageBox.Show("Значение районного коэффициента не может быть меньше 1 и больше 2. \nПроверьте правильность вводимых данных",
                   "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Convert.ToDecimal(oklad) < 13890) MessageBox.Show("Оклад не может быть меньше установленного МРОТ на 2022 г \nМРОТ на 2022 г. = 13890 руб.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (isUserExist() == false)
                        return;
                    else
                    {

                        SqlCommand command = new SqlCommand($"INSERT INTO Выплаты(Код_работника, Оклад, Стим_выплаты, Ком_выплаты,Доплаты,Прочие_выплаты,Р_коэф) VALUES (@id_work,@oklad,@stim,@kom,@dop,@proch,@r)", dataBase.getConnection());

                        command.Parameters.Add("@id_work", SqlDbType.VarChar).Value = id_worker;
                        command.Parameters.Add("@oklad", SqlDbType.Decimal).Value = oklad;
                        command.Parameters.Add("@stim", SqlDbType.Decimal).Value = stim;
                        command.Parameters.Add("@kom", SqlDbType.Decimal).Value = kom;
                        command.Parameters.Add("@dop", SqlDbType.Decimal).Value = dop;
                        command.Parameters.Add("@proch", SqlDbType.Decimal).Value = proch;
                        command.Parameters.Add("@r", SqlDbType.Decimal).Value = r;

                        dataBase.openConnection();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Выплата была успешно добавлена! \nПерейдите на форму \"Выплаты\" и обновите журнал выплат.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Выплата не была добавлена. Возникли ошибки. Обратитесь к главному бухгалтеру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        dataBase.closeConnection();


                    }

                }
            }
            catch
            {
                MessageBox.Show("Неверно введены данные!!! ПРоверьте правильность введенных данных. \nВозможно вы " +
                    "несколько раз указали \"...\"");
            }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textbox_Id_worker.Text = "";    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_Dop.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox_Proch.Text = "";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox_R.Text = "";
        }
        private void clearFields()
        {
            textbox_Id_worker.Text = "";
            textbox_Oklad.Text = "";
            textbox_Kom.Text = "";
            textBox_Stim.Text = "";
            textBox_Dop.Text = "";
            textBox_Proch.Text = "";
            textBox_R.Text = "";
        }
        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void textbox_Id_worker_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textbox_Oklad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void FormNewMoneyIn_Load(object sender, EventArgs e)
        {

        }
    }
}
