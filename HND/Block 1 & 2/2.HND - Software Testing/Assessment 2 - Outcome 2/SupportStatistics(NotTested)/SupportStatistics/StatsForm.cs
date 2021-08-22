using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportStatistics
{
    public partial class StatsForm : Form
    {
        private int[] referrals = new int[11];
        private int total=0;
        private float average = 0;
        private string Month;

        public StatsForm()
        {
          InitializeComponent();
          TotalOut.Enabled = false;
          AverageOut.Enabled = false;
          HighestOut.Enabled = false;
          LowestOut.Enabled = false;
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            bool valid = true;
            total = 0; 
            
            try
            {
                referrals[0] = int.Parse(AugIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for August");
                valid = false;
                AugIn.Text = "";
            }
            try
            {
                referrals[1] = int.Parse(SeptIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for September");
                valid = false;
                SeptIn.Text = "";
            }
            try
            {
                referrals[2] = int.Parse(OctIn.Text);
             }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for October");
                valid = false;
                OctIn.Text = "";
            }
            try
            {
                referrals[3] = int.Parse(NovIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for November");
                valid = false;
                NovIn.Text = "";
            }
            try
            {
                referrals[4] = int.Parse(DecIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for December");
                valid = false;
                DecIn.Text = "";
            }

            try
            {
                referrals[5] = int.Parse(JanIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for January");
                valid = false;
                JanIn.Text = "";
            }

            try
            {
                referrals[6] = int.Parse(FebIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for February");
                valid = false;
                FebIn.Text = "";
            }
            try
            {
                referrals[7] = int.Parse(MarchIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for March");
                valid = false;
                MarchIn.Text = "";
            }
            try
            {
                referrals[8] = int.Parse(AprilIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for April");
                valid = false;
                AprilIn.Text = "";
            }
            try
            {
                referrals[9] = int.Parse(MayIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for May");
                valid = false;
                MayIn.Text = "";
            }
            try
            {
                referrals[10] = int.Parse(JuneIn.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A numeric value is required for June");
                valid = false;
                JuneIn.Text = "";
            }

            if (valid == true)
            { 
                CalculateTotal();
                CalculateAverage();
                FindHighest();
                FindLowest();
                TotalOut.Enabled = true;
                AverageOut.Enabled = true;
                HighestOut.Enabled = true;
                LowestOut.Enabled = true;
            }
       }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            AugIn.Text = "";
            SeptIn.Text = "";
            OctIn.Text = "";
            NovIn.Text = "";
            DecIn.Text = "";
            JanIn.Text = "";
            FebIn.Text = "";
            MarchIn.Text = "";
            AprilIn.Text = "";
            MayIn.Text = "";
            JuneIn.Text = "";
            TotalOut.Text = "";
            AverageOut.Text = "";
            HighestOut.Text = "";
            LowestOut.Text = "";
        }

        private void CalculateTotal()
        {
             for (int count = 0; count < 11; count++)
            {
                total = total + referrals[count];
            }

            TotalOut.Text = total.ToString(); 
        }

        private void CalculateAverage()
        {
                average = total / 11;
                AverageOut.Text = average.ToString();
        }

        private void Enumerate(int index)
        {
            if (index == 0)
                Month = "August";
            if (index == 1)
                Month = "September";
            if (index == 2)
                Month = "October";
            if (index == 3)
                Month = "November";
            if (index == 4)
                Month = "December";
            if (index == 5)
                Month = "January";
            if (index == 6)
                Month = "Febuary";
            if (index == 7)
                Month = "March";
            if (index == 8)
                Month = "April";
            if (index == 9)
                Month = "May";
            if (index == 10)
                Month = "June";
        }

        private void FindHighest()
        {
            int highest = 0, highIndex = 0;
            
            for (int count = 0; count < 11; count++)
            {
                if (referrals[count] > highest)
                {
                    highest = referrals[count];
                    highIndex = count;
                }
            }
            
            Enumerate(highIndex);
            HighestOut.Text = Month.ToString(); 
        }

        private void FindLowest()
        {
            int lowest = 0, lowIndex=0;
            
            for (int count = 0; count < 11; count++)
            {
                if (referrals[count] < lowest)
                {
                    lowest = referrals[count];
                    lowIndex = count;
                }
            }
            
            Enumerate(lowIndex);
            LowestOut.Text = Month.ToString(); 
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}