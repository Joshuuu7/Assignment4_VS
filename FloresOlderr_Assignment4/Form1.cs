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

        void DrawLine(float m, float b, bool x_axis_needed, bool y_axis_needed)
        {
            Graphics g = Playing_Field.CreateGraphics();
            Pen line_pen = new Pen(Color.Green);

            int standard_origin_x = Playing_Field.Width / 2; // get this depending on if you use the "Y" axis or not. If the "Y" axis is not needed, then decrease this value
            int standard_origin_y = Playing_Field.Height / 2; // get this depending on if you use the "X" axis or not. If the "X" axis is not needed, then increase this value
            int origin_x, origin_y;

            if (x_axis_needed && y_axis_needed)
            {
                origin_x = standard_origin_x;
                origin_y = standard_origin_y;
            }
            else if (x_axis_needed)
            {
                origin_x = standard_origin_x - 100;
                origin_y = standard_origin_y;
            }
            else if (y_axis_needed)
            {
                origin_x = standard_origin_x;
                origin_y = standard_origin_y + 100;
            }
            else
            {
                origin_x = standard_origin_x - 100;
                origin_y = standard_origin_y + 100;
            }
            
            float startX = origin_x - 100;
            float endX = origin_x + 100;

            float relative_startX = startX - origin_x;
            float relative_endX = endX - origin_x;
            float startY = ((-1 * m * relative_startX) - b) + origin_y;
            float endY = ((-1 * m * relative_endX) - b) + origin_y;         

            g.DrawLine(line_pen, startX, startY, endX, endY); 
        }

        void DrawQuadratic(int a, int b, int c, bool need_x_axis, bool need_y_axis)
        {
            Graphics g = QuadraticPlayingField.CreateGraphics();//
            Pen quad_pen = new Pen(Color.Red);

            int standard_origin_x = QuadraticPlayingField.Width / 2;
            int standard_origin_y = QuadraticPlayingField.Height / 2;

            int origin_x = standard_origin_x;
            int origin_y = standard_origin_y;

            if (need_x_axis && !need_y_axis)
            {
                origin_x -= 50;
            }
            else if (!need_x_axis && need_y_axis)
            {
                origin_y -= 50;
            }
            else if (!(need_x_axis || need_y_axis))
            {
                origin_x -= 50;
                origin_y -= 50;
            }

            Point[] points = new Point[9];
            int index = 0;

            for (int x = -240; x <= 240; x += 60)
            {
                int y = (a * (x * x)) + (b * x) + c;
                points[index++] = new Point(origin_x + x , origin_y - y);
                Console.WriteLine("x: " + x + " y: " + y);
                Console.WriteLine("origin_x: " + origin_x + " origin_y: "+ origin_y);
            }
            g.DrawCurve(quad_pen, points);
        }

        void DrawCubic(int a, int b, int c, int d, bool need_x_axis, bool need_y_axis)
        {
            Graphics g = CubicPlayingField.CreateGraphics();
            Pen cubic_pen = new Pen(Color.Green);

            int standard_origin_x = QuadraticPlayingField.Width / 2;
            int standard_origin_y = QuadraticPlayingField.Height / 2;

            int origin_x = standard_origin_x;
            int origin_y = standard_origin_y;

            if (need_x_axis && !need_y_axis)
            {
                origin_x -= 50;
            }
            else if (!need_x_axis && need_y_axis)
            {
                origin_y -= 50;
            }
            else if (!(need_x_axis || need_y_axis))
            {
                origin_x -= 50;
                origin_y -= 50;
            }

            Point[] points = new Point[9];
            int index = 0;

            for (int x = -240; x <= 240; x += 60)
            {
                int relative_x = x / 60;
                int y = 50 * ((a * (relative_x * relative_x * relative_x)) + (b * relative_x * relative_x) + (c * relative_x) + d);
                points[index++] = new Point(origin_x + x, origin_y - y);
                Console.WriteLine(" x: " + x + " y: " + y);
            }
            g.DrawCurve(cubic_pen, points);
        }

        void DrawCircle(float h, float k, float r, bool x_axis_needed, bool y_axis_needed)
        {
            Graphics g = CirclePlayingField.CreateGraphics();//
            Pen circle_pen = new Pen(Color.Blue);

            int standard_origin_x = CirclePlayingField.Width / 2;// get this depending on if you use the "Y" axis or not. If the "Y" axis is not needed, then decrease this value
            int standard_origin_y = CirclePlayingField.Height / 2;// get this depending on if you use the "X" axis or not. If the "X" axis is not needed, then increase this value
            int origin_x, origin_y;

            if (x_axis_needed && y_axis_needed)
            {
                origin_x = standard_origin_x;
                origin_y = standard_origin_y;
            }
            else if (x_axis_needed)
            {
                origin_x = standard_origin_x - 50;
                origin_y = standard_origin_y;
            }
            else if (y_axis_needed)
            {
                origin_x = standard_origin_x;
                origin_y = standard_origin_y + 50;
            }
            else
            {
                origin_x = standard_origin_x - 50;
                origin_y = standard_origin_y + 50;
            }

            float startX = origin_x - 50;
            float endX = origin_x + 50;

            float relative_endX = endX - origin_x;

            //g.DrawEllipse(circle_pen, origin_x + (r / 2), origin_y - (r / 2), r * 2, r * 2);
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

        private void DrawTicks(PictureBox p, bool need_x_axis, bool need_y_axis)
        {
            Graphics g = p.CreateGraphics();

            int minX = -150;
            int maxX = 150;
            int x_interval = 15;

            if (need_x_axis && need_y_axis)
            {
                for (int u = minX; u <= maxX; u+= x_interval)
                {
                    g.DrawLine(myWhitePen, VisibleX(u), VisibleY(-5), VisibleX(u), VisibleY(5));
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

        private bool IsFloat(string input_string)
        {
            bool isFloat = float.TryParse(input_string, out float float_string);
            if (isFloat)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void CalculateEquationsBtn_Click(object sender, EventArgs e)
        {
            Graphics lg = Playing_Field.CreateGraphics();
            Graphics qg = QuadraticPlayingField.CreateGraphics();
            Graphics cubic_g = CubicPlayingField.CreateGraphics();
            Graphics cg = CirclePlayingField.CreateGraphics();
            SolidBrush paintItBlack = new SolidBrush(Color.Black);

            if ( ( LineMTextBox.Text != "" && ( Regex.IsMatch(LineMTextBox.Text, @"^\d+$") || Regex.IsMatch(LineMTextBox.Text, @"^[-+]?\d+\.?\d*$") ) )  
                && ( LineBTextBox.Text != "" && ( Regex.IsMatch(LineBTextBox.Text, @"^\d+$") || Regex.IsMatch(LineBTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) )
            {
                
                lg.FillRectangle(paintItBlack, 0, 0, Playing_Field.Width, Playing_Field.Height);
                float m = (float)Convert.ToDouble(LineMTextBox.Text);
                float b_For_Line = (float)Convert.ToDouble(LineBTextBox.Text);

                bool need_Y_for_line = b_For_Line < 0 && m < 0;
                bool need_X_for_line = b_For_Line <= 0 || m <= 0;

                DrawXAxis(Playing_Field, true, false, false, false);
                DrawYAxis(Playing_Field, true, false, false, false);
                DrawTicks(Playing_Field, true, true);
                DrawLine(m, b_For_Line, need_X_for_line, need_Y_for_line);               
            }
            if ( ( QuadraticATextBox.Text != "" && ( Regex.IsMatch(QuadraticATextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticATextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && ( QuadraticBTextBox.Text != "" && ( Regex.IsMatch(QuadraticBTextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticBTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) 
                && ( QuadraticCTextBox.Text != "" && (Regex.IsMatch(QuadraticCTextBox.Text, @"^\d+$") || Regex.IsMatch(QuadraticCTextBox.Text, @"^[-+]?\d+\.?\d*$") ) ) )
            {
                qg.FillRectangle(paintItBlack, 0, 0, QuadraticPlayingField.Width, QuadraticPlayingField.Height);

                int a = Convert.ToInt32(QuadraticATextBox.Text.ToString());
                int b = Convert.ToInt32(QuadraticBTextBox.Text.ToString());
                int c = Convert.ToInt32(QuadraticCTextBox.Text.ToString());
                
                // y = ax2 + bx + c 
                // Create pens.
                Pen redPen = new Pen(Color.Red);
                DrawXAxis(QuadraticPlayingField, false, true, false, false);
                DrawYAxis(QuadraticPlayingField, false, true, false, false);
                // Draw curve to screen.
                DrawQuadratic(a, b, c, true, true);
            }
            if (CubicATextBox.Text != "" && CubicBTextBox.Text != "" && CubicCTextBox.Text != "" && CubicDTextBox.Text != "")
            {
                cubic_g.FillRectangle(paintItBlack, 0, 0, CubicPlayingField.Width, CubicPlayingField.Height);

                int cubicA = Convert.ToInt32(CubicATextBox.Text);
                int cubicB = Convert.ToInt32(CubicBTextBox.Text);
                int cubicC = Convert.ToInt32(CubicCTextBox.Text);
                int cubicD = Convert.ToInt32(CubicDTextBox.Text);

                DrawXAxis(CubicPlayingField, false, false, true, false);
                DrawYAxis(CubicPlayingField, false, false, true, false);

                // Draw curve to screen.
                DrawCubic(cubicA, cubicB, cubicC, cubicD, true, true);
            }
            if ( HCircleTextBox.Text != "" && KCircleTextBox.Text != "" && RCircleTextBox.Text != "")
            {
                cg.FillRectangle(paintItBlack, 0, 0, CirclePlayingField.Width, CirclePlayingField.Height);

                float h = (float)Convert.ToDouble(HCircleTextBox.Text);
                float k = (float)Convert.ToDouble(KCircleTextBox.Text);
                float r = (float)Convert.ToDouble(RCircleTextBox.Text);

                bool need_Y_for_circle = k < 0 && h < 0;
                bool need_X_for_circle = k < 0 || h < 0;

                DrawXAxis(CirclePlayingField, false, false, false, true);
                DrawYAxis(CirclePlayingField, false, false, false, true);
                DrawCircle(h, k, r, true, true);
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

        private void DrawYAxis(PictureBox p,  bool need_it_for_line, bool need_it_for_quadratic, bool need_it_for_cubic, bool need_it_for_circle)
        {
            if (need_it_for_line == true)
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, (Playing_Field.Width / 2), 0,
                              (Playing_Field.Width / 2), Playing_Field.Height);
            }
            if (need_it_for_quadratic == true)
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, (QuadraticPlayingField.Width / 2), 0,
                               (QuadraticPlayingField.Width / 2), QuadraticPlayingField.Height);
            }
            if (need_it_for_cubic == true)
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, (CubicPlayingField.Width / 2), 0,
                              (CubicPlayingField.Width / 2), CubicPlayingField.Height);
            }
            if (need_it_for_circle == true)
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, (CirclePlayingField.Width / 2), 0,
                              (CirclePlayingField.Width / 2), CirclePlayingField.Height);
                Console.WriteLine("IN CIRCLE Y (axis): " + CirclePlayingField.Width / 2);
            }
        }

        private void DrawXAxis(PictureBox p, bool need_it_for_line, bool need_it_for_quadratic, bool need_it_for_cubic, bool need_it_for_circle)
        {
            if (need_it_for_line == true)
            {
                p = Playing_Field;
                Graphics lg = Playing_Field.CreateGraphics();
                lg.DrawLine(myWhitePen, 0, (Playing_Field.Height / 2),
                                   Playing_Field.Width, (Playing_Field.Height / 2));
            }
            if (need_it_for_quadratic == true)
            {
                p = QuadraticPlayingField;
                Graphics qg = QuadraticPlayingField.CreateGraphics();
                qg.DrawLine(myWhitePen, 0, (QuadraticPlayingField.Height / 2),
                                                      QuadraticPlayingField.Width, (QuadraticPlayingField.Height / 2));
            }
            if (need_it_for_cubic == true)
            {
                p = CubicPlayingField;
                Graphics cubic_g = CubicPlayingField.CreateGraphics();
                cubic_g.DrawLine(myWhitePen, 0, (CubicPlayingField.Height / 2),
                                                      CubicPlayingField.Width, (CubicPlayingField.Height / 2));
            }
            if (need_it_for_circle == true)
            {
                p = CirclePlayingField;
                Graphics cg = CirclePlayingField.CreateGraphics();
                cg.DrawLine(myWhitePen, 0, (CirclePlayingField.Height / 2),
                                                     CirclePlayingField.Width, (CirclePlayingField.Height / 2));
                Console.WriteLine("IN CIRCLE X (axis): " + CirclePlayingField.Height / 2);
            }
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
