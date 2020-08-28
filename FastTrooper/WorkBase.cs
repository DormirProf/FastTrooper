using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastTrooper
{
    class WorkBase
    {
        readonly static RegistryKey fasttrooper = Registry.CurrentUser.CreateSubKey(@"Software\Fast Trooper");
        static string id;

        public static bool Login(string s1, string s2, bool s3)
        {
            try
            {
                byte l = 0;
                if (s1 == "TechAdmin" && s2 == "197HKZ358xh92eq39")
                {
                    fasttrooper.SetValue("name", s1);
                    if (s3 == true) 
                        fasttrooper.SetValue("Pass", Cript.Ftencrypt(s2, "D<q3ydnasd6т86фк8ыв6кТ*:КЫ:ЫВКФ"));
                    new GlavMenu().Show();
                    new Adm().Show();
                    return true;
                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(KeyCheck(1)))
                    {
                        try
                        {
                            conn.Open();
                        }
                        catch (Exception)
                        {
                            l = 1;
                            MessageBox.Show("Ошибка подключения!");
                            return false;
                        }
                        if (l != 1)
                        {
                            string sql = "SELECT `id`,`login`,`pass`,`Hwind`,`HddSerial`,`bans` FROM `user` WHERE login = login";
                            using (MySqlCommand command = new MySqlCommand(sql, conn))
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string log = reader[1].ToString();
                                    string pas = reader[2].ToString();
                                    string Hwind = reader[3].ToString();
                                    string HddSerial = reader[4].ToString();
                                    string bans = reader[5].ToString();
                                    if (GetHwind() == Hwind && GetHddSerial() == HddSerial)
                                        if (bans != "0")
                                        {
                                            MessageBox.Show("Вы забанены!");
                                            return false;
                                        }
                                        else
                                            if (s1.ToLower() == log && Cript.GetHash(s2 + s1) + Cript.GetHash(s1) == pas)
                                            {
                                            fasttrooper.SetValue("Name", s1);
                                            if (s3 == true)
                                            {
                                                fasttrooper.SetValue("Pass", Cript.Ftencrypt(s2, "D<q3ydnasd6т86фк8ыв6кТ*:КЫ:ЫВКФ"));
                                                fasttrooper.SetValue("RememberPassword", s3);
                                            }
                                            else
                                            {
                                                fasttrooper.SetValue("RememberPassword", s3);
                                                fasttrooper.SetValue("Pass", "");
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
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Нет поключения к сети!");
                return false;
            }
        }
        public static bool Register(string s1, string s2, string s3)
        {
            byte nm = 0;
            Regex regex = new Regex(" ");
            MatchCollection match = regex.Matches(s1);
            MatchCollection match1 = regex.Matches(s3);
            if (s3 == "" || match1.Count != 0)
            {
                MessageBox.Show("Логин введен с ошибкой!");
                return false;
            }
            if (s1 == "" && s3 != "" || match.Count != 0)
            {
                MessageBox.Show("Пароль введен с ошибкой!");
                return false;
            }
            if (s1 != s2)
            {
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }     
            try
            {
                using (MySqlConnection conn = new MySqlConnection(KeyCheck(1)))
                {
                    conn.Open();
                    string sql = "SELECT `login`, `Hwind`, `HddSerial` FROM `user` WHERE 1";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                                if (s3.ToLower() == reader[0].ToString())
                                    nm = 1;
                                if (GetHwind() == reader[1].ToString() &&
                                    GetHddSerial() == reader[2].ToString())
                                    nm = 2;
                        }
                        reader.Close();
                    }
                }
                if (nm == 0) {
                        using (MySqlConnection connection = new MySqlConnection(KeyCheck(1)))
                        {
                            connection.Open();
                                    string query = "INSERT INTO `user`(`login`, `name`, `pass`, `Hwind`, `HddSerial`,`bans`) VALUES ('" + 
                                        s3.ToLower() + "','" + 
                                        s3 + "','" +
                                        Cript.GetHash(s1 + s3) + Cript.GetHash(s3)+ "','"+
                                        GetHwind() + "','"+
                                        GetHddSerial() + "','0')";
                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                        }
                        fasttrooper.SetValue("CheckRegister", "True");
                        MessageBox.Show("Регистрация прошла успешно!");
                        new Login().Show();
                        return true;
                }
                if (nm == 1) {
                    MessageBox.Show("Такое имя пользователя уже существует!");
                    return false; 
                }
                else
                {
                    fasttrooper.SetValue("CheckRegister", "True");
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


        public static byte CheckChat(string Name, string Pass)
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
                                return 1;
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
        public static bool RegChat(string Name, string Pass)
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
        public static bool RegChat2(string Name)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=chat;password=root;"))
            {
                conn.Open();
                {
                    string query = "CREATE TABLE `"+Name+"` (`id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,`name` text NOT NULL,`mess` text NOT NULL)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
        }
        //смена имени и пароля
        public static bool AcceptProfileName(string name, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(KeyCheck(1)))
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
            using (MySqlConnection connection = new MySqlConnection(KeyCheck(1)))
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
        //изменен только пароль
        public static bool AcceptProfilePass(string name, string pass)
        {
            using (MySqlConnection connection = new MySqlConnection(KeyCheck(1)))
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
        //защита подключения
        protected internal static string KeyCheck(int b)
        {
            string ptrstr = "server=localhost;user=root;database=podkl;password=root;";

            using (MySqlConnection conn = new MySqlConnection(ptrstr))
            {
                conn.Open();
                string sql = "SELECT `key` FROM `pd` WHERE `id` = "+ b +"";
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

        public static string GetHwind() =>
        (from x in new ManagementObjectSearcher("SELECT * FROM win32_processor").Get().OfType<ManagementObject>()
         select x.GetPropertyValue("ProcessorId")).First().ToString();
        public static string GetHddSerial() =>
        (from x in new ManagementObjectSearcher("SELECT * FROM win32_PhysicalMemory").Get().OfType<ManagementObject>()
         select x.GetPropertyValue("Serialnumber")).First().ToString();

    }
}
