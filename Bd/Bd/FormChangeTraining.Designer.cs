namespace Bd
{
    partial class FormChangeTraining
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
            this.radioButtonChangeTime = new System.Windows.Forms.RadioButton();
            this.radioButtonChangePlace = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPlace = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewTime = new System.Windows.Forms.TextBox();
            this.textBoxNewPlace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonChangeTime
            // 
            this.radioButtonChangeTime.AutoSize = true;
            this.radioButtonChangeTime.Location = new System.Drawing.Point(12, 12);
            this.radioButtonChangeTime.Name = "radioButtonChangeTime";
            this.radioButtonChangeTime.Size = new System.Drawing.Size(84, 17);
            this.radioButtonChangeTime.TabIndex = 0;
            this.radioButtonChangeTime.Text = "Change time";
            this.radioButtonChangeTime.UseVisualStyleBackColor = true;
            this.radioButtonChangeTime.CheckedChanged += new System.EventHandler(this.radioButtonChangeTime_CheckedChanged);
            // 
            // radioButtonChangePlace
            // 
            this.radioButtonChangePlace.AutoSize = true;
            this.radioButtonChangePlace.Location = new System.Drawing.Point(103, 12);
            this.radioButtonChangePlace.Name = "radioButtonChangePlace";
            this.radioButtonChangePlace.Size = new System.Drawing.Size(91, 17);
            this.radioButtonChangePlace.TabIndex = 1;
            this.radioButtonChangePlace.Text = "Change place";
            this.radioButtonChangePlace.UseVisualStyleBackColor = true;
            this.radioButtonChangePlace.CheckedChanged += new System.EventHandler(this.radioButtonChangePlace_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(100, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old time";
            // 
            // textBoxOldTime
            // 
            this.textBoxOldTime.Location = new System.Drawing.Point(63, 48);
            this.textBoxOldTime.Name = "textBoxOldTime";
            this.textBoxOldTime.Size = new System.Drawing.Size(72, 20);
            this.textBoxOldTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Old place";
            // 
            // textBoxOldPlace
            // 
            this.textBoxOldPlace.Location = new System.Drawing.Point(63, 74);
            this.textBoxOldPlace.Name = "textBoxOldPlace";
            this.textBoxOldPlace.Size = new System.Drawing.Size(72, 20);
            this.textBoxOldPlace.TabIndex = 7;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(103, 100);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "New time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "New place";
            // 
            // textBoxNewTime
            // 
            this.textBoxNewTime.Location = new System.Drawing.Point(207, 48);
            this.textBoxNewTime.Name = "textBoxNewTime";
            this.textBoxNewTime.Size = new System.Drawing.Size(65, 20);
            this.textBoxNewTime.TabIndex = 11;
            // 
            // textBoxNewPlace
            // 
            this.textBoxNewPlace.Location = new System.Drawing.Point(207, 74);
            this.textBoxNewPlace.Name = "textBoxNewPlace";
            this.textBoxNewPlace.Size = new System.Drawing.Size(65, 20);
            this.textBoxNewPlace.TabIndex = 12;
            // 
            // FormChangeTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.textBoxNewPlace);
            this.Controls.Add(this.textBoxNewTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.textBoxOldPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOldTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonChangePlace);
            this.Controls.Add(this.radioButtonChangeTime);
            this.Name = "FormChangeTraining";
            this.Text = "FormChangeTraining";
            this.Load += new System.EventHandler(this.FormChangeTraining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonChangeTime;
        private System.Windows.Forms.RadioButton radioButtonChangePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOldTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOldPlace;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewTime;
        private System.Windows.Forms.TextBox textBoxNewPlace;
    }
}