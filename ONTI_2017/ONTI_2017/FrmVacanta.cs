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

namespace ONTI_2017
{
    public partial class FrmVacanta : Form
    {
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\TurismDB.mdf"";Integrated Security=True;Connect Timeout=30";
        string _email;
        int tip;
        int index = 1;
        public FrmVacanta(string email)
        {
            InitializeComponent();
            timer1.Start();
            _email = email;
            check();
            if(tip == 1)
            {
                fileToolStripMenuItem.Visible = false;
            }
            emailToolStripMenuItem.Text = _email;
            incarcareImagini(index);
        }

        private void check()
        {
            using(SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select TipCont from Utilizatori where Email = @email", con);
                cmd.Parameters.AddWithValue("@email", _email);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tip = Int32.Parse(dr[0].ToString());

                }
            }
        }

        private void incarcareImagini(int index)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select NumeVacanta, Descriere, CaleFisier, Pret, NrLocuri from Vacante where IdVacanta = @id", con);
                cmd.Parameters.AddWithValue("@id", index);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string nume = dr[0].ToString();
                    string descriere = dr[1].ToString();
                    string cale = dr[2].ToString();
                    int pret = Int32.Parse(dr[3].ToString());
                    int nrLocuri = Int32.Parse(dr[4].ToString());

                    label1.Text = nume;
                    label2.Text = pret + " Lei";
                    label3.Text = nrLocuri + " locuri";
                    label4.Text = descriere + "";

                    label1.Parent = pictureBox1;
                    label2.Parent = pictureBox1;
                    label3.Parent = pictureBox1;
                    label4.Parent = pictureBox1;


                    pictureBox1.Image = Image.FromFile(cale);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(index == 7)
            {
                index = 0;
            }
            index++;
            incarcareImagini(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(index == 1)
            {
                index = 8;
            }
            index--;    
            incarcareImagini(index);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                index++;
                if (index == 8)
                    index = 1;

                incarcareImagini(index);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
