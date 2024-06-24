using System.Media;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Quickfire_Multiplication
{
    public partial class frm : Form
    {

        Random rand = new Random();

        public Color outlineColour = Color.Maroon,
                     mouseDownColour = Color.LightCoral,
                     backgroundColour = Color.Brown,
                     buttontextColour = Color.Azure;

        private int divans;

        private int colour = 1;

        public bool negatives, divisible, decimals, allowed;

        public bool divisibleumbers;

        public int incorrectAnswers, difficultyrange_M, difficultylowerBound_M,
                   Mn1, Mn2, Sn1, Sn2, Dn1, Dn2, An1, An2,
                   scoreM, scoreMD, scoreMA, scoreMS,
                   timerNumber, int_Answer;

        public string gamemodeDifficulty;

        public bool gameOver, flawless;

        private int gamemode;

        private int numerator, denominator, multiplier; //division

        string soundFilePath = @"C:\path\to\your\sound\file.wav";

        public frm()
        {
            InitializeComponent();
        }

        private void setAllColours(int lightText)
        {
            dashboardPanel.ForeColor = backgroundColour;
            dashboardPanel.BackColor = backgroundColour;



            btn_multiplication.FlatAppearance.BorderColor = outlineColour;
            btn_division.FlatAppearance.BorderColor = outlineColour;
            btn_addition.FlatAppearance.BorderColor = outlineColour;
            btn_subtraction.FlatAppearance.BorderColor = outlineColour;
            btn_settings.FlatAppearance.BorderColor = outlineColour;

            btn_multiplication.FlatAppearance.MouseDownBackColor = mouseDownColour;
            btn_division.FlatAppearance.MouseDownBackColor = mouseDownColour;
            btn_addition.FlatAppearance.MouseDownBackColor = mouseDownColour;
            btn_subtraction.FlatAppearance.MouseDownBackColor = mouseDownColour;
            btn_settings.FlatAppearance.MouseDownBackColor = mouseDownColour;

            if (lightText == 1)
            {
                btn_multiplication.ForeColor = Color.Azure;
                btn_division.ForeColor = Color.Azure;
                btn_addition.ForeColor = Color.Azure;
                btn_subtraction.ForeColor = Color.Azure;
                btn_settings.ForeColor = Color.Azure;
                socials.ForeColor = Color.Azure;
            }
            else
            {
                btn_multiplication.ForeColor = Color.FromArgb(1, 38, 45, 57);
                btn_division.ForeColor = Color.FromArgb(1, 38, 45, 57);
                btn_addition.ForeColor = Color.FromArgb(1, 38, 45, 57);
                btn_subtraction.ForeColor = Color.FromArgb(1, 38, 45, 57);
                btn_settings.ForeColor = Color.FromArgb(1, 38, 45, 57);
                socials.ForeColor = Color.FromArgb(1, 38, 45, 57);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Stop();
            flawlessText.Hide();
            dashboardPanel.BackColor = backgroundColour;
            outlineColour = Color.Maroon;
            mouseDownColour = Color.LightCoral;
            backgroundColour = Color.Brown;
            buttontextColour = Color.Azure;

            panelSettings.Show();
            gameplayPanel.Hide();
            congratsPanel.Hide();

            difficultyrange_M = 15;

            hacks.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string gamemodeDifficulty = comboDifficulty.Text;


            if (comboColour.SelectedItem == "Red")
            {
                backgroundColour = Color.Brown;
                outlineColour = Color.Maroon;
                mouseDownColour = Color.LightCoral;
                buttontextColour = Color.Azure;
                colour = 1;

            }

            if (comboColour.SelectedItem == "Yellow")
            {
                backgroundColour = Color.Yellow;
                outlineColour = Color.DarkGoldenrod;
                mouseDownColour = Color.LightGoldenrodYellow;
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 0;
            }


            if (comboColour.SelectedItem == "Green")
            {
                backgroundColour = Color.Green;
                outlineColour = Color.MediumSpringGreen;
                mouseDownColour = Color.FromArgb(1, 192, 255, 192);
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 1;
            }


            if (comboColour.SelectedItem == "Blue")
            {
                backgroundColour = Color.LightSkyBlue;
                outlineColour = Color.SeaShell;
                mouseDownColour = Color.FromArgb(1, 192, 255, 192);
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 0;
            }


            if (comboColour.SelectedItem == "Purple")
            {
                backgroundColour = Color.MediumSlateBlue;
                outlineColour = Color.FromArgb(192, 192, 255);
                mouseDownColour = Color.FromArgb(1, 192, 255, 192);
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 1;
            }


            if (comboColour.SelectedItem == "Dark")
            {
                backgroundColour = Color.Black;
                outlineColour = Color.Maroon;
                mouseDownColour = Color.FromArgb(1, 192, 255, 192);
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 1;
            }


            if (comboColour.SelectedItem == "Light")
            {
                backgroundColour = Color.WhiteSmoke;
                outlineColour = Color.Maroon;
                mouseDownColour = Color.FromArgb(1, 192, 255, 192);
                buttontextColour = Color.FromArgb(1, 38, 45, 57);
                colour = 0;
            }






            if (comboDifficulty.SelectedItem == "Low")
            {
                gamemodeDifficulty = "Low 1-5";
                difficultyrange_M = 5;
            }

            if (comboDifficulty.SelectedItem == "Medium")
            {
                gamemodeDifficulty = "Low 1-15";
                difficultyrange_M = 15;
            }

            if (comboDifficulty.SelectedItem == "High")
            {
                gamemodeDifficulty = "Low 1-30";
                difficultyrange_M = 30;
            }

            if (comboDifficulty.SelectedItem == "Insane")
            {
                gamemodeDifficulty = "Low 1-100";
                difficultyrange_M = 100;
            }


            if (negativeNumbers.Checked)
            {
                negatives = true;
            } else
            {
                negatives = false;
            }


            setAllColours(colour);
            settingStatus.ForeColor = Color.LimeGreen;
            settingStatus.Text = "Applied Settings!";

        }

        public void resetscore()
        {
            scoreM = 0;
            scoreIndication.Text = scoreM.ToString();
        }

        private void resetscoreMs()
        {
            scoreMD = 0;
            scoreM = 0;
            scoreMA = 0;
            scoreMS = 0;
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            panelSettings.Show();
            gameplayPanel.Hide();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;

            settingStatus.Text = " ";
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
      
            resetscore();
            getMultiplicationNumbers();





            gameOver = false;
            sign.Text = "x";

            timerNumber = 30;
            timer.Start();

            resetscoreMs();

            panelSettings.Hide();
            gameplayPanel.Show();
            congratsPanel.Hide();






            answerM.Text = "";

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        private void answerbuttonM_Click(object sender, EventArgs e)
        {

            flawless = true;

            if (sign.Text == "x")
            {
                try
                {
                    if (numerator * denominator == Convert.ToInt32(answerM.Text))
                    {

                        //ans correct

                        getMultiplicationNumbers();

                        scoreM++;
                        statusM.ForeColor = Color.LimeGreen;
                        statusM.Text = "Correct";
                        scoreIndication.ForeColor = Color.LimeGreen;






                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    else
                    {

                        getMultiplicationNumbers();

                        statusM.ForeColor = Color.LightCoral;
                        statusM.Text = "Incorrect";
                        scoreIndication.ForeColor = Color.PaleVioletRed;
                        scoreM--;

                        flawless = false;

                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    scoreIndication.Text = scoreM.ToString();
                }

                catch { }
                answerM.Text = "";
            }
            else if (sign.Text == "÷")
            {
                try
                {
                    if (numerator / denominator == Convert.ToInt32(answerM.Text))
                    {

                        //ans correct

                        getDivisibleNumbers();

                        scoreM++;
                        statusM.ForeColor = Color.LimeGreen;
                        statusM.Text = "Correct";
                        scoreIndication.ForeColor = Color.LimeGreen;






                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    else
                    {

                        getDivisibleNumbers();

                        statusM.ForeColor = Color.LightCoral;
                        statusM.Text = "Incorrect";
                        scoreIndication.ForeColor = Color.PaleVioletRed;
                        scoreM--;

                        flawless = false;

                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    scoreIndication.Text = scoreM.ToString();
                }

                catch { }
                answerM.Text = "";
            }
            else if (sign.Text == "+")
            {
                try
                {
                    if (numerator + denominator == Convert.ToInt32(answerM.Text))
                    {

                        //ans correct

                        getadditionNumbers();

                        scoreM++;
                        statusM.ForeColor = Color.LimeGreen;
                        statusM.Text = "Correct";
                        scoreIndication.ForeColor = Color.LimeGreen;






                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    else
                    {

                        getadditionNumbers();

                        statusM.ForeColor = Color.LightCoral;
                        statusM.Text = "Incorrect";
                        scoreIndication.ForeColor = Color.PaleVioletRed;
                        scoreM--;

                        flawless = false;

                        multiplicationN1.Text = numerator.ToString();
                        multiplicationN2.Text = denominator.ToString();


                    }

                    scoreIndication.Text = scoreM.ToString();
                }

                catch { }
                answerM.Text = "";
            }
            else if (sign.Text == "-")
            {
                try
                {
                    if (numerator - denominator == Convert.ToInt32(answerM.Text))
                    {

                        //ans correct

                        getsubNumbers();

                        scoreM++;
                        statusM.ForeColor = Color.LimeGreen;
                        statusM.Text = "Correct";
                        scoreIndication.ForeColor = Color.LimeGreen;






                    }

                    else
                    {

                        getsubNumbers();

                        statusM.ForeColor = Color.LightCoral;
                        statusM.Text = "Incorrect";
                        scoreIndication.ForeColor = Color.PaleVioletRed;
                        scoreM--;

                        flawless = false;


                    }

                    scoreIndication.Text = scoreM.ToString();
                }

                catch { }
                answerM.Text = "";
            }





        }

        private void negativenumbers_CheckedChanged(object sender, EventArgs e)
        {
            settingStatus.Text = " ";

            if (negativenumbers.Checked)
            {
                negatives = true;
            }

            else if (!negativenumbers.Checked)
            {
                negatives = false;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void decimalnumbers_CheckedChanged(object sender, EventArgs e)
        {
            settingStatus.Text = "";

            if (decimalnumbers.Checked)
            {
                decimals = true;
            }

            else if (!decimalnumbers.Checked)
            {
                decimals = false;
            }
        }

        private void comboColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingStatus.Text = "";
        }

        private void divisiblenumbers_CheckedChanged(object sender, EventArgs e)
        {
            settingStatus.Text = " ";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerNumber = timerNumber - 1;
            timedisplay.Text = timerNumber.ToString();

            if (timerNumber == 0)
            {
                gameOver = true;
            }

            if (gameOver)
            {
                panelSettings.Hide();
                gameplayPanel.Hide();
                congratsPanel.Show();
                scoreNumber.Text = scoreM.ToString();
                difficultyLabel.Text = gamemodeDifficulty;


                if (scoreM < 5)
                {
                    congratsmessage.Text = "Well then.It looks like you've scored " + scoreM.ToString() + " points\nThat's pretty average.";
                }

                else if (10 < scoreM && scoreM < 15)
                {
                    congratsmessage.Text = "Cool. You scored " + scoreM.ToString() + " points, which is good.";
                }

                else if (15 < scoreM && scoreM < 20)
                {
                    congratsmessage.Text = "Nice. You scored " + scoreM.ToString() + " points, which is pretty sick! Keep it up!";
                }

                else if (20 < scoreM && scoreM < 30)
                {
                    congratsmessage.Text = "Amazing! You scored " + scoreM.ToString() + " points, which is incredibly high! Keep it up!";
                }

                else if (30 < scoreM && scoreM < 40)
                {
                    congratsmessage.Text = "You're insane! You scored " + scoreM.ToString() + " points, which is amongst the best in the world!\nKeep it up!";
                }

                if (flawless)
                {
                    flawlessText.Show();
                }

                else
                {
                    flawlessText.Hide();
                }
            }
        }

        private void congratsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getDivisibleNumbers()
        {



            divans = rand.Next(difficultylowerBound_M + 3, difficultyrange_M);

            denominator = rand.Next(difficultylowerBound_M + 1, divans);

            if (negatives)
            {
                int aaa = rand.Next(1, 3);

                if (aaa == 1)
                {
                    divans *= -1;
                }
                else if (aaa == 2)
                {
                    numerator *= -1;
                }
                else
                {
                    denominator *= -1;
                }
            }

            numerator = divans * denominator;


            multiplicationN1.Text = numerator.ToString();
            multiplicationN2.Text = denominator.ToString();
        }

        private void getMultiplicationNumbers()
        {
            if (negatives)
            {
                numerator = rand.Next(-1 * difficultyrange_M, difficultyrange_M);
                denominator = rand.Next(-1 * difficultyrange_M, difficultyrange_M);
            }

            else
            {
                denominator = rand.Next(difficultylowerBound_M, difficultyrange_M);
                numerator = rand.Next(difficultylowerBound_M, difficultyrange_M);
            }

            divans = denominator * numerator;

            multiplicationN1.Text = numerator.ToString();
            multiplicationN2.Text = denominator.ToString();

            sign.Text = "x";
        }

        private void getadditionNumbers()
        {

            

            if (negatives)
            {
                numerator = rand.Next(-1 * difficultyrange_M, difficultyrange_M);
                denominator = rand.Next(-1 * difficultyrange_M, difficultyrange_M);
            }

            else
            {
                denominator = rand.Next(difficultylowerBound_M, difficultyrange_M);
                numerator = rand.Next(difficultylowerBound_M, difficultyrange_M);
            }

            divans = denominator + numerator;

            sign.Text = "+";




            multiplicationN1.Text = numerator.ToString();
            multiplicationN2.Text = denominator.ToString();
        }

        private void getsubNumbers()
        {

            sign.Text = "-";

            if (negatives)
            {
                numerator = rand.Next(difficultylowerBound_M, difficultyrange_M);
                denominator = rand.Next(difficultylowerBound_M, difficultyrange_M);
            }

            else
            {
                numerator = rand.Next(difficultylowerBound_M, difficultyrange_M);
                denominator = rand.Next(difficultylowerBound_M, numerator);
            }



            divans = numerator - denominator;

            




            multiplicationN1.Text = numerator.ToString();
            multiplicationN2.Text = denominator.ToString();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            resetscore();
            getDivisibleNumbers();





            gameOver = false;
            sign.Text = "÷";
            gamemode = 2;

            timerNumber = 30;
            timer.Start();

            resetscoreMs();

            panelSettings.Hide();
            gameplayPanel.Show();
            congratsPanel.Hide();






            answerM.Text = "";

        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            resetscore();
            getadditionNumbers();

            gameOver = false;

            scoreM = 0;
            scoreIndication.Text = "0";

            gamemode = 3;
            sign.Text = "+";

            timerNumber = 30;
            timer.Start();

            resetscoreMs();

            panelSettings.Hide();
            gameplayPanel.Show();
            congratsPanel.Hide();





            answerM.Text = "";



        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            resetscore();
            getsubNumbers();

            gameOver = false;

            scoreM = 0;
            scoreIndication.Text = "0";

            gamemode = 3;
            sign.Text = "-";

            timerNumber = 30;
            timer.Start();


            panelSettings.Hide();
            gameplayPanel.Show();
            congratsPanel.Hide();

            answerM.Text = "";

        }

        private void gameplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hacks_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void scoreIndication_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
