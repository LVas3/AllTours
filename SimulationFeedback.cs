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
    public partial class SimulationFeedback : Form
    {
        public SimulationFeedback()
        {
            InitializeComponent();
        }
        SqlSimulation sf = new SqlSimulation();
        private bool Working;


        string[] NameUsers = { "Сергей Волков", "Анастасия Михайлова ", "Семён Семёнов" };
        string[] NameTours = { "Таллинн-Стокгольм", "Средиземное", "Карибское", "от Крыма до Босфора", "Красота Байкала", "Норвежские чудеса", "Вино,Любовь,Сочи", "Лазурный берег Франции", "Доминикана", "Португалия", "Ялта", "Турецкое солнце" };
        string[] Ratings = { "4", "5" };
        string[] Messages = { "Тур очень понравился", "Спасибо большое за хороший отпуск", "Отдохнул просто бомба", "Ушарнов" };

        Random random = new Random();
        int count = 0; // счётчик для регистрации
        public void SimulateTours()
        {
            while (Working)
            {
                string NameUser = NameUsers[random.Next(0, NameUsers.Length)] + random.Next(10000, 99999);
                string NameTour = NameTours[random.Next(0, NameTours.Length)];
                string Rating = Ratings[random.Next(0, Ratings.Length)];
                string Messagee = Messages[random.Next(0, Messages.Length)];

                sf.Feedbacks(NameUser, NameTour, Rating, Messagee);
                count++;
                label2.Invoke(new Action(() => label2.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }
        class SqlSimulation
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=betaalltours");
            public bool Feedbacks(string NameUser, string NameTour, string Rating, string Messagee)
            {

                bool flag = false;
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO users (NameUser, NameTour, Rating, Message) VALUES (@nameuser, @nametour, @rating, @message)", connection);
                cmd.Parameters.AddWithValue("@nameuser", NameUser);
                cmd.Parameters.AddWithValue("@nametour", NameTour);
                cmd.Parameters.AddWithValue("@rating", Rating);
                cmd.Parameters.AddWithValue("@message", Messagee);
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    flag = true;
                }
                connection.Close();
                return flag;
            }
        }

        private void buttonStarts_Click(object sender, EventArgs e)
        {
            Working = true;
            Task.Run(() => SimulateTours());

        }

        private void buttonStops_Click(object sender, EventArgs e)
        {
            Working = false;
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }
    }
    
}
