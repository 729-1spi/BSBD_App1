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
    public partial class FormOutMoney : Form
    {
        DataBase dataBase = new DataBase();
        private BindingSource bs = new BindingSource();
        public FormOutMoney()
        {
            InitializeComponent();
        }
        public Boolean Proverka()
        {
            bool like = false;
            for (int index = 0; index < отчисленияDataGridView.Rows.Count - 1; index++)
            {
                var sum = отчисленияDataGridView.Rows[index].Cells[2].Value.ToString();
                double sum_2 = Convert.ToDouble(sum);
                var id = отчисленияDataGridView.Rows[index].Cells[0].Value.ToString();

                if (sum_2 < 13890)
                {
                    MessageBox.Show("МРОТ");
                    like = true;

                }
            }
            return like;
        }

        /// <summary>
        /// Проверка существования пользователя в БД
        /// </summary>
        /// <returns></returns>
        public Boolean isUserExist()
        {

            bool like = false;
            bool kip = false;
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            for (int index = 0; index < отчисленияDataGridView.Rows.Count - 1;index++)
            {
                var worker = отчисленияDataGridView.Rows[index].Cells[1].Value.ToString();
                //Выполнение запроса к БД
                string mainstring = $"SELECT Код_работника FROM Работник WHERE Код_работника = {worker}";

                SqlCommand command = new SqlCommand(mainstring, dataBase.getConnection());

                //Покрытие данных для безопасности (заглушки)
                //command.Parameters.Add("@uL", SqlDbType.VarChar).Value = отчисленияDataGridView.Rows[6].Cells[1].Value.ToString();

                adapter.SelectCommand = command;
                

                adapter.Fill(table);
                
                

                //Проверка существования пользователя и его роли
                if (table.Rows.Count == 1)
                {
                    
                    like = true;
                    
                }
                else
                {
                    like = false;
                    MessageBox.Show("Такого работника не существует!!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            return like;
           
        }

        private void отчисленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                //if (isUserExist() == true) return;
                this.Validate();
                this.отчисленияBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.workDataSet1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FormOutMoney_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workDataSet1.Отчисления". При необходимости она может быть перемещена или удалена.
            this.отчисленияTableAdapter.Fill(this.workDataSet1.Отчисления);

        }

        private void отчисленияDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Некоректный ввод данных. Возможно вы заполнили не все поля! \nПроверьте правильность введенных данных", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Проверка допустимости ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void отчисленияDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
            отчисленияDataGridView.Columns[e.ColumnIndex].HeaderText;

            // Прервать проверку, если ячейка отсутствует в столбце Код_работника
            if (!headerText.Equals("Код_работника") && !headerText.Equals("Начислено") && !headerText.Equals("Номер_отчисления")) return;
            // Убедиться, что ячейка не пуста
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                отчисленияDataGridView.Rows[e.RowIndex].ErrorText =
                    "Значения в полях \"Номер_выплаты\", \"Код_работника\" и \"Начислено\"не может быть пустым";
                e.Cancel = true;
            }

            
        }

        /// <summary>
        /// Возникает при остановки режима правки ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void отчисленияDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Очистить ошибку строки, если пользователь нажмет ESC
            отчисленияDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
