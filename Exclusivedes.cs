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
    public partial class Exclusivedes :Form
    {
        // Tourss ts = new Tourss();
        Exclusive ex = new Exclusive();

        public Exclusivedes()
        {
            InitializeComponent();
            Exclusive ex = new Exclusive();
            label7.Text = ex.labelTour.Text;
        }

        public void Exclusivedes_Load(object sender, EventArgs e)
        {
            //Exclusive ex = new Exclusive();
            //ex.labelTour.Text = Convert.ToString(label7);
            // ex.ShowDialog();
            List<string> NumOld = new List<string> { "1", "2", "3", "4", "5+" };
            comboBoxNumOld.DataSource = NumOld;
            // Количество взрослых
            List<string> NumChild = new List<string> { "Нет", "1", "2", "3", "4", "5+" };
            comboBoxNumChild.DataSource = NumChild;

        }

        private void labelTour_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `tours` ( `TypeofTour`,`TourName`,`TourStart`,`NumDayNight`, `NumofOld`, `NumofChild`,`Schengen`) VALUES(@typetour,@tourname,@tourstart,@daynight,@old,@child,@schengen)", db.getConnection());
            command.Parameters.Add("@typetour", MySqlDbType.VarChar).Value = "Эсклюзивный";
            command.Parameters.Add("@tourname", MySqlDbType.VarChar).Value = label7.Text;
            command.Parameters.Add("@tourstart", MySqlDbType.Date).Value = labelTime.Text;
            command.Parameters.Add("@daynight", MySqlDbType.VarChar).Value = labelDays.Text;
            command.Parameters.Add("@old", MySqlDbType.VarChar).Value = comboBoxNumOld.SelectedItem;
            command.Parameters.Add("@child", MySqlDbType.VarChar).Value = comboBoxNumChild.SelectedItem;
            command.Parameters.Add("@schengen", MySqlDbType.Bit).Value = 0;

            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Тур забронирован!");
            else
                MessageBox.Show("Тур не удалось забронировать");


            db.CloseConnect();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
    }
}
