
namespace BSBD_App
{
    partial class FormNewNumber
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id_worker = new System.Windows.Forms.TextBox();
            this.textBox_card = new System.Windows.Forms.TextBox();
            this.textBox_kod = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(598, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BSBD_App.Properties.Resources.money_blank;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код работника:";
            // 
            // textBox_id_worker
            // 
            this.textBox_id_worker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id_worker.Location = new System.Drawing.Point(300, 154);
            this.textBox_id_worker.MaxLength = 9;
            this.textBox_id_worker.Multiline = true;
            this.textBox_id_worker.Name = "textBox_id_worker";
            this.textBox_id_worker.Size = new System.Drawing.Size(200, 39);
            this.textBox_id_worker.TabIndex = 2;
            this.textBox_id_worker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_worker_KeyPress);
            // 
            // textBox_card
            // 
            this.textBox_card.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_card.Location = new System.Drawing.Point(300, 225);
            this.textBox_card.MaxLength = 16;
            this.textBox_card.Multiline = true;
            this.textBox_card.Name = "textBox_card";
            this.textBox_card.Size = new System.Drawing.Size(200, 39);
            this.textBox_card.TabIndex = 3;
            this.textBox_card.TextChanged += new System.EventHandler(this.textBox_card_TextChanged);
            this.textBox_card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_card_KeyPress);
            // 
            // textBox_kod
            // 
            this.textBox_kod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_kod.Location = new System.Drawing.Point(300, 361);
            this.textBox_kod.MaxLength = 3;
            this.textBox_kod.Multiline = true;
            this.textBox_kod.Name = "textBox_kod";
            this.textBox_kod.Size = new System.Drawing.Size(200, 39);
            this.textBox_kod.TabIndex = 4;
            this.textBox_kod.TextChanged += new System.EventHandler(this.textBox_kod_TextChanged);
            this.textBox_kod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kod_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/yy";
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(300, 297);
            this.dateTimePicker.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(185, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер карты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Срок действия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Проверочный код:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::BSBD_App.Properties.Resources.worker;
            this.pictureBox9.Location = new System.Drawing.Point(516, 361);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(56, 51);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 53;
            this.pictureBox9.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(502, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "Перейти\r\nк работникам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNewNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(598, 471);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_kod);
            this.Controls.Add(this.textBox_card);
            this.Controls.Add(this.textBox_id_worker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormNewNumber";
            this.Text = "Добавление счета";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id_worker;
        private System.Windows.Forms.TextBox textBox_card;
        private System.Windows.Forms.TextBox textBox_kod;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button button1;
    }
}