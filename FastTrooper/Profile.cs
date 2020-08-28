using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Profile : Form
    {
        private readonly static RegistryKey pr = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");

        public Profile()
        {
            InitializeComponent();
            Event();
        }

        private void Event()
        {
            username.Text = pr.GetValue("Name").ToString();
            Bprem.Click += ((s, e) =>
            {
                new Thread(() => {
                    Invoke((Action)(() =>
                    {
                        if (username.Text != pr.GetValue("Name").ToString())
                            if (WorkBase.ChangeUsername(username.Text, pass.Text) == true)
                                MessageBox.Show("Изменения успешно внесены");
                            else
                                MessageBox.Show("Пользователь с таким именем уже существует!");
                        else
                            if (WorkBase.ChangePassword(username.Text, pass.Text) == true)
                            MessageBox.Show("Изменения успешно внесены");
                    }));
                }).Start();
            });
        }
    }
}
