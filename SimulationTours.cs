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
    public partial class SimulationTours : Form
    {
        public SimulationTours()
        {
            InitializeComponent();
        }
        SqlSimulation ssi = new SqlSimulation();
        private bool Working;


        string[] TypeofTours = { "Круизный", "Курортный", "Туристический", "Бизнес", "Эсклюзивный" };
        string[] TourNamesCruise = { "Таллинн-Стокгольм", "Средиземное", "Карибское", "от Крыма до Босфора", "Красота Байкала", "Норвежские чудеса" };
        string[] TourStarts = DateTime.MinValue();
        string[] names = { "Алексей", "Сергей", "Анастасия", "Артур", "Екатерина" };
        string[] surnames = { "Сидоров", "Васильев", "Хохлов", "Ушарнов", "Баблов" };
        string[] emails = { "atr@gmail.com", "pr@yandex.ru", "HJ@gmail.com" };
        Random random = new Random();
        int count = 0; // счётчик для регистрации
        public void SimulateTours()
        {
            while (Working)
            {
                string TypeofTour = TypeofTours[random.Next(0, TypeofTours.Length)] + random.Next(10000, 99999);
                string Password = passwords[random.Next(0, passwords.Length)];
                string Name = names[random.Next(0, names.Length)];
                string Surname = surnames[random.Next(0, names.Length)];
                string Email = emails[random.Next(0, emails.Length)];
                ssi.Tours( TypeofTour,  TourName, TourStart,  NumDayNight,  NumofOld,  NumofChild,  Schengen);
                count++;
                label2.Invoke(new Action(() => label2.Text = count.ToString()));
                Thread.Sleep(1000);
            }
        }
        class SqlSimulation
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=betaalltours");
            public bool Tours(string TypeofTour, string TourName, string TourStart, string NumDayNight, string NumofOld, string NumofChild, bool Schengen)
            {

                bool flag = false;
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO tours (TypeofTour, TourName, TourStart,NumDayNight,NumofOld,Numofchild,Schengen) VALUES (@TypeofTour, @TourName, @TourStart, @NumDayNight,@NumofOld,@Numofchild,@Schengen)", connection);
                cmd.Parameters.AddWithValue("@TypeofTour", TypeofTour);
                cmd.Parameters.AddWithValue("@TourName", TourName);
                cmd.Parameters.AddWithValue("@TourStart", TourStart);
                cmd.Parameters.AddWithValue("@NumDayNight", NumDayNight);
                cmd.Parameters.AddWithValue("@NumofOld", NumofOld);
                cmd.Parameters.AddWithValue("@NumofChild", NumofChild);
                cmd.Parameters.AddWithValue("@Schengen", Schengen);
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


            private void buttonStart_Click(object sender, EventArgs e)
            {

            }
        }
    }
}
