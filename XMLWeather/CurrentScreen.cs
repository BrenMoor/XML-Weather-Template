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
            
            forecastButton.FlatStyle = FlatStyle.Flat;
            forecastButton.FlatAppearance.BorderColor = BackColor;
            forecastButton.FlatAppearance.MouseOverBackColor = BackColor;
            forecastButton.FlatAppearance.MouseDownBackColor = BackColor;

            SetFont();

        }
        public void SetFont()
        {
            cTempLabel.Font = new Font("Futura-Heavy", 50);
            cityLabel.Font = new Font("Futura-Heavy", 14);
            dayLabel.Font = new Font("Futura-Heavy", 10);
            minLabel.Font = new Font("Futura-Heavy", 17);
            maxLabel.Font = new Font("Futura-Heavy", 17);
            forecastLabel.Font = new Font("Futura-Heavy", 10);
            forecastButton.Font = new Font("Futura-Heavy", 10);
            forecastButton.Text = "Forecast";
        }

        public void DisplayCurrent()
        {

            cTempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°";
            cityLabel.Text = Form1.days[0].location;
            dayLabel.Text = Form1.days[0].date;
            minLabel.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°";
            maxLabel.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°";

            if (Convert.ToDouble(Form1.days[0].condition) > 199 && Convert.ToDouble(Form1.days[0].condition) < 532)
            {
                csPic.BackgroundImage = Properties.Resources.Rain;
            }
           else if (Convert.ToDouble(Form1.days[0].condition) > 599 && Convert.ToDouble(Form1.days[0].condition) < 623)
            {
                csPic.BackgroundImage = Properties.Resources.Snow;
            }
           else if (Convert.ToDouble(Form1.days[0].condition) > 800 && Convert.ToDouble(Form1.days[0].condition) < 805)
            {
                csPic.BackgroundImage = Properties.Resources.Clouds;
            }
           else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                csPic.BackgroundImage = Properties.Resources.Sun;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void forecastButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
