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
    public partial class RegistrationF : Form
    {
        public RegistrationF()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (TBUser.Text == "" || textBoxPassword.Text == "" || NametextBox.Text == "" || SurnametextBox.Text == "" || EmailtextBox.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                if (checkUser())
                    return;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(" INSERT INTO `users` ( `Login`, `Password`, `Name`, `Surname`,`Email`) VALUES(@login,@pass,@name,@surname,@email)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = TBUser.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NametextBox.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnametextBox.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailtextBox.Text;
                db.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");


                db.CloseConnect();
            }
        }
        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = TBUser.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть!");
                return true;
            }
            else
            {
               
                return false;

            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
