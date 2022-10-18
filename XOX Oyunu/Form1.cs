using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace XOX_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x=1;
        int s;
        int z;
        int y;
        int o;
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (x%2==1)
            {
                pic.Image = Resource1.X;
                pic.Tag = "X";
            }
            else
            {
                pic.Image = Resource1.O;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Tag = "O";
            }
            x++;
            
            
            if ((pictureBox1.Tag=="X" && pictureBox2.Tag=="X" && pictureBox3.Tag=="X") || (pictureBox1.Tag == "O" && pictureBox2.Tag == "O" && pictureBox3.Tag == "O")  )
            {


                    if (pictureBox1.Tag == "X" && pictureBox2.Tag == "X" && pictureBox3.Tag == "X")
                    {
                        MessageBox.Show("X Kazandı");
                        y++;
                        label5.Text = y.ToString();
                    }
                    else
                    {
                        o++;
                        MessageBox.Show("O Kazandı");
                        label8.Text = o.ToString();
                    }

                    foreach (PictureBox p in panel1.Controls)
                    {


                        if (p.Tag == "X" || p.Tag == "O")
                        {





                            p.Image = null;
                            x = 1;
                            p.Tag = "none";
                            s = 0;




                        }





                    }
                
               
            }
            if ((pictureBox4.Tag == "X" && pictureBox5.Tag == "X" && pictureBox6.Tag == "X") || (pictureBox4.Tag == "O" && pictureBox5.Tag == "O" && pictureBox6.Tag == "O"))
            {
                if (pictureBox4.Tag == "X" && pictureBox5.Tag == "X" && pictureBox6.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                 {
                      if (p.Tag == "X" || p.Tag == "O")
                      {
                            p.Image = null;
                            x = 1;
                            p.Tag = "none";

                      }
                 }
            }
            if((pictureBox7.Tag == "X" && pictureBox8.Tag == "X" && pictureBox9.Tag == "X") || (pictureBox7.Tag == "O" && pictureBox8.Tag == "O" && pictureBox9 .Tag == "O"))
            {
                if (pictureBox7.Tag == "X" && pictureBox8.Tag == "X" && pictureBox9.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                    
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                      }
                }
            }
            if ((pictureBox1.Tag == "X" && pictureBox4.Tag == "X" && pictureBox7.Tag == "X") || (pictureBox1.Tag == "O" && pictureBox4.Tag == "O" && pictureBox7.Tag == "O"))
            {
                if (pictureBox1.Tag == "X" && pictureBox4.Tag == "X" && pictureBox7.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                    }
                }
            }
            if ((pictureBox2.Tag == "X" && pictureBox5.Tag == "X" && pictureBox8.Tag == "X") || (pictureBox2.Tag == "O" && pictureBox5.Tag == "O" && pictureBox8.Tag == "O"))
            {

                if (pictureBox2.Tag == "X" && pictureBox5.Tag == "X" && pictureBox8.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                    }
                }
            }
            if ((pictureBox3.Tag == "X" && pictureBox6.Tag == "X" && pictureBox9.Tag == "X") || (pictureBox3.Tag == "O" && pictureBox6.Tag == "O" && pictureBox9.Tag == "O"))
            {
                if (pictureBox3.Tag == "X" && pictureBox6.Tag == "X" && pictureBox9.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                    }
                }
            }
            if ((pictureBox1.Tag == "X" && pictureBox5.Tag == "X" && pictureBox9.Tag == "X") || (pictureBox1.Tag == "O" && pictureBox5.Tag == "O" && pictureBox9.Tag == "O"))
            {
                if (pictureBox1.Tag == "X" && pictureBox5.Tag == "X" && pictureBox9.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                    }
                }
            }
            if ((pictureBox3.Tag == "X" && pictureBox5.Tag == "X" && pictureBox7.Tag == "X") || (pictureBox1.Tag == "O" && pictureBox5.Tag == "O" && pictureBox7.Tag == "O"))
            {
                if (pictureBox3.Tag == "X" && pictureBox5.Tag == "X" && pictureBox7.Tag == "X")
                {
                    y++;
                    MessageBox.Show("X Kazandı");
                    label5.Text = y.ToString();
                }
                else
                {
                    MessageBox.Show("O Kazandı");
                    o++;
                    label8.Text = o.ToString();
                }
                foreach (PictureBox p in panel1.Controls)
                {
                    if (p.Tag == "X" || p.Tag == "O")
                    {
                        p.Image = null;
                        x = 1;
                        p.Tag = "none";

                    }
                }
            }
            else
            {
                
                foreach (PictureBox p in panel1.Controls)
                {

                    if (p.Tag == "none")
                    {
                        z++;
                    }
                }
                
                if (z==0)
                {
                    MessageBox.Show("Beraberlik");
                    foreach (PictureBox p in panel1.Controls)
                    {
                        if (p.Tag == "X" || p.Tag == "O")
                        {
                            p.Image = null;
                            x = 1;
                            p.Tag = "none";
                            

                        }
                    }
                }
            }
            z = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
