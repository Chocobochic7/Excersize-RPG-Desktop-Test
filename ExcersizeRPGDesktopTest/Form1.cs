using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcersizeRPGDesktopTest
{
    public partial class Form1 : Form
    {
        object[] low;

        object[] medium;

        object[] high;

        ArrayList finalArr;

        int totalSeconds;

        int excersizeNum;

        string minutes;

        string seconds;

        public Form1()
        {
            InitializeComponent();

            finalArr = new ArrayList();
            excersizeNum = 0;
            totalSeconds = 0;
            minutes = "00";
            seconds = "00";
            startPauseBtn.Enabled = false;
            timer1.Interval = 1000;

            instructionsLbl.Text = "Please choose a class and then press start";
            timerLbl.Text = minutes + ":" + seconds;
            startPauseBtn.Text = "Start";
            brawlerBtn.Text = "Brawler";
            knightBtn.Text = "Knight";
            thiefBtn.Text = "Thief";
            mageBtn.Text = "Mage";

            instructionsLbl.Left = (this.Width / 2) - (instructionsLbl.Width / 2);
            timerLbl.Left = (this.Width / 2) - (timerLbl.Width / 2);
            startPauseBtn.Left = (this.Width / 2) - (startPauseBtn.Width / 2);
            brawlerBtn.Left = ((this.Width / 4) / 2) - (brawlerBtn.Width / 2);
            knightBtn.Left = (this.Width / 4) + (((this.Width / 4) / 2) - (knightBtn.Width / 2));
            thiefBtn.Left = (this.Width / 2) + (((this.Width / 4) / 2) - (thiefBtn.Width / 2));
            mageBtn.Left = ((this.Width / 2) + this.Width / 4) + (((this.Width / 4) / 2) - (mageBtn.Width / 2));

        }

        private void BrawlerBtn_Click(object sender, EventArgs e)
        {
            low = new object[10]
                { "1", "2", "3", "4", "5", "6", "1 + 2 + 1 + 2", "3 + 4 + 3 + 4", "5 + 6 + 5 + 6", "1 + 2 + 3 + 4 + 5 + 6" };
            medium = new object[10]
                {"1 + 1 + 2", "2 + 3 + 2", "1 + 2 + 3 + 4", "3 + 4 + 5 + 6", "1 + 1 + 6", "1 + 1 + 4", "1 + 1 + 2 + 3 + 2", "3 + 4 + 5 + 6 + 1", "1 + 3 + 5", "2 + 4 + 6" };
            high = new object[5]
                {"3 + Duck + 4 + Duck", "1 + Slip + 2 + Slip", "1 + 2 + Slip + Slip", "1 + Duck + 2 + Duck", "1 + 2 + 3 + Slip + 3  +2 + 1 + Slip" };
            startPauseBtn.Enabled = true;
            brawlerBtn.Enabled = false;
            knightBtn.Enabled = true;
            thiefBtn.Enabled = true;
            mageBtn.Enabled = true;
        }

        private void KnightBtn_Click(object sender, EventArgs e)
        {
            low = new object[10]
                {"1", "2", "3", "4","Center stab", "Side Stab", "Bash", "Deflect", "Swing", "1 + Bash" };
            medium = new object[10]
                {"1 + 2", "3 + 4", "1 + 4", "2 + 3", "1 + center stab", "2 + Side Stab", "Bash + 1", "Bash + Deflect", "Deflect + 1", "Deflect + Side Stab" };
            high = new object[5]
                {"1 + 2 + Bash + Side Stab", "Deflect + 1 + 4 + Side Stab + Bash", "Swing +1 + 4 + Bash +  Center Stab", "1 + 2 + 3 + 4 + Side Stab + Bash", "4 + Swing + Side Stab" };

            startPauseBtn.Enabled = true;
            brawlerBtn.Enabled = true;
            knightBtn.Enabled = false;
            thiefBtn.Enabled = true;
            mageBtn.Enabled = true;
        }

        private void ThiefBtn_Click(object sender, EventArgs e)
        {
            low = new object[10]
                { "1", "2", "3", "4", "Top Stab", "Side Stab", "1 + 2", "2 + 4", "1 + 2 + 3 + 4", "1 + 2 + 3 + 4 + Top Stab + Side Stab" };
            medium = new object[10]
                { "1 + 4", "2 + 3", "1 + Side Stab", "1 + Top Stab" , "Top Stab + 4", "2 + Top Stab", "Side Stab + 2", "Side Stab + 4", "4 + 1", "3 + 2"};
            high = new object[5]
                {"1 + Duck + Side Stab", "1 + duck + Top Stab", "Top Stab + Side Stab", "Top Stab + Duck + Top Stab", "1 + Top Stab + Duck + Side Stab" };
            startPauseBtn.Enabled = true;
            brawlerBtn.Enabled = true;
            knightBtn.Enabled = true;
            thiefBtn.Enabled = false;
            mageBtn.Enabled = true;
        }

        private void MageBtn_Click(object sender, EventArgs e)
        {
            low = new object[10]
                { "Jump Rope", "Jumpm Front and Back", "Jump Side to Side", "Elbow to Knee", "Run in Place", "Run in Place High Knees", "Jumping Jacks", "Cross Jacks", "Jump Squat", "Jump in a Square"};
            medium = new object[10]
                {"Mountain Climbers", "Plank Jack", "Plank to Knee Tap", "Skaters", "Jumping Lunge", "Plank + Right Arm Up + Plank + Left Arm Up", "Football Shuffle", "Squat Jack", "Skip in Place" , "Medium10" };
            high = new object[5]
                { "High", "High2", "High3", "High4", "High5" };
            startPauseBtn.Enabled = true;
            brawlerBtn.Enabled = true;
            knightBtn.Enabled = true;
            thiefBtn.Enabled = true;
            mageBtn.Enabled = false;
        }

        private void StartPauseBtn_Click(object sender, EventArgs e)
        {
            if (totalSeconds == 0)
            {
                randomizer();
                instructionsLbl.Text = Convert.ToString(finalArr[excersizeNum]);
                excersizeNum++;
                instructionsLbl.Left = (this.Width / 2) - (instructionsLbl.Width / 2);
                brawlerBtn.Enabled = false;
                knightBtn.Enabled = false;
                thiefBtn.Enabled = false;
                mageBtn.Enabled = false;

            }
            if (startPauseBtn.Text == "Start")
            {
                timer1.Start();
                startPauseBtn.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                startPauseBtn.Text = "Start";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            totalSeconds++;
            minutes = Convert.ToString(totalSeconds / 60).PadLeft(2, '0');
            seconds = Convert.ToString(totalSeconds % 60).PadLeft(2, '0');
            timerLbl.Text = minutes + ":" + seconds;
            if (minutes == "15")
            {
                timer1.Stop();
                instructionsLbl.Text = "Complete!";
                instructionsLbl.Left = (this.Width / 2) - (instructionsLbl.Width / 2);
            }
            else if (totalSeconds % 30 == 0)
            {
                instructionsLbl.Text = Convert.ToString(finalArr[excersizeNum]);
                excersizeNum++;
                instructionsLbl.Left = (this.Width / 2) - (instructionsLbl.Width / 2);
            }
        }
        private void randomizer()
        {
            object[] firstThird = new object[10];
            object[] secondThird = new object[10];
            object[] finalThird = new object[10];


            Random r = new Random();
            int rNum = -1; //random number in array
            int rNum2 = -1; //see which array to take from
            object temp = -1;
            for (int x = 0; x < 10; x++)
            {
                rNum = r.Next(10);
                while (firstThird.Contains(low[rNum])) { rNum = r.Next(10); }
                firstThird[x] = low[rNum];
                finalArr.Add(firstThird[x]);
            }

            for (int x = 0; x < 10; x++)
            {
                do
                {
                    rNum2 = r.Next(3);
                    if (rNum2 < 2) { temp = medium[r.Next(10)]; }
                    else { temp = low[r.Next(10)]; }
                }
                while (secondThird.Contains(temp));
                secondThird[x] = temp;
                finalArr.Add(secondThird[x]);

            }
            Console.WriteLine();
            for (int x = 0; x < 10; x++)
            {
                do
                {
                    rNum2 = r.Next(8);
                    if (rNum2 < 2) { temp = medium[r.Next(10)]; }
                    else if (rNum2 < 4) { temp = low[r.Next(10)]; }
                    else { temp = high[r.Next(5)]; }
                }
                while (finalThird.Contains(temp));
                finalThird[x] = temp;
                finalArr.Add(finalThird[x]);
            }
        }

    }
}
