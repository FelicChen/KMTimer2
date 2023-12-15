namespace KMTimer2
{
    partial class KMTimer2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KMTimer2));
            lblTime = new Label();
            lblCPU = new Label();
            lblMemory = new Label();
            lblDate = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmiReset = new ToolStripMenuItem();
            tsmiClose = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("微軟正黑體", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(-9, 9);
            lblTime.Margin = new Padding(0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(225, 61);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.BackColor = Color.Transparent;
            lblCPU.ForeColor = Color.White;
            lblCPU.Location = new Point(4, 59);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(63, 15);
            lblCPU.TabIndex = 1;
            lblCPU.Text = "CPU: ---%";
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.BackColor = Color.Transparent;
            lblMemory.ForeColor = Color.White;
            lblMemory.Location = new Point(108, 59);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(87, 15);
            lblMemory.TabIndex = 2;
            lblMemory.Text = "Memory: ---%";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(4, 2);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(81, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "yyyy-MM-dd";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "KMTimer2";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmiReset, tsmiClose });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(106, 48);
            // 
            // tsmiReset
            // 
            tsmiReset.Name = "tsmiReset";
            tsmiReset.Size = new Size(105, 22);
            tsmiReset.Text = "Reset";
            // 
            // tsmiClose
            // 
            tsmiClose.Name = "tsmiClose";
            tsmiClose.Size = new Size(105, 22);
            tsmiClose.Text = "Close";
            // 
            // KMTimer2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(203, 76);
            Controls.Add(lblDate);
            Controls.Add(lblMemory);
            Controls.Add(lblCPU);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KMTimer2";
            Opacity = 0.5D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KMTimer2";
            TopMost = true;
            Load += KMTimer2_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTime;
        private Label lblCPU;
        private Label lblMemory;
        private Label lblDate;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmiClose;
        private ToolStripMenuItem tsmiReset;
    }
}