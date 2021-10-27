//Ian Sullivan and Tyler Trull
//Date Due: 4/15/21
//Assignment 6
//BarForm.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.DataVisualization.Charting;
namespace Assign6
{
    public partial class BarForm : Form
    {
        public BarForm()
        {
            InitializeComponent();
            DrawChart();
        }

        public void DrawChart()
        {
            var randomnumber = new Random();
            BarChart.ChartAreas[0].AxisX.Title = "Number being rated";
            BarChart.ChartAreas[0].AxisY.Title = "Rating out of 100";
            BarChart.Series[0].ChartType = SeriesChartType.Column;
            //X is the number being rated
            //Y is the rating out of 100
            List<Point> points = new List<Point>();
            //Gives a random rating to each number
            for(int i = 0; i < 10; i++)
            {
                int rating = randomnumber.Next(0, 100);
                //Adds a point to our point list
                points.Add(new Point { X = i, Y = rating });
            }
            //Binds the data to our chart
            BarChart.Series[0].Points.DataBind(points, "X", "Y", null);
            BarChart.Series[0].LegendText = "Rating out of 100";
            //Creates our title
            BarChart.Titles.Add("Title");
            BarChart.Titles[0].Text = "Numbers rated out of 100";
            BarChart.Titles[0].Font = new Font(BarChart.Titles[0].Font.FontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
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
