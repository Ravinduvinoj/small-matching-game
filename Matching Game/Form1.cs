using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        //variables
        Random random = new Random(); //select a random value from x and y list and assign a new location to each card
        List<Point> points = new List<Point>(); //List to hold pic points
        PictureBox PendingImage1; //store first flipped card into this variable
        PictureBox PendingImage2; //------second--------------------------------
        int Count_Down_Time = 500;
        int score;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {   
            //winner page
            WinnerPanel.Visible = false;
            
            //time starting 5 seconds
            lblStart.Text = "5";

            //added score 0
            ScoreCounter.Text = "0";
            foreach (PictureBox picture in pbHeader.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in pbHeader.Controls)
            {
               int x = random.Next(points.Count);
                Point p = points[x];
                picture.Location = p;
                points.Remove(p);
            }
            

            startin.Start();
            stpic.Start();
            gmeTimer.Start();
            pb1.Image = Properties.Resources.Card1;
            pbDup1.Image = Properties.Resources.Card1;
            pb2.Image = Properties.Resources.Card2;
            pbDup2.Image = Properties.Resources.Card2;
            pb3.Image = Properties.Resources.Card3;
            pbDup3.Image = Properties.Resources.Card3;
            pb4.Image = Properties.Resources.Card4;
            pbDup4.Image = Properties.Resources.Card4;
            pb5.Image = Properties.Resources.Card5;
            pbDup5.Image = Properties.Resources.Card5;
            pb6.Image = Properties.Resources.Card6;
            pbDup6.Image = Properties.Resources.Card6;
            pb7.Image = Properties.Resources.Card7;
            pbDup7.Image = Properties.Resources.Card7;
            pb8.Image = Properties.Resources.Card8;
            pbDup8.Image = Properties.Resources.Card8;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stpic.Stop();
            foreach (PictureBox picture in pbHeader.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(lblStart.Text);
            timer = timer - 1;
            lblStart.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                startin.Stop();
            }


        }

        private void pb1_Click(object sender, EventArgs e)
        {//first added to the picture box to the image there location
            pb1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)//if this correct 
            {
                PendingImage2 = pb1;//(true)
            } 

            if (PendingImage1 != null && PendingImage2 != null)//if there is anything in this
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb1.Enabled = false;
                    pbDup1.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }//there are 15 equal parts like this
            }
        }

        private void pbDup1_Click(object sender, EventArgs e)
        {//first added to the picture box to the image there location
            pbDup1.Image = Properties.Resources.Card1;

            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)//if this correct
           
            {
                PendingImage2 = pbDup1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb1.Enabled = false;
                    pbDup1.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            pb2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb2.Enabled = false;
                    pbDup2.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup2_Click(object sender, EventArgs e)
        {
            pbDup2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb2.Enabled = false;
                    pbDup2.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            pb3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb3.Enabled = false;
                    pbDup3.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup3_Click(object sender, EventArgs e)
        {
            pbDup3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb3.Enabled = false;
                    pbDup3.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            pb4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb4.Enabled = false;
                    pbDup4.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup4_Click(object sender, EventArgs e)
        {
            pbDup4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb4.Enabled = false;
                    pbDup4.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            pb5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb5.Enabled = false;
                    pbDup5.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup5_Click(object sender, EventArgs e)
        {
            pbDup5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb5.Enabled = false;
                    pbDup5.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            pb6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb6.Enabled = false;
                    pbDup6.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup6_Click(object sender, EventArgs e)
        {
            pbDup6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb6.Enabled = false;
                    pbDup6.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            pb7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb7.Enabled = false;
                    pbDup7.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup7_Click(object sender, EventArgs e)
        {
            pbDup7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb7.Enabled = false;
                    pbDup7.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            pb8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = pb8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pb8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb8.Enabled = false;
                    pbDup8.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void pbDup8_Click(object sender, EventArgs e)
        {
            pbDup8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = pbDup8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = pbDup8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    pb8.Enabled = false;
                    pbDup8.Enabled = false;
                    score = score + 10;
                    ScoreCounter.Text = score.ToString();
                }
                else
                {
                    disblepic.Start();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            disblepic.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void btnRstart_Click(object sender, EventArgs e)
        {
            
            WinnerPanel.Visible = false;
            Count_Down_Time = 500;
            Form1_Load(sender, e);


        }

        private void MainTimer(object sender, EventArgs e)
        {
            Count_Down_Time--;
            lblTimeLeft.Text = Count_Down_Time.ToString();
            if (Count_Down_Time == 0||score==80 ) 
            {
                if (score == 80)
                {
                    gmeTimer.Stop();
                    WinnerPanel.Visible = true;
                    lblWinner.Visible = true;
                    lblLost.Visible = false;
                }
                else
                {
                    gmeTimer.Stop();
                    MessageBox.Show("Game Over!!");
                    WinnerPanel.Visible = true;
                    lblWinner.Visible = false;
                    lblLost.Visible = true;

                    
                }
                
            }
             

        }
    }
}
