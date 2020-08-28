namespace FastTrooper
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.viewpass = new System.Windows.Forms.CheckBox();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textpovpass = new System.Windows.Forms.TextBox();
            this.pictureexit = new System.Windows.Forms.PictureBox();
            this.pictureturn = new System.Windows.Forms.PictureBox();
            this.Breg = new System.Windows.Forms.Label();
            this.Bcom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureexit);
            this.panel1.Controls.Add(this.pictureturn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fast Trooper - Регистрация";
            // 
            // viewpass
            // 
            this.viewpass.AutoSize = true;
            this.viewpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.viewpass.ForeColor = System.Drawing.SystemColors.Control;
            this.viewpass.Location = new System.Drawing.Point(715, 345);
            this.viewpass.Margin = new System.Windows.Forms.Padding(4);
            this.viewpass.Name = "viewpass";
            this.viewpass.Size = new System.Drawing.Size(143, 21);
            this.viewpass.TabIndex = 1;
            this.viewpass.TabStop = false;
            this.viewpass.Text = "Показать пароль";
            this.viewpass.UseVisualStyleBackColor = false;
            // 
            // textlogin
            // 
            this.textlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textlogin.Location = new System.Drawing.Point(440, 238);
            this.textlogin.Margin = new System.Windows.Forms.Padding(4);
            this.textlogin.MaxLength = 19;
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(252, 29);
            this.textlogin.TabIndex = 0;
            this.textlogin.Text = "Введите логин:";
            // 
            // textpass
            // 
            this.textpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textpass.Location = new System.Drawing.Point(440, 288);
            this.textpass.Margin = new System.Windows.Forms.Padding(4);
            this.textpass.MaxLength = 256;
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(252, 29);
            this.textpass.TabIndex = 1;
            this.textpass.Text = "Введите пароль:";
            // 
            // textpovpass
            // 
            this.textpovpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textpovpass.Location = new System.Drawing.Point(440, 337);
            this.textpovpass.Margin = new System.Windows.Forms.Padding(4);
            this.textpovpass.MaxLength = 256;
            this.textpovpass.Name = "textpovpass";
            this.textpovpass.Size = new System.Drawing.Size(252, 29);
            this.textpovpass.TabIndex = 2;
            this.textpovpass.Text = "Повторите пароль:";
            // 
            // pictureexit
            // 
            this.pictureexit.BackgroundImage = global::FastTrooper.Properties.Resources.icons8_закрыть_окно_100;
            this.pictureexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureexit.Location = new System.Drawing.Point(1065, 9);
            this.pictureexit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureexit.Name = "pictureexit";
            this.pictureexit.Size = new System.Drawing.Size(55, 30);
            this.pictureexit.TabIndex = 2;
            this.pictureexit.TabStop = false;
            // 
            // pictureturn
            // 
            this.pictureturn.BackgroundImage = global::FastTrooper.Properties.Resources.icons8_ios_50;
            this.pictureturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureturn.Location = new System.Drawing.Point(997, 9);
            this.pictureturn.Margin = new System.Windows.Forms.Padding(4);
            this.pictureturn.Name = "pictureturn";
            this.pictureturn.Size = new System.Drawing.Size(55, 30);
            this.pictureturn.TabIndex = 1;
            this.pictureturn.TabStop = false;
            // 
            // Breg
            // 
            this.Breg.AutoSize = true;
            this.Breg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Breg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Breg.Location = new System.Drawing.Point(464, 460);
            this.Breg.Name = "Breg";
            this.Breg.Size = new System.Drawing.Size(205, 25);
            this.Breg.TabIndex = 11;
            this.Breg.Text = "Зарегистрироваться";
            this.Breg.Click += new System.EventHandler(this.Breg_Click);
            // 
            // Bcom
            // 
            this.Bcom.AutoSize = true;
            this.Bcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bcom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Bcom.Location = new System.Drawing.Point(442, 506);
            this.Bcom.Name = "Bcom";
            this.Bcom.Size = new System.Drawing.Size(249, 25);
            this.Bcom.TabIndex = 12;
            this.Bcom.Text = "Вернуться к авторизации";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1133, 640);
            this.Controls.Add(this.Bcom);
            this.Controls.Add(this.Breg);
            this.Controls.Add(this.textpovpass);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textlogin);
            this.Controls.Add(this.viewpass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Trooper - Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureexit;
        private System.Windows.Forms.PictureBox pictureturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox viewpass;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textpovpass;
        private System.Windows.Forms.Label Breg;
        private System.Windows.Forms.Label Bcom;
    }
}