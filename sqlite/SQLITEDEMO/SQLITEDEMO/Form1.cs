using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLITEDEMO
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=intranet4.db;Version=3;New=False;Compress=True");
        }

        private void ExecuteQuery(string txtquery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtquery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from GreatPeople";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtquery = "insert into GreatPeople (ID,Name,Lastname,Nickname,Gender)values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            ExecuteQuery(txtquery);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string txtquery = "update GreatPeople set Name='" + textBox2.Text + "' where ID='" + textBox1.Text + "'";
                ExecuteQuery(txtquery);
                LoadData();
            }
            if (textBox3.Text != "")
            {
                string txtquery = "update GreatPeople set Lastname='" + textBox3.Text + "' where ID='" + textBox1.Text + "'";
                ExecuteQuery(txtquery);
                LoadData();
            }
            if (textBox4.Text != "")
            {
                string txtquery = "update GreatPeople set Nickname='" + textBox4.Text + "' where ID='" + textBox1.Text + "'";
                ExecuteQuery(txtquery);
                LoadData();
            }
            if (textBox5.Text != "")
            {
                string txtquery = "update GreatPeople set Gender='" + textBox5.Text + "' where ID='" + textBox1.Text + "'";
                ExecuteQuery(txtquery);
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string txtquery = "delete from GreatPeople where ID='" + textBox1.Text + "'";
            ExecuteQuery(txtquery);
            LoadData();
        }
    }
}
