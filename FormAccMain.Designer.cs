
namespace BSBD_App
{
    partial class FormAccMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаработнойПлатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счетToolStripMenuItem1,
            this.выплатыToolStripMenuItem,
            this.отчисленияToolStripMenuItem,
            this.историяЗаработнойПлатыToolStripMenuItem});
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.работникиToolStripMenuItem.Text = "Работники";
            // 
            // счетToolStripMenuItem1
            // 
            this.счетToolStripMenuItem1.Name = "счетToolStripMenuItem1";
            this.счетToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.счетToolStripMenuItem1.Text = "Счет";
            this.счетToolStripMenuItem1.Click += new System.EventHandler(this.счетToolStripMenuItem1_Click);
            // 
            // выплатыToolStripMenuItem
            // 
            this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
            this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.выплатыToolStripMenuItem.Text = "Выплаты";
            this.выплатыToolStripMenuItem.Click += new System.EventHandler(this.выплатыToolStripMenuItem_Click);
            // 
            // отчисленияToolStripMenuItem
            // 
            this.отчисленияToolStripMenuItem.Name = "отчисленияToolStripMenuItem";
            this.отчисленияToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.отчисленияToolStripMenuItem.Text = "Отчисления";
            this.отчисленияToolStripMenuItem.Click += new System.EventHandler(this.отчисленияToolStripMenuItem_Click);
            // 
            // историяЗаработнойПлатыToolStripMenuItem
            // 
            this.историяЗаработнойПлатыToolStripMenuItem.Name = "историяЗаработнойПлатыToolStripMenuItem";
            this.историяЗаработнойПлатыToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.историяЗаработнойПлатыToolStripMenuItem.Text = "История заработной платы";
            this.историяЗаработнойПлатыToolStripMenuItem.Click += new System.EventHandler(this.историяЗаработнойПлатыToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BSBD_App.Properties.Resources.worker;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Работники";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Счет";
            this.toolStripButton2.Click += new System.EventHandler(this.счетToolStripMenuItem1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BSBD_App.Properties.Resources.in_money;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Выплаты";
            this.toolStripButton3.Click += new System.EventHandler(this.выплатыToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::BSBD_App.Properties.Resources.out_money;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Отчисления";
            this.toolStripButton4.Click += new System.EventHandler(this.отчисленияToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::BSBD_App.Properties.Resources.history_money;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "История зарплаты работников";
            this.toolStripButton5.Click += new System.EventHandler(this.историяЗаработнойПлатыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 135);
            this.label1.TabIndex = 3;
            this.label1.Text = "  Добро пожаловать в программу\r\n    для расчета заработной платы\r\n        работни" +
    "кам организации. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "*На панели инструментов находятся\r\nразделы данного приложения.\r\nВыберете раздел, " +
    "который вам нужен и перейдите на него.\r\n";
            // 
            // FormAccMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccMain";
            this.Text = "FormAccMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаработнойПлатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}