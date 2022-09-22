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
    public partial class FormRegistrAc : Form
    {
        ClassMD5 mD5 = new ClassMD5();
        DataBase dataBase = new DataBase();
        public FormRegistrAc()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormRegistrAc f;

        public static FormRegistrAc fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRegistrAc();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            var loginUser = textBox_login.Text;
            var passwordUser = mD5.hashPassword(textBox_password.Text);
            var ruleUser = comboBox_rule.Text;

            if(loginUser == "" || passwordUser == "" || ruleUser == "")
            {
                MessageBox.Show("Вы заполнили не все поля формы! Повторите попытку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isUserExist())
                    return;
                else
                {

                    SqlCommand command = new SqlCommand($"INSERT INTO Бухгалтер(Логин, Пароль, Роль) VALUES (@login,@password,@rule)", dataBase.getConnection());

                    command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginUser;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordUser;
                    command.Parameters.Add("@rule", SqlDbType.VarChar).Value = ruleUser;

                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт был создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не был создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    dataBase.closeConnection();
                }

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
            string mainstring = $"SELECT Код_бухгалтера, Логин, Пароль, Роль FROM Бухгалтер WHERE Логин = @uL";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

            //Покрытие данных для безопасности (заглушки)
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = textBox_login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Аккаунт с данным логином уже существует. Введите другой логин", "Внимание",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return true;

            }
            else
            {
                return false;
            }
        }

        private void FormRegistrAc_Load(object sender, EventArgs e)
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

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pass = e.KeyChar;
            if (pass == 34 || pass == 39 || pass == 44 || pass == 96 || pass == 32 || pass == 47 ||
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
