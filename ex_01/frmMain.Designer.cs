namespace ex_01
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traineeToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.tutorToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // traineeToolStripMenuItem
            // 
            this.traineeToolStripMenuItem.Name = "traineeToolStripMenuItem";
            this.traineeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.traineeToolStripMenuItem.Text = "Trainee";
            this.traineeToolStripMenuItem.Click += new System.EventHandler(this.traineeToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.insertToolStripMenuItem.Text = "Insert_Update_Delete";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorEntryToolStripMenuItem,
            this.tutorUpdateToolStripMenuItem,
            this.tutorViewToolStripMenuItem});
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.tutorToolStripMenuItem.Text = "Tutor";
            // 
            // tutorEntryToolStripMenuItem
            // 
            this.tutorEntryToolStripMenuItem.Name = "tutorEntryToolStripMenuItem";
            this.tutorEntryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tutorEntryToolStripMenuItem.Text = "Tutor Entry";
            this.tutorEntryToolStripMenuItem.Click += new System.EventHandler(this.tutorEntryToolStripMenuItem_Click);
            // 
            // tutorUpdateToolStripMenuItem
            // 
            this.tutorUpdateToolStripMenuItem.Name = "tutorUpdateToolStripMenuItem";
            this.tutorUpdateToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tutorUpdateToolStripMenuItem.Text = "Tutor Update/Delete";
            this.tutorUpdateToolStripMenuItem.Click += new System.EventHandler(this.tutorUpdateToolStripMenuItem_Click);
            // 
            // tutorViewToolStripMenuItem
            // 
            this.tutorViewToolStripMenuItem.Name = "tutorViewToolStripMenuItem";
            this.tutorViewToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tutorViewToolStripMenuItem.Text = "Tutor View";
            this.tutorViewToolStripMenuItem.Click += new System.EventHandler(this.tutorViewToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorInformationReportToolStripMenuItem,
            this.productInformationReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // tutorInformationReportToolStripMenuItem
            // 
            this.tutorInformationReportToolStripMenuItem.Name = "tutorInformationReportToolStripMenuItem";
            this.tutorInformationReportToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.tutorInformationReportToolStripMenuItem.Text = "Tutor Information Report";
            this.tutorInformationReportToolStripMenuItem.Click += new System.EventHandler(this.tutorInformationReportToolStripMenuItem_Click);
            // 
            // productInformationReportToolStripMenuItem
            // 
            this.productInformationReportToolStripMenuItem.Name = "productInformationReportToolStripMenuItem";
            this.productInformationReportToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.productInformationReportToolStripMenuItem.Text = "Product Information Report";
            this.productInformationReportToolStripMenuItem.Click += new System.EventHandler(this.productInformationReportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInformationReportToolStripMenuItem;
    }
}