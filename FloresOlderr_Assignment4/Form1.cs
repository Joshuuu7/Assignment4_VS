/********************************************************************************
 * 
 * Programmers: Joshua Flores, Adam Olderr
 * 
 * z-IDs: 1682720, 1753651
 * 
 * Assignment Number : 4
 * 
 * Due Date: March 28th, 2018
 * 
 * Class: CSCI504
 * 
 * Instructor: Daniel Rogness
 * 
 * Teaching Assistants: Aravind Muvva, Kiranmayi Manukonda
 * 
 * *******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloresOlderr_Assignment4
{
    public partial class Form1 : Form
    {
        private static Pen myWhitePen;

        public Form1()
        {
            InitializeComponent();

            myWhitePen = new Pen(Color.White);
        }

        void DrawLine(float m, float b, bool need_X_axis, bool need_Y_axis)
        {
            Graphics g = Playing_Field.CreateGraphics();
            Pen line_pen = new Pen(Color.Green);

            float start_X = 0;
            float start_Y = 150 + (150 * m);
            float end_X = 300;
            float end_Y = 150 - (150 * m);
            start_Y -= b;
            end_Y -= b;

            if ( need_X_axis && !need_Y_axis )
            {
                start_X -= 150;
                end_X -= 150;
            }

            g.DrawLine(line_pen, start_X, start_Y, end_X, end_Y);
            Console.WriteLine("startX: " + start_X + " startY: " + start_Y + " end_X: " + end_X + " end_Y: " + end_Y); 
        }

        void DrawQuadratic(float a, float b, float c)
        {
            Graphics g = QuadraticPlayingField.CreateGraphics();//
            Pen quad_pen = new Pen(Color.Red);

            float standard_origin_x = QuadraticPlayingField.Width / 2;
            float standard_origin_y = QuadraticPlayingField.Height / 2;

            float origin_x = standard_origin_x;
            float origin_y = standard_origin_y;

            Point[] points = new Point[9];
            int index = 0;

            for (float x = -240; x <= 240; x += 60)
            {
                float y = (a * (x * x)) + (b * x) + c;
                points[index++] = new Point((int)(origin_x + x) , (int)(origin_y - y));
                Console.WriteLine("x: " + x + " y: " + y);
                Console.WriteLine("origin_x: " + origin_x + " origin_y: "+ origin_y);
            }
            g.DrawCurve(quad_pen, points);
        }

        void DrawCubic(float a, float b, float c, float d)
        {
            Graphics g = CubicPlayingField.CreateGraphics();
            Pen cubic_pen = new Pen(Color.Green);

            int standard_origin_x = QuadraticPlayingField.Width / 2;
            int standard_origin_y = QuadraticPlayingField.Height / 2;

            int origin_x = standard_origin_x;
            int origin_y = standard_origin_y;


            Point[] points = new Point[9];
            int index = 0;

            for (int x = -240; x <= 240; x += 60)
            {
                int relative_x = x / 60;
                float y = 50 * ((a * (relative_x * relative_x * relative_x)) + (b * relative_x * relative_x) + (c * relative_x) + d);
                points[index++] = new Point(origin_x + x, (int)(origin_y - y));
                Console.WriteLine(" x: " + x + " y: " + y);
            }
            g.DrawCurve(cubic_pen, points);
        }

        void DrawCircle(float h, float k, float r, bool need_X_axis, bool need_Y_axis)
        {
            Graphics g = CirclePlayingField.CreateGraphics();//
            Pen circle_pen = new Pen(Color.Blue);

            int standard_origin_x = CirclePlayingField.Width / 2; // get this depending on if you use the "Y" axis or not. If the "Y" axis is not needed, then decrease this value
            int standard_origin_y = CirclePlayingField.Height / 2; // get this depending on if you use the "X" axis or not. If the "X" axis is not needed, then increase this value
            int origin_x = 150, origin_y = 150;

    

            float startX = origin_x - 50;
            float endX = origin_x + 50;

            float relative_endX = endX - origin_x;

            if (!need_Y_axis)
            {
                origin_x -= 150;
            }
            if(!need_X_axis)
            {
                origin_y += 150;
            }

            g.DrawEllipse(circle_pen, (origin_x - r) + h, (origin_y - r) - k, r * 2, r * 2);
            Console.WriteLine("origin_x for circle: " + origin_x + " origin_y: " + origin_y + " k: " + k + " h: " + h + " r: " + r);
            Console.WriteLine("standard_origin_x: " + standard_origin_x + " standard_origin_y: " + standard_origin_y );
        }

        private void DisplayError(string formula)
        {
            switch(formula)
            {
                case "line":
                    MessageBox.Show(string.Format("Please make sure to enter numbers for line formula."), "Ok", MessageBoxButtons.OK);
                    break;
                case "quadratic":
                    MessageBox.Show(string.Format("Please make sure to enter numbers for quadratic formula."), "Ok", MessageBoxButtons.OK);
                    break;
                case "cubic":
                    MessageBox.Show(string.Format("Please make sure to enter numbers for cubic formula."), "Ok", MessageBoxButtons.OK);
                    break;
                case "circle":
                    MessageBox.Show(string.Format("Please make sure to enter numbers for circle formula."), "Ok", MessageBoxButtons.OK);
                    break;
                default:
                    MessageBox.Show(string.Format("Please make sure to enter numbers for formula."), "Ok", MessageBoxButtons.OK);
                    break;
            }

            //if (formula == "line")
            //{
            //    MessageBox.Show(string.Format("Please make sure to enter numbers for line graph."), "Ok", MessageBoxButtons.OK);
            //}
            //if (formula == "quadratic")
            //{
            //    MessageBox.Show(string.Format("Please make sure to enter numbers for quadratic graph."), "Ok", MessageBoxButtons.OK);
            //}
            //if (formula == "cubic")
            //{
            //    MessageBox.Show(string.Format("Please make sure to enter numbers for cubic graph."), "Ok", MessageBoxButtons.OK);
            //}
            //if (formula == "circle")
            //{
            //    MessageBox.Show(string.Format("Please make sure to enter numbers for circle graph."), "Ok", MessageBoxButtons.OK);
            //}
        }

        private void DrawYAxis(PictureBox p, bool need_it_for_line, bool need_it_for_quadratic, bool need_it_for_cubic, bool need_it_for_circle)
        {
            if (need_it_for_line == true)
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, (Playing_Field.Width / 2), 0,
                              (Playing_Field.Width / 2), Playing_Field.Height);
            }
            else
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, (Playing_Field.Width / 2) - 150, 0,
                              (Playing_Field.Width / 2) - 150, Playing_Field.Height);
            }
            if (need_it_for_quadratic == true)
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, (QuadraticPlayingField.Width / 2), 0,
                               (QuadraticPlayingField.Width / 2), QuadraticPlayingField.Height);
            }
            else
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, (QuadraticPlayingField.Width / 2) - 150, 0,
                               (QuadraticPlayingField.Width / 2) - 150, QuadraticPlayingField.Height);
            }
            if (need_it_for_cubic == true)
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, (CubicPlayingField.Width / 2), 0,
                              (CubicPlayingField.Width / 2), CubicPlayingField.Height);
            }
            else
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, (CubicPlayingField.Width / 2) - 150, 0,
                              (CubicPlayingField.Width / 2) - 150, CubicPlayingField.Height);
            }
            if (need_it_for_circle == true)
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, (CirclePlayingField.Width / 2), 0,
                              (CirclePlayingField.Width / 2), CirclePlayingField.Height);
            }
            else
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, (CirclePlayingField.Width / 2) - 150, 0,
                              (CirclePlayingField.Width / 2) - 150, CirclePlayingField.Height);
            }
        }

        private void DrawXAxis(PictureBox p, bool need_it_for_line, bool need_it_for_quadratic, bool need_it_for_cubic, bool need_it_for_circle)
        {
            Graphics g = p.CreateGraphics();

            if (need_it_for_line == true)
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, 0, (Playing_Field.Height / 2),
                                   Playing_Field.Width, (Playing_Field.Height / 2));
            }
            else
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, 0, (Playing_Field.Height / 2) + 150,
                                   Playing_Field.Width, (Playing_Field.Height / 2) + 150);
            }
            if (need_it_for_quadratic == true)
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, 0, (QuadraticPlayingField.Height / 2),
                                                      QuadraticPlayingField.Width, (QuadraticPlayingField.Height / 2));
            }
            else
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, 0, (QuadraticPlayingField.Height / 2) + 150,
                                                      QuadraticPlayingField.Width, (QuadraticPlayingField.Height / 2) + 150);
            }
            if (need_it_for_cubic == true)
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, 0, (CubicPlayingField.Height / 2),
                                                      CubicPlayingField.Width, (CubicPlayingField.Height / 2));
            }
            else
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, 0, (CubicPlayingField.Height / 2) + 150,
                                                      CubicPlayingField.Width, (CubicPlayingField.Height / 2) + 150);
            }
            if (need_it_for_circle == true)
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, 0, (CirclePlayingField.Height / 2),
                                                     CirclePlayingField.Width, (CirclePlayingField.Height / 2));
            }
            else
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, 0, (CirclePlayingField.Height / 2) + 150,
                                                     CirclePlayingField.Width, (CirclePlayingField.Height / 2) + 150);
            }
        }

        private void DrawTicks(PictureBox p, bool need_x_axis, bool need_y_axis)
        {
            Graphics g = p.CreateGraphics();

            int minX = -150;
            int maxX = 150;
            int minY = -150;
            int maxY = 150; int x_interval = 15;
            int y_interval = 15;

            if (need_x_axis && need_y_axis)
            {
                for (int u = minX; u <= maxX; u += x_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(u), VisibleY(-5), VisibleX(u), VisibleY(5));
                    g.DrawString(u.ToString(), new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(u), VisibleY(-5));
                }
                for (int v = minY; v <= maxY; v += y_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(-5), VisibleY(v), VisibleX(5), VisibleY(v));
                    g.DrawString(v.ToString(), new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(-5), VisibleY(v));
                }
            }
            else if (need_x_axis)
            {
                for (int u = minX; u <= maxX; u += x_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(u), VisibleY(-5), VisibleX(u), VisibleY(5));
                    g.DrawString(u.ToString(), new Font(FontFamily.GenericSansSerif, 4, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(u), VisibleY(-5));
                }
                for (int v = minY; v <= maxY; v += y_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(-5) - 150, VisibleY(v), VisibleX(5) - 150, VisibleY(v));
                    g.DrawString(v.ToString(), new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(-5), VisibleY(v));
                }
            }
            else if (need_y_axis)
            {
                for (int u = minX; u <= maxX; u += x_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(u), VisibleY(-5) + 150, VisibleX(u), VisibleY(5) + 150);
                    g.DrawString(u.ToString(), new Font(FontFamily.GenericSansSerif, 4, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(u), VisibleY(-5) + 140);
                }
                for (int v = minY; v <= maxY; v += y_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(-5), VisibleY(v), VisibleX(5), VisibleY(v));
                    g.DrawString(v.ToString(), new Font(FontFamily.GenericSansSerif, 5, FontStyle.Regular),
            new SolidBrush(Color.White), VisibleX(-5), VisibleY(v));
                }
            }
            else
            {
                for (int u = minX; u <= maxX; u += x_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(u), VisibleY(-5) + 150, VisibleX(u), VisibleY(5) + 150);
                }
                for (int v = minY; v <= maxY; v += y_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(-5) - 150, VisibleY(v), VisibleX(5) - 150, VisibleY(v));
                }
            }
        }

        int VisibleX(int x_value)
        {
            return 150 + x_value;
        }

        int VisibleY(int y_value)
        {
            return 150 - y_value;
        }

        private void CalculateEquationsBtn_Click(object sender, EventArgs e)
        {
            Graphics lg = Playing_Field.CreateGraphics();
            Graphics qg = QuadraticPlayingField.CreateGraphics();
            Graphics cubic_g = CubicPlayingField.CreateGraphics();
            Graphics cg = CirclePlayingField.CreateGraphics();
            SolidBrush paintItBlack = new SolidBrush(Color.Black);

            if ( ( LineMTextBox.Text != "" &&
                ( Regex.IsMatch(LineMTextBox.Text, @"^\d+$") || Regex.IsMatch(LineMTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )  
                && ( LineBTextBox.Text != "" 
                && ( Regex.IsMatch(LineBTextBox.Text, @"^\d+$") || Regex.IsMatch(LineBTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) )
            {
                
                lg.FillRectangle(paintItBlack, 0, 0, Playing_Field.Width, Playing_Field.Height);
                float m_for_Line = (float)Convert.ToDouble(LineMTextBox.Text);
                float b_for_Line = (float)Convert.ToDouble(LineBTextBox.Text);

                bool need_Y_for_line = b_for_Line != 0;
                bool need_X_for_line = b_for_Line < 0 || m_for_Line < 0;

                DrawXAxis(Playing_Field, need_X_for_line, false, false, false);
                DrawYAxis(Playing_Field, need_Y_for_line, false, false, false);
                DrawTicks(Playing_Field, need_X_for_line, need_Y_for_line);
                DrawLine(m_for_Line, b_for_Line, need_X_for_line, need_Y_for_line);               
            }
            if ( ( QuadraticATextBox.Text != "" && ( Regex.IsMatch(QuadraticATextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticATextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && ( QuadraticBTextBox.Text != "" && ( Regex.IsMatch(QuadraticBTextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticBTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && ( QuadraticCTextBox.Text != "" && ( Regex.IsMatch(QuadraticCTextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticCTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) )
            {
                qg.FillRectangle(paintItBlack, 0, 0, QuadraticPlayingField.Width, QuadraticPlayingField.Height);

                float a = (float)Convert.ToDouble(QuadraticATextBox.Text.ToString());
                float b = (float)Convert.ToDouble(QuadraticBTextBox.Text.ToString());
                float c = (float)Convert.ToDouble(QuadraticCTextBox.Text.ToString());

                bool need_Y_for_quad = true;
                bool need_X_for_quad = a < 0 || b < 0 || c < 0;

                // y = ax2 + bx + c 
                // Create pens.
                Pen redPen = new Pen(Color.Red);
                DrawXAxis(QuadraticPlayingField, false, need_X_for_quad, false, false);
                DrawYAxis(QuadraticPlayingField, false, need_Y_for_quad, false, false);
                DrawTicks(QuadraticPlayingField, need_X_for_quad, need_Y_for_quad);
                // Draw curve to screen.
                DrawQuadratic(a, b, c);
            }
            if ( ( CubicATextBox.Text != "" && ( Regex.IsMatch(CubicATextBox.Text, @"^\d+$") || Regex.IsMatch(CubicATextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && ( CubicBTextBox.Text != "" && ( Regex.IsMatch(CubicBTextBox.Text, @"^\d+$") || Regex.IsMatch(CubicBTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )
                && ( CubicCTextBox.Text != "" && ( Regex.IsMatch(CubicCTextBox.Text, @"^\d+$") || Regex.IsMatch(CubicCTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )
                && ( CubicDTextBox.Text != "" && ( Regex.IsMatch(CubicDTextBox.Text, @"^\d+$") || Regex.IsMatch(CubicDTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) )
            {
                cubic_g.FillRectangle(paintItBlack, 0, 0, CubicPlayingField.Width, CubicPlayingField.Height);

                float cubicA = (float)Convert.ToDouble(CubicATextBox.Text);
                float cubicB = (float)Convert.ToDouble(CubicBTextBox.Text);
                float cubicC = (float)Convert.ToDouble(CubicCTextBox.Text);
                float cubicD = (float)Convert.ToDouble(CubicDTextBox.Text);

                bool need_Y_for_Cubic = true;
                bool need_X_for_Cubic = true;

                DrawXAxis(CubicPlayingField, false, false, need_X_for_Cubic, false);
                DrawYAxis(CubicPlayingField, false, false, need_Y_for_Cubic, false);
                DrawTicks(CubicPlayingField, need_X_for_Cubic, need_Y_for_Cubic);
                // Draw curve to screen.
                DrawCubic(cubicA, cubicB, cubicC, cubicD);
            }
            if ( ( HCircleTextBox.Text != "" && ( Regex.IsMatch(HCircleTextBox.Text, @"^\d+$") || Regex.IsMatch(HCircleTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )
                && ( KCircleTextBox.Text != "" && ( Regex.IsMatch(KCircleTextBox.Text, @"^\d+$") || Regex.IsMatch(KCircleTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && RCircleTextBox.Text != "" && ( Regex.IsMatch(RCircleTextBox.Text, @"^\d+$") || Regex.IsMatch(RCircleTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )
            {
                cg.FillRectangle(paintItBlack, 0, 0, CirclePlayingField.Width, CirclePlayingField.Height);

                float h = (float)Convert.ToDouble(HCircleTextBox.Text);
                float k = (float)Convert.ToDouble(KCircleTextBox.Text);
                float r = (float)Convert.ToDouble(RCircleTextBox.Text);

                bool need_Y_for_circle = k < 0;
                bool need_X_for_circle = h < 0;

                DrawXAxis(CirclePlayingField, false, false, false, need_X_for_circle);
                DrawYAxis(CirclePlayingField, false, false, false, need_Y_for_circle);
                DrawTicks(CirclePlayingField, need_X_for_circle, need_Y_for_circle);
                DrawCircle(h, k, r, need_X_for_circle, need_Y_for_circle);
            }
            //else
            //{
            //    DisplayError("other");
            //}
        }

        private void Playing_Field_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Graphics g = pictureBox1.CreateGraphics();
            //if (QuadraticATextBox.Text != "" || QuadraticBTextBox.Text != "" || QuadraticCTextBox.Text != "")
            //{
            //    int a = Convert.ToInt32(QuadraticATextBox.Text.ToString());
            //    int b = Convert.ToInt32(QuadraticBTextBox.Text.ToString());
            //    int c = Convert.ToInt32(QuadraticCTextBox.Text.ToString());

            //    Point[] points = new Point[7];
            //    int index = 0;

            //    for (int x = -3; x <= 3; x++)
            //    {
            //        int y = -1 * (a * (x * x)) + (b * x) + c;
            //        points[index] = new Point(500 + (10 * x), (10 * y) + 200);
            //        index++;
            //    }

            //    // y = ax2 + bx + c 
            //    // Create pens.
            //    Pen redPen = new Pen(Color.Red, 3);

            //    float tension = 1.0F;

            //    // Draw curve to screen.
            //    g.DrawCurve(redPen, points, tension);
            //}

        } 

        private void LineMTextBox_Enter(object sender, EventArgs e)
        {
            //if(LineMTextBox.Text.CompareTo("1") == 0 )
            //{

            //}
            LineMTextBox.Text = "";
            LineMTextBox.ForeColor = Color.Black;
        }

        private void HCircleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Coordinate
    {
        public int x;
        public int y;

        public Coordinate (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
