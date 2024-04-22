using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();

            textBack.BackColor = Color.FromArgb(160, 100, 100, 100);
            date1.BackColor = Color.FromArgb(160, 100, 100, 100);
            min1.BackColor = Color.FromArgb(160, 100, 100, 100);
            max1.BackColor = Color.FromArgb(160, 100, 100, 100);
            minLabel.BackColor = Color.FromArgb(160, 100, 100, 100);
            maxLabel.BackColor = Color.FromArgb(160, 100, 100, 100);

            textBack1.BackColor = Color.FromArgb(160, 100, 100, 100);
            date2.BackColor = Color.FromArgb(160, 100, 100, 100);
            min2.BackColor = Color.FromArgb(160, 100, 100, 100);
            max2.BackColor = Color.FromArgb(160, 100, 100, 100);
            minLabel1.BackColor = Color.FromArgb(160, 100, 100, 100);
            maxLabel1.BackColor = Color.FromArgb(160, 100, 100, 100);

            textBack2.BackColor = Color.FromArgb(160, 100, 100, 100);
            date3.BackColor = Color.FromArgb(160, 100, 100, 100);
            min3.BackColor = Color.FromArgb(160, 100, 100, 100);
            max3.BackColor = Color.FromArgb(160, 100, 100, 100);
            minLabel2.BackColor = Color.FromArgb(160, 100, 100, 100);
            maxLabel2.BackColor = Color.FromArgb(160, 100, 100, 100);

            day1CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            day2CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            day3CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);

        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;

            double Min1 = Convert.ToDouble(Form1.days[1].tempLow);
            min1.Text = Min1.ToString("0°");
            double Max1 = Convert.ToDouble(Form1.days[1].tempHigh);
            max1.Text = Max1.ToString("0°");
   

            date2.Text = Form1.days[2].date;
            double Min2 = Convert.ToDouble(Form1.days[2].tempLow);
            min2.Text = Min2.ToString("0°");
            double Max2 = Convert.ToDouble(Form1.days[2].tempHigh);
            max2.Text = Max2.ToString("0°");


            date3.Text = Form1.days[3].date;
            double Min3 = Convert.ToDouble(Form1.days[3].tempLow);
            min3.Text = Min3.ToString("0°");
            double Max3 = Convert.ToDouble(Form1.days[3].tempHigh);
            max3.Text = Max3.ToString("0°");
            

            day1CondOutput.Text = Form1.days[1].condition;
            day2CondOutput.Text = Form1.days[2].condition;
            day3CondOutput.Text = Form1.days[3].condition;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
