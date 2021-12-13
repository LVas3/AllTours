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
    public partial class Feedback : Form
    {
        public bool Sorted { get; set; }
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            //NameTourcomboBox.Sorted = true;
            List<string> Cruise = new List<string> { "Таллинн-Стокгольм", "Средиземное", "Карибское", "от Крыма до Босфора", "Красота Байкала", "Норвежские чудеса","Вино,Любовь,Сочи", "Лазурный берег Франции", "Доминикана", "Португалия", "Ялта", "Турецкое солнце" };
            NameTourcomboBox.DataSource = Cruise;
            List<int> rate = new List<int> { 5,4,3,2,1 };
            comboBoxRating.DataSource = rate;


        }

        private void NameTourcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NameTourcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Feedbackbutton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `feedback` ( `NameUser`,`NameTour`,`Rating`,`Message`) VALUES(@nuser,@ntour,@rate,@mes)", db.getConnection());
            command.Parameters.Add("@nuser", MySqlDbType.VarChar).Value = textBoxNameUser.Text;
            command.Parameters.Add("@rate", MySqlDbType.VarChar).Value = comboBoxRating.SelectedItem;

            command.Parameters.Add("@ntour", MySqlDbType.VarChar).Value = NameTourcomboBox.SelectedItem;
            command.Parameters.Add("@mes", MySqlDbType.VarChar).Value = richTextBoxFBack.Text;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Спасибо за отзыв");
                this.Hide();
                FormChooseTour ctour = new FormChooseTour();
                ctour.Show();
            }



            else
                MessageBox.Show("УХАДИ!");


            db.CloseConnect();
        }

        private void comboBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
