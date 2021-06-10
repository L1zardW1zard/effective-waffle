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

        int[] iData = new int[9];
        int iTurn = -1;
        int iType = 1;
        int iLastMove = -1;
        int iXScores = 0;
        int iOScores = 0;
        bool bEnableBot = false;

        public Form1()
        {
            InitializeComponent();
        }

        void RestartGame()
        {
            for (int i = 0; i <= 8; i++)
            {
                iData[i] = 0;
            }

            iLastMove = -1;
            bEnableBot = false;
            iTurn = 1;
            SetNextTurn();
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Easy";
            iType = 0;

            RestartGame();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Medium";
            iType = 1;

            RestartGame();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Impossible";
            iType = 2;

            RestartGame();
        }

        private void playAgainstAFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Play against a friend";
            iType = 3;

            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[0] == 0)
            {
                iLastMove = 0;
                iData[0] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[1] == 0)
            {
                iLastMove = 1;
                iData[1] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[2] == 0)
            {
                iLastMove = 2;
                iData[2] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[3] == 0)
            {
                iLastMove = 3;
                iData[3] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[4] == 0)
            {
                iLastMove = 4;
                iData[4] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[5] == 0)
            {
                iLastMove = 5;
                iData[5] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[6] == 0)
            {
                iLastMove = 6;
                iData[6] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[7] == 0)
            {
                iLastMove = 7;
                iData[7] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (iTurn == 0 || bEnableBot)
                return;

            if (iData[8] == 0)
            {
                iLastMove = 8;
                iData[8] = iTurn;
                ChangeButtonBackgroundImage(iLastMove);
                SetNextTurn();
                RunBot();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (iType == 3 || iLastMove != -1)
                return;

            RunBot();
        }


        void SetNextTurn()
        {
            int iGameStatus = CheckGameStatus();
            if (iGameStatus == 2)
            {
                if (iTurn == -1)
                {
                    iTurn = 1;
                    label1.Text = "                 𐩒 Turn";
                    panel2.Visible = false;
                    panel3.Visible = true;
                }
                else
                {
                    if (iType != 3 && iLastMove == -1)
                    {
                        iTurn = -1;
                        label1.Text = "Start game or select player";
                        panel2.Visible = true;
                        panel3.Visible = false;
                    }
                    else
                    {
                        iTurn = -1;
                        label1.Text = "                 🗙 Turn";
                        panel2.Visible = true;
                        panel3.Visible = false;
                    }
                }
            }
            else
            {
                if (iGameStatus == -1)
                {
                    iXScores++;
                    button11.Text = "🗙                   " + iXScores.ToString();
                }
                else if (iGameStatus == 1)
                {
                    iOScores++;
                    button12.Text = "◯                   " + iOScores.ToString();
                }
                else
                {

                }
                iTurn = 0;
                label1.Text = "              Game Over";
            }
        }

        int CheckGameStatus()
        {
            // -
            if (iData[0] != 0 && iData[0] == iData[1] && iData[1] == iData[2])
            {
                return iData[0];
            }
            else if (iData[3] != 0 && iData[3] == iData[4] && iData[4] == iData[5])
            {
                return iData[3];
            }
            else if (iData[6] != 0 && iData[6] == iData[7] && iData[7] == iData[8])
            {
                return iData[6];
            }
            // |
            else if (iData[0] != 0 && iData[0] == iData[3] && iData[3] == iData[6])
            {
                return iData[0];
            }
            else if (iData[1] != 0 && iData[1] == iData[4] && iData[4] == iData[7])
            {
                return iData[1];
            }
            else if (iData[2] != 0 && iData[2] == iData[5] && iData[5] == iData[8])
            {
                return iData[2];
            }
            // \
            else if (iData[0] != 0 && iData[0] == iData[4] && iData[4] == iData[8])
            {
                return iData[0];
            }
            // /
            else if (iData[2] != 0 && iData[2] == iData[4] && iData[4] == iData[6])
            {
                return iData[2];
            }

            else if (iData[0] != 0 && iData[1] != 0 && iData[2] != 0 && iData[3] != 0 && iData[4] != 0 && iData[5] != 0 && iData[6] != 0 && iData[7] != 0 && iData[8] != 0)
            {
                return 0;
            }

            return 2;
        }

        void RunBot()
        {
            if (iType == 3 || iTurn == 0)
                return;

            bEnableBot = true;
            WaitNSeconds(0.5f);
 
            if (iType == 0)
            {
                RunEasyBot();
            }
            else if (iType == 1)
            {
                RunMediumBot();
            }
            else if (iType == 2)
            {
                RunImpossibleBot();
            }
        }

        void RunEasyBot()
        {
            iLastMove = RandomPosition();
            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }

        void RunMediumBot()
        {
            int iOpponent;
            if (iTurn == -1) iOpponent = 1;
            else iOpponent = -1;

            if (iLastMove == -1)
            {
                iLastMove = RandomPosition();
            }
            else
            {
                CheckWinAndDontLose(iOpponent);
                CheckWinAndDontLose(iTurn);
                if (iData[iLastMove] != 0) iLastMove = RandomPosition();
            }

            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }

        void RunImpossibleBot()
        {
            int iOpponent;
            if (iTurn == -1)    iOpponent = 1;
            else  iOpponent = -1;
             
            if (iLastMove == -1)
            {
                if (iData[4] == 0)
                {
                    iLastMove = 4;
                }
            }
            else if (iData[iLastMove] != 0)
            {
                CheckWinAndDontLose(iOpponent);
                CheckWinAndDontLose(iTurn);
                if (iData[iLastMove] != 0)
                {
                    if (iLastMove == 4)
                    {
                        if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        else iLastMove = RandomPosition();
                    }
                    else if (iLastMove == 0 || iLastMove == 2 || iLastMove == 6 || iLastMove == 8)
                    {
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        else if (iData[0] == 0 && iData[8] == iOpponent)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[6] == iOpponent)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[2] == iOpponent)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[0] == iOpponent)
                        {
                            iLastMove = 8;
                        }
                        else if ((iData[0] == iOpponent && iData[8] == iOpponent) || (iData[2] == iOpponent && iData[6] == iOpponent))
                        {
                            if (iData[1] == 0)
                            {
                                iLastMove = 1;
                            }
                            else if (iData[3] == 0)
                            {
                                iLastMove = 3;
                            }
                            else if (iData[5] == 0)
                            {
                                iLastMove = 5;
                            }
                            else if (iData[7] == 0)
                            {
                                iLastMove = 7;
                            }
                        }
                        else if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        else iLastMove = RandomPosition();
                    }
                    else if (iLastMove == 1 || iLastMove == 3 || iLastMove == 5 || iLastMove == 7)
                    {
                        if (iData[4] == 0)
                        {
                            iLastMove = 4;
                        }
                        else if (iData[0] == 0 && iData[1] == iOpponent && iData[3] == iOpponent)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && iData[1] == iOpponent && iData[5] == iOpponent)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && iData[3] == iOpponent && iData[7] == iOpponent)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && iData[5] == iOpponent && iData[7] == iOpponent)
                        {
                            iLastMove = 8;
                        }
                        else if (iData[0] == 0 && ((iData[1] == iOpponent) || (iData[3] == iOpponent)))
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0 && ((iData[1] == iOpponent) || (iData[5] == iOpponent)))
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0 && ((iData[3] == iOpponent) || (iData[7] == iOpponent)))
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0 && ((iData[5] == iOpponent) || (iData[7] == iOpponent)))
                        {
                            iLastMove = 8;
                        }
                        else if (iData[0] == 0)
                        {
                            iLastMove = 0;
                        }
                        else if (iData[2] == 0)
                        {
                            iLastMove = 2;
                        }
                        else if (iData[6] == 0)
                        {
                            iLastMove = 6;
                        }
                        else if (iData[8] == 0)
                        {
                            iLastMove = 8;
                        }
                        else if (iData[1] == 0)
                        {
                            iLastMove = 1;
                        }
                        else if (iData[3] == 0)
                        {
                            iLastMove = 3;
                        }
                        else if (iData[5] == 0)
                        {
                            iLastMove = 5;
                        }
                        else if (iData[7] == 0)
                        {
                            iLastMove = 7;
                        }
                        else iLastMove = RandomPosition();
                    }
                }

            }

            iData[iLastMove] = iTurn;
            ChangeButtonBackgroundImage(iLastMove);
            bEnableBot = false;
            SetNextTurn();
        }

        void CheckWinAndDontLose(int turn)
        {
            if (iData[0] == 0 && ((iData[1] == turn && iData[2] == turn) || (iData[3] == turn && iData[6] == turn) || (iData[4] == turn && iData[8] == turn)))
                iLastMove = 0;
            else if (iData[1] == 0 && ((iData[0] == turn && iData[2] == turn) || (iData[4] == turn && iData[7] == turn)))
                iLastMove = 1;
            else if (iData[2] == 0 && ((iData[0] == turn && iData[1] == turn) || (iData[5] == turn && iData[8] == turn) || (iData[4] == turn && iData[6] == turn)))
                iLastMove = 2;
            else if (iData[3] == 0 && ((iData[0] == turn && iData[6] == turn) || (iData[4] == turn && iData[5] == turn)))
                iLastMove = 3;
            else if (iData[4] == 0 && ((iData[0] == turn && iData[8] == turn) || (iData[2] == turn && iData[6] == turn) || (iData[1] == turn && iData[7] == turn) || (iData[3] == turn && iData[5] == turn)))
                iLastMove = 4;
            else if (iData[5] == 0 && ((iData[2] == turn && iData[8] == turn) || (iData[3] == turn && iData[4] == turn)))
                iLastMove = 5;
            else if (iData[6] == 0 && ((iData[0] == turn && iData[3] == turn) || (iData[7] == turn && iData[8] == turn) || (iData[2] == turn && iData[4] == turn)))
                iLastMove = 6;
            else if (iData[7] == 0 && ((iData[1] == turn && iData[4] == turn) || (iData[6] == turn && iData[8] == turn)))
                iLastMove = 7;
            else if (iData[8] == 0 && ((iData[2] == turn && iData[5] == turn) || (iData[6] == turn && iData[7] == turn) || (iData[0] == turn && iData[4] == turn)))
                iLastMove = 8;
        }

        int RandomPosition()
        {
            int Count = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                }
            }
            Random rnd = new Random();
            int iRandom = rnd.Next(1, Count);

            Count = 0;
            for (int i = 0; i <= 8; i++)
            {
                if (iData[i] == 0)
                {
                    Count++;
                    if (Count == iRandom)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        void ChangeButtonBackgroundImage(int iPosition)
        {
            if (iData[iPosition] == -1)
            {
                switch(iPosition)
                {
                    case (0): button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (1): button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (2): button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (3): button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (4): button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (5): button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (6): button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (7): button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                    case (8): button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cross)); break;
                }
            }
            else if (iData[iPosition] == 1)
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (1): button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (2): button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (3): button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (4): button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (5): button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (6): button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (7): button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                    case (8): button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Circle)); break;
                }
            }
            else
            {
                switch (iPosition)
                {
                    case (0): button1.BackgroundImage = null; break;
                    case (1): button2.BackgroundImage = null; break;
                    case (2): button3.BackgroundImage = null; break;
                    case (3): button4.BackgroundImage = null; break;
                    case (4): button5.BackgroundImage = null; break;
                    case (5): button6.BackgroundImage = null; break;
                    case (6): button7.BackgroundImage = null; break;
                    case (7): button8.BackgroundImage = null; break;
                    case (8): button9.BackgroundImage = null; break;
                }
            }
        }
        private void WaitNSeconds(float time)
        {
            if (time < 0.2f) return;
            DateTime _desired = DateTime.Now.AddSeconds(time);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
