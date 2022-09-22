
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
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бухгалтерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРаботникахToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.счётToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выплатыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяЗаработнойПлатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.бухгалтер_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияОРаботникахToolStripMenuItem,
            this.информацияОРаботникахToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.info;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(271, 30);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // информацияОРаботникахToolStripMenuItem
            // 
            this.информацияОРаботникахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работникиToolStripMenuItem,
            this.бухгалтерToolStripMenuItem});
            this.информацияОРаботникахToolStripMenuItem.Name = "информацияОРаботникахToolStripMenuItem";
            this.информацияОРаботникахToolStripMenuItem.Size = new System.Drawing.Size(244, 29);
            this.информацияОРаботникахToolStripMenuItem.Text = "Сотрудники организации";
            this.информацияОРаботникахToolStripMenuItem.Click += new System.EventHandler(this.информацияОРаботникахToolStripMenuItem_Click);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.worker;
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.работникиToolStripMenuItem.Text = "Работники";
            this.работникиToolStripMenuItem.Click += new System.EventHandler(this.работникиToolStripMenuItem_Click);
            // 
            // бухгалтерToolStripMenuItem
            // 
            this.бухгалтерToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.Money_work;
            this.бухгалтерToolStripMenuItem.Name = "бухгалтерToolStripMenuItem";
            this.бухгалтерToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.бухгалтерToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.бухгалтерToolStripMenuItem.Text = "Бухгалтеры";
            this.бухгалтерToolStripMenuItem.Click += new System.EventHandler(this.бухгалтерToolStripMenuItem_Click);
            // 
            // информацияОРаботникахToolStripMenuItem1
            // 
            this.информацияОРаботникахToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счётToolStripMenuItem1,
            this.выплатыToolStripMenuItem1,
            this.отчисленияToolStripMenuItem,
            this.историяЗаработнойПлатыToolStripMenuItem});
            this.информацияОРаботникахToolStripMenuItem1.Name = "информацияОРаботникахToolStripMenuItem1";
            this.информацияОРаботникахToolStripMenuItem1.Size = new System.Drawing.Size(261, 29);
            this.информацияОРаботникахToolStripMenuItem1.Text = "Информация о работниках";
            // 
            // счётToolStripMenuItem1
            // 
            this.счётToolStripMenuItem1.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.счётToolStripMenuItem1.Name = "счётToolStripMenuItem1";
            this.счётToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D0)));
            this.счётToolStripMenuItem1.Size = new System.Drawing.Size(380, 30);
            this.счётToolStripMenuItem1.Text = "Счёт";
            this.счётToolStripMenuItem1.Click += new System.EventHandler(this.счётToolStripMenuItem1_Click);
            // 
            // выплатыToolStripMenuItem1
            // 
            this.выплатыToolStripMenuItem1.Image = global::BSBD_App.Properties.Resources.in_money;
            this.выплатыToolStripMenuItem1.Name = "выплатыToolStripMenuItem1";
            this.выплатыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.выплатыToolStripMenuItem1.Size = new System.Drawing.Size(380, 30);
            this.выплатыToolStripMenuItem1.Text = "Выплаты";
            this.выплатыToolStripMenuItem1.Click += new System.EventHandler(this.выплатыToolStripMenuItem1_Click);
            // 
            // отчисленияToolStripMenuItem
            // 
            this.отчисленияToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.out_money;
            this.отчисленияToolStripMenuItem.Name = "отчисленияToolStripMenuItem";
            this.отчисленияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.отчисленияToolStripMenuItem.Size = new System.Drawing.Size(380, 30);
            this.отчисленияToolStripMenuItem.Text = "Отчисления";
            this.отчисленияToolStripMenuItem.Click += new System.EventHandler(this.отчисленияToolStripMenuItem_Click);
            // 
            // историяЗаработнойПлатыToolStripMenuItem
            // 
            this.историяЗаработнойПлатыToolStripMenuItem.Image = global::BSBD_App.Properties.Resources.history_money;
            this.историяЗаработнойПлатыToolStripMenuItem.Name = "историяЗаработнойПлатыToolStripMenuItem";
            this.историяЗаработнойПлатыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.историяЗаработнойПлатыToolStripMenuItem.Size = new System.Drawing.Size(380, 30);
            this.историяЗаработнойПлатыToolStripMenuItem.Text = "История заработной платы";
            this.историяЗаработнойПлатыToolStripMenuItem.Click += new System.EventHandler(this.историяЗаработнойПлатыToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStripMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.бухгалтер_toolStripButton,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStripMain.Location = new System.Drawing.Point(0, 33);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1001, 57);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::BSBD_App.Properties.Resources.exit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 54);
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
            this.toolStripButton2.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton2.Text = "О программе...";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::BSBD_App.Properties.Resources.worker;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton3.Text = "Информация о работниках";
            this.toolStripButton3.Click += new System.EventHandler(this.работникиToolStripMenuItem_Click);
            // 
            // бухгалтер_toolStripButton
            // 
            this.бухгалтер_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.бухгалтер_toolStripButton.Image = global::BSBD_App.Properties.Resources.Money_work;
            this.бухгалтер_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.бухгалтер_toolStripButton.Name = "бухгалтер_toolStripButton";
            this.бухгалтер_toolStripButton.Size = new System.Drawing.Size(54, 54);
            this.бухгалтер_toolStripButton.Text = "Данные бухгалтера";
            this.бухгалтер_toolStripButton.Click += new System.EventHandler(this.бухгалтерToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton5.Text = "Счёт работника";
            this.toolStripButton5.Click += new System.EventHandler(this.счётToolStripMenuItem1_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::BSBD_App.Properties.Resources.in_money;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton6.Text = "Выплаты";
            this.toolStripButton6.Click += new System.EventHandler(this.выплатыToolStripMenuItem1_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::BSBD_App.Properties.Resources.out_money;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton7.Text = "Отчисления ";
            this.toolStripButton7.Click += new System.EventHandler(this.отчисленияToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::BSBD_App.Properties.Resources.history_money;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton8.Text = "История заработной платы";
            this.toolStripButton8.Click += new System.EventHandler(this.историяЗаработнойПлатыToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "  Добро пожаловать в программу\r\n    для расчета заработной платы\r\n        работни" +
    "кам организации. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 69);
            this.label2.TabIndex = 3;
            this.label2.Text = "*На панели инструментов находятся\r\nразделы данного приложения.\r\nВыберете раздел, " +
    "который вам нужен и перейдите на него.\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1001, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::BSBD_App.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = global::BSBD_App.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для расчёта заработной платы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бухгалтерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРаботникахToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem счётToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem отчисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяЗаработнойПлатыToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton бухгалтер_toolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

