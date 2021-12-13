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
    public partial class DBUsers : Form
    {
        static string conString = "server=localhost;port=3306;user=root;password=root;database=betaalltours";
        MySqlConnection con = new(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new();
        public DBUsers()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Login";
            dataGridView1.Columns[2].Name = "Password";
            dataGridView1.Columns[3].Name = "Name";
            dataGridView1.Columns[4].Name = "Surname";
            dataGridView1.Columns[5].Name = "Email";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void add( string Login, string Password, string Name, string Surname, string Email)
        {
            // string sql = "Insert Into users (id,Login,Password,Name,Surname,Email) Values (@id,@Login,@Password,@Name,@Surname,@Email)";
            //   cmd = new MySqlCommand(sql, con);
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `users` ( `Login`, `Password`, `Name`, `Surname`,`Email`) VALUES(@login,@pass,@name,@surname,@email)", db.getConnection());
            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value =Surname;
            command.Parameters.Add("@email",MySqlDbType.VarChar).Value = Email;
            try
            {
                con.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Succefully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void populate(string id, string Login, string Password, string Name, string Surname, string Email)
        {
            dataGridView1.Rows.Add(id, Login, Password, Name, Surname, Email);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            string sql = "Select * from users";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void update(int id,string Login, string Password, string Name, string Surname, string Email)
        {
            string sql = "Update users SET Login ='" + Login + "',Password='" + Password + "',Name='" + Name + "',Surname='" + Surname + "',Email'" + Email + "',Password'" + Password+"'WHERE ID ='"+id+"";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("It's update!");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void Delete (int id)
        {
            string sql = "DELETE FROM users Where id=" + id + "";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                if (MessageBox.Show("Sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("This Delete!");
                    }
                }
                con.Close();
                retrieve();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void clearTxts()
        {
            LoginTxt.Text = "";
            PassTxt.Text = "";
            NameTxt.Text = "";
            SurnameTxt.Text = "";
            EmailTxt.Text = "";
        }
        private void DBUsers_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            Delete(id);
        }

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            LoginTxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            PassTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            NameTxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            SurnameTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            EmailTxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            add(LoginTxt.Text, PassTxt.Text, NameTxt.Text, SurnameTxt.Text, EmailTxt.Text);
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            update( id, LoginTxt.Text, PassTxt.Text, NameTxt.Text, SurnameTxt.Text, EmailTxt.Text);
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            clearTxts();
        }
    }
}
