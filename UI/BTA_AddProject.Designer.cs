namespace Bug_Tracking_Application
{
    partial class BTA_AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTA_AddProject));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_projecttitle = new System.Windows.Forms.Label();
            this.label_projectdescription = new System.Windows.Forms.Label();
            this.label_projecturl = new System.Windows.Forms.Label();
            this.label_startdate = new System.Windows.Forms.Label();
            this.label_enddate = new System.Windows.Forms.Label();
            this.dateTimePicker_startdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_enddate = new System.Windows.Forms.DateTimePicker();
            this.textBox_projecttitle = new System.Windows.Forms.TextBox();
            this.textBox_projectdescription = new System.Windows.Forms.TextBox();
            this.textBox_projecturl = new System.Windows.Forms.TextBox();
            this.label_adddnewproject = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.dataGridView_Projects = new System.Windows.Forms.DataGridView();
            this.label_projectId = new System.Windows.Forms.Label();
            this.textBox_ProjectID = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.bugsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.projectsToolStripMenuItem.Text = "Projects";
            this.projectsToolStripMenuItem.Click += new System.EventHandler(this.projectsToolStripMenuItem_Click);
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.bugsToolStripMenuItem.Text = "Bugs";
            this.bugsToolStripMenuItem.Click += new System.EventHandler(this.bugsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label_projecttitle
            // 
            this.label_projecttitle.AutoSize = true;
            this.label_projecttitle.BackColor = System.Drawing.Color.Transparent;
            this.label_projecttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projecttitle.Location = new System.Drawing.Point(15, 113);
            this.label_projecttitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projecttitle.Name = "label_projecttitle";
            this.label_projecttitle.Size = new System.Drawing.Size(99, 20);
            this.label_projecttitle.TabIndex = 1;
            this.label_projecttitle.Text = "Project Title";
            // 
            // label_projectdescription
            // 
            this.label_projectdescription.AutoSize = true;
            this.label_projectdescription.BackColor = System.Drawing.Color.Transparent;
            this.label_projectdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectdescription.Location = new System.Drawing.Point(15, 169);
            this.label_projectdescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectdescription.Name = "label_projectdescription";
            this.label_projectdescription.Size = new System.Drawing.Size(153, 20);
            this.label_projectdescription.TabIndex = 2;
            this.label_projectdescription.Text = "Project Description";
            // 
            // label_projecturl
            // 
            this.label_projecturl.AutoSize = true;
            this.label_projecturl.BackColor = System.Drawing.Color.Transparent;
            this.label_projecturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projecturl.Location = new System.Drawing.Point(15, 295);
            this.label_projecturl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projecturl.Name = "label_projecturl";
            this.label_projecturl.Size = new System.Drawing.Size(101, 20);
            this.label_projecturl.TabIndex = 3;
            this.label_projecturl.Text = "Project URL";
            // 
            // label_startdate
            // 
            this.label_startdate.AutoSize = true;
            this.label_startdate.BackColor = System.Drawing.Color.Transparent;
            this.label_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startdate.Location = new System.Drawing.Point(15, 354);
            this.label_startdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startdate.Name = "label_startdate";
            this.label_startdate.Size = new System.Drawing.Size(86, 20);
            this.label_startdate.TabIndex = 4;
            this.label_startdate.Text = "Start Date";
            // 
            // label_enddate
            // 
            this.label_enddate.AutoSize = true;
            this.label_enddate.BackColor = System.Drawing.Color.Transparent;
            this.label_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enddate.Location = new System.Drawing.Point(15, 425);
            this.label_enddate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_enddate.Name = "label_enddate";
            this.label_enddate.Size = new System.Drawing.Size(79, 20);
            this.label_enddate.TabIndex = 5;
            this.label_enddate.Text = "End Date";
            // 
            // dateTimePicker_startdate
            // 
            this.dateTimePicker_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startdate.Location = new System.Drawing.Point(193, 354);
            this.dateTimePicker_startdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_startdate.Name = "dateTimePicker_startdate";
            this.dateTimePicker_startdate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_startdate.TabIndex = 6;
            // 
            // dateTimePicker_enddate
            // 
            this.dateTimePicker_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_enddate.Location = new System.Drawing.Point(193, 425);
            this.dateTimePicker_enddate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_enddate.Name = "dateTimePicker_enddate";
            this.dateTimePicker_enddate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_enddate.TabIndex = 7;
            // 
            // textBox_projecttitle
            // 
            this.textBox_projecttitle.Location = new System.Drawing.Point(193, 113);
            this.textBox_projecttitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_projecttitle.Name = "textBox_projecttitle";
            this.textBox_projecttitle.Size = new System.Drawing.Size(265, 22);
            this.textBox_projecttitle.TabIndex = 8;
            // 
            // textBox_projectdescription
            // 
            this.textBox_projectdescription.Location = new System.Drawing.Point(193, 169);
            this.textBox_projectdescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_projectdescription.Multiline = true;
            this.textBox_projectdescription.Name = "textBox_projectdescription";
            this.textBox_projectdescription.Size = new System.Drawing.Size(265, 86);
            this.textBox_projectdescription.TabIndex = 9;
            // 
            // textBox_projecturl
            // 
            this.textBox_projecturl.Location = new System.Drawing.Point(193, 295);
            this.textBox_projecturl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_projecturl.Name = "textBox_projecturl";
            this.textBox_projecturl.Size = new System.Drawing.Size(265, 22);
            this.textBox_projecturl.TabIndex = 10;
            // 
            // label_adddnewproject
            // 
            this.label_adddnewproject.AutoSize = true;
            this.label_adddnewproject.BackColor = System.Drawing.Color.Transparent;
            this.label_adddnewproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adddnewproject.Location = new System.Drawing.Point(415, 38);
            this.label_adddnewproject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_adddnewproject.Name = "label_adddnewproject";
            this.label_adddnewproject.Size = new System.Drawing.Size(174, 25);
            this.label_adddnewproject.TabIndex = 11;
            this.label_adddnewproject.Text = "Manage Projects";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Green;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add.Location = new System.Drawing.Point(193, 478);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 42);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "SAVE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Navy;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(328, 478);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(100, 42);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // dataGridView_Projects
            // 
            this.dataGridView_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Projects.Location = new System.Drawing.Point(504, 74);
            this.dataGridView_Projects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Projects.Name = "dataGridView_Projects";
            this.dataGridView_Projects.RowHeadersWidth = 51;
            this.dataGridView_Projects.Size = new System.Drawing.Size(711, 375);
            this.dataGridView_Projects.TabIndex = 14;
            this.dataGridView_Projects.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Projects_RowHeaderMouseClick);
            // 
            // label_projectId
            // 
            this.label_projectId.AutoSize = true;
            this.label_projectId.BackColor = System.Drawing.Color.Transparent;
            this.label_projectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectId.Location = new System.Drawing.Point(16, 74);
            this.label_projectId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_projectId.Name = "label_projectId";
            this.label_projectId.Size = new System.Drawing.Size(84, 20);
            this.label_projectId.TabIndex = 15;
            this.label_projectId.Text = "Project ID";
            // 
            // textBox_ProjectID
            // 
            this.textBox_ProjectID.Location = new System.Drawing.Point(193, 74);
            this.textBox_ProjectID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ProjectID.Name = "textBox_ProjectID";
            this.textBox_ProjectID.ReadOnly = true;
            this.textBox_ProjectID.Size = new System.Drawing.Size(265, 22);
            this.textBox_ProjectID.TabIndex = 16;
            this.textBox_ProjectID.TextChanged += new System.EventHandler(this.textBox_ProjectID_TextChanged);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(464, 478);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 42);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(1184, 1);
            this.pictureBox_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(31, 28);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Close.TabIndex = 19;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            this.pictureBox_Close.MouseHover += new System.EventHandler(this.pictureBox_Close_MouseHover);
            // 
            // BTA_AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 540);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_ProjectID);
            this.Controls.Add(this.label_projectId);
            this.Controls.Add(this.dataGridView_Projects);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_adddnewproject);
            this.Controls.Add(this.textBox_projecturl);
            this.Controls.Add(this.textBox_projectdescription);
            this.Controls.Add(this.textBox_projecttitle);
            this.Controls.Add(this.dateTimePicker_enddate);
            this.Controls.Add(this.dateTimePicker_startdate);
            this.Controls.Add(this.label_enddate);
            this.Controls.Add(this.label_startdate);
            this.Controls.Add(this.label_projecturl);
            this.Controls.Add(this.label_projectdescription);
            this.Controls.Add(this.label_projecttitle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BTA_AddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTA_AddProject";
            this.Load += new System.EventHandler(this.BTA_AddProject_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label_projecttitle;
        private System.Windows.Forms.Label label_projectdescription;
        private System.Windows.Forms.Label label_projecturl;
        private System.Windows.Forms.Label label_startdate;
        private System.Windows.Forms.Label label_enddate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_enddate;
        private System.Windows.Forms.TextBox textBox_projecttitle;
        private System.Windows.Forms.TextBox textBox_projectdescription;
        private System.Windows.Forms.TextBox textBox_projecturl;
        private System.Windows.Forms.Label label_adddnewproject;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.DataGridView dataGridView_Projects;
        private System.Windows.Forms.Label label_projectId;
        private System.Windows.Forms.TextBox textBox_ProjectID;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}