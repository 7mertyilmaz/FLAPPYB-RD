using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class FLAPPYBİRD : Form
    {
        int boruhizi = 8;
        int gravity = 10;
        int score = 0;

        public FLAPPYBİRD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            boruAlt.Left -= boruhizi;
            boruUst.Left -= boruhizi;
            scoreText.Text = "Score :" + score;


            if (boruAlt.Left<-90)
            {
                boruAlt.Left = 350;
                score++;
            }
            if (boruUst.Left<-110)
            {
                boruUst.Left = 300;
                
            }
            if (flappybird.Bounds.IntersectsWith(boruAlt.Bounds) || flappybird.Bounds.IntersectsWith(boruUst.Bounds) || flappybird.Bounds.IntersectsWith(zemin.Bounds))

            {
                endGame();
            }
            if (score>5)
            {
                boruhizi = 15;
            }
            if (flappybird.Top<-25)
            {

                endGame();
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over !!! ";
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -10;

            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;

            }
           
        } 
    } 
}
