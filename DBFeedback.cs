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
    public partial class DBFeedback : Form
    {
        static string conString = "server=localhost;port=3306;user=root;password=root;database=betaalltours";
        MySqlConnection con = new(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new();
        public DBFeedback()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "NameUser";
            dataGridView1.Columns[2].Name = "NameTour";
            dataGridView1.Columns[3].Name = "Rating";
            dataGridView1.Columns[4].Name = "Message";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
        private void populate(string id, string NameUser, string NameTour, string Rating, string Message)
        {
            dataGridView1.Rows.Add(id, NameUser, NameTour, Rating, Message);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            string sql = "Select * from feedback";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
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
        private void DBFeedback_Load(object sender, EventArgs e)
        {

        }

        private void buttonRetvieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }
        private void Delete(int id)
        {
            string sql = "DELETE FROM feedback Where id=" + id + "";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            Delete(id);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin aform = new Admin();
        

        }
    }
}
