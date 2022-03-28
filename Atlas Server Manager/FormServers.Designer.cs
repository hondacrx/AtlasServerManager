namespace AtlasServerManager
{
    partial class FormServers
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
            this.bStopSelectedGrids = new FontAwesome.Sharp.IconButton();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.bStartSelectedGrids = new FontAwesome.Sharp.IconButton();
            this.bStartAllGrids = new FontAwesome.Sharp.IconButton();
            this.bStopAllGrids = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStopSelectedGrids
            // 
            this.bStopSelectedGrids.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.bStopSelectedGrids.IconColor = System.Drawing.Color.Black;
            this.bStopSelectedGrids.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bStopSelectedGrids.IconSize = 30;
            this.bStopSelectedGrids.Location = new System.Drawing.Point(104, 31);
            this.bStopSelectedGrids.Name = "bStopSelectedGrids";
            this.bStopSelectedGrids.Size = new System.Drawing.Size(95, 30);
            this.bStopSelectedGrids.TabIndex = 2;
            this.bStopSelectedGrids.Text = "Stop (0)";
            this.bStopSelectedGrids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStopSelectedGrids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStopSelectedGrids.UseVisualStyleBackColor = true;
            this.bStopSelectedGrids.Click += new System.EventHandler(this.bStopSelectedGrids_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.DropDownWidth = 100;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "None",
            "All",
            "Invert",
            "Enabled",
            "Running",
            "Off"});
            this.cbSelect.Location = new System.Drawing.Point(1, 1);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(0);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(18, 23);
            this.cbSelect.TabIndex = 4;
            this.cbSelect.SelectedValueChanged += new System.EventHandler(this.cbSelect_SelectedValueChanged);
            // 
            // bStartSelectedGrids
            // 
            this.bStartSelectedGrids.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.bStartSelectedGrids.IconColor = System.Drawing.Color.Black;
            this.bStartSelectedGrids.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bStartSelectedGrids.IconSize = 30;
            this.bStartSelectedGrids.Location = new System.Drawing.Point(3, 31);
            this.bStartSelectedGrids.Name = "bStartSelectedGrids";
            this.bStartSelectedGrids.Size = new System.Drawing.Size(95, 30);
            this.bStartSelectedGrids.TabIndex = 5;
            this.bStartSelectedGrids.Text = "Start (0)";
            this.bStartSelectedGrids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStartSelectedGrids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStartSelectedGrids.UseVisualStyleBackColor = true;
            this.bStartSelectedGrids.Click += new System.EventHandler(this.bStartSelectedGrids_Click);
            // 
            // bStartAllGrids
            // 
            this.bStartAllGrids.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.bStartAllGrids.IconColor = System.Drawing.Color.Black;
            this.bStartAllGrids.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bStartAllGrids.IconSize = 30;
            this.bStartAllGrids.Location = new System.Drawing.Point(226, 31);
            this.bStartAllGrids.Name = "bStartAllGrids";
            this.bStartAllGrids.Size = new System.Drawing.Size(95, 30);
            this.bStartAllGrids.TabIndex = 6;
            this.bStartAllGrids.Text = "Start All";
            this.bStartAllGrids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStartAllGrids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStartAllGrids.UseVisualStyleBackColor = true;
            this.bStartAllGrids.Click += new System.EventHandler(this.bStartAllGrids_Click);
            // 
            // bStopAllGrids
            // 
            this.bStopAllGrids.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.bStopAllGrids.IconColor = System.Drawing.Color.Black;
            this.bStopAllGrids.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bStopAllGrids.IconSize = 30;
            this.bStopAllGrids.Location = new System.Drawing.Point(327, 31);
            this.bStopAllGrids.Name = "bStopAllGrids";
            this.bStopAllGrids.Size = new System.Drawing.Size(95, 30);
            this.bStopAllGrids.TabIndex = 7;
            this.bStopAllGrids.Text = "Stop All";
            this.bStopAllGrids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bStopAllGrids.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bStopAllGrids.UseVisualStyleBackColor = true;
            this.bStopAllGrids.Click += new System.EventHandler(this.bStopAllGrids_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Control";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1097, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Status";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbSelect, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1201, 25);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(23, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Enabled";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1102, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Status";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Server Name";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(945, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "ProcessId";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(804, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Folder Loc";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(396, 4);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "Players";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(670, 4);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Memory";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(542, 4);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Cpu";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Grid";
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.bStartSelectedGrids);
            this.pTop.Controls.Add(this.tableLayoutPanel3);
            this.pTop.Controls.Add(this.bStopSelectedGrids);
            this.pTop.Controls.Add(this.bStopAllGrids);
            this.pTop.Controls.Add(this.bStartAllGrids);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1201, 133);
            this.pTop.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1201, 581);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // FormServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 714);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pTop);
            this.Name = "FormServers";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormServers_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton bStopSelectedGrids;
        private ComboBox cbSelect;
        private FontAwesome.Sharp.IconButton bStartSelectedGrids;
        private FontAwesome.Sharp.IconButton bStartAllGrids;
        private FontAwesome.Sharp.IconButton bStopAllGrids;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Panel pTop;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}