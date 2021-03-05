using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using System.Diagnostics.SymbolStore;
using System.Diagnostics;

using System.Media;


namespace WindowsFormsApp2
{
  
    public partial class Form1 : Form
    {
        int speed;
        public static int  score;
        int timeRem ;
        public static int duration;
        bool GameOver;
        int wrong;
        Random r = new Random();
        int i,j,k;
        SoundPlayer pop = new SoundPlayer(@"C:\Users\User\Downloads\Blop-Mark_DiAngelo-79054334 (online-audio-converter.com).wav");
       
        SoundPlayer wrongSound = new SoundPlayer(@"C:\Users\User\Downloads\incorrect2.wav");
        

        PictureBox[] balloons = new PictureBox[19];
       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            balloons[1] = balloon1;
            balloons[2] = balloon2;
            balloons[3] = balloon3;
            balloons[4] = balloon4;
            balloons[5] = balloon5;
            balloons[6] = balloon6;
            balloons[7] = balloon7;
            balloons[8] = balloon8;
            balloons[9] = balloon9;
            balloons[10] = balloon10;
            balloons[11] = balloon11;
            balloons[12] = balloon12;
            balloons[13] = balloon13;
            balloons[14] = balloon14;
            balloons[15] = balloon15;
            balloons[16] = balloon16;
            balloons[17] = balloon17;
            balloons[18] = balloon18;
          


        }

      

        public Form1()
        {
            InitializeComponent();
            RestartGame();

        }   
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Score:" + score;
            label4.Text = i + " + " + j + "=" + "?";
            label3.Text = "Wrong = " + wrong;
            TimeRemaining.Text = timeRem + "sec";
            CountDown.Start();
            foreach (Control X in this.Controls)
            {
                if(X is PictureBox )
                {
                    X.Top -= speed;
                    if(X.Top + X.Height<100)
                    {
                        X.Top = r.Next(700, 1200);
                        X.Left = r.Next(200,700);
                    }
                }   
            }
           
            if (wrong==5 || timeRem==0)
             {
                GameOver = true;
                gameTimer.Stop();
                this.Close();
                Form4 f = new Form4();
                f.Show();
             }
            if (score>=10)
            {
                label4.Text = i + "-" + j + "=" + "?";
            }
            if(timeRem>=90 && timeRem<=150 && score==5)
            {
                score += 3;
                
            }
            if (timeRem >= 60 && timeRem <= 90 && score == 10)
            {
                score += 3;

            }

            if (score>=8)
            {
                speed = 6;
            }
            if (score >= 12)
            {
                speed = 7;
            }
            if (score >= 16)
            {
                speed = 8;
            }
            
        }

      
        private void RestartGame()
        {
            Equation();
            speed = 5;
            score = 0;
            timeRem = 150;
            GameOver = false;
            foreach(Control X in this.Controls)
            {
                if(X is PictureBox )
                {
                    X.Top = r.Next(500, 1500);
                    X.Left = r.Next(5, 600);
                }
            }

            gameTimer.Start();
        }

        private void bomb_Click(object sender, EventArgs e)
        {
            if (GameOver==false)
            { 
                gameTimer.Stop();
                GameOver = true;
                this.Close();
                Form4 f = new Form4();
                f.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void Countdown(object sender, EventArgs e)
        {
            if (timeRem > 0 && GameOver==false)
            {

                timeRem -=1; ;
                TimeRemaining.Text = timeRem + " sec";
                duration = 150 - timeRem;
            }
            else
            {
                
                CountDown.Stop();
                gameTimer.Stop();
                GameOver = true;
            
            }
        }

        private void Equation()
        {
            i = r.Next(1, 9);
            j = r.Next(1, 9);
            k = i + j;
            if (score>=10)
            {
                i = r.Next(10, 20);
                j = r.Next(1, 9);
                k = i - j;   
            }         
        }

        private void PopBalloon(object sender, EventArgs e)
        {

            if (GameOver == false)
            {

                var baloon = (PictureBox)sender;
                baloon.Top = r.Next(700, 1000);
                baloon.Left = r.Next(5, 500);
                for (int h = 1; h <= 18; h++)
                {
                    if (baloon == balloons[h] && k == h)
                    {
                        score++;
                        pop.Play();                   
                        Equation();
                    }
                    else if (baloon == balloons[h] && k != h)
                    {
                        wrong++;
                        wrongSound.Play();
                    }
                }
            }
        }  
    }
}
