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
    public partial class CruiseTourForm : Form
    {
        public CruiseTourForm()
        {
            InitializeComponent();
        }

      

        private void comboBoxChooseTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxChooseTour.SelectedItem == "Таллинн-Стокгольм")
            {
                comboBoxDayNight.Items.Remove("7 дней/7 ночей");
                comboBoxDayNight.Items.Remove("14 дней/14 ночей");
               checkBox1.Checked = true;

            }

            if (comboBoxChooseTour.SelectedItem == "Средиземное")
            {
                comboBoxDayNight.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNight.Items.Remove("10 дней/10 ночей");
                checkBox1.Checked = true;

            }
            if (comboBoxChooseTour.SelectedItem == "Карибское")
            {
                comboBoxDayNight.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNight.Items.Remove("7 дней/7 ночей");
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTour.SelectedItem == "от Крыма до Босфора")
            {
                comboBoxDayNight.Items.Remove("3 дня/ 3 ночи");

                comboBoxDayNight.Items.Remove("14 дней/14 ночей");
                 checkBox1.Checked = false;

            }

            if (comboBoxChooseTour.SelectedItem == "Красота Байкала")
            {
                comboBoxDayNight.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNight.Items.Remove("7 дней/7 ночей");
                comboBoxDayNight.Items.Remove("14 дней/14 ночей");
             
                checkBox1.Checked = false;

            }
            if (comboBoxChooseTour.SelectedItem == "Норвежские чудеса")
            {
                comboBoxDayNight.Items.Remove("3 дня/ 3 ночи");
                comboBoxDayNight.Items.Remove("7 дней/7 ночей");
                comboBoxDayNight.Items.Remove("14 дней/14 ночей");
                checkBox1.Checked = true;

            }
           
        }

        private void CruiseTourForm_Load(object sender, EventArgs e)
        {
            //Выбор тура
            List<string> ChooseTour = new List<string> { "Таллинн-Стокгольм", "Средиземное", "Карибское", "от Крыма до Босфора", "Красота Байкала", "Норвежские чудеса" };
            comboBoxChooseTour.DataSource = ChooseTour;
            //Выбор дней /ночей
            // List<string> NumDN = new List<string> { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей"};
            // comboBoxDayNight.DataSource = NumDN;
            comboBoxDayNight.Items.AddRange(new string[] { "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей" });
            // Количество взрослых
            List<string> NumOld = new List<string> { "1", "2", "3", "4", "5+" };
            comboBoxNumOld.DataSource = NumOld;
            // Количество взрослых
            List<string> NumChild = new List<string> { "Нет", "1", "2", "3", "4", "5+" };
            comboBoxNumChild.DataSource = NumChild;
            
           
        }

      

      
       

        private void comboBoxChooseTour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Random rnd = new Random() ;
            double val =   rnd.NextDouble() * (5.00 - 4.25)+ 4.25 ;
            val = (val - val % 0.01);
            label9.Text = val.ToString();
        }

        private void buttonCruise_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Круизный";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = comboBoxChooseTour.SelectedItem;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = comboBoxDayNight.SelectedItem;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                labelforvisa.Visible = true;
            }
            else
            {
                labelforvisa.Visible = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
