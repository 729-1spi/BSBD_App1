using BSBD_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_App
{
    public partial class FormMain : Form
    {

        DataBase dataBase = new DataBase();
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для расчёта заработной платы работникам организации\n(C)ТУСУР, КИБЭВС, Сергачева П.И., гр. 729-1,2022", "О программе", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void информацияОРаботникахToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void счётToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNumber.fw.ShowForm();
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }

        private void историяЗаработнойПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory.fw.ShowForm();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void бухгалтерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountant.fw.ShowForm();
        }

        private void выплатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMoneyIn.fw.ShowForm();
        }

        private void отчисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeductions.fw.ShowForm();
        }
    }
}
