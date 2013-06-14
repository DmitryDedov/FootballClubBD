namespace Bd
{
    partial class FormOffer
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOffer = new System.Windows.Forms.Button();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelCenter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(104, 9);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(299, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offer...";
            // 
            // buttonOffer
            // 
            this.buttonOffer.Location = new System.Drawing.Point(15, 47);
            this.buttonOffer.Name = "buttonOffer";
            this.buttonOffer.Size = new System.Drawing.Size(66, 23);
            this.buttonOffer.TabIndex = 2;
            this.buttonOffer.Text = "Offer";
            this.buttonOffer.UseVisualStyleBackColor = true;
            this.buttonOffer.Click += new System.EventHandler(this.buttonOffer_Click);
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(101, 26);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(13, 13);
            this.labelLeft.TabIndex = 3;
            this.labelLeft.Text = "0";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(368, 26);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(35, 13);
            this.labelRight.TabIndex = 4;
            this.labelRight.Text = "label2";
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Location = new System.Drawing.Point(237, 26);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(0, 13);
            this.labelCenter.TabIndex = 5;
            // 
            // FormOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 146);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.buttonOffer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FormOffer";
            this.Text = "FormOffer";
            this.Load += new System.EventHandler(this.FormOffer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOffer;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelCenter;
    }
}