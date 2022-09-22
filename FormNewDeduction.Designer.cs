
namespace BSBD_App
{
    partial class FormNewDeduction
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox_plata = new System.Windows.Forms.TextBox();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_id_worker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(690, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BSBD_App.Properties.Resources.out_money;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Начислено:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Номер выплаты:";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(251, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 46);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox_plata
            // 
            this.textBox_plata.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_plata.Location = new System.Drawing.Point(347, 276);
            this.textBox_plata.MaxLength = 11;
            this.textBox_plata.Multiline = true;
            this.textBox_plata.Name = "textBox_plata";
            this.textBox_plata.Size = new System.Drawing.Size(200, 39);
            this.textBox_plata.TabIndex = 13;
            this.textBox_plata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_plata_KeyPress);
            // 
            // textBox_num
            // 
            this.textBox_num.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_num.Location = new System.Drawing.Point(347, 144);
            this.textBox_num.MaxLength = 5;
            this.textBox_num.Multiline = true;
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(200, 39);
            this.textBox_num.TabIndex = 12;
            this.textBox_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_num_KeyPress);
            // 
            // textBox_id_worker
            // 
            this.textBox_id_worker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id_worker.Location = new System.Drawing.Point(347, 210);
            this.textBox_id_worker.MaxLength = 9;
            this.textBox_id_worker.Multiline = true;
            this.textBox_id_worker.Name = "textBox_id_worker";
            this.textBox_id_worker.Size = new System.Drawing.Size(200, 39);
            this.textBox_id_worker.TabIndex = 11;
            this.textBox_id_worker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_worker_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Код работника:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BSBD_App.Properties.Resources.in_money;
            this.pictureBox2.Location = new System.Drawing.Point(606, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(590, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Перейти\r\nк выплатам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNewDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(690, 408);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox_plata);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.textBox_id_worker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormNewDeduction";
            this.Text = "Добавление отчисления";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox_plata;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_id_worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}