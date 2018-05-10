namespace GoldSentinel
{
    partial class MainForm
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
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStagffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVisitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBuildingBtn = new System.Windows.Forms.Button();
            this.managePatientBtn = new System.Windows.Forms.Button();
            this.signOutVisitorBtn = new System.Windows.Forms.Button();
            this.manageStaffBtn = new System.Windows.Forms.Button();
            this.manageVisitorBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.visitorToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBuildingToolStripMenuItem});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.roomToolStripMenuItem.Text = "Building";
            // 
            // manageBuildingToolStripMenuItem
            // 
            this.manageBuildingToolStripMenuItem.Name = "manageBuildingToolStripMenuItem";
            this.manageBuildingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.manageBuildingToolStripMenuItem.Text = "Manage Building";
            this.manageBuildingToolStripMenuItem.Click += new System.EventHandler(this.manageBuildingToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStagffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // manageStagffToolStripMenuItem
            // 
            this.manageStagffToolStripMenuItem.Name = "manageStagffToolStripMenuItem";
            this.manageStagffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.manageStagffToolStripMenuItem.Text = "Manage Staff";
            this.manageStagffToolStripMenuItem.Click += new System.EventHandler(this.manageStaffToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // managePatientToolStripMenuItem
            // 
            this.managePatientToolStripMenuItem.Name = "managePatientToolStripMenuItem";
            this.managePatientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.managePatientToolStripMenuItem.Text = "Manage Patient";
            this.managePatientToolStripMenuItem.Click += new System.EventHandler(this.managePatientToolStripMenuItem_Click);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVisitorToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // manageVisitorToolStripMenuItem
            // 
            this.manageVisitorToolStripMenuItem.Name = "manageVisitorToolStripMenuItem";
            this.manageVisitorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.manageVisitorToolStripMenuItem.Text = "Manage Visitors";
            this.manageVisitorToolStripMenuItem.Click += new System.EventHandler(this.manageVisitorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // manageBuildingBtn
            // 
            this.manageBuildingBtn.Location = new System.Drawing.Point(12, 40);
            this.manageBuildingBtn.Name = "manageBuildingBtn";
            this.manageBuildingBtn.Size = new System.Drawing.Size(150, 43);
            this.manageBuildingBtn.TabIndex = 0;
            this.manageBuildingBtn.Text = "Manage Building";
            this.manageBuildingBtn.UseVisualStyleBackColor = true;
            this.manageBuildingBtn.Click += new System.EventHandler(this.manageBuildingBtn_Click);
            // 
            // managePatientBtn
            // 
            this.managePatientBtn.Location = new System.Drawing.Point(12, 138);
            this.managePatientBtn.Name = "managePatientBtn";
            this.managePatientBtn.Size = new System.Drawing.Size(150, 43);
            this.managePatientBtn.TabIndex = 1;
            this.managePatientBtn.Text = "Manage Patient";
            this.managePatientBtn.UseVisualStyleBackColor = true;
            this.managePatientBtn.Click += new System.EventHandler(this.managePatientBtn_Click);
            // 
            // signOutVisitorBtn
            // 
            this.signOutVisitorBtn.Location = new System.Drawing.Point(12, 236);
            this.signOutVisitorBtn.Name = "signOutVisitorBtn";
            this.signOutVisitorBtn.Size = new System.Drawing.Size(150, 43);
            this.signOutVisitorBtn.TabIndex = 2;
            this.signOutVisitorBtn.Text = "Sign Out Visitor";
            this.signOutVisitorBtn.UseVisualStyleBackColor = true;
            this.signOutVisitorBtn.Click += new System.EventHandler(this.signOutVisitorBtn_Click);
            // 
            // manageStaffBtn
            // 
            this.manageStaffBtn.Location = new System.Drawing.Point(12, 89);
            this.manageStaffBtn.Name = "manageStaffBtn";
            this.manageStaffBtn.Size = new System.Drawing.Size(150, 43);
            this.manageStaffBtn.TabIndex = 4;
            this.manageStaffBtn.Text = "Manage Staff";
            this.manageStaffBtn.UseVisualStyleBackColor = true;
            this.manageStaffBtn.Click += new System.EventHandler(this.manageStaffBtn_Click);
            // 
            // manageVisitorBtn
            // 
            this.manageVisitorBtn.Location = new System.Drawing.Point(12, 187);
            this.manageVisitorBtn.Name = "manageVisitorBtn";
            this.manageVisitorBtn.Size = new System.Drawing.Size(150, 43);
            this.manageVisitorBtn.TabIndex = 5;
            this.manageVisitorBtn.Text = "Manage Visitors";
            this.manageVisitorBtn.UseVisualStyleBackColor = true;
            this.manageVisitorBtn.Click += new System.EventHandler(this.manageVisitorBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(755, 419);
            this.dataGridView1.TabIndex = 6;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(12, 416);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(150, 43);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 471);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.manageVisitorBtn);
            this.Controls.Add(this.manageStaffBtn);
            this.Controls.Add(this.signOutVisitorBtn);
            this.Controls.Add(this.managePatientBtn);
            this.Controls.Add(this.manageBuildingBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatientToolStripMenuItem;
        private System.Windows.Forms.Button manageBuildingBtn;
        private System.Windows.Forms.Button managePatientBtn;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVisitorToolStripMenuItem;
        private System.Windows.Forms.Button signOutVisitorBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStagffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button manageStaffBtn;
        private System.Windows.Forms.Button manageVisitorBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
    }
}

