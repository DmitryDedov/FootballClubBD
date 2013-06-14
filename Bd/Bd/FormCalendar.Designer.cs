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
            this.buttonCreateTraining = new System.Windows.Forms.Button();
            this.buttonChangeTraining = new System.Windows.Forms.Button();
            this.buttonDeleteTraining = new System.Windows.Forms.Button();
            this.buttonCreateMatch = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateTraining
            // 
            this.buttonCreateTraining.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateTraining.Name = "buttonCreateTraining";
            this.buttonCreateTraining.Size = new System.Drawing.Size(87, 23);
            this.buttonCreateTraining.TabIndex = 0;
            this.buttonCreateTraining.Text = "Create training";
            this.buttonCreateTraining.UseVisualStyleBackColor = true;
            this.buttonCreateTraining.Visible = false;
            this.buttonCreateTraining.Click += new System.EventHandler(this.buttonCreateTraining_Click);
            // 
            // buttonChangeTraining
            // 
            this.buttonChangeTraining.Location = new System.Drawing.Point(105, 12);
            this.buttonChangeTraining.Name = "buttonChangeTraining";
            this.buttonChangeTraining.Size = new System.Drawing.Size(90, 23);
            this.buttonChangeTraining.TabIndex = 1;
            this.buttonChangeTraining.Text = "Change training";
            this.buttonChangeTraining.UseVisualStyleBackColor = true;
            this.buttonChangeTraining.Visible = false;
            this.buttonChangeTraining.Click += new System.EventHandler(this.buttonChangeTraining_Click);
            // 
            // buttonDeleteTraining
            // 
            this.buttonDeleteTraining.Location = new System.Drawing.Point(201, 12);
            this.buttonDeleteTraining.Name = "buttonDeleteTraining";
            this.buttonDeleteTraining.Size = new System.Drawing.Size(83, 23);
            this.buttonDeleteTraining.TabIndex = 2;
            this.buttonDeleteTraining.Text = "Delete training";
            this.buttonDeleteTraining.UseVisualStyleBackColor = true;
            this.buttonDeleteTraining.Visible = false;
            this.buttonDeleteTraining.Click += new System.EventHandler(this.buttonDeleteTraining_Click);
            // 
            // buttonCreateMatch
            // 
            this.buttonCreateMatch.Location = new System.Drawing.Point(290, 12);
            this.buttonCreateMatch.Name = "buttonCreateMatch";
            this.buttonCreateMatch.Size = new System.Drawing.Size(126, 23);
            this.buttonCreateMatch.TabIndex = 3;
            this.buttonCreateMatch.Text = "Create query on match";
            this.buttonCreateMatch.UseVisualStyleBackColor = true;
            this.buttonCreateMatch.Click += new System.EventHandler(this.buttonCreateMatch_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(422, 12);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(94, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set composition";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Visible = false;
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 302);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.buttonCreateMatch);
            this.Controls.Add(this.buttonDeleteTraining);
            this.Controls.Add(this.buttonChangeTraining);
            this.Controls.Add(this.buttonCreateTraining);
            this.Name = "FormCalendar";
            this.Text = "FormCalendar";
            this.Load += new System.EventHandler(this.FormCalendar_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCalendar_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormCalendar_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTraining;
        private System.Windows.Forms.Button buttonChangeTraining;
        private System.Windows.Forms.Button buttonDeleteTraining;
        private System.Windows.Forms.Button buttonCreateMatch;
        private System.Windows.Forms.Button buttonSet;






    }
}