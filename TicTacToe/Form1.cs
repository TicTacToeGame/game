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
        bool choice = true;
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (choice)
                btn.Text = ("X");
            else
                btn.Text = ("0");

            btn.Enabled = false;
            choice = !choice;
            count++;
            check_win();
        }

        private void check_win() 
        {
            bool win=false;

            if (ButnA1.Text == ButnA2.Text && ButnA2.Text == ButnA3.Text && (!ButnA1.Enabled)){
                win = true;
                ButnA1.BackColor = ButnA2.BackColor = ButnA3.BackColor = Color.LightSkyBlue;
                
            }

            else if (ButnB1.Text == ButnB2.Text && ButnB2.Text == ButnB3.Text && (!ButnB1.Enabled))
            {
                win = true;
                ButnB1.BackColor = ButnB2.BackColor = ButnB3.BackColor = Color.LightSkyBlue;
            }
            else if (ButnC1.Text == ButnC2.Text && ButnC2.Text == ButnC3.Text && (!ButnC1.Enabled))
            {
                win = true;
                ButnC1.BackColor = ButnC2.BackColor = ButnC3.BackColor = Color.LightSkyBlue;
            }

            else if (ButnA1.Text == ButnB1.Text && ButnB1.Text == ButnC1.Text && (!ButnA1.Enabled))
            {
                win = true;
                ButnA1.BackColor = ButnB1.BackColor = ButnC1.BackColor = Color.LightSkyBlue;
            }
            else if (ButnA2.Text == ButnB2.Text && ButnB2.Text == ButnC2.Text && (!ButnA2.Enabled))
            {
                win = true;
                ButnA2.BackColor = ButnB2.BackColor = ButnC2.BackColor = Color.LightSkyBlue;
            }
            else if (ButnA3.Text == ButnB3.Text && ButnB3.Text == ButnC3.Text && (!ButnA3.Enabled))
            {
                win = true;
                ButnA3.BackColor = ButnB3.BackColor = ButnC3.BackColor = Color.LightSkyBlue;
            }

            else if (ButnA1.Text == ButnB2.Text && ButnB2.Text == ButnC3.Text && (!ButnA1.Enabled))
            {
                win = true;
                ButnA1.BackColor = ButnB2.BackColor = ButnC3.BackColor = Color.LightSkyBlue;
            }
            else if (ButnA3.Text == ButnB2.Text && ButnB2.Text == ButnC1.Text && (!ButnC1.Enabled))
            {
                win = true;
                ButnA3.BackColor = ButnB2.BackColor = ButnC1.BackColor = Color.LightSkyBlue;
            }


            if (win)
            {
                String winner;
                if (choice )
                    winner = "0";
                else
                    winner = "X";
                DialogResult result=MessageBox.Show("    "+winner + " won !" + "\n" + "Do you want to play again?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);



                if (result == DialogResult.Yes)
                {
                    choice = true;
                    count = 0;
                    try
                    {
                        foreach (Control i in Controls)
                        {
                            Button newBtn = (Button)i;
                            newBtn.BackColor = Color.LightSteelBlue;
                            newBtn.Text = "";
                            newBtn.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    { }
                }

                else
                    Application.Exit();
            }
            else if (!win && count == 9)
            {
                DialogResult result = MessageBox.Show("         It's tie!" + "\n" + "Do you want to play again?", "Notification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    choice = true;
                    count = 0;
                    try
                    {
                        foreach (Control i in Controls)
                        {
                            Button newBtn = (Button)i;
                            newBtn.BackColor = Color.LightSteelBlue;
                            newBtn.Text = "";
                            newBtn.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    { }
                }

                else
                    Application.Exit();
            }
            
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choice = true;
            count = 0;
            try
            {
                foreach (Control i in Controls)
                {
                    Button newBtn = (Button)i;
                    newBtn.BackColor = Color.LightSteelBlue;
                    newBtn.Text = "";
                    newBtn.Enabled = true;
                }
            }
            catch(Exception ex)
            {}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
