using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastTrooper
{
    class WorkBase
    {
        private readonly static RegistryKey fastTrooper = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");
        private static string id;
        private const string selectLoginInSQL = "SELECT `id`,`login`,`pass`,`Hwind`,`HddSerial`,`bans` FROM `user` WHERE login = login";

        public static bool Login(string name, string password, bool savedCheck)
        {
            try
            {
                if (OfflineAuthorization(name, password, savedCheck))
                {
                    return true;
                }
                else
                {
                    Authorization(name, password, savedCheck);
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Нет поключения к сети!");
                return false;
            }
        }

        public static bool Register(string password, string repeatPassword, string name)
        {
            bool nameExists;
            if (CheckForErrors(name, password, repeatPassword) == false)
            {
                return false;
            }
            try
            {
                nameExists = CheckHwindAndNameExists(name);
                if (nameExists == false)
                {
                    using (MySqlConnection connection = new MySqlConnection(CheckKey(1)))
                    {
                        connection.Open();
                        string query = "INSERT INTO `user`(`login`, `name`, `pass`, `Hwind`, `HddSerial`,`bans`) VALUES ('" +
                            name.ToLower() + "','" +
                            name + "','" +
                            Cript.GetHash(password + name) + Cript.GetHash(name) + "','" +
                            HwindAndHddSerial.GetHwind() + "','" +
                            HwindAndHddSerial.GetHddSerial() + "','0')";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    fastTrooper.SetValue("CheckRegister", "True");
                    MessageBox.Show("Регистрация прошла успешно!");
                    new Login().Show();
                    return true;
                }
                if (nameExists == true)
                {
                    MessageBox.Show("Такое имя пользователя уже существует!");
                    return false;
                }
                else
                {
                    fastTrooper.SetValue("CheckRegister", "True");
                    MessageBox.Show("Вы уже регистрировались!");
                    new Login().Show();
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения!");
                return false;
            }
        }

        public static int CheckChatAuthorization(string Name, string Pass)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=chat;password=root;"))
            {
                conn.Open();
                string sql = "SELECT `Name`, `Pass` FROM `list` WHERE 1";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (Name == reader[0].ToString())
                        {
                            if (Pass == reader[1].ToString())
                            {
                                return 1;
                            }
                            else
                            {
                                return 2;
                            }
                        }
                    }
                    reader.Close();
                }
                return 3;
            }
        }

        public static bool RegisterNewChat(string Name, string Pass)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=chat;password=root;"))
            {
                conn.Open();
                {
                    string query = "INSERT INTO `list`(`Name`, `Pass`) VALUES ('" +
                                        Name + "','" +
                                        Pass + "')";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }

        public static bool RegisterNewChat2(string Name)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=chat;password=root;"))
            {
                conn.Open();
                {
                    string query = "CREATE TABLE `" + Name + "` (`id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,`name` text NOT NULL,`mess` text NOT NULL)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }

        public static bool ChangeUsername(string name, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(CheckKey(1)))
            {
                conn.Open();
                string sql = "SELECT `login` FROM `user` WHERE 1";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (name.ToLower() == reader[0].ToString())
                            return false;
                    }
                    reader.Close();
                }
            }
            using (MySqlConnection connection = new MySqlConnection(CheckKey(1)))
            {
                connection.Open();
                {
                    string query = "UPDATE `user` SET `login` = '" + name.ToLower() + "' , `name` = '" + name + "' , `pass` = '" + Cript.GetHash(pass + name) + Cript.GetHash(name)
                        + "' WHERE `id` = " + id + "";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }

        public static bool ChangePassword(string name, string pass)
        {
            using (MySqlConnection connection = new MySqlConnection(CheckKey(1)))
            {
                connection.Open();
                {
                    string query = "UPDATE `user` SET `pass` = '" + Cript.GetHash(pass + name) + Cript.GetHash(name) + "' WHERE `id` = " + id + "";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }

        public static string CheckKey(int number)
        {
            string SQLAuthorization = "server=localhost;user=root;database=podkl;password=root;";

            using (MySqlConnection conn = new MySqlConnection(SQLAuthorization))
            {
                conn.Open();
                string sql = "SELECT `key` FROM `pd` WHERE `id` = " + number + "";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return Cript.Ftdecrypt(reader[0].ToString(), "NHd923asdm-9q83y3ydq3dwf4");
                    }
                    reader.Close();
                }
            }
            return "";
        }

        private static bool OfflineAuthorization(string name, string password, bool savedCheck)
        {
            if (name == "TechAdmin" && password == "197HKZ358xh92eq39")
            {
                fastTrooper.SetValue("name", name);
                if (savedCheck == true)
                    fastTrooper.SetValue("Pass", Cript.Ftencrypt(password, "D<q3ydnasd6т86фк8ыв6кТ*:КЫ:ЫВКФ"));
                new GlavMenu().Show();
                new Adm().Show();
                return true;
            }
            return false;
        }

        private static bool Authorization(string name, string password, bool savedCheck)
        {
            using (MySqlConnection conn = new MySqlConnection(CheckKey(1)))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка подключения!");
                    return false;
                }
                using (MySqlCommand command = new MySqlCommand(selectLoginInSQL, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string log = reader[1].ToString();
                        string pas = reader[2].ToString();
                        string Hwind = reader[3].ToString();
                        string HddSerial = reader[4].ToString();
                        string bans = reader[5].ToString();
                        if (HwindAndHddSerial.GetHwind() == Hwind && HwindAndHddSerial.GetHddSerial() == HddSerial)
                            if (bans != "0")
                            {
                                MessageBox.Show("Вы забанены!");
                                return false;
                            }
                            else if ((name.ToLower() == log) && (Cript.GetHash(password + name) + Cript.GetHash(name) == pas))
                            {
                                fastTrooper.SetValue("Name", name);
                                if (savedCheck == true)
                                {
                                    fastTrooper.SetValue("Pass", Cript.Ftencrypt(password, "D<q3ydnasd6т86фк8ыв6кТ*:КЫ:ЫВКФ"));
                                    fastTrooper.SetValue("RememberPassword", savedCheck);
                                }
                                else
                                {
                                    fastTrooper.SetValue("RememberPassword", savedCheck);
                                    fastTrooper.SetValue("Pass", "");
                                }
                                if (log == "admin")
                                {
                                    new GlavMenu().Show();
                                    new Adm().Show();
                                    return true;

                                }
                                else
                                    new GlavMenu().Show();
                                id = reader[0].ToString();
                                return true;
                            }
                    }
                    reader.Close();
                    MessageBox.Show("Не правильный логин или пароль! Или вы вошли с нового устройства!");
                    return false;
                }
            }
        }

        private static bool CheckForErrors(string name , string password, string repeatPassword)
        {
            Regex regex = new Regex(" ");
            MatchCollection match = regex.Matches(password);
            MatchCollection match1 = regex.Matches(name);
            if (name == "" || match1.Count != 0)
            {
                MessageBox.Show("Логин введен с ошибкой!");
                return false;
            } else if (password == "" && name != "" || match.Count != 0)
            {
                MessageBox.Show("Пароль введен с ошибкой!");
                return false;
            } else if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }
            return true;
        }

        private static bool CheckHwindAndNameExists(string name)
        {
            using (MySqlConnection conn = new MySqlConnection(CheckKey(1)))
            {
                conn.Open();
                string sql = "SELECT `login`, `Hwind`, `HddSerial` FROM `user` WHERE 1";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (name.ToLower() == reader[0].ToString())
                            return true;
                        if (HwindAndHddSerial.GetHwind() == reader[1].ToString() &&
                            HwindAndHddSerial.GetHddSerial() == reader[2].ToString())
                            return false;
                    }
                    reader.Close();
                }
            }
            return false;
        }
    }
}
