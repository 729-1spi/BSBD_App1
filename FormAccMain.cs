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
    public partial class FormAccMain : Form
    {
        public FormAccMain()
        {
            InitializeComponent();
        }

        private void счетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNumber.fw.ShowForm();
        }

        private void выплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMoneyIn.fw.ShowForm();
        }

        private void отчисленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeductions.fw.Show();
        }

        private void историяЗаработнойПлатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory.fw.ShowForm();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormWorker.fw.ShowForm();
        }
    }
}
