namespace Bd
{
    partial class Form3
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
            this.comboBoxTypeOperation = new System.Windows.Forms.ComboBox();
            this.buttonDo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeOperation
            // 
            this.comboBoxTypeOperation.FormattingEnabled = true;
            this.comboBoxTypeOperation.Items.AddRange(new object[] {
            "Посмотреть информацию о футбольном клубе",
            "Посмотреть информацию о контрактах",
            "Посмотреть информацию о работних",
            "Посмотреть информацию о спонсорах"});
            this.comboBoxTypeOperation.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTypeOperation.Name = "comboBoxTypeOperation";
            this.comboBoxTypeOperation.Size = new System.Drawing.Size(246, 21);
            this.comboBoxTypeOperation.TabIndex = 0;
            this.comboBoxTypeOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeOperation_SelectedIndexChanged);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(12, 256);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(246, 23);
            this.buttonDo.TabIndex = 1;
            this.buttonDo.Text = "Посмотреть";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 283);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 307);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.comboBoxTypeOperation);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeOperation;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}