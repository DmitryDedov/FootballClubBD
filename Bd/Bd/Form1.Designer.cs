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
            this.labelSelectTypeUser = new System.Windows.Forms.Label();
            this.radioButtonCoach = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.labelInputPassword = new System.Windows.Forms.Label();
            this.textBoxInputPassword = new System.Windows.Forms.TextBox();
            this.buttonStartWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectTypeUser
            // 
            this.labelSelectTypeUser.AutoSize = true;
            this.labelSelectTypeUser.Location = new System.Drawing.Point(12, 9);
            this.labelSelectTypeUser.Name = "labelSelectTypeUser";
            this.labelSelectTypeUser.Size = new System.Drawing.Size(154, 13);
            this.labelSelectTypeUser.TabIndex = 0;
            this.labelSelectTypeUser.Text = "Выберите тип пользователя:";
            // 
            // radioButtonCoach
            // 
            this.radioButtonCoach.AutoSize = true;
            this.radioButtonCoach.Checked = true;
            this.radioButtonCoach.Location = new System.Drawing.Point(12, 25);
            this.radioButtonCoach.Name = "radioButtonCoach";
            this.radioButtonCoach.Size = new System.Drawing.Size(62, 17);
            this.radioButtonCoach.TabIndex = 1;
            this.radioButtonCoach.TabStop = true;
            this.radioButtonCoach.Text = "Тренер";
            this.radioButtonCoach.UseVisualStyleBackColor = true;
            this.radioButtonCoach.CheckedChanged += new System.EventHandler(this.radioButtonUser_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(12, 48);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(104, 17);
            this.radioButtonAdmin.TabIndex = 2;
            this.radioButtonAdmin.Text = "Администратор";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // labelInputPassword
            // 
            this.labelInputPassword.AutoSize = true;
            this.labelInputPassword.Location = new System.Drawing.Point(212, 50);
            this.labelInputPassword.Name = "labelInputPassword";
            this.labelInputPassword.Size = new System.Drawing.Size(178, 13);
            this.labelInputPassword.TabIndex = 3;
            this.labelInputPassword.Text = "Введите пароль администратора:";
            this.labelInputPassword.Visible = false;
            // 
            // textBoxInputPassword
            // 
            this.textBoxInputPassword.Location = new System.Drawing.Point(277, 71);
            this.textBoxInputPassword.Name = "textBoxInputPassword";
            this.textBoxInputPassword.Size = new System.Drawing.Size(57, 20);
            this.textBoxInputPassword.TabIndex = 4;
            this.textBoxInputPassword.Text = "1";
            this.textBoxInputPassword.Visible = false;
            this.textBoxInputPassword.TextChanged += new System.EventHandler(this.textBoxInputPassword_TextChanged);
            // 
            // buttonStartWork
            // 
            this.buttonStartWork.Location = new System.Drawing.Point(12, 71);
            this.buttonStartWork.Name = "buttonStartWork";
            this.buttonStartWork.Size = new System.Drawing.Size(154, 23);
            this.buttonStartWork.TabIndex = 5;
            this.buttonStartWork.Text = "Начать работу";
            this.buttonStartWork.UseVisualStyleBackColor = true;
            this.buttonStartWork.Click += new System.EventHandler(this.buttonStartWork_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 108);
            this.Controls.Add(this.buttonStartWork);
            this.Controls.Add(this.textBoxInputPassword);
            this.Controls.Add(this.labelInputPassword);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.radioButtonCoach);
            this.Controls.Add(this.labelSelectTypeUser);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectTypeUser;
        private System.Windows.Forms.RadioButton radioButtonCoach;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label labelInputPassword;
        private System.Windows.Forms.TextBox textBoxInputPassword;
        private System.Windows.Forms.Button buttonStartWork;


    }
}

