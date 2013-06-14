namespace Bd
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.toolStripLabelMakeContract = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButtonMakeContract = new System.Windows.Forms.ToolStripSplitButton();
            this.makeContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sponsorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelDismissEmployee = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonDismissEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelCleanSponsor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonCleanSponsor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonOffer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelChangeSalary = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonChangeSalary = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabelMakeContract
            // 
            this.toolStripLabelMakeContract.Name = "toolStripLabelMakeContract";
            this.toolStripLabelMakeContract.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabelMakeContract.Text = "Make contract ->";
            // 
            // toolStripSplitButtonMakeContract
            // 
            this.toolStripSplitButtonMakeContract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonMakeContract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeContractToolStripMenuItem});
            this.toolStripSplitButtonMakeContract.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonMakeContract.Image")));
            this.toolStripSplitButtonMakeContract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonMakeContract.Name = "toolStripSplitButtonMakeContract";
            this.toolStripSplitButtonMakeContract.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonMakeContract.Text = "Make contract";
            // 
            // makeContractToolStripMenuItem
            // 
            this.makeContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.sponsorToolStripMenuItem});
            this.makeContractToolStripMenuItem.Name = "makeContractToolStripMenuItem";
            this.makeContractToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.makeContractToolStripMenuItem.Text = "Make contract";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // sponsorToolStripMenuItem
            // 
            this.sponsorToolStripMenuItem.Name = "sponsorToolStripMenuItem";
            this.sponsorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sponsorToolStripMenuItem.Text = "Sponsor";
            this.sponsorToolStripMenuItem.Click += new System.EventHandler(this.sponsorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelDismissEmployee
            // 
            this.toolStripLabelDismissEmployee.Name = "toolStripLabelDismissEmployee";
            this.toolStripLabelDismissEmployee.Size = new System.Drawing.Size(118, 22);
            this.toolStripLabelDismissEmployee.Text = "Dismiss employee ->";
            // 
            // toolStripButtonDismissEmployee
            // 
            this.toolStripButtonDismissEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDismissEmployee.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDismissEmployee.Image")));
            this.toolStripButtonDismissEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDismissEmployee.Name = "toolStripButtonDismissEmployee";
            this.toolStripButtonDismissEmployee.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDismissEmployee.Text = "Dismiss Employee";
            this.toolStripButtonDismissEmployee.Click += new System.EventHandler(this.toolStripButtonDismissEmployee_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelCleanSponsor
            // 
            this.toolStripLabelCleanSponsor.Name = "toolStripLabelCleanSponsor";
            this.toolStripLabelCleanSponsor.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabelCleanSponsor.Text = "Clean sponsor ->";
            // 
            // toolStripButtonCleanSponsor
            // 
            this.toolStripButtonCleanSponsor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCleanSponsor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCleanSponsor.Image")));
            this.toolStripButtonCleanSponsor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCleanSponsor.Name = "toolStripButtonCleanSponsor";
            this.toolStripButtonCleanSponsor.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCleanSponsor.Text = "toolStripButtonClean sponsor";
            this.toolStripButtonCleanSponsor.Click += new System.EventHandler(this.toolStripButtonCleanSponsor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Offer ->";
            // 
            // toolStripButtonOffer
            // 
            this.toolStripButtonOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOffer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOffer.Image")));
            this.toolStripButtonOffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOffer.Name = "toolStripButtonOffer";
            this.toolStripButtonOffer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOffer.Text = "Offer";
            this.toolStripButtonOffer.Click += new System.EventHandler(this.toolStripButtonOffer_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelChangeSalary
            // 
            this.toolStripLabelChangeSalary.Name = "toolStripLabelChangeSalary";
            this.toolStripLabelChangeSalary.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabelChangeSalary.Text = "Change salary ->";
            // 
            // toolStripButtonChangeSalary
            // 
            this.toolStripButtonChangeSalary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonChangeSalary.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangeSalary.Image")));
            this.toolStripButtonChangeSalary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangeSalary.Name = "toolStripButtonChangeSalary";
            this.toolStripButtonChangeSalary.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonChangeSalary.Text = "ChangeSalary";
            this.toolStripButtonChangeSalary.Click += new System.EventHandler(this.toolStripButtonChangeSalary_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMakeContract,
            this.toolStripSplitButtonMakeContract,
            this.toolStripSeparator1,
            this.toolStripLabelDismissEmployee,
            this.toolStripButtonDismissEmployee,
            this.toolStripSeparator2,
            this.toolStripLabelCleanSponsor,
            this.toolStripButtonCleanSponsor,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripButtonOffer,
            this.toolStripSeparator4,
            this.toolStripLabelChangeSalary,
            this.toolStripButtonChangeSalary,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 24);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabelMakeContract;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonMakeContract;
        private System.Windows.Forms.ToolStripMenuItem makeContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sponsorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDismissEmployee;
        private System.Windows.Forms.ToolStripButton toolStripButtonDismissEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCleanSponsor;
        private System.Windows.Forms.ToolStripButton toolStripButtonCleanSponsor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOffer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChangeSalary;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangeSalary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}