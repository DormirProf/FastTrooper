using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Register : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        public Register()
        {
            InitializeComponent();
            Events();
            Open();
        }
        async void Open()
        {
            for (double i = 0; i < 0.95; i += 0.05, await Task.Delay(20))
            {
                Opacity = i;
            }
        }
        new void Events()
        {
            /////////Кнопка закрытия приложения
            pictureexit.Click += ((s, e) =>
            {
                Application.Exit();
            });
            pictureexit.MouseMove += ((s, e) =>
            {
                pictureexit.BackgroundImage = Properties.Resources.icons8_закрыть_окно_1001;
            });
            pictureexit.MouseLeave += ((s, e) =>
            {
                pictureexit.BackgroundImage = Properties.Resources.icons8_закрыть_окно_100;
            });
            ///////Кнопка сворачивания приложения
            pictureturn.MouseMove += ((s, e) =>
            {
                pictureturn.BackgroundImage = Properties.Resources.icons8_ios_50_копия;
            });
            pictureturn.MouseLeave += ((s, e) =>
            {
                pictureturn.BackgroundImage = Properties.Resources.icons8_ios_50;
            });
            pictureturn.Click += ((s, e) =>
            {
                WindowState = FormWindowState.Minimized;
            });
            ////////Для смены позиции приложения
            panel1.MouseDown += ((s, e) =>
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            });
            Breg.MouseMove += ((s, e) =>
            {
                Breg.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            });
            Breg.MouseLeave += ((s, e) =>
            {
                Breg.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            });
            Bcom.MouseMove += ((s, e) =>
            {
                Bcom.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            });
            Bcom.MouseLeave += ((s, e) =>
            {
                Bcom.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            });
            ///////Ели нажата клавиша энтер
            KeyDown += ((s, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                    Breg_Click(Breg, null);
            });
            ////////Кнопка возвращения к авторизации
            Bcom.Click += ((s, e) =>
            {
                Close();
                new Login().Show();
            });
            ////////Когда выделен элемент ввода пароля
            textpass.Enter += ((s, e) =>
            {
                if(textpass.Text == "Введите пароль:")
                    textpass.Text = null;
                textpass.UseSystemPasswordChar = true;
            });
            ////////////Когда выделен элемент повторного ввода пароля
            textpovpass.Enter += ((s, e) =>
            {
                if (textpovpass.Text == "Повторите пароль:")
                    textpovpass.Text = null;
                textpovpass.UseSystemPasswordChar = true;
            });
            /////////Виден ли пароль
            viewpass.CheckedChanged += ((s, e) => 
            {
                textpass.UseSystemPasswordChar = viewpass?.Checked == true ? false : true;
                textpovpass.UseSystemPasswordChar = viewpass?.Checked == true ? false : true;
            });
        }

        private void Breg_Click(object sender, EventArgs e)
        {
                new Thread(() =>
                {
                    Invoke((Action)(() =>
                    {
                        if (WorkBase.Register(textpass.Text, textpovpass.Text, textlogin.Text) == true)
                            Close();
                    }));
                }).Start();
        }
    }
}
