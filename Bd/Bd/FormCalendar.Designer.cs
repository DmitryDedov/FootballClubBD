namespace Bd
{
    partial class FormCalendar
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
            this.labelNameMonthAndYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameMonthAndYear
            // 
            this.labelNameMonthAndYear.AutoSize = true;
            this.labelNameMonthAndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMonthAndYear.Location = new System.Drawing.Point(293, 9);
            this.labelNameMonthAndYear.Name = "labelNameMonthAndYear";
            this.labelNameMonthAndYear.Size = new System.Drawing.Size(70, 17);
            this.labelNameMonthAndYear.TabIndex = 0;
            this.labelNameMonthAndYear.Text = "May 2013";
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 319);
            this.Controls.Add(this.labelNameMonthAndYear);
            this.Name = "FormCalendar";
            this.Text = "FormCalendar";
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCalendar_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormCalendar_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameMonthAndYear;

    }
}