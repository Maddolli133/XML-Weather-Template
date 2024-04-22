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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

            textBack.BackColor = Color.FromArgb(160, 100, 100, 100);
            cityOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            currentOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            minOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
            maxOutput.BackColor = Color.FromArgb(160, 100, 100, 100);
        }

        public void DisplayCurrent()
        {
            //Removes decimal from the temperature
            double current = Convert.ToDouble (Form1.days[0].currentTemp);
            currentOutput.Text = current.ToString("0°");

            double lowTemp = Convert.ToDouble(Form1.days[0].tempLow);
            minOutput.Text = lowTemp.ToString("0°");

            double maxTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            maxOutput.Text = maxTemp.ToString("0°");

            //Displays the information onto labels
            cityOutput.Text = Form1.days[0].location;
            currentDateOutput.Text = Form1.days[0].date;
            currentCondOutput.Text = Form1.days[0].condition;
            visibilityOutput.Text = Form1.days[0].visibility;
            precipitationOutput.Text = Form1.days[0].precipitation;
            windspeedOutput.Text = Form1.days[0].windSpeed;

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void citySearchButton_Click(object sender, EventArgs e)
        {
            Form1.days.Clear();
            Form1.something = citySearchImput.Text;
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            DisplayCurrent();

            Refresh();
        }
    }
}
