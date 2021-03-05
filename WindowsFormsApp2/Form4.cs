using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        SoundPlayer gamOver = new SoundPlayer(@"C:\Users\User\Downloads\endsound (online-audio-converter.com).wav");
        SoundPlayer clickSound = new SoundPlayer(@"C:\Users\User\Downloads\zapsplat_multimedia_button_click_007_53868 (online-audio-converter.com).wav");
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        
        
        private void Form4_Load(object sender, EventArgs e)
        {
            gamOver.Play();
            label3.Text = "Score = " + Form1.score;
            if (Form1.duration==150)
            {
                label4.Text = "Time was UP ";
            }
            else { 
            label4.Text = "Time = " + Form1.duration + "sec";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clickSound.PlaySync();
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            clickSound.PlaySync();
            Application.Exit();
        }
    }
}
