
namespace BSBD_App
{
    partial class FormAccountant
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.pictureBox_refresh = new System.Windows.Forms.PictureBox();
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_inf = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Clear_login = new System.Windows.Forms.PictureBox();
            this.pictureBox_Clear_pass = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.comboBox_rule = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(634, 8);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(211, 44);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // pictureBox_refresh
            // 
            this.pictureBox_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_refresh.Image = global::BSBD_App.Properties.Resources.refr;
            this.pictureBox_refresh.Location = new System.Drawing.Point(500, 8);
            this.pictureBox_refresh.Name = "pictureBox_refresh";
            this.pictureBox_refresh.Size = new System.Drawing.Size(44, 44);
            this.pictureBox_refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_refresh.TabIndex = 1;
            this.pictureBox_refresh.TabStop = false;
            this.pictureBox_refresh.Click += new System.EventHandler(this.pictureBox_refresh_Click);
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.Image = global::BSBD_App.Properties.Resources.sear;
            this.pictureBox_search.Location = new System.Drawing.Point(576, 7);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(44, 44);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_search.TabIndex = 2;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.pictureBox_inf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox_Clear_login);
            this.panel2.Controls.Add(this.pictureBox_Clear_pass);
            this.panel2.Controls.Add(this.pictureBoxClear);
            this.panel2.Controls.Add(this.comboBox_rule);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_password);
            this.panel2.Controls.Add(this.textBox_login);
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Location = new System.Drawing.Point(12, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 341);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox_inf
            // 
            this.pictureBox_inf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_inf.Image = global::BSBD_App.Properties.Resources.inform;
            this.pictureBox_inf.Location = new System.Drawing.Point(381, 14);
            this.pictureBox_inf.Name = "pictureBox_inf";
            this.pictureBox_inf.Size = new System.Drawing.Size(44, 38);
            this.pictureBox_inf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_inf.TabIndex = 12;
            this.pictureBox_inf.TabStop = false;
            this.pictureBox_inf.Click += new System.EventHandler(this.pictureBox_inf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Данные для редактирования";
            // 
            // pictureBox_Clear_login
            // 
            this.pictureBox_Clear_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear_login.Image = global::BSBD_App.Properties.Resources.passno;
            this.pictureBox_Clear_login.Location = new System.Drawing.Point(328, 60);
            this.pictureBox_Clear_login.Name = "pictureBox_Clear_login";
            this.pictureBox_Clear_login.Size = new System.Drawing.Size(29, 29);
            this.pictureBox_Clear_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Clear_login.TabIndex = 10;
            this.pictureBox_Clear_login.TabStop = false;
            this.pictureBox_Clear_login.Click += new System.EventHandler(this.pictureBox_Clear_login_Click);
            // 
            // pictureBox_Clear_pass
            // 
            this.pictureBox_Clear_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear_pass.Image = global::BSBD_App.Properties.Resources.passno;
            this.pictureBox_Clear_pass.Location = new System.Drawing.Point(328, 148);
            this.pictureBox_Clear_pass.Name = "pictureBox_Clear_pass";
            this.pictureBox_Clear_pass.Size = new System.Drawing.Size(29, 29);
            this.pictureBox_Clear_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Clear_pass.TabIndex = 9;
            this.pictureBox_Clear_pass.TabStop = false;
            this.pictureBox_Clear_pass.Click += new System.EventHandler(this.pictureBox_Clear_pass_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Image = global::BSBD_App.Properties.Resources.clear1;
            this.pictureBoxClear.Location = new System.Drawing.Point(378, 282);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(44, 44);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClear.TabIndex = 4;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // comboBox_rule
            // 
            this.comboBox_rule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rule.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_rule.FormattingEnabled = true;
            this.comboBox_rule.ItemHeight = 26;
            this.comboBox_rule.Items.AddRange(new object[] {
            "Бухгалтер",
            "Главный бухгалтер"});
            this.comboBox_rule.Location = new System.Drawing.Point(111, 237);
            this.comboBox_rule.Name = "comboBox_rule";
            this.comboBox_rule.Size = new System.Drawing.Size(211, 34);
            this.comboBox_rule.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Роль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(111, 148);
            this.textBox_password.MaxLength = 50;
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_password.Size = new System.Drawing.Size(211, 44);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(111, 60);
            this.textBox_login.MaxLength = 50;
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_login.Size = new System.Drawing.Size(211, 44);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            this.textBox_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_KeyPress);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(135, 121);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Controls.Add(this.btnDel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(547, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 341);
            this.panel3.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(51, 245);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 69);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(51, 151);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(198, 69);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Управление записями";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(51, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать новую запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(870, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(232)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(868, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.pictureBox_refresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAccountant";
            this.Text = "Бухгалеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccountant_FormClosing);
            this.Load += new System.EventHandler(this.FormAccountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.ComboBox comboBox_rule;
        private System.Windows.Forms.PictureBox pictureBox_Clear_pass;
        private System.Windows.Forms.PictureBox pictureBox_Clear_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_inf;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}