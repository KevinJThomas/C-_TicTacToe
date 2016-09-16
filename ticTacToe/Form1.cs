using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        List<int> playerBoxes = new List<int>();
        List<int> cpuBoxes = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Image == null)
            {
                button1.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(1);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private bool winCheck(List<int> li)
        {
            if (li.Contains(1))
            {
                if (li.Contains(2) && li.Contains(3))
                {
                    return true;
                }
                else if (li.Contains(4) && li.Contains(7))
                {
                    return true;
                }
                else if (li.Contains(5) && li.Contains(9))
                {
                    return true;
                }
            }
            if (li.Contains(3))
            {
                if (li.Contains(5) && li.Contains(7))
                {
                    return true;
                }
                else if (li.Contains(6) && li.Contains(9))
                {
                    return true;
                }
            }
            if (li.Contains(5))
            {
                if (li.Contains(2) && li.Contains(8))
                {
                    return true;
                }
                else if (li.Contains(4) && li.Contains(6))
                {
                    return true;
                }
            }
            if (li.Contains(7))
            {
                if (li.Contains(8) && li.Contains(9))
                {
                    return true;
                }
            }

            return false;
        }

        private void cpuTurn() //make sure no infinite loop/recursion
        {
            Random rand = new Random();
            int x = rand.Next(9) + 1;
            while (playerBoxes.Contains(x) || cpuBoxes.Contains(x))
            {
                //MessageBox.Show("You're in while loop");
                x = rand.Next(9) + 1;
            }
            switch (x)
            {
                case 1:
                    //MessageBox.Show("You're in case 1");
                    if (button1.Image == null)
                    {
                        button1.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(1);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {

                    }
                    break;
                case 2:
                    //MessageBox.Show("You're in case 2");
                    if (button2.Image == null)
                    {
                        button2.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(2);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 3:
                    //MessageBox.Show("You're in case 3");
                    if (button3.Image == null)
                    {
                        button3.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(3);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 4:
                    //MessageBox.Show("You're in case 4");
                    if (button4.Image == null)
                    {
                        button4.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(4);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 5:
                    //MessageBox.Show("You're in case 5");
                    if (button5.Image == null)
                    {
                        button5.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(5);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 6:
                    //MessageBox.Show("You're in case 6");
                    if (button6.Image == null)
                    {
                        button6.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(6);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 7:
                    //MessageBox.Show("You're in case 7");
                    if (button7.Image == null)
                    {
                        button7.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(7);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 8:
                    //MessageBox.Show("You're in case 8");
                    if (button8.Image == null)
                    {
                        button8.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(8);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                case 9:
                    //MessageBox.Show("You're in case 9");
                    if (button9.Image == null)
                    {
                        button9.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\o.png");
                        cpuBoxes.Add(9);
                        bool winner = winCheck(cpuBoxes);
                        if (winner)
                        {
                            loseGame();
                        }
                    }
                    else
                    {
                        cpuTurn();
                    }
                    break;
                default:
                    Console.WriteLine("CASE DEFAULT: cpuTurn()");
                    break;
            }
        }

        private void winGame()
        {
            Winner wi = new Winner();
            Form1.ActiveForm.Hide();
            wi.Show();
        }

        private void loseGame()
        {
            Loser lo = new Loser();
            Form1.ActiveForm.Hide();
            lo.Show();
        }

        private void drawGame()
        {
            Draw dr = new Draw();
            Form1.ActiveForm.Hide();
            dr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Image == null)
            {
                button2.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(2);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Image == null)
            {
                button3.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(3);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Image == null)
            {
                button4.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(4);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Image == null)
            {
                button5.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(5);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Image == null)
            {
                button6.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(6);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Image == null)
            {
                button7.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(7);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Image == null)
            {
                button8.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(8);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Image == null)
            {
                button9.Image = Image.FromFile(@"c:\users\kevint\documents\visual studio 2015\Projects\ticTacToe\ticTacToe\Resources\x.png");
                playerBoxes.Add(9);
                bool winner = winCheck(playerBoxes);
                if (winner)
                {
                    winGame();
                }
                else
                {
                    if (playerBoxes.Count() + cpuBoxes.Count() < 9)
                    {
                        cpuTurn();
                    }
                    else
                    {
                        drawGame();
                    }
                }
            }
        }
    }
}
