
namespace BSBD_App
{
    partial class FormNewWorker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Dad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Dol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Sem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Child = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Pol = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 100);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(120, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 99);
            this.label5.TabIndex = 2;
            this.label5.Text = "Создание записи:\r\nотдел Бухгалтерии\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(729, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Дети*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата трудоустройства*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(208, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя*:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(485, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 46);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/yy";
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(297, 352);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 30);
            this.dateTimePicker.TabIndex = 14;
            // 
            // textBox_count
            // 
            this.textBox_count.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_count.Location = new System.Drawing.Point(827, 380);
            this.textBox_count.MaxLength = 2;
            this.textBox_count.Multiline = true;
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(224, 60);
            this.textBox_count.TabIndex = 13;
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kod_KeyPress);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(297, 198);
            this.textBox_Name.MaxLength = 30;
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Name.Size = new System.Drawing.Size(224, 60);
            this.textBox_Name.TabIndex = 12;
            this.textBox_Name.WordWrap = false;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SecondName_KeyPress);
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SecondName.Location = new System.Drawing.Point(297, 121);
            this.textBox_SecondName.MaxLength = 30;
            this.textBox_SecondName.Multiline = true;
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_SecondName.Size = new System.Drawing.Size(224, 60);
            this.textBox_SecondName.TabIndex = 11;
            this.textBox_SecondName.WordWrap = false;
            this.textBox_SecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SecondName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(153, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия*:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BSBD_App.Properties.Resources.worker;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Dad
            // 
            this.textBox_Dad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Dad.Location = new System.Drawing.Point(297, 275);
            this.textBox_Dad.MaxLength = 30;
            this.textBox_Dad.Multiline = true;
            this.textBox_Dad.Name = "textBox_Dad";
            this.textBox_Dad.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Dad.Size = new System.Drawing.Size(224, 60);
            this.textBox_Dad.TabIndex = 19;
            this.textBox_Dad.WordWrap = false;
            this.textBox_Dad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Dad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(164, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество:";
            // 
            // textBox_Dol
            // 
            this.textBox_Dol.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Dol.Location = new System.Drawing.Point(827, 116);
            this.textBox_Dol.MaxLength = 30;
            this.textBox_Dol.Multiline = true;
            this.textBox_Dol.Name = "textBox_Dol";
            this.textBox_Dol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Dol.Size = new System.Drawing.Size(224, 60);
            this.textBox_Dol.TabIndex = 21;
            this.textBox_Dol.WordWrap = false;
            this.textBox_Dol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Dol_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(660, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Должность*:";
            // 
            // comboBox_Sem
            // 
            this.comboBox_Sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Sem.FormattingEnabled = true;
            this.comboBox_Sem.Items.AddRange(new object[] {
            "",
            "холост",
            "женат",
            "замужем",
            "не замужем"});
            this.comboBox_Sem.Location = new System.Drawing.Point(827, 265);
            this.comboBox_Sem.Name = "comboBox_Sem";
            this.comboBox_Sem.Size = new System.Drawing.Size(224, 31);
            this.comboBox_Sem.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(536, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 33);
            this.label8.TabIndex = 24;
            this.label8.Text = "Семейное положение*:";
            // 
            // comboBox_Child
            // 
            this.comboBox_Child.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Child.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Child.FormattingEnabled = true;
            this.comboBox_Child.Items.AddRange(new object[] {
            "",
            "есть",
            "нет"});
            this.comboBox_Child.Location = new System.Drawing.Point(827, 322);
            this.comboBox_Child.Name = "comboBox_Child";
            this.comboBox_Child.Size = new System.Drawing.Size(224, 31);
            this.comboBox_Child.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(578, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 33);
            this.label9.TabIndex = 26;
            this.label9.Text = "Количество детей*:";
            // 
            // comboBox_Pol
            // 
            this.comboBox_Pol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Pol.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Pol.FormattingEnabled = true;
            this.comboBox_Pol.Items.AddRange(new object[] {
            "",
            "мужской",
            "женский"});
            this.comboBox_Pol.Location = new System.Drawing.Point(827, 198);
            this.comboBox_Pol.Name = "comboBox_Pol";
            this.comboBox_Pol.Size = new System.Drawing.Size(224, 31);
            this.comboBox_Pol.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(734, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 33);
            this.label10.TabIndex = 28;
            this.label10.Text = "Пол*:";
            // 
            // FormNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1145, 510);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_Pol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_Child);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_Sem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Dol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Dad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_SecondName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormNewWorker";
            this.Text = "Добавление нового работника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Dad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Dol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Sem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Child;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Pol;
        private System.Windows.Forms.Label label10;
    }
}