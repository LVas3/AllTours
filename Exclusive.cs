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
    public partial class Exclusive : Form
    {
        public Exclusive()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            List<string> ChTour = new List<string>() { };
        }
       
        private void Exclusive_Load(object sender, EventArgs e)
        {
           
           
                List<string> ChTour = new List<string>() { "Таллинн-Стокгольм", "Средиземное", "Карибское", "от Крыма до Босфора", "Красота Байкала", "Норвежские чудеса", "Дегустация Крымксих вин", "Пеший Петербург", "Казань", "Псковские просторы", "Свежая Карелия", "По горам, по Алтаю", "За сыром в Швейцарию", "Романовский Петербург", "Карнавал-Де-Жанейро", "Египетская сила", "Москва на все времена" };
                var random = new Random();
            List<string> DayNight = new List<string> (){ "3 дня/ 3 ночи", "5 дней/5 ночей", "7 дней/7 ночей", "10 дней/10 ночей", "14 дней/14 ночей" };
            



            string s = ChTour[random.Next(ChTour.Count)];
            string sq = ChTour[random.Next(ChTour.Count)];
            string tq = ChTour[random.Next(ChTour.Count)];

            string d = DayNight[random.Next(DayNight.Count)];
            string dq = DayNight[random.Next(DayNight.Count)];
            string de= DayNight[random.Next(DayNight.Count)];


            labelTour.Text = s;
            label8.Text = sq;
         //   label9.Text = tq;
            label13.Text = d;
            labelDays.Text = dq;
            //  label15.Text = de;
           
           // val = (val - val % 0.01);
            labelTime.Text = DateTime.Now.ToString("yyyy.MM.dd"); 
         
            label11.Text = DateTime.Now.ToString("yyyy.MM.dd");


        }

        private void ReLabel_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exclusivedes exd = new Exclusivedes();
            exd.Show();
            exd.label7.Text = this.labelTour.Text;
            exd.labelDays.Text = this.labelDays.Text;
            exd.labelTime.Text = this.labelTime.Text;

        }

        private void buttonar_Click(object sender, EventArgs e)
        {
            Exclusivedes exd = new Exclusivedes();
            exd.Show();
            exd.label7.Text = this.label8.Text;
            exd.labelDays.Text = this.label13.Text;
            exd.labelTime.Text = this.label11.Text;
        }
    }
}
