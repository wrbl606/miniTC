namespace miniTCApp
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
            this.miniTCPanel1 = new miniTCApp.MiniTCPanel();
            this.miniTCPanel2 = new miniTCApp.MiniTCPanel();
            this.SuspendLayout();
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Location = new System.Drawing.Point(12, 12);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.Size = new System.Drawing.Size(449, 502);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Location = new System.Drawing.Point(488, 12);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.Size = new System.Drawing.Size(449, 502);
            this.miniTCPanel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 514);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.miniTCPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MiniTCPanel miniTCPanel1;
        private MiniTCPanel miniTCPanel2;
    }
}

