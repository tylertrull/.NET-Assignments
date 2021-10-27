//Ian Sullivan and Tyler Trull
//Date Due: 4/15/21
//Assignment 6
//BubbleForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6
{
    public partial class BubbleForm : Form
    {
        public BubbleForm()
        {
            InitializeComponent();
            DrawChart();
        }
        public void DrawChart()
        {
            //Adds two more series to simulate three people (1 added defaultly)
            BubbleChart.Series.Add("1");
            BubbleChart.Series.Add("2");

            BubbleChart.Titles.Add("0");
            BubbleChart.Titles[0].Text = "Rating of a Number 0-9 Between Anthony, Skylar, and Scott (The Size of the bubble is how much I agree with the decision)";
            BubbleChart.Titles[0].Font = new Font(BubbleChart.Titles[0].Font.FontFamily, 12);

            //Sets all styles to circles
            BubbleChart.Series[0].MarkerStyle = MarkerStyle.Circle;
            BubbleChart.Series[1].MarkerStyle = MarkerStyle.Circle;
            BubbleChart.Series[2].MarkerStyle = MarkerStyle.Circle;
            //Disables our grid
            BubbleChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            BubbleChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            BubbleChart.ChartAreas[0].AxisX.Interval = 1;
            //Sets all the charts to bubble so that when creating a data point it will take in an extra value Y for size
            BubbleChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            BubbleChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            BubbleChart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;

            BubbleChart.Series[0].LegendText = "Anthony";
            BubbleChart.Series[1].LegendText = "Skylar";
            BubbleChart.Series[2].LegendText = "Scott";
            BubbleChart.Legends[0].Font = new Font(BubbleChart.Legends[0].Font.FontFamily, 12);
            BubbleChart.ChartAreas[0].AxisY.Maximum = 100;
            BubbleChart.ChartAreas[0].AxisX.Title = "Number being rated";
            BubbleChart.ChartAreas[0].AxisY.Title = "Rating out of 100";
            var randomnumber = new Random();

            //Generate random numbers for our data
            for (int i = 0; i < 10; i++)
            {
                BubbleChart.Series[0].Points.AddXY(i.ToString(), randomnumber.Next(0, 100), randomnumber.Next(0, 100));
                BubbleChart.Series[1].Points.AddXY(i.ToString(), randomnumber.Next(0, 100), randomnumber.Next(0, 100));
                BubbleChart.Series[2].Points.AddXY(i.ToString(), randomnumber.Next(0, 100), randomnumber.Next(0, 100));

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
