namespace AtlasServerManager
{
    partial class FormLogs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tPerformance = new System.Windows.Forms.Timer(this.components);
            this.bStartAll = new System.Windows.Forms.Button();
            this.lMemoryPercent = new System.Windows.Forms.Label();
            this.lCpuPercent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lMemory = new System.Windows.Forms.Label();
            this.tCrashDetector = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tPerformance
            // 
            this.tPerformance.Interval = 5000;
            this.tPerformance.Tick += new System.EventHandler(this.tPerformance_Tick);
            // 
            // bStartAll
            // 
            this.bStartAll.Location = new System.Drawing.Point(958, 144);
            this.bStartAll.Name = "bStartAll";
            this.bStartAll.Size = new System.Drawing.Size(90, 23);
            this.bStartAll.TabIndex = 9;
            this.bStartAll.Text = "StartAllGrids";
            this.bStartAll.UseVisualStyleBackColor = true;
            // 
            // lMemoryPercent
            // 
            this.lMemoryPercent.AutoSize = true;
            this.lMemoryPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lMemoryPercent.Location = new System.Drawing.Point(244, 19);
            this.lMemoryPercent.Name = "lMemoryPercent";
            this.lMemoryPercent.Size = new System.Drawing.Size(23, 15);
            this.lMemoryPercent.TabIndex = 8;
            this.lMemoryPercent.Text = "0%";
            // 
            // lCpuPercent
            // 
            this.lCpuPercent.AutoSize = true;
            this.lCpuPercent.BackColor = System.Drawing.Color.Transparent;
            this.lCpuPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCpuPercent.Location = new System.Drawing.Point(154, 19);
            this.lCpuPercent.Name = "lCpuPercent";
            this.lCpuPercent.Size = new System.Drawing.Size(23, 15);
            this.lCpuPercent.TabIndex = 7;
            this.lCpuPercent.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cpu:";
            // 
            // lMemory
            // 
            this.lMemory.AutoSize = true;
            this.lMemory.Location = new System.Drawing.Point(183, 19);
            this.lMemory.Name = "lMemory";
            this.lMemory.Size = new System.Drawing.Size(55, 15);
            this.lMemory.TabIndex = 1;
            this.lMemory.Text = "Memory:";
            // 
            // tCrashDetector
            // 
            this.tCrashDetector.Interval = 10000;
            this.tCrashDetector.Tick += new System.EventHandler(this.tCrashDetector_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lMemoryPercent);
            this.groupBox1.Controls.Add(this.lCpuPercent);
            this.groupBox1.Controls.Add(this.lMemory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(777, 386);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 714);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bStartAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tPerformance;
        private Label lMemory;
        private Label label2;
        private Label lMemoryPercent;
        private Label lCpuPercent;
        private System.Windows.Forms.Timer tCrashDetector;
        private Button bStartAll;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}