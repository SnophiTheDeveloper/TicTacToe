using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Connect classor = new Connect();
     
        private void button1_Click(object sender, EventArgs e)
        {   if (classor.whosnext(1))
            { this.button1.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            { this.button1.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button1.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(2))
            { this.button2.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            { this.button2.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(3))
            { this.button3.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            { this.button3.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(4))
            { this.button4.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            { this.button4.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(5))
            {
                this.button5.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            {
                this.button5.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(6))
            {
                this.button6.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            {
                this.button6.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(7))
            {
                this.button7.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            {
                this.button7.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(8))
            {
                this.button8.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            {
                this.button8.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (classor.whosnext(9))
            {
                this.button9.BackgroundImage = Properties.Resources.x1;
                label1.Text = "Player2's Turn";
            }
            else
            {
                this.button9.BackgroundImage = Properties.Resources.o1;
                label1.Text = "Player1's Turn";
            }
            button9.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
    
            this.BackgroundImage = Properties.Resources.Bg; //bg upload
            this.AutoSize = true;
            label5.Text = score2.ToString(); //shares scores to labels
            label4.Text = score.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        
        public int score = 0; //player1score
        public int score2 = 0; //player2score


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (classor.End() || ((classor.End())!=true && classor.count==9))  //Checks is end equal true or is that tie
            {
                if (label1.Text == "Player1's Turn") 
                {
                    score2++;
                    label5.Text = score2.ToString();
                    MessageBox.Show("Player2 Won");
                }
                else
                {   if (classor.count==9 && (classor.End()) != true  )
                    {
                        MessageBox.Show("Tie");
                    }
                    else
                    {
                        score++;
                        label4.Text = score.ToString();
                        MessageBox.Show("Player1 Won");  }
                }


                button1.BackgroundImage = null; //cleaning
                button2.BackgroundImage = null;
                button3.BackgroundImage = null;
                button4.BackgroundImage = null;
                button5.BackgroundImage = null;
                button6.BackgroundImage = null;
                button7.BackgroundImage = null;
                button8.BackgroundImage = null;
                button9.BackgroundImage = null;
                label1.Text = "";

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;



                classor.gameReset();
            }


        }
    }
}
