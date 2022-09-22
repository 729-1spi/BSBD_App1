
namespace BSBD_App
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.workDataSet1 = new BSBD_App.WorkDataSet1();
            this.бухгалтерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бухгалтерTableAdapter = new BSBD_App.WorkDataSet1TableAdapters.БухгалтерTableAdapter();
            this.tableAdapterManager = new BSBD_App.WorkDataSet1TableAdapters.TableAdapterManager();
            this.бухгалтерDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.workDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workDataSet1
            // 
            this.workDataSet1.DataSetName = "WorkDataSet1";
            this.workDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бухгалтерBindingSource
            // 
            this.бухгалтерBindingSource.DataMember = "Бухгалтер";
            this.бухгалтерBindingSource.DataSource = this.workDataSet1;
            // 
            // бухгалтерTableAdapter
            // 
            this.бухгалтерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BSBD_App.WorkDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БухгалтерTableAdapter = this.бухгалтерTableAdapter;
            this.tableAdapterManager.ВыплатыTableAdapter = null;
            this.tableAdapterManager.История_заработной_платыTableAdapter = null;
            this.tableAdapterManager.ОтчисленияTableAdapter = null;
            this.tableAdapterManager.РаботникTableAdapter = null;
            this.tableAdapterManager.СчетTableAdapter = null;
            // 
            // бухгалтерDataGridView
            // 
            this.бухгалтерDataGridView.AllowUserToAddRows = false;
            this.бухгалтерDataGridView.AllowUserToDeleteRows = false;
            this.бухгалтерDataGridView.AutoGenerateColumns = false;
            this.бухгалтерDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.бухгалтерDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.бухгалтерDataGridView.DataSource = this.бухгалтерBindingSource;
            this.бухгалтерDataGridView.Location = new System.Drawing.Point(4, -2);
            this.бухгалтерDataGridView.Name = "бухгалтерDataGridView";
            this.бухгалтерDataGridView.ReadOnly = true;
            this.бухгалтерDataGridView.Size = new System.Drawing.Size(796, 227);
            this.бухгалтерDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_бухгалтера";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_бухгалтера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Роль";
            this.dataGridViewTextBoxColumn4.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.бухгалтерDataGridView);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бухгалтерDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WorkDataSet1 workDataSet1;
        private System.Windows.Forms.BindingSource бухгалтерBindingSource;
        private WorkDataSet1TableAdapters.БухгалтерTableAdapter бухгалтерTableAdapter;
        private WorkDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView бухгалтерDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}