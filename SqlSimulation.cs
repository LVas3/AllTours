using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTours
{
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
        public bool Tours(string TypeofTour,string TourName,string TourStart,string NumDayNight,string NumofOld, string NumofChild,bool Schengen)
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
}
