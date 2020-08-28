using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Login : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;

        
        public Login()
        {
            InitializeComponent();
            Reged();
            Open();
            Events();
        }
        void Reged()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");
            textlogin.Text = key?.GetValue("Name")?.ToString() != null ? key.GetValue("Name").ToString() : "Введите логин:";
            textpass.Text = key?.GetValue("RememberPassword")?.ToString() == "True" ? Cript.Ftdecrypt(key.GetValue("Pass").ToString(), "D<q3ydnasd6т86фк8ыв6кТ*:КЫ:ЫВКФ") : "Введите пароль:";
            textpass.UseSystemPasswordChar = textpass?.Text == "Введите пароль:" ? false : true;
            savepass.Checked = key?.GetValue("RememberPassword")?.ToString() == "True" ? true : false;
            Lreg.Visible = key?.GetValue("CheckRegister")?.ToString() == "True" ? false : true;
        }

        async void Open()
        {
            for (double i = 0; i < 0.97; i += 0.03, await Task.Delay(25))
            {
                Opacity = i;
            }
        }

        new void Events()
        {
            /////////Кнопка выхода из приложения
            pictureexit1.Click += ((s, e) =>
            {
                Application.Exit();
            });
            pictureexit1.MouseMove += ((s, e) =>
            {
                pictureexit1.BackgroundImage = Properties.Resources.icons8_закрыть_окно_1001;
            });
            pictureexit1.MouseLeave += ((s, e) =>
            {
                pictureexit1.BackgroundImage = Properties.Resources.icons8_закрыть_окно_100;
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
            /////////Для смены позиции приложения
            panel1.MouseDown += ((s, e) =>
            {
                ReleaseCapture();
                PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
            });
            Laut.MouseMove += ((s, e) =>
            {
                    Laut.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            });
            Laut.MouseLeave += ((s, e) =>
            {
                    this.Laut.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            });

            Lreg.MouseMove += ((s, e) =>
            {
                    Lreg.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            });
            Lreg.MouseLeave += ((s, e) =>
            {
                    this.Lreg.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            });
            ////////Если нажата клавиша энтер
            KeyDown += ((s, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    Laut_Click(Laut, null);
                }
            });
            /////////Кнопка зарегистрироваться
            Lreg.Click += ((s, e) =>
            {
                Hide();
                new Register().Show();
            });
            ///////Если выбран элемент ввода пароля
            textpass.Enter += ((s, e) =>
            {
                textpass.Text = textpass.Text == "Введите пароль:" ? null : "";
                textpass.UseSystemPasswordChar = textpass.Text == "Введите пароль:" ? false:true;
            });
        }

        private void Laut_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Invoke((Action)(() =>
                {
                    if (WorkBase.Login(textlogin.Text, textpass.Text, savepass.Checked) == true)
                        Hide();
                }));
            }).Start();
        }
    }
}
