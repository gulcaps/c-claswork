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
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Name = "namie";
            var a = txt.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = @"Data Source=CODE0;Initial Catalog=simple_sample;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var surnameText = surname.Text;
            // var nameText =Form1.namie;
            var ageText = age.Text;

            var sql = "insert into (name,surname,age) values (''"+surnameText+"','hello world'," + ageText + ")";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            
        }
    }
}
