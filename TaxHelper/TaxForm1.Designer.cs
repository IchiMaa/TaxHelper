namespace TaxHelper
{
    partial class TaxForm1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHoursPerWeek = new System.Windows.Forms.TextBox();
            this.cmSalary = new System.Windows.Forms.ComboBox();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(433, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem4.Text = "Tax Table";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(0, 24);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(111, 27);
            this.lblHourlyRate.TabIndex = 1;
            this.lblHourlyRate.Text = "Hourly Rate ($)";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(114, 28);
            this.txtHourlyRate.MaxLength = 5;
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(38, 20);
            this.txtHourlyRate.TabIndex = 2;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHourlyRate.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(0, 57);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(111, 23);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "Hours Per Week";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHoursPerWeek
            // 
            this.txtHoursPerWeek.Location = new System.Drawing.Point(114, 60);
            this.txtHoursPerWeek.MaxLength = 5;
            this.txtHoursPerWeek.Name = "txtHoursPerWeek";
            this.txtHoursPerWeek.Size = new System.Drawing.Size(38, 20);
            this.txtHoursPerWeek.TabIndex = 4;
            this.txtHoursPerWeek.Text = "37.5";
            this.txtHoursPerWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoursPerWeek.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // cmSalary
            // 
            this.cmSalary.FormattingEnabled = true;
            this.cmSalary.Items.AddRange(new object[] {
            "Weekly",
            "Fortnightly",
            "Monthly",
            "Annually"});
            this.cmSalary.Location = new System.Drawing.Point(155, 94);
            this.cmSalary.Name = "cmSalary";
            this.cmSalary.Size = new System.Drawing.Size(73, 21);
            this.cmSalary.TabIndex = 5;
            this.cmSalary.SelectedIndexChanged += new System.EventHandler(this.cmSalary_SelectedIndexChanged);
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPay.Location = new System.Drawing.Point(0, 91);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(82, 23);
            this.lblTotalPay.TabIndex = 3;
            this.lblTotalPay.Text = "Your Salary";
            this.lblTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(88, 94);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(64, 20);
            this.txtSalary.TabIndex = 4;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TaxForm1
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(433, 392);
            this.Controls.Add(this.cmSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtHoursPerWeek);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TaxForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Helper";
            this.Load += new System.EventHandler(this.TaxForm1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxTableToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHoursPerWeek;
        private System.Windows.Forms.ComboBox cmSalary;
        private System.Windows.Forms.Label lblTotalPay;
        private System.Windows.Forms.TextBox txtSalary;
    }

}

