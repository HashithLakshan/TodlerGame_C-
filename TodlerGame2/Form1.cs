using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodlerGame2
{
    public partial class Form1 : Form
    {
        PictureBox[] pics = new PictureBox[13];

        
        public Form1()
        {
            InitializeComponent();
        }

        private void pbjean_Click(object sender, EventArgs e)
        {
            if (pbjean.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbjean.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbjean.Location = new Point(192, 12);
            }
            else if (pbjean.Bounds.IntersectsWith(pbfridge.Bounds))
            {
               pbjean.Location = new Point(192, 12);
               // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbblouse_Click(object sender, EventArgs e)
        {
            if (pbblouse.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbblouse.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbblouse.Location = new Point(192, 12);

            }
            else if (pbblouse.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbblouse.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbcorsagedress_Click(object sender, EventArgs e)
        {
            if (pbcorsagedress.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbcorsagedress.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbcorsagedress.Location = new Point(192, 12);

            }
            else if (pbcorsagedress.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbcorsagedress.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pics[0] = pbjean;
            pics[1] = pbblouse;
            pics[2] = pbcorsagedress;
            pics[3] = pbgown;
            pics[4] = pbjumper;
            pics[5] = pbshirt;
            pics[6] = pbshort;
            pics[7] = pbbeatroot;
            pics[8] = pbbroccoli;
            pics[9] = pbcarrot;
            pics[10] = pbcauliflower;
            pics[11] = pbpumkin;
            pics[12] = pbtomato;

            Random random = new Random();
            int start2 = random.Next(0, pics.Length);
            pics[start2].Visible = true;
        }

        private void pbgown_Click(object sender, EventArgs e)
        {
            if (pbgown.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbgown.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbgown.Location = new Point(192, 12);

            }
            else if (pbgown.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbgown.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbjumper_Click(object sender, EventArgs e)
        {
            if (pbjumper.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbjumper.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbjumper.Location = new Point(192, 12);

            }
            else if (pbjumper.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbjumper.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbshirt_Click(object sender, EventArgs e)
        {
            if (pbshirt.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbshirt.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbshirt.Location = new Point(192, 12);

            }
            else if (pbshirt.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbshirt.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbshort_Click(object sender, EventArgs e)
        {
            if (pbshort.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbshort.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbshort.Location = new Point(192, 12);

            }
            else if (pbshort.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbshort.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }

        }

        private void pbbeatroot_Click(object sender, EventArgs e)
        {
            if (pbbeatroot.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbbeatroot.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbbeatroot.Location = new Point(192, 12);

            }
            else if (pbbeatroot.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbbeatroot.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbbroccoli_Click(object sender, EventArgs e)
        {
            if (pbbroccoli.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbbroccoli.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbbroccoli.Location = new Point(192, 12);
            }
            else if (pbbroccoli.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbbroccoli.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbcarrot_Click(object sender, EventArgs e)
        {
            if (pbcarrot.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbcarrot.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbcarrot.Location = new Point(192, 12);

            }
            else if (pbcarrot.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbcarrot.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbcauliflower_Click(object sender, EventArgs e)
        {
            if (pbcauliflower.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbcauliflower.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbcauliflower.Location = new Point(192, 12);

            }
            else if (pbcauliflower.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbcauliflower.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbpumkin_Click(object sender, EventArgs e)
        {
            if (pbpumkin.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbpumkin.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbpumkin.Location = new Point(187, 12);

            }
            else if (pbpumkin.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbpumkin.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }
        }

        private void pbtomato_Click(object sender, EventArgs e)
        {
            if (pbtomato.Bounds.IntersectsWith(pbfridge.Bounds))
            {
                pbtomato.Visible = false;

                //MarksTimer.Enabled = true;
                int marks = Int32.Parse(txtmarks.Text);
                txtmarks.Text = (marks + 10).ToString();
                Random random = new Random();
                int start2 = random.Next(0, pics.Length);
                pics[start2].Visible = true;
                pbtomato.Location = new Point(192, 12);


            }
            else if (pbtomato.Bounds.IntersectsWith(pbcloset.Bounds))
            {
                pbtomato.Location = new Point(192, 12);
                // ErrorTimer.Enabled = true;
                //lblError.Visible = true;
            }


        }

        private void txtmarks_TextChanged(object sender, EventArgs e)
        {
            int marks = Int32.Parse(txtmarks.Text);

            if (marks == 150)
            {
                DialogResult result = MessageBox.Show("You Made IT", "Victory", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }

            }
        }
    }
}

