namespace TimeApp
{
    partial class TimeApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeApp));
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.btnStopUpdate = new System.Windows.Forms.Button();
            this.ntfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkMiniOnStartUP = new System.Windows.Forms.CheckBox();
            this.chkRunOnStartUp = new System.Windows.Forms.CheckBox();
            this.lblUpdating = new System.Windows.Forms.Label();
            this.ctxtIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runFirstTimeSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopUpdatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(179, 23);
            this.btnUpdateTime.TabIndex = 0;
            this.btnUpdateTime.Text = "Update Time";
            this.btnUpdateTime.UseVisualStyleBackColor = true;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // btnStopUpdate
            // 
            this.btnStopUpdate.Enabled = false;
            this.btnStopUpdate.Location = new System.Drawing.Point(12, 41);
            this.btnStopUpdate.Name = "btnStopUpdate";
            this.btnStopUpdate.Size = new System.Drawing.Size(179, 23);
            this.btnStopUpdate.TabIndex = 2;
            this.btnStopUpdate.Text = "Stop Updating";
            this.btnStopUpdate.UseVisualStyleBackColor = true;
            this.btnStopUpdate.Click += new System.EventHandler(this.btnStopUpdate_Click);
            // 
            // ntfyIcon
            // 
            this.ntfyIcon.ContextMenuStrip = this.ctxtIcon;
            this.ntfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyIcon.Icon")));
            this.ntfyIcon.Text = "Time App";
            this.ntfyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyIcon_MouseDoubleClick);
            // 
            // chkMiniOnStartUP
            // 
            this.chkMiniOnStartUP.AutoSize = true;
            this.chkMiniOnStartUP.Location = new System.Drawing.Point(12, 119);
            this.chkMiniOnStartUP.Name = "chkMiniOnStartUP";
            this.chkMiniOnStartUP.Size = new System.Drawing.Size(124, 17);
            this.chkMiniOnStartUP.TabIndex = 3;
            this.chkMiniOnStartUP.Text = "Minimize on Startup?";
            this.chkMiniOnStartUP.UseVisualStyleBackColor = true;
            this.chkMiniOnStartUP.CheckedChanged += new System.EventHandler(this.chkMiniOnStartUP_CheckedChanged);
            // 
            // chkRunOnStartUp
            // 
            this.chkRunOnStartUp.AutoSize = true;
            this.chkRunOnStartUp.Location = new System.Drawing.Point(12, 96);
            this.chkRunOnStartUp.Name = "chkRunOnStartUp";
            this.chkRunOnStartUp.Size = new System.Drawing.Size(167, 17);
            this.chkRunOnStartUp.TabIndex = 4;
            this.chkRunOnStartUp.Text = "Update Time on App Startup?";
            this.chkRunOnStartUp.UseVisualStyleBackColor = true;
            this.chkRunOnStartUp.CheckedChanged += new System.EventHandler(this.chkRunOnStartUp_CheckedChanged);
            // 
            // lblUpdating
            // 
            this.lblUpdating.Location = new System.Drawing.Point(12, 67);
            this.lblUpdating.Name = "lblUpdating";
            this.lblUpdating.Size = new System.Drawing.Size(179, 26);
            this.lblUpdating.TabIndex = 5;
            this.lblUpdating.Text = "Updating Time...";
            this.lblUpdating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdating.Visible = false;
            // 
            // ctxtIcon
            // 
            this.ctxtIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runFirstTimeSetupToolStripMenuItem,
            this.stopUpdatingToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.ctxtIcon.Name = "ctxtIcon";
            this.ctxtIcon.Size = new System.Drawing.Size(183, 92);
            // 
            // runFirstTimeSetupToolStripMenuItem
            // 
            this.runFirstTimeSetupToolStripMenuItem.Name = "runFirstTimeSetupToolStripMenuItem";
            this.runFirstTimeSetupToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.runFirstTimeSetupToolStripMenuItem.Text = "Run First Time Setup";
            this.runFirstTimeSetupToolStripMenuItem.Click += new System.EventHandler(this.runFirstTimeSetupToolStripMenuItem_Click);
            // 
            // stopUpdatingToolStripMenuItem
            // 
            this.stopUpdatingToolStripMenuItem.Name = "stopUpdatingToolStripMenuItem";
            this.stopUpdatingToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stopUpdatingToolStripMenuItem.Text = "Stop Updating";
            this.stopUpdatingToolStripMenuItem.Click += new System.EventHandler(this.stopUpdatingToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // TimeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 148);
            this.Controls.Add(this.lblUpdating);
            this.Controls.Add(this.chkRunOnStartUp);
            this.Controls.Add(this.chkMiniOnStartUP);
            this.Controls.Add(this.btnStopUpdate);
            this.Controls.Add(this.btnUpdateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeApp";
            this.Text = "Time Engine";
            this.Resize += new System.EventHandler(this.TimeApp_Resize);
            this.ctxtIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateTime;
        private System.Windows.Forms.Button btnStopUpdate;
        private System.Windows.Forms.NotifyIcon ntfyIcon;
        private System.Windows.Forms.CheckBox chkMiniOnStartUP;
        private System.Windows.Forms.CheckBox chkRunOnStartUp;
        private System.Windows.Forms.Label lblUpdating;
        private System.Windows.Forms.ContextMenuStrip ctxtIcon;
        private System.Windows.Forms.ToolStripMenuItem runFirstTimeSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopUpdatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

