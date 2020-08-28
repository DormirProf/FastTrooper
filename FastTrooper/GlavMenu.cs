using Microsoft.Win32;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class GlavMenu : Form
    {
        readonly static RegistryKey fasttrooper = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        readonly Chat chat = new Chat();
        readonly Profile prof = new Profile();
        byte prov = 0;

        public GlavMenu()
        {
            chat.NamesUsers = fasttrooper.GetValue("Name").ToString();
            InitializeComponent();
            Event();
            But();
        }

        void Event()
        {
            exit.Click += ((s, e) =>
            {
                Application.Exit();
            });
            exit.MouseMove += ((s, e) =>
            {
                exit.BackgroundImage = Properties.Resources.icons8_закрыть_окно_1001;
            });
            exit.MouseLeave += ((s, e) =>
            {
                exit.BackgroundImage = Properties.Resources.icons8_закрыть_окно_100;
            });
            ///////Кнопка сворачивания приложения
            turn.MouseMove += ((s, e) =>
            {
                turn.BackgroundImage = Properties.Resources.icons8_ios_50_копия;
            });
            turn.MouseLeave += ((s, e) =>
            {
                turn.BackgroundImage = Properties.Resources.icons8_ios_50;
            });
            turn.Click += ((s, e) =>
            {
                WindowState = FormWindowState.Minimized;
            });
            //////Для изменения положения приложения
            mov.MouseDown += ((s, e) =>
            {
                ReleaseCapture();
                PostMessage(Handle, WM_SYSCOMMAND, DOMOVE, 0);
            });

            Lglav.Click += ((s, e) =>
            {
                ColorMt(0);
                ColorMt(6);
                prov = 0;
                chat.Hide();
                prof.Hide();
            });
            Lchat.Click += ((s, e) =>
            {
                panelchat.Visible = true;
            });
            Lprof.Click += ((s, e) =>
            {
                ColorMt(4);
                ColorMt(5);
                prov = 1;
                prof.MdiParent = this;
                prof.Show();
                chat.Hide();
            });
            textlogchat.Click += ((s, e) =>
            {
                textlogchat.Text = "";
            });
            textpasschat.Enter += ((s, e) =>
            {
                textpasschat.Text = textpasschat.Text == "Введите пароль:" ? null : "";
                textpasschat.UseSystemPasswordChar = textpasschat.Text == "Введите пароль:" ? false : true;
            });
            Laut.Click += ((s, e) =>
            {
                new Thread(() =>
                {
                    Invoke((Action)(() =>
                    {
                        switch(WorkBase.CheckChatAuthorization(textlogchat.Text.ToLower(), textpasschat.Text))
                        {
                            case 1:
                                panelchat.Visible = false;
                                ColorMt(1);
                                ColorMt(5);
                                prov = 1;
                                chat.Names = this.textlogchat.Text.ToLower();
                                chat.MdiParent = this;
                                chat.Refresh();
                                chat.Show();
                                prof.Hide();
                                break;
                            case 2:
                                MessageBox.Show("Вы ввели неверный пароль!");
                                break;
                            case 3:
                                MessageBox.Show("Вы ввели неверный пароль!");
                                break;
                        }
                        
                    }));
                }).Start();
            });
            Lcreate.Click += ((s, e) =>
            {
                new Thread(() =>
                {
                    Invoke((Action)(() =>
                    {
                        if (WorkBase.RegisterNewChat(textlogchat.Text.ToLower(), textpasschat.Text) == true)
                        {
                            MessageBox.Show("Вы успешно создали чат.");
                            WorkBase.RegisterNewChat2(textlogchat.Text.ToLower());
                        }
                    }));
                }).Start();
            });
            Pchatexit.Click += ((s, e) =>
            {
                panelchat.Visible = false;
            });


        }

        void But()
        {
            Lglav.MouseMove += ((s, e) =>
            {
                if (this.Lglav.ForeColor == Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))))
                {
                    Lglav.ForeColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
                }
            });
            Lglav.MouseLeave += ((s, e) =>
            {
                if (Lglav.ForeColor == Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))))
                {
                    this.Lglav.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                }
            });

            Lchat.MouseMove += ((s, e) =>
            {
                if (this.Lchat.ForeColor == Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))))
                {
                    Lchat.ForeColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
                }
            });
            Lchat.MouseLeave += ((s, e) =>
            {
                if (Lchat.ForeColor == Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))))
                {
                    this.Lchat.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                }
            });
            Lprof.MouseMove += ((s, e) =>
            {
                if (this.Lprof.ForeColor == Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))))
                {
                    Lprof.ForeColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
                }
            });
            Lprof.MouseLeave += ((s, e) =>
            {
                if (Lprof.ForeColor == Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))))
                {
                    this.Lprof.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                }
            });
            Laut.MouseMove += ((s, e) =>
            {
                if (this.Laut.ForeColor == Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))))
                {
                    Laut.ForeColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
                }
            });
            Laut.MouseLeave += ((s, e) =>
            {
                if (Laut.ForeColor == Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))))
                {
                    this.Laut.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                }
            });
            Lcreate.MouseMove += ((s, e) =>
            {
                if (this.Lcreate.ForeColor == Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))))
                {
                    Lcreate.ForeColor = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
                }
            });
            Lcreate.MouseLeave += ((s, e) =>
            {
                if (Lcreate.ForeColor == Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))))
                {
                    this.Lcreate.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                }
            });

        }
        void ColorMt(byte check)
        {
            if (check == 0)
            {
                Lglav.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                Lchat.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lprof.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            }

            if (check == 1)
            {
                Lchat.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                Lglav.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lprof.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            }

            if (check == 2)
            {
                Lglav.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lchat.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lprof.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            }

            if (check == 3)
            {
                Lglav.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lchat.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lprof.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            }

            if (check == 4)
            {
                Lprof.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                Lglav.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
                Lchat.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            }

            if (check == 5)
            {
                pictureBox1.Size = new Size(343, 596);
                pictureBox1.Location = new Point(608, 35);
            }

            if (check == 6)
            {
                pictureBox1.Size = new Size(1136, 596);
                pictureBox1.Location = new Point(0, 0);
            }
        }
        

        public static string GetHwind() =>
        (from x in new ManagementObjectSearcher("SELECT * FROM win32_processor").Get().OfType<ManagementObject>()
         select x.GetPropertyValue("ProcessorId")).First().ToString();
        public static string GetHddSerial() =>
        (from x in new ManagementObjectSearcher("SELECT * FROM win32_PhysicalMemory").Get().OfType<ManagementObject>()
         select x.GetPropertyValue("Serialnumber")).First().ToString();
    }
}
