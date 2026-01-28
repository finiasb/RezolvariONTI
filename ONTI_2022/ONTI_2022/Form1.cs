using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTI_2022
{
    public partial class Form1 : Form
    {
        int x;
        string username;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 3;
            textBox1.Text = "a";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            username = comboBox1.SelectedItem.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            x = 1;
            if (username == "Ioana" && textBox1.Text == "eco")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Radu" && textBox1.Text == "123")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Maria" && textBox1.Text == "abc")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Florin" && textBox1.Text == "a")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Mihai" && textBox1.Text == "tg")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else
            {
                

                MessageBox.Show("Parola este gresita");
                textBox1.Text = string.Empty;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            x = 3;
            if (username == "Ioana" && textBox1.Text == "eco")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Radu" && textBox1.Text == "123")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Maria" && textBox1.Text == "abc")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Florin" && textBox1.Text == "a")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Mihai" && textBox1.Text == "tg")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else
            {
                MessageBox.Show("Parola este gresita");
                textBox1.Text = string.Empty;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            x = 2;
            if (username == "Ioana" && textBox1.Text == "eco")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Radu" && textBox1.Text == "123")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Maria" && textBox1.Text == "abc")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Florin" && textBox1.Text == "a")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Mihai" && textBox1.Text == "tg")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else
            {
                MessageBox.Show("Parola este gresita");
                textBox1.Text = string.Empty;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            x = 4;
            if (username == "Ioana" && textBox1.Text == "eco")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Radu" && textBox1.Text == "123")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Maria" && textBox1.Text == "abc")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Florin" && textBox1.Text == "a")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Mihai" && textBox1.Text == "tg")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else
            {
                MessageBox.Show("Parola este gresita");
                textBox1.Text = string.Empty;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            x = 5;
            if (username == "Ioana" && textBox1.Text == "eco")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Radu" && textBox1.Text == "123")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Maria" && textBox1.Text == "abc")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Florin" && textBox1.Text == "a")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else if (username == "Mihai" && textBox1.Text == "tg")
            {
                this.Hide();
                InterferenteECO inteferente = new InterferenteECO(username, x);
                inteferente.Show();
            }
            else
            {
                MessageBox.Show("Parola este gresita");
                textBox1.Text = string.Empty;
            }
        }
    }
}
