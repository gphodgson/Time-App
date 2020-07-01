namespace TimeApp
{
    partial class FirstTimeSetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunFirstTimeSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "This will setup a connection with SteelSeries Engine 3.0 and set the \"game\" up. T" +
    "his should only need to be run once";
            // 
            // btnRunFirstTimeSetup
            // 
            this.btnRunFirstTimeSetup.Location = new System.Drawing.Point(12, 98);
            this.btnRunFirstTimeSetup.Name = "btnRunFirstTimeSetup";
            this.btnRunFirstTimeSetup.Size = new System.Drawing.Size(149, 34);
            this.btnRunFirstTimeSetup.TabIndex = 1;
            this.btnRunFirstTimeSetup.Text = "Run First Time Setup";
            this.btnRunFirstTimeSetup.UseVisualStyleBackColor = true;
            this.btnRunFirstTimeSetup.Click += new System.EventHandler(this.btnRunFirstTimeSetup_Click);
            // 
            // FirstTimeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 144);
            this.Controls.Add(this.btnRunFirstTimeSetup);
            this.Controls.Add(this.label1);
            this.Name = "FirstTimeSetup";
            this.Text = "FirstTimeSetup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunFirstTimeSetup;
    }
}