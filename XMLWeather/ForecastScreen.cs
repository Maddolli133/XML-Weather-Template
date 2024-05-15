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
            temp1.BackColor = Color.FromArgb(160, 100, 100, 100);

            textBack1.BackColor = Color.FromArgb(160, 100, 100, 100);
            date2.BackColor = Color.FromArgb(160, 100, 100, 100);
            temp2.BackColor = Color.FromArgb(160, 100, 100, 100);
           
            textBack2.BackColor = Color.FromArgb(160, 100, 100, 100);
            date3.BackColor = Color.FromArgb(160, 100, 100, 100);
            temp3.BackColor = Color.FromArgb(160, 100, 100, 100);

            day1CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            day2CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            day3CondOutput.BackColor = Color.FromArgb(160, 100, 100, 100);

        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;

            double Temp1 = Convert.ToDouble(Form1.days[1].currentTemp);
            temp1.Text = Temp1.ToString("0°");
           
            date2.Text = Form1.days[2].date;
            double Temp2 = Convert.ToDouble(Form1.days[2].currentTemp);
            temp2.Text = Temp2.ToString("0°");

            date3.Text = Form1.days[3].date;
            double Temp3 = Convert.ToDouble(Form1.days[3].currentTemp);
            temp3.Text = Temp3.ToString("0°");

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
