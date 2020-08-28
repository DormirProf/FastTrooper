namespace FastTrooper
{
    partial class Chat
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
            this.textchat = new System.Windows.Forms.RichTextBox();
            this.textinchat = new System.Windows.Forms.TextBox();
            this.Lsent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textchat
            // 
            this.textchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textchat.Location = new System.Drawing.Point(37, 88);
            this.textchat.Name = "textchat";
            this.textchat.ReadOnly = true;
            this.textchat.Size = new System.Drawing.Size(746, 426);
            this.textchat.TabIndex = 0;
            this.textchat.TabStop = false;
            this.textchat.Text = "";
            // 
            // textinchat
            // 
            this.textinchat.Location = new System.Drawing.Point(37, 541);
            this.textinchat.MaxLength = 250;
            this.textinchat.Name = "textinchat";
            this.textinchat.Size = new System.Drawing.Size(419, 22);
            this.textinchat.TabIndex = 1;
            // 
            // Lsent
            // 
            this.Lsent.AutoSize = true;
            this.Lsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lsent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Lsent.Location = new System.Drawing.Point(490, 541);
            this.Lsent.Name = "Lsent";
            this.Lsent.Size = new System.Drawing.Size(102, 20);
            this.Lsent.TabIndex = 2;
            this.Lsent.Text = "Отправить";
            this.Lsent.Click += new System.EventHandler(this.Lsent_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(809, 634);
            this.Controls.Add(this.Lsent);
            this.Controls.Add(this.textinchat);
            this.Controls.Add(this.textchat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textchat;
        private System.Windows.Forms.TextBox textinchat;
        private System.Windows.Forms.Label Lsent;
    }
}