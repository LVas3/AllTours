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
using static AllTours.DB;


namespace AllTours
{
    public partial class FormChooseTour : Form
    {
        Account ac = new Account();
        public FormChooseTour()
        {
            InitializeComponent();
        
           
        }

        public FormChooseTour(Account ac)
        {

            InitializeComponent();
            this.ac = ac;

        }
        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization aut = new Authorization();
           aut.Show();

        }

        private void pictureBoxCruise_Click(object sender, EventArgs e)
        {
            loadform(new CruiseTourForm());
        }

        private void labelUser_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
           // labelUser.Text = ac.Login;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            loadform(new Exclusive());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new ResortTour());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadform(new TourismForm());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadform(new BusinessForm());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
           Feedback Fback = new Feedback();
            Fback.Show();
        }
    }
}
