namespace Bd
{
    partial class FormMain
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
            this.buttonStartWork = new System.Windows.Forms.Button();
            this.labelInputName = new System.Windows.Forms.Label();
            this.textBoxInputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStartWork
            // 
            this.buttonStartWork.Location = new System.Drawing.Point(12, 64);
            this.buttonStartWork.Name = "buttonStartWork";
            this.buttonStartWork.Size = new System.Drawing.Size(134, 23);
            this.buttonStartWork.TabIndex = 5;
            this.buttonStartWork.Text = "Начать работу";
            this.buttonStartWork.UseVisualStyleBackColor = true;
            this.buttonStartWork.Click += new System.EventHandler(this.buttonStartWork_Click);
            // 
            // labelInputName
            // 
            this.labelInputName.AutoSize = true;
            this.labelInputName.Location = new System.Drawing.Point(12, 15);
            this.labelInputName.Name = "labelInputName";
            this.labelInputName.Size = new System.Drawing.Size(86, 13);
            this.labelInputName.TabIndex = 6;
            this.labelInputName.Text = "Input your name:";
            // 
            // textBoxInputName
            // 
            this.textBoxInputName.Location = new System.Drawing.Point(111, 12);
            this.textBoxInputName.Name = "textBoxInputName";
            this.textBoxInputName.Size = new System.Drawing.Size(104, 20);
            this.textBoxInputName.TabIndex = 7;
            this.textBoxInputName.Text = "Jose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input password:";
            // 
            // textBoxInputPassword
            // 
            this.textBoxInputPassword.Location = new System.Drawing.Point(111, 38);
            this.textBoxInputPassword.Name = "textBoxInputPassword";
            this.textBoxInputPassword.Size = new System.Drawing.Size(104, 20);
            this.textBoxInputPassword.TabIndex = 9;
            this.textBoxInputPassword.Text = "jm";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 93);
            this.Controls.Add(this.textBoxInputPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputName);
            this.Controls.Add(this.labelInputName);
            this.Controls.Add(this.buttonStartWork);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartWork;
        private System.Windows.Forms.Label labelInputName;
        private System.Windows.Forms.TextBox textBoxInputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputPassword;



    }
}

