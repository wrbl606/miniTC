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
            this.miniTCPanel2 = new miniTCApp.MiniTCPanel();
            this.miniTCPanel1 = new miniTCApp.MiniTCPanel();
            this.copyButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pointer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // miniTCPanel2
            // 
            this.miniTCPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniTCPanel2.AutoSize = true;
            this.miniTCPanel2.CurrentPath = "";
            this.miniTCPanel2.Location = new System.Drawing.Point(488, 12);
            this.miniTCPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniTCPanel2.Name = "miniTCPanel2";
            this.miniTCPanel2.Size = new System.Drawing.Size(434, 464);
            this.miniTCPanel2.TabIndex = 1;
            // 
            // miniTCPanel1
            // 
            this.miniTCPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miniTCPanel1.AutoSize = true;
            this.miniTCPanel1.CurrentPath = "";
            this.miniTCPanel1.Location = new System.Drawing.Point(12, 12);
            this.miniTCPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miniTCPanel1.Name = "miniTCPanel1";
            this.miniTCPanel1.Size = new System.Drawing.Size(434, 464);
            this.miniTCPanel1.TabIndex = 0;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(13, 482);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(172, 57);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "📋 Kopiuj";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(191, 482);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(167, 57);
            this.moveButton.TabIndex = 3;
            this.moveButton.Text = "✂️ Przenieś";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(364, 481);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 57);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "🗑";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // pointer
            // 
            this.pointer.AutoSize = true;
            this.pointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointer.Location = new System.Drawing.Point(442, 240);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(47, 32);
            this.pointer.TabIndex = 5;
            this.pointer.Text = "➡️";
            this.pointer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 551);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.miniTCPanel2);
            this.Controls.Add(this.miniTCPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MiniTCPanel miniTCPanel1;
        private MiniTCPanel miniTCPanel2;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label pointer;
    }
}

