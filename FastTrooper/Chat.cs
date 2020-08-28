using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Chat : Form
    {
        public string name = "123";
        public string nameuser = "User";


        public string Names
        {
            get { return name; }
            set { name = value; }
        }

        public string NamesUsers
        {
            get { return nameuser; }
            set { nameuser = value; }
        }
        public Chat()
        {
            InitializeComponent();
            Event();
            Up();
        }

        void Event()
        {
            Lsent.MouseMove += ((s, e) =>
            {
                    Lsent.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            });
            Lsent.MouseLeave += ((s, e) =>
            {
                    Lsent.ForeColor = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            });
            KeyDown += ((s, e) =>
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    Lsent_Click(Lsent, null);
                }
            });
        }

        async void Up() //// Метод обновления чата
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(WorkBase.KeyCheck(2)))
                {
                    conn.Open();
                    string sql = "SELECT `name`,`mess` FROM `"+ name + "` WHERE mess = mess";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textchat.Text += reader[0].ToString() + Cript.Ftdecrypt(reader[1].ToString(), "N_As7dda8s7dgqasD@d7a6fsdh9q") + "\r\n";
                        }
                        reader.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
            await Task.Delay(2300);
            textchat.Text = "";
            Up();
        }

        private void Lsent_Click(object sender, EventArgs e)
        {
            new Thread(() => {
                Invoke((Action)(() =>
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(2)))
                        {
                            connection.Open();
                            string query1 = "INSERT INTO `"+ name + "` (name,mess) VALUES ('" + nameuser + ": " + "','" + Cript.Ftencrypt(textinchat.Text, "N_As7dda8s7dgqasD@d7a6fsdh9q") + "')";
                            using (MySqlCommand command = new MySqlCommand(query1, connection))
                                command.ExecuteNonQuery();
                        }
                        textinchat.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка соединения!");
                    }
                }));
            }).Start();
        }
    }
}
