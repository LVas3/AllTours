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
    public partial class ResortTour : Form
    {
        public ResortTour()
        {
            InitializeComponent();
        }

        private void ResortTour_Load(object sender, EventArgs e)
        {
            //Выбор тура
            List<string> ChooseTourK = new List<string> { "Вино,Любовь,Сочи", "Лазурный берег Франции", "Доминикана", "Португалия", "Ялта", "Турецкое солнце" };
            comboBoxChooseTourK.DataSource = ChooseTourK;
            //Выбор дней /ночей
            // List<string> NumDN = new List<string> { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей"};
            // comboBoxDayNight.DataSource = NumDN;
            comboBoxDayNightK.Items.AddRange(new string[] { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей" });
            // Количество взрослых
            List<string> NumOld = new List<string> { "1", "2", "3", "4", "5+" };
            comboBoxNumOld.DataSource = NumOld;
            // Количество взрослых
            List<string> NumChild = new List<string> { "Нет", "1", "2", "3", "4", "5+" };
            comboBoxNumChild.DataSource = NumChild;

        }

        private void comboBoxChooseTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseTourK.SelectedItem == "Вино,Любовь,Сочи")
            {
                comboBoxDayNightK.Items.Remove("7 дней/7 ночей");
                comboBoxDayNightK.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }

            if (comboBoxChooseTourK.SelectedItem == "Лазурный берег Франции")
            {
                comboBoxDayNightK.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightK.Items.Remove("10 дней/10 ночей");
                checkBox1.Checked = true;

            }
            if (comboBoxChooseTourK.SelectedItem == "Доминикана")
            {
                comboBoxDayNightK.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightK.Items.Remove("7 дней/7 ночей");
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTourK.SelectedItem == "Португалия")
            {
                comboBoxDayNightK.Items.Remove("3 дня/ 3 ночи");

                comboBoxDayNightK.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = true;

            }

            if (comboBoxChooseTourK.SelectedItem == "Ялта")
            {
                comboBoxDayNightK.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightK.Items.Remove("7 дней/7 ночей");
                //comboBoxDayNightK.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTourK.SelectedItem == "Турецкое солнце")
            {
                comboBoxDayNightK.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightK.Items.Remove("7 дней/7 ночей");
                comboBoxDayNightK.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }

        }

        private void ResortTour_Click(object sender, EventArgs e)
        {

           
        }

        private void buttonResort_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Курортный";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = comboBoxChooseTourK.SelectedItem;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = comboBoxDayNightK.SelectedItem;
            command.Parameters.Add("@old", MySqlDbType.VarChar).Value = comboBoxNumOld.SelectedItem;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = comboBoxNumChild.SelectedItem;
            command.Parameters.Add("@schengen", MySqlDbType.Bit).Value = checkBox1.Checked;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тур забронирован!");
            else
                MessageBox.Show("Тур не удалось забронировать");


            db.CloseConnect();
        }

        private void comboBoxChooseTourK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double val = rnd.NextDouble() * (5.00 - 4.25) + 4.25;
            val = (val - val % 0.01);
            label9.Text = val.ToString();
        }
    }
}
