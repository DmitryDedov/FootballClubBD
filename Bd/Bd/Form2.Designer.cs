namespace Bd
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelMainTypeOperation = new System.Windows.Forms.Label();
            this.comboBoxTypeOperation = new System.Windows.Forms.ComboBox();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonRoalback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 335);
            this.dataGridView1.TabIndex = 19;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(177, 52);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(124, 23);
            this.buttonSelect.TabIndex = 20;
            this.buttonSelect.Text = "Просмотр данных";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelMainTypeOperation
            // 
            this.labelMainTypeOperation.AutoSize = true;
            this.labelMainTypeOperation.Location = new System.Drawing.Point(107, 9);
            this.labelMainTypeOperation.Name = "labelMainTypeOperation";
            this.labelMainTypeOperation.Size = new System.Drawing.Size(131, 13);
            this.labelMainTypeOperation.TabIndex = 21;
            this.labelMainTypeOperation.Text = "Выберите тип операции:";
            // 
            // comboBoxTypeOperation
            // 
            this.comboBoxTypeOperation.FormattingEnabled = true;
            this.comboBoxTypeOperation.Items.AddRange(new object[] {
            "Работа с футбольным клубом",
            "Работа с контрактами"});
            this.comboBoxTypeOperation.Location = new System.Drawing.Point(12, 25);
            this.comboBoxTypeOperation.Name = "comboBoxTypeOperation";
            this.comboBoxTypeOperation.Size = new System.Drawing.Size(289, 21);
            this.comboBoxTypeOperation.TabIndex = 24;
            this.comboBoxTypeOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOperation_SelectedIndexChanged);
            // 
            // buttonEditing
            // 
            this.buttonEditing.Location = new System.Drawing.Point(12, 52);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(159, 23);
            this.buttonEditing.TabIndex = 25;
            this.buttonEditing.Text = "Редактирование данных";
            this.buttonEditing.UseVisualStyleBackColor = true;
            this.buttonEditing.Click += new System.EventHandler(this.buttonEditing_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(93, 321);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(177, 321);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Удаление";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCommit
            // 
            this.buttonCommit.Location = new System.Drawing.Point(12, 350);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(119, 25);
            this.buttonCommit.TabIndex = 29;
            this.buttonCommit.Text = "Сохранить данные";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonRoalback
            // 
            this.buttonRoalback.Location = new System.Drawing.Point(137, 350);
            this.buttonRoalback.Name = "buttonRoalback";
            this.buttonRoalback.Size = new System.Drawing.Size(115, 25);
            this.buttonRoalback.TabIndex = 30;
            this.buttonRoalback.Text = "Откатить данные";
            this.buttonRoalback.UseVisualStyleBackColor = true;
            this.buttonRoalback.Click += new System.EventHandler(this.buttonRoalback_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 389);
            this.Controls.Add(this.buttonRoalback);
            this.Controls.Add(this.buttonCommit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEditing);
            this.Controls.Add(this.comboBoxTypeOperation);
            this.Controls.Add(this.labelMainTypeOperation);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "CreateContract";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelMainTypeOperation;
        private System.Windows.Forms.ComboBox comboBoxTypeOperation;
        private System.Windows.Forms.Button buttonEditing;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonRoalback;
    }
}