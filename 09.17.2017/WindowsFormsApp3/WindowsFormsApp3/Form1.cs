using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_load(object render ,EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "ADD";
            btn.Width = 100;
            btn.Height = 30;
            btn.Top = 150;
            btn.Left = 50;
            this.Controls.Add(btn);
            btn.Click += new System.EventHandler(btn_click);

            TextBox name = new TextBox();
            this.Controls.Add(name);
            name.Top = 40;
            name.Width = 200;
            name.Left = 50;
            TextBox surname = new TextBox();
            this.Controls.Add(surname);
            surname.Top = name.Top + 40;
            surname.Width = 200;
            surname.Left = 50;
            TextBox age = new TextBox();
            this.Controls.Add(age);
            age.Top = surname.Top + 40;
            age.Left = 50;
            age.Width = 200;
        }
        public void btn_click(object obj ,EventArgs eve)
        {
            var mybtn = obj as Button;
          //  MessageBox.Show(mybtn.Height.ToString());
          foreach(var i in Controls)
            {

            }

        }
    }
}
