
namespace BSBD_App
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРаботникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРаботникахToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.счётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаработнойПлатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияОРаботникахToolStripMenuItem,
            this.информацияОРаботникахToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.info;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // информацияОРаботникахToolStripMenuItem
            // 
            this.информацияОРаботникахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счётToolStripMenuItem,
            this.выплатыToolStripMenuItem});
            this.информацияОРаботникахToolStripMenuItem.Name = "информацияОРаботникахToolStripMenuItem";
            this.информацияОРаботникахToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.информацияОРаботникахToolStripMenuItem.Text = "Сотрудники организации";
            this.информацияОРаботникахToolStripMenuItem.Click += new System.EventHandler(this.информацияОРаботникахToolStripMenuItem_Click);
            // 
            // счётToolStripMenuItem
            // 
            this.счётToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.worker;
            this.счётToolStripMenuItem.Name = "счётToolStripMenuItem";
            this.счётToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.счётToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.счётToolStripMenuItem.Text = "Работники";
            // 
            // выплатыToolStripMenuItem
            // 
            this.выплатыToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.Money_work;
            this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
            this.выплатыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.выплатыToolStripMenuItem.Text = "Бухгалтеры";
            // 
            // информацияОРаботникахToolStripMenuItem1
            // 
            this.информацияОРаботникахToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счётToolStripMenuItem1,
            this.выплатыToolStripMenuItem1,
            this.отчисленияToolStripMenuItem,
            this.историяЗаработнойПлатыToolStripMenuItem});
            this.информацияОРаботникахToolStripMenuItem1.Name = "информацияОРаботникахToolStripMenuItem1";
            this.информацияОРаботникахToolStripMenuItem1.Size = new System.Drawing.Size(170, 20);
            this.информацияОРаботникахToolStripMenuItem1.Text = "Информация о работниках";
            // 
            // счётToolStripMenuItem1
            // 
            this.счётToolStripMenuItem1.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.счётToolStripMenuItem1.Name = "счётToolStripMenuItem1";
            this.счётToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D0)));
            this.счётToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.счётToolStripMenuItem1.Text = "Счёт";
            // 
            // выплатыToolStripMenuItem1
            // 
            this.выплатыToolStripMenuItem1.Image = global::BSBD_App.Properties.Resources.in_money;
            this.выплатыToolStripMenuItem1.Name = "выплатыToolStripMenuItem1";
            this.выплатыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.выплатыToolStripMenuItem1.Size = new System.Drawing.Size(261, 22);
            this.выплатыToolStripMenuItem1.Text = "Выплаты";
            // 
            // отчисленияToolStripMenuItem
            // 
            this.отчисленияToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.out_money;
            this.отчисленияToolStripMenuItem.Name = "отчисленияToolStripMenuItem";
            this.отчисленияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.отчисленияToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.отчисленияToolStripMenuItem.Text = "Отчисления";
            // 
            // историяЗаработнойПлатыToolStripMenuItem
            // 
            this.историяЗаработнойПлатыToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.history_money;
            this.историяЗаработнойПлатыToolStripMenuItem.Name = "историяЗаработнойПлатыToolStripMenuItem";
            this.историяЗаработнойПлатыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.историяЗаработнойПлатыToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.историяЗаработнойПлатыToolStripMenuItem.Text = "История заработной платы";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BSBD_App.Properties.Resources.exit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Закрыть программу";
            this.toolStripButton1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::BSBD_App.Properties.Resources.info;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "О программе...";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BSBD_App.Properties.Resources.worker;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Информация о работниках";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::BSBD_App.Properties.Resources.Money_work;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Данные бухгалтера";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Счёт работника";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::BSBD_App.Properties.Resources.in_money;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Выплаты";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::BSBD_App.Properties.Resources.out_money;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Отчисления ";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::BSBD_App.Properties.Resources.history_money;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "История заработной платы";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::BSBD_App.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::BSBD_App.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Программа для расчёта заработной платы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРаботникахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРаботникахToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem счётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаработнойПлатыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}

