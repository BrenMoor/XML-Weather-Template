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
            msButton.FlatStyle = FlatStyle.Flat;
            msButton.FlatAppearance.BorderColor = BackColor;
            msButton.FlatAppearance.MouseOverBackColor = BackColor;
            msButton.FlatAppearance.MouseDownBackColor = BackColor;
            SetFont();
        }
        public void SetFont()
        {
            date1.Font = new Font("Futura-Heavy", 10);
            date2.Font = new Font("Futura-Heavy", 10);
            date3.Font = new Font("Futura-Heavy", 10);
            d1max.Font = new Font("Futura-Heavy", 10);
            d2max.Font = new Font("Futura-Heavy", 10);
            d3max.Font = new Font("Futura-Heavy", 10);
            d1min.Font = new Font("Futura-Heavy", 10);
            d2min.Font = new Font("Futura-Heavy", 10);
            d3min.Font = new Font("Futura-Heavy", 10);
            msButton.Font = new Font("Futura-Heavy", 10);
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            d1min.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°";
            d1max.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°";

            date2.Text = Form1.days[2].date;
            d2min.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°";
            d2max.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°";

            date3.Text = Form1.days[3].date;
            d3min.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°";
            d3max.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°";

            if (Convert.ToDouble(Form1.days[1].condition) > 199 && Convert.ToDouble(Form1.days[1].condition) < 532)
            {
                d1pic.BackgroundImage = Properties.Resources.Rain;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) > 599 && Convert.ToDouble(Form1.days[1].condition) < 623)
            {
                d1pic.BackgroundImage = Properties.Resources.Snow;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) > 800 && Convert.ToDouble(Form1.days[1].condition) < 805)
            {
                d1pic.BackgroundImage = Properties.Resources.Clouds;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) == 800)
            {
                d1pic.BackgroundImage = Properties.Resources.Sun;
            }

            if (Convert.ToDouble(Form1.days[2].condition) > 199 && Convert.ToDouble(Form1.days[2].condition) < 532)
            {
                d2pic.BackgroundImage = Properties.Resources.Rain;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) > 599 && Convert.ToDouble(Form1.days[2].condition) < 623)
            {
                d2pic.BackgroundImage = Properties.Resources.Snow;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) > 800 && Convert.ToDouble(Form1.days[2].condition) < 805)
            {
                d2pic.BackgroundImage = Properties.Resources.Clouds;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) == 800)
            {
                d2pic.BackgroundImage = Properties.Resources.Sun;
            }

            if (Convert.ToDouble(Form1.days[3].condition) > 199 && Convert.ToDouble(Form1.days[3].condition) < 532)
            {
                d3pic.BackgroundImage = Properties.Resources.Rain;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) > 599 && Convert.ToDouble(Form1.days[3].condition) < 623)
            {
                d3pic.BackgroundImage = Properties.Resources.Snow;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) > 800 && Convert.ToDouble(Form1.days[3].condition) < 805)
            {
                d3pic.BackgroundImage = Properties.Resources.Clouds;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) == 800)
            {
                d3pic.BackgroundImage = Properties.Resources.Sun;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void msButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
