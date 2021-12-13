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
    public partial class TourismForm : Form
    {
        public TourismForm()
        {
            InitializeComponent();
        }

        private void TourismForm_Click(object sender, EventArgs e)
        {
            List<string> ChooseTour = new List<string> { "По горам, по Алтаю", "За сыром в Швейцарию", "Романовский Петербург", "Карнавал-Де-Жанейро", "Египетская сила", "Москва на все времена" };
            comboBoxChooseTourT.DataSource = ChooseTour;
            //Выбор дней /ночей
            // List<string> NumDN = new List<string> { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей"};
            // comboBoxDayNight.DataSource = NumDN;
            comboBoxDayNightT.Items.AddRange(new string[] { "1 день/ 1 ночь", "3 дня/3 ночи", "7 дней/7 ночей", "11 дней/11 ночей", "14 дней/14 ночей" });
            // Количество взрослых
            List<string> NumOld = new List<string> { "1", "2", "3", "4", "5+" };
            comboBoxNumOld.DataSource = NumOld;
            // Количество взрослых
            List<string> NumChild = new List<string> { "Нет", "1", "2", "3", "4", "5+" };
            comboBoxNumChild.DataSource = NumChild;
        }

        private void buttonTourism_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Туристический";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = comboBoxChooseTourT.SelectedItem;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = comboBoxDayNightT.SelectedItem;
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

        private void comboBoxChooseTourT_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxChooseTourT.SelectedItem == "Вино,Любовь,Сочи")
            {
                comboBoxDayNightT.Items.Remove("7 дней/7 ночей");
                comboBoxDayNightT.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }

            if (comboBoxChooseTourT.SelectedItem == "Лазурный берег Франции")
            {
                comboBoxDayNightT.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightT.Items.Remove("10 дней/10 ночей");
                checkBox1.Checked = true;

            }
            if (comboBoxChooseTourT.SelectedItem == "Доминикана")
            {
                comboBoxDayNightT.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightT.Items.Remove("7 дней/7 ночей");
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTourT.SelectedItem == "Португалия")
            {
                comboBoxDayNightT.Items.Remove("3 дня/ 3 ночи");

                comboBoxDayNightT.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = true;

            }

            if (comboBoxChooseTourT.SelectedItem == "Ялта")
            {
                comboBoxDayNightT.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightT.Items.Remove("7 дней/7 ночей");
                //comboBoxDayNightT.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTourT.SelectedItem == "Турецкое солнце")
            {
                comboBoxDayNightT.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNightT.Items.Remove("7 дней/7 ночей");
                comboBoxDayNightT.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = false;

            }
        }

        private void TourismForm_Load(object sender, EventArgs e)
        {
            List<string> ChooseTour = new List<string> { "По горам, по Алтаю", "За сыром в Швейцарию", "Романовский Петербург", "Карнавал-Де-Жанейро", "Египетская сила", "Москва на все времена" };
            comboBoxChooseTourT.DataSource = ChooseTour;
            //Выбор дней /ночей
            // List<string> NumDN = new List<string> { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей"};
            // comboBoxDayNight.DataSource = NumDN;
            comboBoxDayNightT.Items.AddRange(new string[] { "1 день/ 1 ночь", "3 дня/3 ночи", "7 дней/7 ночей", "11 дней/11 ночей", "14 дней/14 ночей" });
            // Количество взрослых
            List<string> NumOld = new List<string> { "1", "2", "3", "4", "5+" };
            comboBoxNumOld.DataSource = NumOld;
            // Количество взрослых
            List<string> NumChild = new List<string> { "Нет", "1", "2", "3", "4", "5+" };
            comboBoxNumChild.DataSource = NumChild;

        }

        private void comboBoxChooseTourT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double val = rnd.NextDouble() * (5.00 - 4.25) + 4.25;
            val = (val - val % 0.01);
            label9.Text = val.ToString();
        }
    }
}
