using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{

    public partial class FormSignIn : Form
    {
        DataBase dataBase = new DataBase();
        ClassMD5 mD5 = new ClassMD5();

        public FormSignIn()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string LoginUser = textbox_login.Text;
            string PassUser = mD5.hashPassword(textbox_password.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            
            //Выполнение запроса к БД
            string mainstring = $"SELECT Код_бухгалтера, Логин, Пароль, Роль FROM Бухгалтер WHERE Логин = @uL and Пароль = @uP";

            SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());
            
            //Покрытие данных для безопасности
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = PassUser;


            adapter.SelectCommand = command;
            adapter.Fill(table);
            string role = "Главный бухгалтер";

            //Проверка существования пользователя и его роли
            if (table.Rows.Count == 1)
            {
               if (table.Columns[3].ColumnName.Equals("Роль") && table.Columns[3].Table.Rows[0].ItemArray.GetValue(3).ToString() == role)
               {
                   MessageBox.Show("Привет главный бухгалтер)", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FormMain formmain = new FormMain();
                   this.Hide();
                   formmain.ShowDialog();
               }
               else
               {
                   MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FormAccMain formworker = new FormAccMain();
                   this.Hide();
                   formworker.ShowDialog();
               }
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует. \nВозможно вы ввели неверный пароль. Повторите попытку или обратитесь к главному бухгалетру организации", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            textbox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = false;
            textbox_login.MaxLength = 50;
            textbox_password.MaxLength = 50;
        }

        //закрытый глаз
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textbox_password.UseSystemPasswordChar = false; 
            pictureBox2.Visible = false; 
            pictureBox3.Visible = true; 
        }

        //открытый глаз
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textbox_password.UseSystemPasswordChar = true; 
            pictureBox2.Visible = true; 
            pictureBox3.Visible = false; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textbox_login.Text = "";
            textbox_password.Text = "";
        }

        private void textbox_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char login = e.KeyChar;
            if (((login <32) || (login >45)) && (login != 47) && ((login<=58) || (login>63)) && ((login<91) || (login>=97)) && (login<123) || ((login>=192) &&(login<=255)) ||
                ((login>=1040)&&(login<=1103)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textbox_password_KeyPress(object sender, KeyPressEventArgs e)
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
