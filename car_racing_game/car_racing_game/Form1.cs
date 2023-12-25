using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_racing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            moveline(gamespeed);
            enemy(gamespeed);
            game_Over();
            coins(gamespeed);
            coins_collection();
        }

        int collectedCoins = 0;

        void enemy(int speed)
        {
            if(enemy1.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(5, 115);
                enemy1.Top = 0;
                enemy1.Left = rand;                 
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(140, 180);
                enemy2.Top = 0;
                enemy2.Left = rand;
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(185, 250);
                enemy3.Top = 0;
                enemy3.Left = rand;
            }
            else
            {
                enemy3.Top += speed;
            }

        }


        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(5, 115);
                coin1.Top = 0;
                coin1.Left = rand;
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(140, 180);
                coin2.Top = 0;
                coin2.Left = rand;
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(185, 250);
                coin3.Top = 0;
                coin3.Left = rand;
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                Random random = new Random();
                int rand = random.Next(185, 250);
                coin4.Top = 0;
                coin4.Left = rand;
            }
            else
            {
                coin4.Top += speed;
            }

        }

        void game_Over()
        {
            Rectangle carBounds = new Rectangle(car.Left, car.Top, car.Width, car.Height);
            
            Rectangle enemy1Bounds = new Rectangle(enemy1.Left, enemy1.Top, enemy1.Width, enemy1.Height);
            if (carBounds.IntersectsWith(enemy1Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            Rectangle enemy2Bounds = new Rectangle(enemy2.Left, enemy2.Top, enemy2.Width, enemy2.Height);
            if (carBounds.IntersectsWith(enemy2Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }

            Rectangle enemy3Bounds = new Rectangle(enemy3.Left, enemy3.Top, enemy3.Width, enemy3.Height);
            if (car.Bounds.IntersectsWith(enemy3Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }
                
        void moveline(int speed)
        {
            if(pictureBox1.Top >= 500){
                pictureBox1.Location = new Point(135, -50);
            }
            else{
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Location = new Point(135, -50);
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Location = new Point(135, -50);
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Location = new Point(135, -50);
            }
            else
            {
                pictureBox4.Top += speed;
            }


            //pictureBox2.Top += speed;
            //pictureBox3.Top += speed;
            //pictureBox4.Top += speed;

        }

        void coins_collection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                coin_count.Text = "Coins = " + collectedCoins.ToString();
                Random random = new Random();
                int x = random.Next(50, 300);
                coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                coin_count.Text = "Coins = " + collectedCoins.ToString();
                Random random = new Random();
                int x = random.Next(50, 300);
                coin2.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                coin_count.Text = "Coins = " + collectedCoins.ToString();
                Random random = new Random();
                int x = random.Next(50, 300);
                coin3.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                coin_count.Text = "Coins = " + collectedCoins.ToString();
                Random random = new Random();
                int x = random.Next(50, 300);
                coin4.Location = new Point(x, 0);

            }
        }

        int gamespeed = 0;
        int c = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                if (car.Left > 0)
                {
                    car.Left -= 8;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 285)
                {
                    car.Left += 8;
                }
            }

            if((e.KeyCode == Keys.Up) && gamespeed < 21)
            {
                gamespeed++;
            }
            else if((e.KeyCode == Keys.Down) && gamespeed > 0)
            {
                gamespeed--;
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void timer1_Tick_1(object sender, EventArgs e)
        //{

        //}
    }
}
