//Ian Sullivan and Tyler Trull
//Date Due: 4/15/21
//Assignment 6
//PieForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign6
{
    public partial class PieForm : Form
    {
        public PieForm()
        {
            InitializeComponent();
            //Calls drawchart function
            DrawChart();
        }

        //Updates the chart on the pieform
        public void DrawChart()
        {
            PieChart.Titles.Add("0");
            PieChart.Titles[0].Text = "Percentage of People who created up to 9 Funky Fresh Rhymes within 10 seconds";
            PieChart.Titles[0].Font = new Font(PieChart.Titles[0].Font.FontFamily, 12);
            PieChart.Legends[0].Font = new Font(PieChart.Titles[0].Font.FontFamily, 12);

            PieChart.Legends[0].Title = "Number of Freakishly Funky Fresh Rhymes created within 10 seconds";
            PieChart.Legends[0].BorderColor = Color.Black;
            PieChart.Series[0].LegendText = "#VALX";
            PieChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            PieChart.Series[0].Label = "#PERCENT";
            var randomnumber = new Random();

            //Generates random data points
            for(int i = 0; i < 10; i++)
            {
                PieChart.Series[0].Points.AddXY(i.ToString(), randomnumber.Next(0, 100));
            }

        }
        //Used in all forms to open the portal after the "X" is clicked
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            PortalForm portalform = new PortalForm();
            portalform.Show();
        }

        private void PortalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
