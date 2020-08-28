using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Profile : Form
    {
        readonly static RegistryKey pr = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");

        public Profile()
        {
            InitializeComponent();
            Event();
        }

        void Event()
        {
            username.Text = pr.GetValue("Name").ToString();
            Bprem.Click += ((s, e) =>
            {
                new Thread(() => {
                    Invoke((Action)(() =>
                    {
                        if (username.Text != pr.GetValue("Name").ToString())
                            if (WorkBase.AcceptProfileName(username.Text, pass.Text) == true)
                                MessageBox.Show("Изменения успешно внесены");
                            else
                                MessageBox.Show("Пользователь с таким именем уже существует!");
                        else
                            if (WorkBase.AcceptProfilePass(username.Text, pass.Text) == true)
                            MessageBox.Show("Изменения успешно внесены");
                    }));
                }).Start();
            });
        }
    }
}
