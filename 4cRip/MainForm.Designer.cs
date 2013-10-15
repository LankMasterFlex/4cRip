namespace _4cRip
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
            this.comboBoard = new System.Windows.Forms.ComboBox();
            this.lblBoard = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.numThread = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDownload = new System.Windows.Forms.Button();
            this.statusLog = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
            this.statusLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoard
            // 
            this.comboBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoard.FormattingEnabled = true;
            this.comboBoard.Location = new System.Drawing.Point(53, 12);
            this.comboBoard.Name = "comboBoard";
            this.comboBoard.Size = new System.Drawing.Size(58, 21);
            this.comboBoard.TabIndex = 0;
            // 
            // lblBoard
            // 
            this.lblBoard.AutoSize = true;
            this.lblBoard.Location = new System.Drawing.Point(12, 15);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(35, 13);
            this.lblBoard.TabIndex = 1;
            this.lblBoard.Text = "Board";
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(132, 15);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(41, 13);
            this.lblThread.TabIndex = 2;
            this.lblThread.Text = "Thread";
            // 
            // numThread
            // 
            this.numThread.Location = new System.Drawing.Point(179, 13);
            this.numThread.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numThread.Name = "numThread";
            this.numThread.Size = new System.Drawing.Size(120, 20);
            this.numThread.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 42);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output Folder";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(89, 39);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(178, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(273, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dialogOutput
            // 
            this.dialogOutput.Description = "Select your output folder";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 65);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(287, 23);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // statusLog
            // 
            this.statusLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusLog.Location = new System.Drawing.Point(0, 97);
            this.statusLog.Name = "statusLog";
            this.statusLog.Size = new System.Drawing.Size(311, 22);
            this.statusLog.TabIndex = 8;
            this.statusLog.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(26, 17);
            this.statusLabel.Text = "Idle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 119);
            this.Controls.Add(this.statusLog);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.numThread);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.lblBoard);
            this.Controls.Add(this.comboBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "4cRip";
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
            this.statusLog.ResumeLayout(false);
            this.statusLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoard;
        private System.Windows.Forms.Label lblBoard;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog dialogOutput;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.StatusStrip statusLog;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

    }
}

