using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=CODE0;Initial Catalog=simple_sample;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var sql = "select id from users";
            SqlCommand cmd = new SqlCommand(sql, connection);
            var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            textBox1.Text = "";

            for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows.ToString());



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=CODE0;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Context Connection=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var surnameText = surname.Text;
            var nameText =namie.Text;
            var ageText = age.Text;

            var sql = "insert into (name,surname,age) values ('"+nameText+"',"+surnameText+"'," + ageText + ")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            var sqlSelect = "select id from users";
            SqlCommand cmdSelect = new SqlCommand(sql, connection);
            var adapterSelect= new SqlDataAdapter(cmd);
            var dsSelect = new DataSet();
            adapterSelect.Fill(dsSelect);
            textBox1.Text = "";

            for (var i = 0; i < dsSelect.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dsSelect.Tables[0].Rows.ToString());



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=CODE0;Initial Catalog=simple_sample;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var sql = "select * from users";
            SqlCommand cmd = new SqlCommand(sql, connection);
            var adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            textBox1.Text = "";

            for(var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                textBox1.Text += ds.Tables[0].Rows[i]["id"].ToString() + "." + ds.Tables[0].Rows[i]["name"].ToString() + " " + ds.Tables[0].Rows[i]["surname"].ToString() + "." + ds.Tables[0].Rows[i]["age"].ToString() + "r\n";



            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            var sql = "delete from users where id="+Convert.ToInt32(selected)+"";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            
          
           

            var selected = comboBox1.SelectedItem.ToString();
            form2.Selected;
            form2.Show();






        }





    }

}
