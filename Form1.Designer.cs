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
            this.SuspendLayout();
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Location = new System.Drawing.Point(192, 30);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(35, 13);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "label1";
            // 
            // labelBatteryPercent
            // 
            this.labelBatteryPercent.AutoSize = true;
            this.labelBatteryPercent.Location = new System.Drawing.Point(192, 148);
            this.labelBatteryPercent.Name = "labelBatteryPercent";
            this.labelBatteryPercent.Size = new System.Drawing.Size(35, 13);
            this.labelBatteryPercent.TabIndex = 1;
            this.labelBatteryPercent.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 208);
            this.Controls.Add(this.labelBatteryPercent);
            this.Controls.Add(this.labelCurrentUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label labelBatteryPercent;
    }
}

