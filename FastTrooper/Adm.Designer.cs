namespace FastTrooper
{
    partial class Adm
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
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Bprem = new System.Windows.Forms.Button();
            this.Bydal = new System.Windows.Forms.Button();
            this.Boxusers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bban = new System.Windows.Forms.Button();
            this.Bunban = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьАдминпанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(240, 176);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(265, 22);
            this.username.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(240, 232);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(265, 22);
            this.pass.TabIndex = 1;
            // 
            // Bprem
            // 
            this.Bprem.Location = new System.Drawing.Point(289, 300);
            this.Bprem.Name = "Bprem";
            this.Bprem.Size = new System.Drawing.Size(223, 30);
            this.Bprem.TabIndex = 2;
            this.Bprem.Text = "Смена имени и пароля";
            this.Bprem.UseVisualStyleBackColor = true;
            // 
            // Bydal
            // 
            this.Bydal.Location = new System.Drawing.Point(289, 348);
            this.Bydal.Name = "Bydal";
            this.Bydal.Size = new System.Drawing.Size(223, 32);
            this.Bydal.TabIndex = 3;
            this.Bydal.Text = "Удаление привязки";
            this.Bydal.UseVisualStyleBackColor = true;
            // 
            // Boxusers
            // 
            this.Boxusers.FormattingEnabled = true;
            this.Boxusers.Location = new System.Drawing.Point(241, 111);
            this.Boxusers.Name = "Boxusers";
            this.Boxusers.Size = new System.Drawing.Size(191, 24);
            this.Boxusers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Изменение имени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изменение пароля";
            // 
            // Bban
            // 
            this.Bban.Location = new System.Drawing.Point(552, 348);
            this.Bban.Name = "Bban";
            this.Bban.Size = new System.Drawing.Size(223, 32);
            this.Bban.TabIndex = 8;
            this.Bban.Text = "Забанить";
            this.Bban.UseVisualStyleBackColor = true;
            // 
            // Bunban
            // 
            this.Bunban.Location = new System.Drawing.Point(552, 386);
            this.Bunban.Name = "Bunban";
            this.Bunban.Size = new System.Drawing.Size(223, 32);
            this.Bunban.TabIndex = 12;
            this.Bunban.Text = "Разбанить";
            this.Bunban.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьАвтораToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // показатьАвтораToolStripMenuItem
            // 
            this.показатьАвтораToolStripMenuItem.Name = "показатьАвтораToolStripMenuItem";
            this.показатьАвтораToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.показатьАвтораToolStripMenuItem.Text = "Показать автора";
            this.показатьАвтораToolStripMenuItem.Click += new System.EventHandler(this.показатьАвтораToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьПрограммуToolStripMenuItem,
            this.закрытьАдминпанельToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // закрытьПрограммуToolStripMenuItem
            // 
            this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
            this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
            this.закрытьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.закрытьПрограммуToolStripMenuItem_Click);
            // 
            // закрытьАдминпанельToolStripMenuItem
            // 
            this.закрытьАдминпанельToolStripMenuItem.Name = "закрытьАдминпанельToolStripMenuItem";
            this.закрытьАдминпанельToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.закрытьАдминпанельToolStripMenuItem.Text = "Закрыть админпанель";
            this.закрытьАдминпанельToolStripMenuItem.Click += new System.EventHandler(this.закрытьАдминпанельToolStripMenuItem_Click);
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bunban);
            this.Controls.Add(this.Bban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boxusers);
            this.Controls.Add(this.Bydal);
            this.Controls.Add(this.Bprem);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Adm";
            this.Text = "Adm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Bprem;
        private System.Windows.Forms.Button Bydal;
        private System.Windows.Forms.ComboBox Boxusers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bban;
        private System.Windows.Forms.Button Bunban;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьАдминпанельToolStripMenuItem;
    }
}