namespace Exam_Window
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
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.labelBatteryPercent = new System.Windows.Forms.Label();
            this.labelBatteryLifeRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Enabled = false;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.Location = new System.Drawing.Point(12, 14);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(66, 24);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "label1";
            // 
            // labelBatteryPercent
            // 
            this.labelBatteryPercent.AutoSize = true;
            this.labelBatteryPercent.Enabled = false;
            this.labelBatteryPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryPercent.Location = new System.Drawing.Point(12, 38);
            this.labelBatteryPercent.Name = "labelBatteryPercent";
            this.labelBatteryPercent.Size = new System.Drawing.Size(60, 24);
            this.labelBatteryPercent.TabIndex = 1;
            this.labelBatteryPercent.Text = "label2";
            this.labelBatteryPercent.Click += new System.EventHandler(this.labelBatteryPercent_Click);
            // 
            // labelBatteryLifeRemaining
            // 
            this.labelBatteryLifeRemaining.AutoSize = true;
            this.labelBatteryLifeRemaining.Enabled = false;
            this.labelBatteryLifeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatteryLifeRemaining.Location = new System.Drawing.Point(12, 62);
            this.labelBatteryLifeRemaining.Name = "labelBatteryLifeRemaining";
            this.labelBatteryLifeRemaining.Size = new System.Drawing.Size(60, 24);
            this.labelBatteryLifeRemaining.TabIndex = 2;
            this.labelBatteryLifeRemaining.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(190, 95);
            this.ControlBox = false;
            this.Controls.Add(this.labelBatteryLifeRemaining);
            this.Controls.Add(this.labelBatteryPercent);
            this.Controls.Add(this.labelCurrentUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(190, 95);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(190, 95);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label labelBatteryPercent;
        private System.Windows.Forms.Label labelBatteryLifeRemaining;
    }
}

