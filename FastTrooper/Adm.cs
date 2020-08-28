using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FastTrooper
{
    public partial class Adm : Form
    {

        public Adm()
        {
            InitializeComponent();
            Event();
        }

        void Event()
        {
            Bprem.Click += ((s, e) =>
            {
                SmenUser();
            });
            Boxusers.Click += ((s, e) =>
            {
                Check();
            });
            Bban.Click += ((s, e) =>
            {
                try { 
                using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(1)))
                {
                    connection.Open();
                    {
                        string query = "UPDATE `user` SET `bans`= '1' WHERE `login` = '"+   Boxusers.Text.ToLower() +"'";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Успешно");
            }
                catch
            {
                MessageBox.Show("Ошибка");
            }
        });
            Bunban.Click += ((s, e) =>
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(1)))
                    {
                        connection.Open();
                        {
                            string query = "UPDATE `user` SET `bans`= '0' WHERE `login` = '" + Boxusers.Text.ToLower() + "'";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Успешно");
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            });
        }

       
        void Check()
        {
            using (MySqlConnection conn = new MySqlConnection(WorkBase.KeyCheck(1)))
            {
                conn.Open();
                string sql = "SELECT `name` FROM `user` WHERE 1";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Boxusers.Items.Add("" + reader[0].ToString() + "");
                    }
                }
            }
        }
        void SmenUser()
        {
            if (pass.Text == "" && username.Text != "")
            {
                try
                {
                    byte g = 0;
                    using (MySqlConnection conn = new MySqlConnection(WorkBase.KeyCheck(1)))
                    {
                        conn.Open();
                        string sql = "SELECT `login` FROM `user` WHERE 1";
                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (username.Text.ToLower() == reader[0].ToString())
                                    g = 1;
                            }
                            if (g == 1)
                            {
                                MessageBox.Show("Такое имя пользователя уже существует!");
                            }
                        }
                    }
                    if (g == 0)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(1)))
                            {
                                connection.Open();
                                {
                                    string query = "UPDATE `user` SET `login` = '" + username.Text.ToLower() + "', `name` = '" + username.Text + "' WHERE `login` = '" + Boxusers.Text.ToLower() + "'";
                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                }
                            }
                            MessageBox.Show("Успешно");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
            if(pass.Text != "" && username.Text == "")
            {
               try
               {
                   using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(1)))
                   {
                       connection.Open();
                       {
                           string query = "UPDATE `user` SET `pass` = '" + Cript.GetHash(pass.Text + Boxusers.Text) + Cript.GetHash(Boxusers.Text) + "'  WHERE `login` = '" + Boxusers.Text.ToLower() + "'";
                           using (MySqlCommand command = new MySqlCommand(query, connection))
                           {
                               command.ExecuteNonQuery();
                           }
                       }
                   }
                   MessageBox.Show("Успешно");
               }
               catch
               {
                   MessageBox.Show("Ошибка");
               }
            }
            if(pass.Text != "" && username.Text != "")
            {
                    try
                    {
                        byte g = 0;
                        using (MySqlConnection conn = new MySqlConnection(WorkBase.KeyCheck(1)))
                        {
                            conn.Open();
                            string sql = "SELECT `login` FROM `user` WHERE 1";
                            using (MySqlCommand command = new MySqlCommand(sql, conn))
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                    if (username.Text.ToLower() == reader[0].ToString())
                                        g = 1;
                                if (g == 1)
                                    MessageBox.Show("Такое имя пользователя уже существует!");
                                reader.Close();
                            }
                        }
                        if (g == 0)
                        {
                            try
                            {
                                using (MySqlConnection connection = new MySqlConnection(WorkBase.KeyCheck(1)))
                                {
                                    connection.Open();
                                    {
                                        string query = "UPDATE `user` SET `login` = '" + username.Text.ToLower() + "' , `name` = '" + username.Text + "', `pass` = '" + Cript.GetHash(pass.Text + username.Text) + Cript.GetHash(username.Text) + "' WHERE `login` = '" + Boxusers.Text.ToLower() + "'";
                                        using (MySqlCommand command = new MySqlCommand(query, connection))
                                        {
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                MessageBox.Show("Успешно");
                            }
                            catch
                            {
                                MessageBox.Show("Ошибка");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }  
            }
        }

        private void показатьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vertexit");
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void закрытьАдминпанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
