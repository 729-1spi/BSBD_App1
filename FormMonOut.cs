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
    public partial class FormMonOut : Form
    {
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlBuilder = null;
        private DataSet dataSet = null;
        private bool newRowAdding = false;


        DataBase database = new DataBase();
        public FormMonOut()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод выгрузки данных из БД в DataGridView
        /// </summary>
        private void LoadData()
        {
            try
            {
               sqlDataAdapter = new SqlDataAdapter("SELECT *, 'DELETE' AS [COMMAND] FROM Отчисления",database.getConnection());
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Отчисления");

                dataGridView1.DataSource = dataSet.Tables["Отчисления"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ReloadData()
        {
            try
            {
                dataSet.Tables["Отчисления"].Clear();

                sqlDataAdapter.Fill(dataSet, "Отчисления");

                dataGridView1.DataSource = dataSet.Tables["Отчисления"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMonOut_Load(object sender, EventArgs e)
        {
            database.openConnection();
            LoadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        public Boolean Proverka()
        {
            bool like = false;
            for (int index = 0; index < dataGridView1.Rows.Count - 1; index++)
            {
                var sum = dataGridView1.Rows[index].Cells[2].Value.ToString();
                double sum_2 = Convert.ToDouble(sum);

                if (sum_2 < 13890)
                {
                    MessageBox.Show("МРОТ");
                    like = true;

                }
            }
            return like;
        }
        /// <summary>
        /// Обработка события нажатия на ячейку. Возникает при щелчке на содержимое ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    if (Proverka() == true) return;
                    else
                    {
                        //Проверка команды, которую ъотел выполнить пользователь
                        if (task == "DELETE")
                        {
                            if (MessageBox.Show("Вы хотите удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes)
                            {
                                int rowIndex = e.RowIndex;

                                //Удаление строки из DataGridView
                                dataGridView1.Rows.RemoveAt(rowIndex);

                                //Удалени строки из таблицы
                                dataSet.Tables["Отчисления"].Rows[rowIndex].Delete();

                                sqlDataAdapter.Update(dataSet, "Отчисления");
                            }
                        }
                        else if (task == "INSERT")
                        {
                            int rowIndex = dataGridView1.Rows.Count - 2;
                            //Ссылка на новую строку, которая создается
                            DataRow row = dataSet.Tables["Отчисления"].NewRow();

                            row["Код_работника"] = dataGridView1.Rows[rowIndex].Cells["Код_работника"].Value;
                            row["Начислено"] = dataGridView1.Rows[rowIndex].Cells["Начислено"].Value;
                            //row["Мед_отчисл"] = dataGridView1.Rows[rowIndex].Cells["Мед_отчисл"].Value;
                            //row["Пенс_отчисл"] = dataGridView1.Rows[rowIndex].Cells["Пенс_отчисл"].Value;
                            //row["ФСС_отчисл"] = dataGridView1.Rows[rowIndex].Cells["ФСС_отчисл"].Value;


                            dataSet.Tables["Отчисления"].Rows.Add(row);
                            dataSet.Tables["Отчисления"].Rows.RemoveAt(dataSet.Tables["Отчисления"].Rows.Count - 1);
                            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                            dataGridView1.Rows[e.RowIndex].Cells[7].Value = "DELETE";

                            //Обновление данных в DataGridView и занесение данных в БД

                            sqlDataAdapter.Update(dataSet, "Отчисления");

                            newRowAdding = false;
                        }
                        else if (task == "UPDATE")
                        {
                            //Получение индекса выделенной строки
                            int r = e.RowIndex;

                            dataSet.Tables["Отчисления"].Rows[r]["Код_работника"] = dataGridView1.Rows[r].Cells["Код_работника"].Value;
                            dataSet.Tables["Отчисления"].Rows[r]["Начислено"] = dataGridView1.Rows[r].Cells["Начислено"].Value;

                            sqlDataAdapter.Update(dataSet, "Отчисления");

                            dataGridView1.Rows[e.RowIndex].Cells[7].Value = "DELETE";

                        }
                        ReloadData();
                    }
                }      
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Событие возникает после завершения добавления строки в DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                         
                            //Добавление новой строки
                            newRowAdding = true;

                            int lastRow = dataGridView1.Rows.Count - 2;

                            DataGridViewRow row = dataGridView1.Rows[lastRow];

                            DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                            dataGridView1[7, lastRow] = linkCell;

                            row.Cells["COMMAND"].Value = "INSERT";
                        
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработка событий при изменении данных в DataGridView. Возникает при изменении содержимого ячейки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    //Получение индекса строки выделенной ячейки
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, rowIndex] = linkCell;

                    editingRow.Cells["COMMAND"].Value = "UPDATE";
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if(dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
