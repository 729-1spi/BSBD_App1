using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{
    public partial class FormNewWorker : Form
    {
        DataBase dataBase = new DataBase();
        public FormNewWorker()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Реализация шаблона проектирования "Одиночка"
        /// </summary>
        private static FormNewWorker f;

        public static FormNewWorker fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormNewWorker();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        private void textBox_SecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
       

        private void textBox_Dol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && number != 8 && number != 45 && !Char.IsDigit(number) && number != 32)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var second_name = textBox_SecondName.Text;
            var name = textBox_Name.Text;
            var dad = textBox_Dad.Text;
            var date = dateTimePicker.Text;
            var dol = textBox_Dol.Text;
            var pol = comboBox_Pol.Text;
            var sem = comboBox_Sem.Text;
            var child = comboBox_Child.Text;
            var num_child = textBox_count.Text;
            var man = comboBox_Pol.Items.IndexOf(2);
            var women = comboBox_Pol.Items.IndexOf(3);
            CultureInfo provider = new CultureInfo("fr-FR");
            DateTime parsedDate = DateTime.ParseExact(date, "MM/yy", provider);
            DateTime now = new DateTime(2022, 06, 10);

            if (second_name == "" || name == "" || date == "" || dol == "" || pol == "" || sem == "" || child == "")
            {
                MessageBox.Show("Вы заполнили не все обязательные поля формы! Повторите попытку \nОбязательные поля формы помечены знаком *", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((child == "есть" && num_child == "0") || (child == "есть" && num_child == "")) MessageBox.Show("Укажите количество детей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            else if ((child == "нет" && num_child != "0") && (child == "нет" && num_child != "")) MessageBox.Show("Вы указали, что у работника нет детей." +
                "\nОставьте поле \"Количество детей\" пустым или укажите значение 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if((pol.Equals("мужской") && sem.Equals("замужем"))|| ((pol.Equals("мужской") && sem.Equals("не замужем")))) MessageBox.Show("Вы указали пол работника мужской," +
                "следовательно, в поле  \"Семейное положение\" вы можете указать только значения \"холост\" или \"женат\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if ((pol.Equals("женский") && sem.Equals("холост")) || ((pol.Equals("женский") && sem.Equals("женат")))) MessageBox.Show("Вы указали пол работника женский," +
                  "следовательно, в поле  \"Семейное положение\" вы можете указать только значения \"не замужем\" или \"замужем\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (parsedDate > now) MessageBox.Show("Вы не можете указать дату трудоустройства в будущем времени.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
              SqlCommand command = new SqlCommand($"INSERT INTO Работник(Фамилия, Имя, Отчество, Дата_трудоустройства, Должность, Пол, Семейное_положение, Дети, Кол_детей) VALUES (@second_name,@name,@dad,@date,@dol,@pol,@sem,@child,@count)", dataBase.getConnection());

              command.Parameters.Add("@second_name", SqlDbType.VarChar).Value = second_name;
              command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
              command.Parameters.Add("@dad", SqlDbType.VarChar).Value = dad;
              command.Parameters.Add("@date", SqlDbType.DateTime).Value = parsedDate;
              command.Parameters.Add("@dol", SqlDbType.VarChar).Value = dol;
              command.Parameters.Add("@pol", SqlDbType.VarChar).Value = pol;
              command.Parameters.Add("@sem", SqlDbType.VarChar).Value = sem;
              command.Parameters.Add("@child", SqlDbType.VarChar).Value = child;
              command.Parameters.Add("@count", SqlDbType.VarChar).Value = num_child;

                dataBase.openConnection();

              if (command.ExecuteNonQuery() == 1)
              {
                  MessageBox.Show("Работник был успешно добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              else
              {
                  MessageBox.Show("Работник не был добавлен. Возникли ошибки. Обратитесь к главному бухгалтеру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }

              dataBase.closeConnection();
                

            }
        }

        private void textBox_Dad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
    }
}
