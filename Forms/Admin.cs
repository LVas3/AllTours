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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBUsers dbu = new DBUsers();
            dbu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBTours dbt = new DBTours();
            dbt.Show();
        }
    }
}
