//Ian Sullivan and Tyler Trull
//Date Due: 4/15/21
//Assignment 6
//PortalForm.cs

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
    public partial class PortalForm : Form
    {
        public PortalForm()
        {
            InitializeComponent();
        }

        //All button clicks for our portal form
        private void BarChartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BarForm barform = new BarForm();
            barform.Show();
        }

        private void LineChartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineForm lineform = new LineForm();
            lineform.Show();
        }

        private void PieChartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PieForm pieform = new PieForm();
            pieform.Show();
        }

        private void BubbleChartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BubbleForm bubbleform = new BubbleForm();
            bubbleform.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Makes sure everything closes
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
