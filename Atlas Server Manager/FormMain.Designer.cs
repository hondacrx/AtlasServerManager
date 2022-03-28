namespace AtlasServerManager
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.bLogs = new FontAwesome.Sharp.IconButton();
            this.bDatabase = new FontAwesome.Sharp.IconButton();
            this.bConfigEditor = new FontAwesome.Sharp.IconButton();
            this.bServers = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPlayersOnline = new System.Windows.Forms.Label();
            this.lMemory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lCpuPercent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMemoryPercent = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconButton6);
            this.panelMenu.Controls.Add(this.bLogs);
            this.panelMenu.Controls.Add(this.bDatabase);
            this.panelMenu.Controls.Add(this.bConfigEditor);
            this.panelMenu.Controls.Add(this.bServers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 750);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 690);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Size = new System.Drawing.Size(230, 60);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.Tag = "Exit";
            this.iconButton6.Text = "Exit";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // bLogs
            // 
            this.bLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.bLogs.FlatAppearance.BorderSize = 0;
            this.bLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogs.ForeColor = System.Drawing.Color.Gainsboro;
            this.bLogs.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.bLogs.IconColor = System.Drawing.Color.Gainsboro;
            this.bLogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLogs.Location = new System.Drawing.Point(0, 280);
            this.bLogs.Name = "bLogs";
            this.bLogs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bLogs.Size = new System.Drawing.Size(230, 60);
            this.bLogs.TabIndex = 4;
            this.bLogs.Tag = "Logs";
            this.bLogs.Text = "Logs";
            this.bLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bLogs.UseVisualStyleBackColor = true;
            this.bLogs.Click += new System.EventHandler(this.bLogs_Click);
            // 
            // bDatabase
            // 
            this.bDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDatabase.FlatAppearance.BorderSize = 0;
            this.bDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDatabase.ForeColor = System.Drawing.Color.Gainsboro;
            this.bDatabase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.bDatabase.IconColor = System.Drawing.Color.Gainsboro;
            this.bDatabase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDatabase.Location = new System.Drawing.Point(0, 220);
            this.bDatabase.Name = "bDatabase";
            this.bDatabase.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bDatabase.Size = new System.Drawing.Size(230, 60);
            this.bDatabase.TabIndex = 3;
            this.bDatabase.Tag = "Database";
            this.bDatabase.Text = "Database";
            this.bDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bDatabase.UseVisualStyleBackColor = true;
            this.bDatabase.Click += new System.EventHandler(this.bDatabase_Click);
            // 
            // bConfigEditor
            // 
            this.bConfigEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bConfigEditor.FlatAppearance.BorderSize = 0;
            this.bConfigEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfigEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.bConfigEditor.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bConfigEditor.IconColor = System.Drawing.Color.Gainsboro;
            this.bConfigEditor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bConfigEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConfigEditor.Location = new System.Drawing.Point(0, 160);
            this.bConfigEditor.Name = "bConfigEditor";
            this.bConfigEditor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bConfigEditor.Size = new System.Drawing.Size(230, 60);
            this.bConfigEditor.TabIndex = 2;
            this.bConfigEditor.Tag = "Config Editor";
            this.bConfigEditor.Text = "Config Editor";
            this.bConfigEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConfigEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bConfigEditor.UseVisualStyleBackColor = true;
            this.bConfigEditor.Click += new System.EventHandler(this.bConfigEditor_Click);
            // 
            // bServers
            // 
            this.bServers.Dock = System.Windows.Forms.DockStyle.Top;
            this.bServers.FlatAppearance.BorderSize = 0;
            this.bServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bServers.ForeColor = System.Drawing.Color.Gainsboro;
            this.bServers.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.bServers.IconColor = System.Drawing.Color.Gainsboro;
            this.bServers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bServers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bServers.Location = new System.Drawing.Point(0, 100);
            this.bServers.Name = "bServers";
            this.bServers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bServers.Size = new System.Drawing.Size(230, 60);
            this.bServers.TabIndex = 0;
            this.bServers.Tag = "Servers";
            this.bServers.Text = "Servers";
            this.bServers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bServers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bServers.UseVisualStyleBackColor = true;
            this.bServers.Click += new System.EventHandler(this.bServers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lName);
            this.panelLogo.Controls.Add(this.btnMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.Transparent;
            this.lName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lName.ForeColor = System.Drawing.Color.White;
            this.lName.Location = new System.Drawing.Point(12, 11);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(139, 64);
            this.lName.TabIndex = 1;
            this.lName.Text = "Atlas Server\r\nManager";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(164, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.groupBox1);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.iconButton9);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1082, 54);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lPlayersOnline);
            this.groupBox1.Controls.Add(this.lMemory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lCpuPercent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lMemoryPercent);
            this.groupBox1.Location = new System.Drawing.Point(388, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lPlayersOnline
            // 
            this.lPlayersOnline.AutoSize = true;
            this.lPlayersOnline.ForeColor = System.Drawing.Color.White;
            this.lPlayersOnline.Location = new System.Drawing.Point(253, 19);
            this.lPlayersOnline.Name = "lPlayersOnline";
            this.lPlayersOnline.Size = new System.Drawing.Size(13, 15);
            this.lPlayersOnline.TabIndex = 14;
            this.lPlayersOnline.Text = "0";
            // 
            // lMemory
            // 
            this.lMemory.AutoSize = true;
            this.lMemory.ForeColor = System.Drawing.Color.White;
            this.lMemory.Location = new System.Drawing.Point(72, 19);
            this.lMemory.Name = "lMemory";
            this.lMemory.Size = new System.Drawing.Size(55, 15);
            this.lMemory.TabIndex = 9;
            this.lMemory.Text = "Memory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Players Online:";
            // 
            // lCpuPercent
            // 
            this.lCpuPercent.AutoSize = true;
            this.lCpuPercent.BackColor = System.Drawing.Color.Transparent;
            this.lCpuPercent.ForeColor = System.Drawing.Color.White;
            this.lCpuPercent.Location = new System.Drawing.Point(43, 19);
            this.lCpuPercent.Name = "lCpuPercent";
            this.lCpuPercent.Size = new System.Drawing.Size(23, 15);
            this.lCpuPercent.TabIndex = 11;
            this.lCpuPercent.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cpu:";
            // 
            // lMemoryPercent
            // 
            this.lMemoryPercent.AutoSize = true;
            this.lMemoryPercent.ForeColor = System.Drawing.Color.White;
            this.lMemoryPercent.Location = new System.Drawing.Point(133, 19);
            this.lMemoryPercent.Name = "lMemoryPercent";
            this.lMemoryPercent.Size = new System.Drawing.Size(23, 15);
            this.lMemoryPercent.TabIndex = 12;
            this.lMemoryPercent.Text = "0%";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(995, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1057, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // iconButton9
            // 
            this.iconButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton9.IconColor = System.Drawing.Color.White;
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 20;
            this.iconButton9.Location = new System.Drawing.Point(1026, 0);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButton9.Size = new System.Drawing.Size(25, 25);
            this.iconButton9.TabIndex = 4;
            this.iconButton9.UseVisualStyleBackColor = false;
            this.iconButton9.Click += new System.EventHandler(this.bMaximize_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(230, 54);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1082, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 63);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1082, 687);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton bLogs;
        private FontAwesome.Sharp.IconButton bDatabase;
        private FontAwesome.Sharp.IconButton bConfigEditor;
        private FontAwesome.Sharp.IconButton bServers;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Label lName;
        private Label label2;
        private Label lMemoryPercent;
        private Label lCpuPercent;
        private Label lMemory;
        private Label lPlayersOnline;
        private Label label1;
        private GroupBox groupBox1;
    }
}