
namespace BSBD_App
{
    partial class FormRegistrAc
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_rule = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание записи:\r\nотдел Бухгалтерии\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BSBD_App.Properties.Resources.Registr;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_rule);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_password);
            this.panel2.Controls.Add(this.textBox_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 367);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(97, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Роль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин:";
            // 
            // comboBox_rule
            // 
            this.comboBox_rule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rule.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_rule.FormattingEnabled = true;
            this.comboBox_rule.Items.AddRange(new object[] {
            "Бухгалтер",
            "Главный бухгалтер"});
            this.comboBox_rule.Location = new System.Drawing.Point(198, 230);
            this.comboBox_rule.Name = "comboBox_rule";
            this.comboBox_rule.Size = new System.Drawing.Size(235, 34);
            this.comboBox_rule.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(198, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 46);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(198, 150);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_password.Size = new System.Drawing.Size(235, 51);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(198, 71);
            this.textBox_login.MaxLength = 50;
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_login.Size = new System.Drawing.Size(235, 51);
            this.textBox_login.TabIndex = 0;
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // FormRegistrAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormRegistrAc";
            this.Text = "Добавление бухгалтера";
            this.Load += new System.EventHandler(this.FormRegistrAc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_rule;
    }
}