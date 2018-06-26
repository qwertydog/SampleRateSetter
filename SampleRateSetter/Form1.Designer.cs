namespace SampleRateSetter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.asus44100Button = new System.Windows.Forms.Button();
            this.asus48000Button = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setSampleRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schiit44100 = new System.Windows.Forms.ToolStripMenuItem();
            this.schiit48000 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSUS44100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSUS48000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asusGroupBox = new System.Windows.Forms.GroupBox();
            this.schiitGroupBox = new System.Windows.Forms.GroupBox();
            this.schiit48000Button = new System.Windows.Forms.Button();
            this.schiit44100Button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.asusGroupBox.SuspendLayout();
            this.schiitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // asus44100Button
            // 
            this.asus44100Button.Location = new System.Drawing.Point(6, 19);
            this.asus44100Button.Name = "asus44100Button";
            this.asus44100Button.Size = new System.Drawing.Size(45, 26);
            this.asus44100Button.TabIndex = 0;
            this.asus44100Button.Text = "44100";
            this.asus44100Button.UseVisualStyleBackColor = true;
            this.asus44100Button.Click += new System.EventHandler(this.asus44100Button_Click);
            // 
            // asus48000Button
            // 
            this.asus48000Button.Location = new System.Drawing.Point(59, 19);
            this.asus48000Button.Name = "asus48000Button";
            this.asus48000Button.Size = new System.Drawing.Size(52, 26);
            this.asus48000Button.TabIndex = 1;
            this.asus48000Button.Text = "48000";
            this.asus48000Button.UseVisualStyleBackColor = true;
            this.asus48000Button.Click += new System.EventHandler(this.asus48000Button_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Set Sample Rate";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSampleRateToolStripMenuItem,
            this.schiit44100,
            this.schiit48000,
            this.aSUS44100ToolStripMenuItem,
            this.aSUS48000ToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 136);
            // 
            // setSampleRateToolStripMenuItem
            // 
            this.setSampleRateToolStripMenuItem.Enabled = false;
            this.setSampleRateToolStripMenuItem.Name = "setSampleRateToolStripMenuItem";
            this.setSampleRateToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.setSampleRateToolStripMenuItem.Text = "Set Sample Rate";
            // 
            // schiit44100
            // 
            this.schiit44100.Name = "schiit44100";
            this.schiit44100.Size = new System.Drawing.Size(158, 22);
            this.schiit44100.Text = "Schiit 44100";
            this.schiit44100.Click += new System.EventHandler(this.schiit44100ToolStripItem_Click);
            // 
            // schiit48000
            // 
            this.schiit48000.Name = "schiit48000";
            this.schiit48000.Size = new System.Drawing.Size(158, 22);
            this.schiit48000.Text = "Schiit 48000";
            this.schiit48000.Click += new System.EventHandler(this.schiit48000ToolStripItem_Click);
            // 
            // aSUS44100ToolStripMenuItem
            // 
            this.aSUS44100ToolStripMenuItem.Name = "aSUS44100ToolStripMenuItem";
            this.aSUS44100ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aSUS44100ToolStripMenuItem.Text = "ASUS 44100";
            this.aSUS44100ToolStripMenuItem.Click += new System.EventHandler(this.aSUS44100ToolStripMenuItem_Click);
            // 
            // aSUS48000ToolStripMenuItem
            // 
            this.aSUS48000ToolStripMenuItem.Name = "aSUS48000ToolStripMenuItem";
            this.aSUS48000ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aSUS48000ToolStripMenuItem.Text = "ASUS 48000";
            this.aSUS48000ToolStripMenuItem.Click += new System.EventHandler(this.aSUS48000ToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // asusGroupBox
            // 
            this.asusGroupBox.Controls.Add(this.asus48000Button);
            this.asusGroupBox.Controls.Add(this.asus44100Button);
            this.asusGroupBox.Location = new System.Drawing.Point(146, 12);
            this.asusGroupBox.Name = "asusGroupBox";
            this.asusGroupBox.Size = new System.Drawing.Size(123, 53);
            this.asusGroupBox.TabIndex = 2;
            this.asusGroupBox.TabStop = false;
            this.asusGroupBox.Text = "ASUS";
            // 
            // schiitGroupBox
            // 
            this.schiitGroupBox.Controls.Add(this.schiit48000Button);
            this.schiitGroupBox.Controls.Add(this.schiit44100Button);
            this.schiitGroupBox.Location = new System.Drawing.Point(12, 12);
            this.schiitGroupBox.Name = "schiitGroupBox";
            this.schiitGroupBox.Size = new System.Drawing.Size(123, 53);
            this.schiitGroupBox.TabIndex = 3;
            this.schiitGroupBox.TabStop = false;
            this.schiitGroupBox.Text = "Schiit";
            // 
            // schiit48000Button
            // 
            this.schiit48000Button.Location = new System.Drawing.Point(59, 19);
            this.schiit48000Button.Name = "schiit48000Button";
            this.schiit48000Button.Size = new System.Drawing.Size(52, 26);
            this.schiit48000Button.TabIndex = 1;
            this.schiit48000Button.Text = "48000";
            this.schiit48000Button.UseVisualStyleBackColor = true;
            this.schiit48000Button.Click += new System.EventHandler(this.schiit48000Button_Click);
            // 
            // schiit44100Button
            // 
            this.schiit44100Button.Location = new System.Drawing.Point(6, 19);
            this.schiit44100Button.Name = "schiit44100Button";
            this.schiit44100Button.Size = new System.Drawing.Size(45, 26);
            this.schiit44100Button.TabIndex = 0;
            this.schiit44100Button.Text = "44100";
            this.schiit44100Button.UseVisualStyleBackColor = true;
            this.schiit44100Button.Click += new System.EventHandler(this.schiit44100Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 71);
            this.Controls.Add(this.schiitGroupBox);
            this.Controls.Add(this.asusGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Set Sample Rate";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.asusGroupBox.ResumeLayout(false);
            this.schiitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button asus44100Button;
        private System.Windows.Forms.Button asus48000Button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schiit44100;
        private System.Windows.Forms.ToolStripMenuItem schiit48000;
        private System.Windows.Forms.ToolStripMenuItem setSampleRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSUS44100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSUS48000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.GroupBox asusGroupBox;
        private System.Windows.Forms.GroupBox schiitGroupBox;
        private System.Windows.Forms.Button schiit48000Button;
        private System.Windows.Forms.Button schiit44100Button;
    }
}

