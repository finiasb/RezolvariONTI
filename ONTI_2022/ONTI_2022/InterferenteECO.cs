using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTI_2022
{
    public partial class InterferenteECO : Form
    {
        string _username;
        int _poza;
        private string path = System.AppDomain.CurrentDomain.BaseDirectory;
        private int x = 0, y = 0;
        public InterferenteECO(string user, int poza)
        {
            InitializeComponent();
            _username = user;
            _poza = poza;
            pictureBox1.Image = Image.FromFile(path + $@"Background\Back{_poza}.jpg");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.White, 2);
                for(int x = 0; x <= 800; x += 40)
                {
                    Point p1 = new Point(x, 0);
                    Point p2 = new Point(x, 500);
                    g.DrawLine(pen, p1, p2);
                }
                for (int y = 0; y <= 500; y += 50)
                {
                    Point p1 = new Point(0, y);
                    Point p2 = new Point(800, y);
                    g.DrawLine(pen, p1, p2);
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(path + $@"Background\Back{_poza}.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            pictureBox1.Image = Image.FromFile(path + $@"Background\Back{_poza}.jpg");
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (checkBox1.Checked)
                    {
                        Graphics g = pictureBox1.CreateGraphics();
                        Pen pen = new Pen(Color.White, 2);
                        for (int x = 0; x <= 800; x += 40)
                        {
                            Point p1 = new Point(x, 0);
                            Point p2 = new Point(x, 500);
                            g.DrawLine(pen, p1, p2);
                        }
                        for (int y = 0; y <= 500; y += 50)
                        {
                            Point p1 = new Point(0, y);
                            Point p2 = new Point(800, y);
                            g.DrawLine(pen, p1, p2);
                        }
                    }
                    string path2 = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();
                    StreamReader sr = new StreamReader(fileStream);
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] c = line.Split(' ');
                        if (c[0] == "Robot")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "Robot\\Robot.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                            
                        }
                        else if (c[0] == "Meduza1")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "Meduze\\Meduza1.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Meduza2")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "Meduze\\Meduza2.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Meduza3")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "Meduze\\Meduza3.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Meduza4")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "Meduze\\Meduza4.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Hartie")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "MaterialeReciclabile\\Hartie.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Plastic")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "MaterialeReciclabile\\Plastic.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                        else if (c[0] == "Sticla")
                        {
                            int x = int.Parse(c[1]) * 40 - 40;
                            int y = int.Parse(c[2]) * 50 - 50;
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Location = new Point(x, y);
                            pictureBox.Size = new Size(38, 48);
                            pictureBox.BackColor = Color.Transparent;
                            pictureBox.Image = Image.FromFile(path + "MaterialeReciclabile\\Sticla.png");
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Controls.Add(pictureBox);
                        }
                    }
                }
            }
        }


        private void DreaptaJos(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Image bg = Image.FromFile(path + "Wood\\Wood1.jpg"))
                {
                    g.DrawImage(bg, 0, 0, pictureBox2.Width, pictureBox2.Height);
                }

                Pen pen = new Pen(Color.White, 3);
                Brush brush = new SolidBrush(Color.White);

                Point[] points =
                {
                    new Point(49, 175),
                    new Point(49 + 38, 175),
                    new Point(49, 175 + 48)
                };

                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.Image = bmp;
        }
        
        private void StangaSus(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Image bg = Image.FromFile(path + "Wood\\Wood1.jpg"))
                {
                    g.DrawImage(bg, 0, 0, pictureBox2.Width, pictureBox2.Height);
                }

                Pen pen = new Pen(Color.White, 3);
                Brush brush = new SolidBrush(Color.White);

                Point[] points =
                {
                    new Point(49 + 38, 175),
                    new Point(49 + 38, 175 + 48),
                    new Point(49, 175 + 48)
                };

                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.Image = bmp;
        }

        private void StangaJos(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Image bg = Image.FromFile(path + "Wood\\Wood1.jpg"))
                {
                    g.DrawImage(bg, 0, 0, pictureBox2.Width, pictureBox2.Height);
                }

                Pen pen = new Pen(Color.White, 3);
                Brush brush = new SolidBrush(Color.White);

                Point[] points =
                {
                    new Point(49, 175),
                    new Point(49 + 38, 175),
                    new Point(49 + 38, 175 + 48)
                };

                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.Image = bmp;
        }
        private void DreaptaSus(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Image bg = Image.FromFile(path + "Wood\\Wood1.jpg"))
                {
                    g.DrawImage(bg, 0, 0, pictureBox2.Width, pictureBox2.Height);
                }

                Pen pen = new Pen(Color.White, 3);
                Brush brush = new SolidBrush(Color.White);

                Point[] points =
                {
                    new Point(49, 175),
                    new Point(49 + 38, 175 + 48),
                    new Point(49, 175 + 48)
                };

                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.Image = bmp;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private int ok = 2;
        private void button2_Click(object sender, EventArgs e)
        {
            //DreaptaJos - 1;
            //StanagaJos - 2;
            //StangaSus - 3
            //DreaptaSus - 4;
            if (ok == 1)
            {
                DreaptaJos(sender, e);
                ok++;
            }
            else if(ok == 2)
            {
                StangaJos(sender, e);
                ok++;
            }
            else if(ok == 3)
            {
                StangaSus(sender, e);
                ok++;
            }
            else if(ok == 4)
            {
                DreaptaSus(sender, e);
                ok = 1;
            }
        }
        bool selectat = false;
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show($"{e.X}, {e.Y}");
            if(e.X >= 49 && e.X <= 89 && e.Y >= 174 && e.Y <= 225)
            {
                selectat = true;
            }
        }

        private void InterferenteECO_Load(object sender, EventArgs e)
        {
            DreaptaJos(sender, e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!selectat || ok != 2)
                return;

            int col = e.X / 40 + 1;
            int row = e.Y / 50 + 1;

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Image bg = Image.FromFile(path + $@"Background\Back{_poza}.jpg"))
                {
                    g.DrawImage(bg, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }

                Pen pen = new Pen(Color.White, 2);
                Brush brush = new SolidBrush(Color.White);
                if(checkBox1.Checked)
                {
                    for (int x = 0; x <= 800; x += 40)
                    {
                        Point p1 = new Point(x, 0);
                        Point p2 = new Point(x, 500);
                        g.DrawLine(pen, p1, p2);
                    }
                    for (int y = 0; y <= 500; y += 50)
                    {
                        Point p1 = new Point(0, y);
                        Point p2 = new Point(800, y);
                        g.DrawLine(pen, p1, p2);
                    }
                }
                
                Point[] points =
                {
                    new Point((col - 1) * 40, (row - 1) * 50),
                    new Point((col - 1) * 40 + 38, (row - 1) * 50),
                    new Point((col - 1) * 40, (row - 1) * 50 + 48)
                };

                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            pictureBox1.Image = bmp;
        }

    }
}
