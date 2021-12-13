using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllTours
{
    public partial class BusinessForm : Form
    {
        public BusinessForm()
        {
            InitializeComponent();
        }

        private void buttonBisness_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Бизнес";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = comboBoxChooseTourB.SelectedItem;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = comboBoxDayNightB.SelectedItem;
            command.Parameters.Add("@old", MySqlDbType.VarChar).Value = comboBoxNumOld.SelectedItem;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = "NULL";
            command.Parameters.Add("@schengen", MySqlDbType.Bit).Value = 0;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тур забронирован!");
            else
                MessageBox.Show("Тур не удалось забронировать");


            db.CloseConnect();
        }

        private void comboBoxChooseTourB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double val = rnd.NextDouble() * (5.00 - 4.25) + 4.25;
            val = (val - val % 0.01);
            label9.Text = val.ToString();
        }

        private void BusinessForm_Load(object sender, EventArgs e)
        {
            List<string> ChooseTour = new List<string> { "Дегустация Крымксих вин", "Пеший Петербург", "Москва красна", "Казань", "Псковские просторы", "Свежая Карелия" };
            comboBoxChooseTourB.DataSource = ChooseTour;
            //Выбор дней /ночей
            // List<string> NumDN = new List<string> { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей"};
            // comboBoxDayNight.DataSource = NumDN;
            comboBoxDayNightB.Items.AddRange(new string[] { "1 день/ 1 ночь", "3 дня/3 ночи", "7 дней/7 ночей", "11 дней/11 ночей", "14 дней/14 ночей" });
            // Количество взрослых
            List<string> NumOld = new List<string> { "1-5", "5-10", "10-20", "20-50", "50+" };
            comboBoxNumOld.DataSource = NumOld;
        }

        private void buttonBisness_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Бизнес";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = comboBoxChooseTourB.SelectedItem;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = comboBoxDayNightB.SelectedItem;
            command.Parameters.Add("@old", MySqlDbType.VarChar).Value = comboBoxNumOld.SelectedItem;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = "NULL";
            command.Parameters.Add("@schengen", MySqlDbType.Bit).Value = 0;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тур забронирован!");
            else
                MessageBox.Show("Тур не удалось забронировать");


            db.CloseConnect();

        }
    }
}
