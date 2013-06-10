namespace Bd
{
    partial class FormCleanSponsor
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonDeleteSponsor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 95);
            this.listBox.TabIndex = 0;
            // 
            // buttonDeleteSponsor
            // 
            this.buttonDeleteSponsor.Location = new System.Drawing.Point(12, 113);
            this.buttonDeleteSponsor.Name = "buttonDeleteSponsor";
            this.buttonDeleteSponsor.Size = new System.Drawing.Size(120, 23);
            this.buttonDeleteSponsor.TabIndex = 1;
            this.buttonDeleteSponsor.Text = "Delete sponsor";
            this.buttonDeleteSponsor.UseVisualStyleBackColor = true;
            this.buttonDeleteSponsor.Click += new System.EventHandler(this.buttonDeleteSponsor_Click);
            // 
            // FormCleanSponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 145);
            this.Controls.Add(this.buttonDeleteSponsor);
            this.Controls.Add(this.listBox);
            this.Name = "FormCleanSponsor";
            this.Text = "FormCleanSponsor";
            this.Load += new System.EventHandler(this.FormCleanSponsor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonDeleteSponsor;
    }
}