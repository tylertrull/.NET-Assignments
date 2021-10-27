//Ian Sullivan and Tyler Trull
//Date Due: 4/15/21
//Assignment 6
//LineForm.cs

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
    public partial class LineForm : Form
    {
        public LineForm()
        {
            InitializeComponent();
            //Calls DrawChart function which adds points to our line graph
            DrawChart(30);
        }
        public void DrawChart(int numberofpoints)
        {
            var randomNumber = new Random();
            List<Point> points = new List<Point>();

            //Adds a numberofpoints to a list of points
            //X and Y are random numbers 0 to 1000
            for(int i = 0; i < numberofpoints; i++)
            {
                points.Add(new Point { X = randomNumber.Next(0, 1000), Y = randomNumber.Next(0,1000)});
            }

            LineChart.Titles[0].Text = "A Randomly drawn Line!!!";
            LineChart.Titles[0].Font = new Font(LineChart.Titles[0].Font.FontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
            LineChart.Series[0].Points.DataBind(points, "X", "Y", null);
            LineChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            LineChart.Series[0].Color = Color.Red;
            LineChart.ChartAreas[0].AxisY.Title = "Random Y Value (0-1000)";
            LineChart.ChartAreas[0].AxisX.Title = "Random X Value (0-1000)";

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
