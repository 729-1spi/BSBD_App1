
namespace BSBD_App
{
    partial class FormNumber
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_kod = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textbox_card = new System.Windows.Forms.TextBox();
            this.textbox_id_worker = new System.Windows.Forms.TextBox();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 215);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(886, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBoxClear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textbox_kod);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.textbox_card);
            this.panel2.Controls.Add(this.textbox_id_worker);
            this.panel2.Controls.Add(this.textbox_id);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(12, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 335);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(78, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Данные для форматирования";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::BSBD_App.Properties.Resources.passno;
            this.pictureBox4.Location = new System.Drawing.Point(435, 262);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BSBD_App.Properties.Resources.passno;
            this.pictureBox2.Location = new System.Drawing.Point(435, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BSBD_App.Properties.Resources.passno;
            this.pictureBox1.Location = new System.Drawing.Point(435, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Image = global::BSBD_App.Properties.Resources.clear1;
            this.pictureBoxClear.Location = new System.Drawing.Point(460, 288);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(44, 44);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 12;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Проверочный код:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срок действия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код работника:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер счета:";
            this.label1.Visible = false;
            // 
            // textbox_kod
            // 
            this.textbox_kod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_kod.Location = new System.Drawing.Point(229, 258);
            this.textbox_kod.MaxLength = 3;
            this.textbox_kod.Multiline = true;
            this.textbox_kod.Name = "textbox_kod";
            this.textbox_kod.Size = new System.Drawing.Size(200, 39);
            this.textbox_kod.TabIndex = 4;
            this.textbox_kod.TextChanged += new System.EventHandler(this.textbox_kod_TextChanged);
            this.textbox_kod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_kod_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/yy";
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(229, 193);
            this.dateTimePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            // 
            // textbox_card
            // 
            this.textbox_card.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_card.Location = new System.Drawing.Point(229, 126);
            this.textbox_card.MaxLength = 16;
            this.textbox_card.Multiline = true;
            this.textbox_card.Name = "textbox_card";
            this.textbox_card.Size = new System.Drawing.Size(200, 39);
            this.textbox_card.TabIndex = 2;
            this.textbox_card.TextChanged += new System.EventHandler(this.textbox_card_TextChanged);
            this.textbox_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_card_KeyPress);
            // 
            // textbox_id_worker
            // 
            this.textbox_id_worker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_id_worker.Location = new System.Drawing.Point(229, 60);
            this.textbox_id_worker.MaxLength = 9;
            this.textbox_id_worker.Multiline = true;
            this.textbox_id_worker.Name = "textbox_id_worker";
            this.textbox_id_worker.Size = new System.Drawing.Size(200, 39);
            this.textbox_id_worker.TabIndex = 1;
            this.textbox_id_worker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_id_worker_KeyPress);
            // 
            // textbox_id
            // 
            this.textbox_id.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_id.Location = new System.Drawing.Point(144, 303);
            this.textbox_id.Multiline = true;
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(103, 20);
            this.textbox_id.TabIndex = 0;
            this.textbox_id.Visible = false;
            this.textbox_id.TextChanged += new System.EventHandler(this.textbox_id_TextChanged);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(701, 7);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(175, 39);
            this.textBox_search.TabIndex = 5;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_search.Image = global::BSBD_App.Properties.Resources.sear;
            this.pictureBox_search.Location = new System.Drawing.Point(650, 5);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(39, 41);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_search.TabIndex = 4;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.MouseEnter += new System.EventHandler(this.pictureBox_search_MouseEnter);
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_refresh.Image = global::BSBD_App.Properties.Resources.refr;
            this.pictureBox_refresh.Location = new System.Drawing.Point(591, 5);
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.Size = new System.Drawing.Size(40, 41);
            this.pictureBox_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_refresh.TabIndex = 3;
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox_refresh_Click);
            // 
            // btn_New
            // 
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_New.Location = new System.Drawing.Point(81, 61);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(177, 67);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Создать новую запись";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Del.Location = new System.Drawing.Point(81, 148);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(177, 67);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "Удалить";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.Location = new System.Drawing.Point(81, 235);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(177, 67);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Сохранить изменения";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(62, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Управление записями";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btn_Save);
            this.panel3.Controls.Add(this.btn_Del);
            this.panel3.Controls.Add(this.btn_New);
            this.panel3.Location = new System.Drawing.Point(542, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 335);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::BSBD_App.Properties.Resources.worker;
            this.pictureBox7.Location = new System.Drawing.Point(9, 1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(60, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Перейти\r\nк работникам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(888, 630);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.pictureBox_refresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormNumber";
            this.Text = "Счет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNumber_FormClosing);
            this.Load += new System.EventHandler(this.FormNumber_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_kod;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textbox_card;
        private System.Windows.Forms.TextBox textbox_id_worker;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.PictureBox pictureBox_refresh;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
    }
}