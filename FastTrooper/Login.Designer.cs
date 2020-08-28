namespace FastTrooper
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.savepass = new System.Windows.Forms.CheckBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.pictureexit1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureturn = new System.Windows.Forms.PictureBox();
            this.Lreg = new System.Windows.Forms.Label();
            this.Laut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureexit1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureturn)).BeginInit();
            this.SuspendLayout();
            // 
            // savepass
            // 
            this.savepass.AutoSize = true;
            this.savepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.savepass.ForeColor = System.Drawing.SystemColors.Control;
            this.savepass.Location = new System.Drawing.Point(440, 356);
            this.savepass.Margin = new System.Windows.Forms.Padding(4);
            this.savepass.Name = "savepass";
            this.savepass.Size = new System.Drawing.Size(150, 21);
            this.savepass.TabIndex = 1;
            this.savepass.TabStop = false;
            this.savepass.Text = "Сохранить пароль";
            this.savepass.UseVisualStyleBackColor = false;
            // 
            // textlogin
            // 
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textlogin.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textlogin.Location = new System.Drawing.Point(440, 245);
            this.textlogin.Margin = new System.Windows.Forms.Padding(4);
            this.textlogin.MaxLength = 20;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(252, 29);
            this.textlogin.TabIndex = 0;
            this.textlogin.Text = "Введите логин:";
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textpass.Location = new System.Drawing.Point(440, 306);
            this.textpass.Margin = new System.Windows.Forms.Padding(4);
            this.textpass.MaxLength = 256;
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(252, 29);
            this.textpass.TabIndex = 1;
            this.textpass.Text = "Введите пароль:";
            this.textpass.UseSystemPasswordChar = true;
            // 
            // pictureexit1
            // 
            this.pictureexit1.BackColor = System.Drawing.Color.Black;
            this.pictureexit1.BackgroundImage = global::FastTrooper.Properties.Resources.icons8_закрыть_окно_100;
            this.pictureexit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureexit1.Location = new System.Drawing.Point(1065, 9);
            this.pictureexit1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureexit1.Name = "pictureexit1";
            this.pictureexit1.Size = new System.Drawing.Size(55, 30);
            this.pictureexit1.TabIndex = 5;
            this.pictureexit1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fast Trooper - Авторизация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureturn);
            this.panel1.Controls.Add(this.pictureexit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 46);
            this.panel1.TabIndex = 8;
            // 
            // pictureturn
            // 
            this.pictureturn.BackColor = System.Drawing.Color.Black;
            this.pictureturn.BackgroundImage = global::FastTrooper.Properties.Resources.icons8_ios_50;
            this.pictureturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureturn.Location = new System.Drawing.Point(997, 9);
            this.pictureturn.Margin = new System.Windows.Forms.Padding(4);
            this.pictureturn.Name = "pictureturn";
            this.pictureturn.Size = new System.Drawing.Size(55, 30);
            this.pictureturn.TabIndex = 9;
            this.pictureturn.TabStop = false;
            // 
            // Lreg
            // 
            this.Lreg.AutoSize = true;
            this.Lreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lreg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Lreg.Location = new System.Drawing.Point(464, 472);
            this.Lreg.Name = "Lreg";
            this.Lreg.Size = new System.Drawing.Size(205, 25);
            this.Lreg.TabIndex = 9;
            this.Lreg.Text = "Зарегистрироваться";
            // 
            // Laut
            // 
            this.Laut.AutoSize = true;
            this.Laut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Laut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Laut.Location = new System.Drawing.Point(484, 426);
            this.Laut.Name = "Laut";
            this.Laut.Size = new System.Drawing.Size(165, 25);
            this.Laut.TabIndex = 10;
            this.Laut.Text = "Авторизоваться";
            this.Laut.Click += new System.EventHandler(this.Laut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1133, 640);
            this.Controls.Add(this.Laut);
            this.Controls.Add(this.Lreg);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.savepass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Trooper -Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureexit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox savepass;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.PictureBox pictureexit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureturn;
        private System.Windows.Forms.Label Lreg;
        private System.Windows.Forms.Label Laut;
    }
}