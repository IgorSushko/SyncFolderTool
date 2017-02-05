namespace Syncfolderi
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SourceFiles = new System.Windows.Forms.ListBox();
            this.TargetFiles = new System.Windows.Forms.ListBox();
            this.Sourcelabel1 = new System.Windows.Forms.Label();
            this.targetlabel2 = new System.Windows.Forms.Label();
            this.bSync = new System.Windows.Forms.Button();
            this.bSource = new System.Windows.Forms.Button();
            this.bTarget = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lStitistics = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SourceFiles);
            this.flowLayoutPanel1.Controls.Add(this.TargetFiles);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1029, 287);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SourceFiles
            // 
            this.SourceFiles.FormattingEnabled = true;
            this.SourceFiles.Location = new System.Drawing.Point(3, 3);
            this.SourceFiles.Name = "SourceFiles";
            this.SourceFiles.Size = new System.Drawing.Size(490, 277);
            this.SourceFiles.TabIndex = 0;
            // 
            // TargetFiles
            // 
            this.TargetFiles.FormattingEnabled = true;
            this.TargetFiles.Location = new System.Drawing.Point(499, 3);
            this.TargetFiles.Name = "TargetFiles";
            this.TargetFiles.Size = new System.Drawing.Size(520, 277);
            this.TargetFiles.TabIndex = 1;
            this.TargetFiles.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Sourcelabel1
            // 
            this.Sourcelabel1.AutoSize = true;
            this.Sourcelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sourcelabel1.Location = new System.Drawing.Point(152, 9);
            this.Sourcelabel1.Name = "Sourcelabel1";
            this.Sourcelabel1.Size = new System.Drawing.Size(0, 16);
            this.Sourcelabel1.TabIndex = 1;
            // 
            // targetlabel2
            // 
            this.targetlabel2.AutoSize = true;
            this.targetlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetlabel2.Location = new System.Drawing.Point(723, 9);
            this.targetlabel2.Name = "targetlabel2";
            this.targetlabel2.Size = new System.Drawing.Size(0, 16);
            this.targetlabel2.TabIndex = 2;
            // 
            // bSync
            // 
            this.bSync.Location = new System.Drawing.Point(39, 19);
            this.bSync.Name = "bSync";
            this.bSync.Size = new System.Drawing.Size(90, 44);
            this.bSync.TabIndex = 3;
            this.bSync.Text = "Sync";
            this.bSync.UseVisualStyleBackColor = true;
            this.bSync.Click += new System.EventHandler(this.bSync_Click);
            // 
            // bSource
            // 
            this.bSource.Location = new System.Drawing.Point(127, 321);
            this.bSource.Name = "bSource";
            this.bSource.Size = new System.Drawing.Size(75, 23);
            this.bSource.TabIndex = 4;
            this.bSource.Text = "Source";
            this.bSource.UseVisualStyleBackColor = true;
            this.bSource.Click += new System.EventHandler(this.bSource_Click);
            // 
            // bTarget
            // 
            this.bTarget.Location = new System.Drawing.Point(695, 321);
            this.bTarget.Name = "bTarget";
            this.bTarget.Size = new System.Drawing.Size(75, 23);
            this.bTarget.TabIndex = 5;
            this.bTarget.Text = "Target";
            this.bTarget.UseVisualStyleBackColor = true;
            this.bTarget.Click += new System.EventHandler(this.bTarget_Click);
            // 
            // lStitistics
            // 
            this.lStitistics.FormattingEnabled = true;
            this.lStitistics.Location = new System.Drawing.Point(215, 45);
            this.lStitistics.Name = "lStitistics";
            this.lStitistics.Size = new System.Drawing.Size(310, 95);
            this.lStitistics.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lStitistics);
            this.groupBox1.Controls.Add(this.bSync);
            this.groupBox1.Location = new System.Drawing.Point(3, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synchronization";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Statistics";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(552, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 146);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 69);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bTarget);
            this.Controls.Add(this.bSource);
            this.Controls.Add(this.targetlabel2);
            this.Controls.Add(this.Sourcelabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox SourceFiles;
        private System.Windows.Forms.ListBox TargetFiles;
        private System.Windows.Forms.Label Sourcelabel1;
        private System.Windows.Forms.Label targetlabel2;
        private System.Windows.Forms.Button bSync;
        private System.Windows.Forms.Button bSource;
        private System.Windows.Forms.Button bTarget;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lStitistics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

