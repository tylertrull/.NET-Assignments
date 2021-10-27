//Written by Ian Sullivan and Tyler Trull
//Form1.cs

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

namespace Assign4
{
    public partial class Form1 : Form
    {
        const float GRAPH1X = 400f;
        const float GRAPH1Y = 20f;
        const float GRAPH1XEND = 470f;
        const float GRAPH1YEND = 450f;

        const float GRAPH2X = 880f;
        const float GRAPH2Y = 20f;
        const float GRAPH2XEND = 470f;
        const float GRAPH2YEND = 450f;

        const float GRAPH3X = 400f;
        const float GRAPH3Y = 490f;
        const float GRAPH3XEND = 470f;
        const float GRAPH3YEND = 450f;

        const float GRAPH4X = 880f;
        const float GRAPH4Y = 490f;
        const float GRAPH4XEND = 470f;
        const float GRAPH4YEND = 450f;

        int c1Width;
        int c1Height;
        int c2Width;
        int c2Height;
        int c3Width;
        int c3Height;
        int c4Width;
        int c4Height;

        //These are to keep track of what type of graph each picturebox should refresh too
        bool linearClicked = false;
        bool quadraticClicked = false;
        bool cubicClicked = false;
        bool circleClicked = false;

        struct DoublePoint
        {
            public double x;
            public double y;

            public override string ToString()
            {
                return ("[" + x + "," + y + "] ");
            }
        };

        public Form1()
        {
            InitializeComponent();
            DrawChart();
            linearMBox.Text = "2";
            linearBBox.Text = "3";
            quadraticABox.Text = "2";
            quadraticBBox.Text = "4";
            quadraticCBox.Text = "-2";
            cubicABox.Text = "2";
            cubicBBox.Text = "6";
            cubicCBox.Text = "-3";
            cubicDBox.Text = "2";
            circleHBox.Text = "2";
            circleKBox.Text = "2";
            circleRBox.Text = "4";
            xIntervalBox.Text = "5";
            yIntervalBox.Text = "5";
            xMinBox.Text = "-30";
            xMaxBox.Text = "30";
            yMinBox.Text = "-30";
            yMaxBox.Text = "30";
            c1Width = pictureBox1.Width;
            c2Width = pictureBox2.Width;
            c3Width = pictureBox3.Width;
            c4Width = pictureBox4.Width;
            c1Height = pictureBox1.Height;
            c2Height = pictureBox2.Height;
            c3Height = pictureBox3.Height;
            c4Height = pictureBox4.Height;
            graphSelectorBox.SelectedIndex = 0;
            lineColorBox.SelectedIndex = 0;
        }
        //Gets y for linear line
        private double CalculateY(double x, double m, double b)
        {
             return ((m * x) + b);
        }

        //Gets y for quadratic
        private double SolveQuadratic(double x, double a, double b, double c)
        {
            return ((a * Math.Pow(x, 2)) + (b * x) + c);
        }

        //Gets y for cubic
        private double SolveCubic(double x, double a, double b, double c, double d)
        {
            double y;
            return y = ((a * Math.Pow(x, 3)) + (b * Math.Pow(x, 2)) + (c * x) + d);
        }

        //Gets y for a circle (idk if this works for what we're doing)
        private double Solvecircle(double x, double r)
        {
            double y = Math.Pow(r, 2) - Math.Pow(x, 2);
            return y;
        }



        //Graphs linear line when the linear button is clicked
        private void GraphLinearLine( double m, double b, int xMax, int xMin, int yMax, int yMin, int xInterval, int yInterval, int graphNum, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 255));
            
            List<DoublePoint> pointDoublesY = new List<DoublePoint>();

            
            //errorLogBox.Clear();
            for (int i = xMin; i <= xMax; i++)
            {
                DoublePoint tempDoublePoint = new DoublePoint();
                tempDoublePoint.x = i;
                tempDoublePoint.y = CalculateY(i, m, b);
                if(yMin <= tempDoublePoint.y && tempDoublePoint.y <= yMax)
                {
                    pointDoublesY.Add(tempDoublePoint);
                    errorLogBox.Text += tempDoublePoint.ToString();
                    //errorLogBox.Text += pointDoublesY[pointDoublesY.Count - 1];

                }

                
            }

            Point p = ReturnPoint(pointDoublesY[0], xMin, xMax, yMin, yMax, graphNum);
            Point pEnd = ReturnPoint(pointDoublesY[pointDoublesY.Count - 1], xMin, xMax, yMin, yMax, graphNum);
            //errorLogBox.Text = p.ToString();
            //errorLogBox.Text += pEnd.ToString();

            g.DrawLine(pen, p, pEnd);

            

        }

        private Point ReturnPoint(DoublePoint d, int xMin, int xMax, int yMin, int yMax, int graphNum)
        {
            int totalYDiff = Math.Abs((yMax - yMin));
            int yTickPixels = (FindGraphHeight(graphNum) / totalYDiff);
            int totalXDiff = Math.Abs((xMax - xMin)); //Adding an additional for zero which is also technically a tick
            int xTickPixels = FindGraphWidth(graphNum) / totalXDiff;

            //We need a number that represents the maximum graph length - the x coord * the distance

            //compare d.x and d.y to figure out their relative position
            //if d.x is between -inf and 0 then we draw backwards
            //if d.x is between 0 and +inf then we draw forwards
            //if d.y is between -inf and 0 then we draw down? forwards? regularly?
            //if d.y is between 0 and +inf then we draw reflected
            if(xMin < 0 && xMax <= 0) //This is for drawing just the left side quads 1 & 3 not including 2 & 4
            {
                if (yMin < 0 && yMax <= 0) // This is for drawing Just the bottom left
                {
                    int endDistanceX = FindGraphWidth(graphNum) - (Math.Abs((int)d.x) * xTickPixels);
                    int endDistanceY = Math.Abs((int)d.y) * yTickPixels;
                    return new Point { X = endDistanceX, Y = endDistanceY };
                    


                } else //This is for drawing either the entire left side or just the top left
                {
                    int endDistanceX = FindGraphWidth(graphNum) - (Math.Abs((int)d.x) * xTickPixels);
                    if(yMax > 0) // We're drawing the entire left
                    {
                        if (d.y >= 0)
                        {
                            int yDifference = yMax - (int)d.y; //The difference is how many times we have to multiply to go down the correct y amount
                            int endDistanceY = yDifference * yTickPixels;
                            return new Point { X = endDistanceX, Y = endDistanceY };
                        }
                        else
                        {
                            int endDistanceY = yTickPixels * (Math.Abs(yMax) + (int)Math.Abs(d.y));
                            return new Point { X = endDistanceX, Y = endDistanceY };
                        }
                    } else // We're drawing the bottom left
                    {
                        int endDistanceY = (int)Math.Abs(d.x) * yTickPixels;
                        return new Point { X = endDistanceX, Y = endDistanceY };
                    }
                    
                    
                }

            } else //This is for drawing either both or just the right side
            {
                if (yMin < 0 && yMax <= 0) // This is for drawing either the entire bottom quads 3 and 4 or just the bottom right
                {
                    int endDistanceY = (int)Math.Abs(d.y) * yTickPixels;
                    if(xMin >= 0) // Then we know it's in the positve quadrant
                    {
                        
                        int endDistanceX = ((int)Math.Abs(d.x) * xTickPixels);
                        return new Point { X = endDistanceX, Y = endDistanceY };
                    } else
                    {
                        if(d.x >= 0)
                        {
                            int endDistanceX = (Math.Abs(xMin) * xTickPixels) + ((int)d.x * xTickPixels);
                            return new Point { X = endDistanceX, Y = endDistanceY };
                        } else
                        {
                            
                            int xDifference = (Math.Abs(xMin) - (int)Math.Abs(d.x));
                            int endDistanceX = (xDifference * xTickPixels);
                            return new Point { X = endDistanceX, Y = endDistanceY };
                        }
                        
                        
                    }
                    
                }
                else // This is for drawing either everything or drawing top right or just the right side.
                {
                    if(xMin >= 0 && yMin >= 0) //Drawing top right
                    {
                        int endDistanceX = ((int)Math.Abs(d.x) * xTickPixels);
                        int endDistanceY = ((int)Math.Abs(d.y) * yTickPixels);
                        return new Point { X = endDistanceX, Y = endDistanceY };

                    } else if(xMin >= 0 && yMin < 0 && yMax > 0) //Drawing right side
                    {
                        int endDistanceX = ((int)Math.Abs(d.x) * xTickPixels);
                        int yDifference = yMax - (int)d.y; //The difference is how many times we have to multiply to go down the correct y amount
                        int endDistanceY = yDifference * yTickPixels;
                        return new Point { X = endDistanceX, Y = endDistanceY };

                    } else //Drawing the whole picture 
                    {
                        if (d.y >= 0) //if the y value is positive
                        {
                            int yDifference = yMax - (int)d.y; //The difference is how many times we have to multiply to go down the correct y amount
                            int endDistanceY = yDifference * yTickPixels;
                            if(d.x >= 0) // if the x and y values are positive
                            {
                                int endDistanceX = (Math.Abs(xMin) * xTickPixels) + ((int)d.x * xTickPixels);
                                return new Point { X = endDistanceX, Y = endDistanceY };

                            } else //If the y value is positive but the x value is not
                            {
                                int xDifference = (Math.Abs(xMin) - (int)Math.Abs(d.x));
                                int endDistanceX = (xDifference * xTickPixels);
                                return new Point { X = endDistanceX, Y = endDistanceY };
                            }
                        } else //If the y Value is negative
                        {
                            int endDistanceY = yTickPixels * (Math.Abs(yMax) + (int)Math.Abs(d.y));
                            if (d.x >= 0) // y is negative but x is not
                            {
                                int endDistanceX = (Math.Abs(xMin) * xTickPixels) + ((int)d.x * xTickPixels);
                                return new Point { X = endDistanceX, Y = endDistanceY };

                            }
                            else // both are negative
                            {
                                int xDifference = (Math.Abs(xMin) - (int)Math.Abs(d.x));
                                int endDistanceX = (xDifference * xTickPixels);
                                return new Point { X = endDistanceX, Y = endDistanceY };
                            }
                        }
                        
                    }
                    
                }
            }

        }

        private void GraphCubic(double a, double b, double c, double d, int xMax, int xMin, int yMax, int yMin, int xInterval, int yInterval, int graphNum, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 255));

            List<DoublePoint> pointDoublesY = new List<DoublePoint>();
            //List<DoublePoint> pointDoublesX = new List<DoublePoint>();

            //errorLogBox.Clear();
            for (int i = xMin; i <= xMax; i++)
            {
                DoublePoint tempDoublePoint = new DoublePoint();
                tempDoublePoint.x = i;
                tempDoublePoint.y = SolveCubic(i, a, b, c, d);
                if (yMin <= tempDoublePoint.y && tempDoublePoint.y <= yMax)
                {
                    pointDoublesY.Add(tempDoublePoint);
                    errorLogBox.Text += tempDoublePoint.ToString();
                    //errorLogBox.Text += pointDoublesY[pointDoublesY.Count - 1];

                }


            }

            Point[] pf = new Point[pointDoublesY.Count - 1];

            for (int i = 0; i < pointDoublesY.Count - 1; i++)
            {
                pf[i] = ReturnPoint(pointDoublesY[i], xMin, xMax, yMin, yMax, graphNum);
            }

            g.DrawCurve(pen, pf);

        }


        //Graphs quadratic when the quadratic button is clicked
        private void GraphQuadratic(double a, double b, double c, int xMax, int xMin, int yMax, int yMin, int xInterval, int yInterval, int graphNum, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 255));

            List<DoublePoint> pointDoublesY = new List<DoublePoint>();
            //List<DoublePoint> pointDoublesX = new List<DoublePoint>();

            //errorLogBox.Clear();
            for (int i = xMin; i <= xMax; i++)
            {
                DoublePoint tempDoublePoint = new DoublePoint();
                tempDoublePoint.x = i;
                tempDoublePoint.y = SolveQuadratic(i, a, b, c);
                if (yMin <= tempDoublePoint.y && tempDoublePoint.y <= yMax)
                {
                    pointDoublesY.Add(tempDoublePoint);
                    errorLogBox.Text += tempDoublePoint.ToString();
                    //errorLogBox.Text += pointDoublesY[pointDoublesY.Count - 1];

                }


            }

            //Point p = ReturnPoint(pointDoublesY[0], xMin, xMax, yMin, yMax, graphNum);
            //Point pEnd = ReturnPoint(pointDoublesY[pointDoublesY.Count - 1], xMin, xMax, yMin, yMax, graphNum);

            //DoublePoint? p2 = null;
            //Point p;
            //Point pEnd;
            Point[] pf = new Point[pointDoublesY.Count - 1];

            for (int i = 0; i < pointDoublesY.Count-1; i++)
            {
                pf[i] = ReturnPoint(pointDoublesY[i], xMin, xMax, yMin, yMax, graphNum);
            }

            g.DrawCurve(pen, pf);
            /*
            foreach(DoublePoint point in pointDoublesY)
            {
                
                if (p1 == null)
                {
                    p1 = point;
                    continue;
                } else
                {
                    p = ReturnPoint((DoublePoint)p1, xMin, xMax, yMin, yMax, graphNum);
                    pEnd = ReturnPoint(point, xMin, xMax, yMin, yMax, graphNum);
                    g.DrawC
                }
                

            }
            */
            //errorLogBox.Text = p.ToString();
            //errorLogBox.Text += pEnd.ToString();

            

        }

        //Graphs Cubic when the cubic button is clicked



        private void GraphCircle(double h, double k, double r, int xMax, int xMin, int yMax, int yMin, int xInterval, int yInterval, int graphNum, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(255, 255, 255));

            DoublePoint dp = new DoublePoint();
            dp.x = h;
            dp.y = Solvecircle(h, r);
            Point p = ReturnPoint(dp, xMin, xMax, yMin, yMax, graphNum);

            g.DrawCircle(pen, p.X, p.Y, (float)r);
        }

        private Color ReturnColor()
        {
            int c = lineColorBox.SelectedIndex;
            if(c == 0)
            {
                return Color.FromArgb(255, 0, 0);
            }
            else if(c == 1)
            {
                return Color.FromArgb(0, 255, 0);
            }
            else if(c == 2)
            {
                return Color.FromArgb(0, 0, 255);
            }
            else
            {
                return Color.FromArgb(255, 0, 255);
            }
        }

        
        private int ReturnChart()
        {
            
            int g = graphSelectorBox.SelectedIndex;
            if (g == 0){
                return 0;
            }
            else if(g == 1)
            {
                return 1;
            }
            else if(g == 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
            
        }
        

        private void linearGraphButton_Click(object sender, EventArgs e)
        {
            
            if (linearMBox.Text != "" && linearBBox.Text != "")
            {
                linearClicked = true;
                switch(ReturnChart())
                {
                    case 0:
                        pictureBox1.Refresh();
                        break;
                    case 1:
                        pictureBox2.Refresh();
                        break;
                    case 2:
                        pictureBox3.Refresh();
                        break;
                    case 3:
                        pictureBox4.Refresh();
                        break;
                    default:
                        pictureBox1.Refresh();
                        break;
                }
                
            }
        }

        private void quadraticGraphButton_Click(object sender, EventArgs e)
        {
            if (quadraticABox.Text != "" && quadraticBBox.Text != "" && quadraticCBox.Text != "")
            {
                quadraticClicked = true;
                switch (ReturnChart())
                {
                    case 0:
                        pictureBox1.Refresh();
                        break;
                    case 1:
                        pictureBox2.Refresh();
                        break;
                    case 2:
                        pictureBox3.Refresh();
                        break;
                    case 3:
                        pictureBox4.Refresh();
                        break;
                    default:
                        pictureBox1.Refresh();
                        break;
                }
            }
        }

        private void cubicGraphButton_Click(object sender, EventArgs e)
        {
            if (cubicABox.Text != "" && cubicBBox.Text != "" && cubicCBox.Text != "" && cubicDBox.Text != "")
            {
                cubicClicked = true;
                switch (ReturnChart())
                {
                    case 0:
                        pictureBox1.Refresh();
                        break;
                    case 1:
                        pictureBox2.Refresh();
                        break;
                    case 2:
                        pictureBox3.Refresh();
                        break;
                    case 3:
                        pictureBox4.Refresh();
                        break;
                    default:
                        pictureBox1.Refresh();
                        break;
                }
            }
        }

        
        private void circleGraphButton_Click(object sender, EventArgs e)
        {
            if (circleHBox.Text != "" && circleKBox.Text != "" && circleRBox.Text != "")
            {

                circleClicked = true;
                switch (ReturnChart())
                {
                    case 0:
                        pictureBox1.Refresh();
                        break;
                    case 1:
                        pictureBox2.Refresh();
                        break;
                    case 2:
                        pictureBox3.Refresh();
                        break;
                    case 3:
                        pictureBox4.Refresh();
                        break;
                    default:
                        pictureBox1.Refresh();
                        break;
                }
            }
        }

        private void DrawChart()
        {
            Pen pen = new Pen(ReturnColor(), 2f);

            Graphics g = this.CreateGraphics();

            g.DrawRectangle(pen, GRAPH1X, GRAPH1Y, GRAPH1XEND, GRAPH1YEND);
            g.DrawRectangle(pen, GRAPH2X, GRAPH2Y, GRAPH2XEND, GRAPH2YEND);
            g.DrawRectangle(pen, GRAPH3X, GRAPH3Y, GRAPH3XEND, GRAPH3YEND);
            g.DrawRectangle(pen, GRAPH4X, GRAPH4Y, GRAPH4XEND, GRAPH4YEND);

        }
        private void DrawTicks(int graphType, int graphNum, int xMin, int xMax, int yMin, int yMax, int xInterval, int yInterval, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.FromArgb(255, 255, 255));

            switch (graphType)
            {
                case 0:
                    DrawBothAxis(xMin, xMax, yMin, yMax, xInterval, yInterval, e, graphNum);
                    errorLogBox.Text = "I got to case 0";
                    break;
                case 1:
                    errorLogBox.Text = "I got to case 1";
                    DrawJustYAxis(xMin, xMax, yMin, yMax, xInterval, yInterval, e, graphNum);
                    break;
                case 2:
                    errorLogBox.Text = "I got to case 2";
                    DrawJustXAxis(xMin, xMax, yMin, yMax, xInterval, yInterval, e, graphNum);
                    break;
                case 3:
                    errorLogBox.Text = "I got to case 3";
                    DrawNoAxis(xMin, xMax, yMin, yMax, xInterval, yInterval, e, graphNum);
                    break;
                default:
                    
                    break;
            }
        }

        private void DrawNoAxis(int xMin, int xMax, int yMin, int yMax, int xInterval, int yInterval, PaintEventArgs e, int graphNum)
        {

            Pen pen = new Pen(ReturnColor(), 2);
            Graphics g = e.Graphics;

            if (xMin > 0 && yMin > 0)
            {
                //top right
                int tempXTick = (xMax - xMin) / xInterval;
                int xTickLength = (FindGraphWidth(graphNum) / tempXTick);
                int tempYTick = (yMax - yMin) / yInterval;
                int yTickLength = (FindGraphHeight(graphNum) / tempYTick);

                for (int i = 0; i <= FindGraphWidth(graphNum); i += xTickLength)
                {
                    Point p = new Point(i, FindGraphHeight(graphNum));
                    Point pEnd = new Point(i, FindGraphHeight(graphNum) - 20);
                    g.DrawLine(pen, p, pEnd);
                }

                for (int i = 0; i <= FindGraphHeight(graphNum); i += yTickLength)
                {
                    Point p = new Point(0, i);
                    Point pEnd = new Point(20, i);
                    g.DrawLine(pen, p, pEnd);
                }

            } else if (xMax < 0 && yMin > 0)
            {
                //top left
                int tempXTick = Math.Abs(xMax - xMin) / xInterval;
                int xTickLength = (FindGraphWidth(graphNum) / tempXTick);
                int tempYTick = (yMax - yMin) / yInterval;
                int yTickLength = (FindGraphHeight(graphNum) / tempYTick);

                for (int i = FindGraphWidth(graphNum); i >= 0; i -= xTickLength)
                {
                    Point p = new Point(i, FindGraphHeight(graphNum));
                    Point pEnd = new Point(i, FindGraphHeight(graphNum) - 20);
                    g.DrawLine(pen, p, pEnd);
                }

                for (int i = 0; i <= FindGraphHeight(graphNum); i += yTickLength)
                {
                    Point p = new Point(FindGraphWidth(graphNum), i);
                    Point pEnd = new Point(FindGraphWidth(graphNum) - 20, i);
                    g.DrawLine(pen, p, pEnd);
                }

            } else if (xMax < 0 && yMax < 0)
            {
                int tempXTick = Math.Abs(xMax - xMin) / xInterval;
                int xTickLength = (FindGraphWidth(graphNum) / tempXTick);
                int tempYTick = Math.Abs(yMax - yMin) / yInterval;
                int yTickLength = (FindGraphHeight(graphNum) / tempYTick);

                for (int i = FindGraphWidth(graphNum); i >= 0; i -= xTickLength)
                {
                    Point p = new Point(i, 0);
                    Point pEnd = new Point(i, 20);
                    g.DrawLine(pen, p, pEnd);
                }

                for (int i = FindGraphHeight(graphNum); i >= 0; i -= yTickLength)
                {
                    Point p = new Point(FindGraphWidth(graphNum), i);
                    Point pEnd = new Point(FindGraphWidth(graphNum) - 20, i);
                    g.DrawLine(pen, p, pEnd);
                }
                //bottom left
            } else
            {
                int tempYTick = Math.Abs(yMax - yMin) / yInterval;
                int yTickLength = (FindGraphHeight(graphNum) / tempYTick);
                int tempXTick = (xMax - xMin) / xInterval;
                int xTickLength = (FindGraphWidth(graphNum) / tempXTick);

                for (int i = FindGraphWidth(graphNum); i >= 0; i -= xTickLength)
                {
                    Point p = new Point(i, 0);
                    Point pEnd = new Point(i,20);
                    g.DrawLine(pen, p, pEnd);
                }

                for (int i = FindGraphHeight(graphNum); i >= 0; i -= yTickLength)
                {
                    Point p = new Point(0, i);
                    Point pEnd = new Point(20, i);
                    g.DrawLine(pen, p, pEnd);
                }
                //bottom right
            }
        }
        private void DrawBothAxis(int xMin, int xMax, int yMin, int yMax, int xInterval, int yInterval, PaintEventArgs e, int graphNum)
        {
            int upYTickAmount = (Math.Abs(yMax) / yInterval);
            int downYTickAmount = (Math.Abs(yMin) / yInterval);
            int totalYTickAmount = (upYTickAmount + downYTickAmount);
            int yTickPixels = (FindGraphHeight(graphNum) / totalYTickAmount);
            int xAxis = (yTickPixels * upYTickAmount);

            int leftXTickAmount = (Math.Abs(xMin) / xInterval); //This is the amount of ticks to the left of zero
            int rightXTickAmount = (Math.Abs(xMax) / xInterval); //This is the amount of ticks to the right of zero
            int totalXTickAmount = (leftXTickAmount + rightXTickAmount); //Adding an additional for zero which is also technically a tick
            int xTickPixels = FindGraphWidth(graphNum) / totalXTickAmount; //This divides our screen space evenly
            int yAxis = (xTickPixels * (leftXTickAmount)); //This is the pixel where we need to draw our yAxis

            Pen pen = new Pen(ReturnColor(), 2);
            Graphics g = e.Graphics;

            for (int i = 0; i <= FindGraphHeight(graphNum); i += yTickPixels)
            {
                if (i != xAxis)
                {
                    Point p = new Point(yAxis - 10, i);
                    Point pEnd = new Point(yAxis + 10, i);
                    g.DrawLine(pen, p, pEnd);
                }
                else
                {
                    Point p = new Point(0, i);
                    Point pEnd = new Point(FindGraphWidth(graphNum), i);
                    g.DrawLine(pen, p, pEnd);
                }
            }

            for (int i = xTickPixels; i <= FindGraphWidth(graphNum); i += xTickPixels)
            {
                if (i != yAxis)
                {
                    Point p = new Point(i, xAxis - 10);
                    Point pEnd = new Point(i, xAxis + 10);
                    g.DrawLine(pen, p, pEnd);
                }
                else
                {
                    Point p = new Point(i, FindGraphHeight(graphNum));
                    Point pEnd = new Point(i, 0);
                    g.DrawLine(pen, p, pEnd);
                }

            }
        }
        private void DrawJustXAxis(int xMin, int xMax, int yMin, int yMax, int xInterval, int yInterval, PaintEventArgs e, int graphNum)
        {

            int upYTickAmount = (Math.Abs(yMax) / yInterval);
            int downYTickAmount = (Math.Abs(yMin) / yInterval);
            int totalYTickAmount = (upYTickAmount + downYTickAmount);
            int yTickPixels = (FindGraphHeight(graphNum) / totalYTickAmount);
            int xAxis = (yTickPixels * upYTickAmount);

            int xTickAmount = Math.Abs((xMin - xMax) / xInterval);
            int xTickPixels = FindGraphWidth(graphNum) / xTickAmount;

            Pen pen = new Pen(ReturnColor(), 2);
            Graphics g = e.Graphics;

            if (xMin > 0)
            {
                for (int i = 0; i <= FindGraphHeight(graphNum); i += yTickPixels)
                {
                    /*
                    if(i == 0 || i == FindGraphHeight(graphNum))
                    {
                        continue;
                    }
                    */
                    if(i != xAxis)
                    {
                        Point p = new Point(0, i);
                        Point pEnd = new Point(10, i);
                        g.DrawLine(pen, p, pEnd);
                    } else
                    {
                        Point p = new Point(0, i);
                        Point pEnd = new Point(FindGraphWidth(graphNum), i);
                        g.DrawLine(pen, p, pEnd);
                    }
                }
            } else
            {
                for (int i = 0; i <= FindGraphHeight(graphNum); i += yTickPixels)
                {
                    if (i != xAxis)
                    {
                        Point p = new Point(FindGraphWidth(graphNum), i);
                        Point pEnd = new Point(FindGraphWidth(graphNum) - 10, i);
                        g.DrawLine(pen, p, pEnd);
                    }
                    else
                    {
                        Point p = new Point(0, i);
                        Point pEnd = new Point(FindGraphWidth(graphNum), i);
                        g.DrawLine(pen, p, pEnd);
                    }
                }
            }
            for (int i = 0; i <= FindGraphWidth(graphNum); i += xTickPixels)
            {
                Point p = new Point(i, xAxis - 10);
                Point pEnd = new Point(i, xAxis + 10);
                g.DrawLine(pen, p, pEnd);
                if(xTickPixels == FindGraphWidth(graphNum))
                {
                    int tempTick = (FindGraphWidth(graphNum) / xMax);
                    tempTick = (tempTick * xInterval);
                    Point tempP = new Point(tempTick, xAxis - 10);
                    Point tempPEnd = new Point(tempTick, xAxis + 10);
                    g.DrawLine(pen, tempP, tempPEnd);

                }
                else if (xMax < 0)
                {
                    //errorLogBox.Text = "I got this far";
                    int tempTick = (FindGraphWidth(graphNum) / Math.Abs(xMax));
                    int tempSub = (Math.Abs(xMax) - xInterval);
                    tempTick = (tempTick * tempSub);
                    Point tempP = new Point(tempTick, xAxis - 10);
                    Point tempPEnd = new Point(tempTick, xAxis + 10);
                    g.DrawLine(pen, tempP, tempPEnd);

                }
            }

        }
        
        private void DrawJustYAxis(int xMin, int xMax, int yMin, int yMax, int xInterval, int yInterval, PaintEventArgs e, int graphNum)
        {
            
            
            int leftXTickAmount = (Math.Abs(xMin) / xInterval); //This is the amount of ticks to the left of zero
            int rightXTickAmount = (Math.Abs(xMax) / xInterval); //This is the amount of ticks to the right of zero
            int totalXTickAmount = (leftXTickAmount + rightXTickAmount); //Adding an additional for zero which is also technically a tick
            int xTickPixels = FindGraphWidth(graphNum) / totalXTickAmount; //This divides our screen space evenly
            int yAxis = (xTickPixels * (leftXTickAmount)); //This is the pixel where we need to draw our yAxis

            int yTickAmount = (Math.Abs(yMin) + Math.Abs(yMax)) / yInterval;
            int yTickPixels = FindGraphHeight(graphNum) / yTickAmount; //We know for a fact if this function is selected that we won't have to draw the xAxis so we don't need complex math.

            Pen pen = new Pen(ReturnColor(), 2);
            Graphics g = e.Graphics;

            if (yMin > 0)
            {
                for (int i = xTickPixels; i <= FindGraphWidth(graphNum) - xTickPixels; i += xTickPixels)
                {
                    if (i != yAxis)
                    {
                        Point p = new Point(i, FindGraphHeight(graphNum));
                        Point pEnd = new Point(i, FindGraphHeight(graphNum) - 20);
                        g.DrawLine(pen, p, pEnd);
                    }
                    else
                    {
                        Point p = new Point(i, FindGraphHeight(graphNum));
                        Point pEnd = new Point(i, 0);
                        g.DrawLine(pen, p, pEnd);
                    }

                }
                
            }
            else
            {
                for (int i = xTickPixels; i <= FindGraphWidth(graphNum) - xTickPixels; i += xTickPixels)
                {
                    if (i != yAxis)
                    {
                        Point p = new Point(i, 0);
                        Point pEnd = new Point(i, 20);
                        g.DrawLine(pen, p, pEnd);
                    }
                    else
                    {
                        Point p = new Point(i, 0);
                        Point pEnd = new Point(i, FindGraphHeight(graphNum));
                        g.DrawLine(pen, p, pEnd);

                    }

                }
            }
            for (int i = yTickPixels; i <= FindGraphHeight(graphNum) - yTickPixels; i += yTickPixels)
            {
                Point p = new Point(yAxis - 10, i);
                Point pEnd = new Point(yAxis + 10, i);
                g.DrawLine(pen, p, pEnd);
            }
        }
        
        private int FindGraphHeight(int graphNum)
        {
            switch(graphNum)
            {
                case 0:
                    return c1Height;
                case 1:
                    return c2Height;
                case 2:
                    return c3Height;
                case 3:
                    return c4Height;
                default:
                    return c1Height;
            }
        }

        private int FindGraphWidth(int graphNum)
        {
            switch(graphNum)
            {
                case 0:
                    return c1Width;
                case 1:
                    return c2Width;
                case 2:
                    return c3Width;
                case 3:
                    return c4Width;
                default:
                    return c1Width;
            }
        }

        private int GetXBegin(int graph)
        {
            switch (graph)
            {
                case 0:
                    return (int)GRAPH1X;

                case 1:
                    return (int)GRAPH2X;

                case 2:
                    return (int)GRAPH3X;

                case 3:
                    return (int)GRAPH4X;

                default:

                    return (int)GRAPH1X;

            }
        }
        private int GetXLength(int graph)
        {
            switch (graph)
            {
                case 0:
                    return (int)GRAPH1XEND;
                case 1:
                    return (int)GRAPH2XEND;
                case 2:
                    return (int)GRAPH3XEND;
                case 3:
                    return (int)GRAPH4XEND;
                default:
                    return (int)GRAPH1XEND;
            }
        }

        private int GetYBegin(int graph)
        {
            switch(graph)
            {
                case 0:
                    return (int)GRAPH1Y;
                case 1:
                    return (int)GRAPH2Y;
                case 2:
                    return (int)GRAPH3Y;
                case 3:
                    return (int)GRAPH4Y;
                default:
                    return (int)GRAPH1Y;
            }
        }

        private int GetYEnd(int graph)
        {
            switch (graph)
            {
                case 0:
                    return (int)GRAPH1YEND + (int)GRAPH1Y;
                case 1:
                    return (int)GRAPH2YEND + (int)GRAPH2Y;
                case 2:
                    return (int)GRAPH3YEND + (int)GRAPH3Y;
                case 3:
                    return (int)GRAPH4YEND + (int)GRAPH4Y;
                default:
                    return (int)GRAPH1YEND + (int)GRAPH1Y;
            }
        }

        private int FindXCenter(int x1, int x2)
        {
            return (x1 + x2) / 2;
        }

        private int FindYCenter(int y1, int y2)
        {
            return (y1 + y2) / 2;
        }

        private int FindGraphType(int xMin, int xMax, int yMin, int yMax)
        {
            /*
            if (xMin <= 0 && yMin <= 0 && xMax > 0 && yMax > 0)
            {
                return 0;
            } else if (yMin > 0 || yMax < 0)
            {
                return 1;
            } else if (xMin > 0 || xMax < 0)
            {
                return 2;
            } else
            {
                return 3;
            }
            */

            if (xMin <= 0 && yMin <= 0 && xMax > 0 && yMax > 0)
            {
                return 0;
            } else if ((xMin > 0 && yMin > 0) || (xMax < 0 && yMin > 0) || (xMax < 0 && yMax < 0) || (xMin > 0 && yMax < 0))
            {
                return 3;
            } else if (yMin > 0 || yMax < 0)
            {
                return 1;
            } else
            {
                return 2;
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            int xmax = Convert.ToInt32(xMaxBox.Text);
            int xmin = Convert.ToInt32(xMinBox.Text);
            int ymax = Convert.ToInt32(yMaxBox.Text);
            int ymin = Convert.ToInt32(yMinBox.Text);
            int xInterval = Convert.ToInt32(xIntervalBox.Text);
            int yInterval = Convert.ToInt32(yIntervalBox.Text);

            Graphics g = e.Graphics;
            Pen pen = new Pen(ReturnColor(), 2);
            g.DrawRectangle(pen, 0, 0, c1Width, c1Height);

            //errorLogBox.Text = linearClicked.ToString();
            if (linearClicked == true)
            {
                double m = Convert.ToDouble(linearMBox.Text);
                double b = Convert.ToDouble(linearBBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                linearClicked = false; //When done reset it
                GraphLinearLine(m, b, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            } else if (quadraticClicked == true)
            {
                double a = Convert.ToDouble(quadraticABox.Text);
                double b = Convert.ToDouble(quadraticBBox.Text);
                double c = Convert.ToDouble(quadraticCBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                quadraticClicked = false;
                GraphQuadratic(a, b, c, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
                //Call the draw graph function here
            }
            else if (cubicClicked == true)
            {
                double a = Convert.ToDouble(cubicABox.Text);
                double b = Convert.ToDouble(cubicBBox.Text);
                double c = Convert.ToDouble(cubicCBox.Text);
                double d = Convert.ToDouble(cubicDBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                cubicClicked = false;
                GraphCubic(a, b, c, d, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            } else
            {
                double h = Convert.ToDouble(circleHBox.Text);
                double k = Convert.ToDouble(circleKBox.Text);
                double r = Convert.ToDouble(circleRBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                circleClicked = false;
                GraphCircle(h, k, r, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int xmax = Convert.ToInt32(xMaxBox.Text);
            int xmin = Convert.ToInt32(xMinBox.Text);
            int ymax = Convert.ToInt32(yMaxBox.Text);
            int ymin = Convert.ToInt32(yMinBox.Text);
            int xInterval = Convert.ToInt32(xIntervalBox.Text);
            int yInterval = Convert.ToInt32(yIntervalBox.Text);

            Graphics g = e.Graphics;
            Pen pen = new Pen(ReturnColor(), 2);
            g.DrawRectangle(pen, 0, 0, c2Width, c2Height);

            //errorLogBox.Text = linearClicked.ToString();
            if (linearClicked == true)
            {
                double m = Convert.ToDouble(linearMBox.Text);
                double b = Convert.ToDouble(linearBBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                linearClicked = false; //When done reset it
                GraphLinearLine(m, b, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else if (quadraticClicked == true)
            {
                double a = Convert.ToDouble(quadraticABox.Text);
                double b = Convert.ToDouble(quadraticBBox.Text);
                double c = Convert.ToDouble(quadraticCBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                quadraticClicked = false;
                GraphQuadratic(a, b, c, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
                //Call the draw graph function here
            }
            else if (cubicClicked == true)
            {
                double a = Convert.ToDouble(cubicABox.Text);
                double b = Convert.ToDouble(cubicBBox.Text);
                double c = Convert.ToDouble(cubicCBox.Text);
                double d = Convert.ToDouble(cubicDBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                cubicClicked = false;
                GraphCubic(a, b, c, d, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else
            {
                double h = Convert.ToDouble(circleHBox.Text);
                double k = Convert.ToDouble(circleKBox.Text);
                double r = Convert.ToDouble(circleRBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                circleClicked = false;
                GraphCircle(h, k, r, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            int xmax = Convert.ToInt32(xMaxBox.Text);
            int xmin = Convert.ToInt32(xMinBox.Text);
            int ymax = Convert.ToInt32(yMaxBox.Text);
            int ymin = Convert.ToInt32(yMinBox.Text);
            int xInterval = Convert.ToInt32(xIntervalBox.Text);
            int yInterval = Convert.ToInt32(yIntervalBox.Text);

            Graphics g = e.Graphics;
            Pen pen = new Pen(ReturnColor(), 2);
            g.DrawRectangle(pen, 0, 0, c3Width, c3Height);

            //errorLogBox.Text = linearClicked.ToString();
            if (linearClicked == true)
            {
                double m = Convert.ToDouble(linearMBox.Text);
                double b = Convert.ToDouble(linearBBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                linearClicked = false; //When done reset it
                GraphLinearLine(m, b, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else if (quadraticClicked == true)
            {
                double a = Convert.ToDouble(quadraticABox.Text);
                double b = Convert.ToDouble(quadraticBBox.Text);
                double c = Convert.ToDouble(quadraticCBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                quadraticClicked = false;
                GraphQuadratic(a, b, c, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
                //Call the draw graph function here
            }
            else if (cubicClicked == true)
            {
                double a = Convert.ToDouble(cubicABox.Text);
                double b = Convert.ToDouble(cubicBBox.Text);
                double c = Convert.ToDouble(cubicCBox.Text);
                double d = Convert.ToDouble(cubicDBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                cubicClicked = false;
                GraphCubic(a, b, c, d, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else
            {
                double h = Convert.ToDouble(circleHBox.Text);
                double k = Convert.ToDouble(circleKBox.Text);
                double r = Convert.ToDouble(circleRBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                circleClicked = false;
                GraphCircle(h, k, r, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            int xmax = Convert.ToInt32(xMaxBox.Text);
            int xmin = Convert.ToInt32(xMinBox.Text);
            int ymax = Convert.ToInt32(yMaxBox.Text);
            int ymin = Convert.ToInt32(yMinBox.Text);
            int xInterval = Convert.ToInt32(xIntervalBox.Text);
            int yInterval = Convert.ToInt32(yIntervalBox.Text);

            Graphics g = e.Graphics;
            Pen pen = new Pen(ReturnColor(), 2);
            g.DrawRectangle(pen, 0, 0, c4Width, c4Height);

            //errorLogBox.Text = linearClicked.ToString();
            if (linearClicked == true)
            {
                double m = Convert.ToDouble(linearMBox.Text);
                double b = Convert.ToDouble(linearBBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                linearClicked = false; //When done reset it
                GraphLinearLine(m, b, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else if (quadraticClicked == true)
            {
                double a = Convert.ToDouble(quadraticABox.Text);
                double b = Convert.ToDouble(quadraticBBox.Text);
                double c = Convert.ToDouble(quadraticCBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                quadraticClicked = false;
                GraphQuadratic(a, b, c, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
                //Call the draw graph function here
            }
            else if (cubicClicked == true)
            {
                double a = Convert.ToDouble(cubicABox.Text);
                double b = Convert.ToDouble(cubicBBox.Text);
                double c = Convert.ToDouble(cubicCBox.Text);
                double d = Convert.ToDouble(cubicDBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                cubicClicked = false;
                GraphCubic(a, b, c, d, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
            else
            {
                double h = Convert.ToDouble(circleHBox.Text);
                double k = Convert.ToDouble(circleKBox.Text);
                double r = Convert.ToDouble(circleRBox.Text);
                DrawTicks(FindGraphType(xmin, xmax, ymin, ymax), graphSelectorBox.SelectedIndex, xmin, xmax, ymin, ymax, xInterval, yInterval, e);
                circleClicked = false;
                GraphCircle(h, k, r, xmax, xmin, ymax, ymin, xInterval, yInterval, graphSelectorBox.SelectedIndex, e);
            }
        }
    }
}
