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
    public partial class DBTours : Form
    {
        static string conString = "server=localhost;port=3306;user=root;password=root;database=betaalltours";
        MySqlConnection con = new(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new();
        public DBTours()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "TypeOfTour";
            dataGridView1.Columns[2].Name = "TourName";
            dataGridView1.Columns[3].Name = "TourStart";
            dataGridView1.Columns[4].Name = "NumDayNight";
            dataGridView1.Columns[5].Name = "NumofOld";
            dataGridView1.Columns[6].Name = "NumofChild";
            dataGridView1.Columns[7].Name = "Schengen";



            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
  
        
        private void populate(string id,string TypeOfTour, string TourName, string TourStart, string NumDayNight, string NumofOld, string NumofChild,string Schengen)
        {
            dataGridView1.Rows.Add(id,TypeOfTour, TourName, TourStart, NumDayNight, NumofOld, NumofChild, Schengen);
        }
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            string sql = "Select * from tours";
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
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
        private void Delete(int id)
        {
            string sql = "DELETE FROM tours Where id =" + id + "";
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

        private void buttonRetrieve_Click(object sender, EventArgs e)
        {
            retrieve();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           int id = Convert.ToInt32(selected);
            Delete(id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeTourTxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TournameTxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DateTourTxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DayNightTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            OldTxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ChildTxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void TournameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin aform = new Admin();
            
        }
    }
}
