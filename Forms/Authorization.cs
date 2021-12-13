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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
      

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void pictureBoxvispass_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string LoginUser = TBUser.Text;
            string PassUser = textBoxPassword.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL AND `Password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
          
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Не удалось войти", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (TBUser.Text == "Admin")
            {
                this.Hide();
               Admin aform = new Admin();
                aform.Show();
            }
            else
            {
                this.Hide();
                FormChooseTour ctour = new FormChooseTour();
                ctour.Show();
                //  FormChooseTour ctour = new FormChooseTour();
                ctour.labelUser.Text = this.TBUser.Text;

            }


        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationF register = new RegistrationF();
            register.Show();
        }

        private void buttonRegist_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationF rf = new RegistrationF();
            rf.Show();
        }
    }
}
