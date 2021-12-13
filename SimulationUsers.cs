using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTours
{
    public partial class SimulationUsers : Form
    {
        public SimulationUsers()
        {
            InitializeComponent();
        }
        SqlSimulation ss = new SqlSimulation();
        private bool Working;


        string[] logins = { "ilya12", "kifdh244", "nrh45" };
        string[] passwords = { "345", "4gh57", "4j582" };
        string[] names = { "Алексей", "Сергей", "Анастасия", "Артур", "Екатерина" };
        string[] surnames = { "Сидоров", "Васильев", "Хохлов", "Ушарнов", "Баблов" };
        string[] emails = { "atr@gmail.com", "pr@yandex.ru", "HJ@gmail.com" };
        Random random = new Random();
        int count = 0; // счётчик для регистрации
        public void SimulateRegistration()
        {
            while (Working)
            {
                string Login = logins[random.Next(0, logins.Length)] + random.Next(10000, 99999);
                string Password = passwords[random.Next(0, passwords.Length)];
                string Name = names[random.Next(0, names.Length)];
                string Surname = surnames[random.Next(0, names.Length)];
                string Email = emails[random.Next(0, emails.Length)];
                ss.RegUsers(Login, Password, Name, Surname, Email);
                count++;
                label2.Invoke(new Action(() => label2.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }
        class SqlSimulation
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=betaalltours");
            public bool RegUsers(string Login, string Password, string Name, string Surname, string Email)
            {
                bool flag = false;
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO users (Login, Password, Name, Surname,Email) VALUES (@login, @password, @name, @surname,@email)", connection);
                cmd.Parameters.AddWithValue("@login", Login);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@email", Email);
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
                connection.Close();
                return flag;
            }

            // Авторизация пользователя
            public bool LogUsers(string Login, string Password)
            {
                bool flag = false;
                MySqlCommand cmd = new MySqlCommand($"SELECT login FROM users WHERE Login = @login AND Password = @password", connection);
                cmd.Parameters.AddWithValue("@login", Login);
                cmd.Parameters.AddWithValue("@password", Password);
                connection.Open();
                MySqlDataReader srd = cmd.ExecuteReader();
                if (srd.HasRows)
                {
                    flag = true;
                }
                connection.Close();
                return flag;
            }
        }
        private void Startbutton_Click(object sender, EventArgs e)
        {
            Working = true;
            Task.Run(() => SimulateRegistration());
        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            Working = false;
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
