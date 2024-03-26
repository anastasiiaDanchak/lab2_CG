using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2_CG
{
    public partial class Form1 : Form
    {

        Bitmap image;
        List<PointF> points = new List<PointF>();
        Pen penLine = new Pen(Color.Blue, 3);
        bool big = false;
        float max = 0;
        int selectMethod = 0;
        float[,] matrixN;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(500, 500);
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(image).Clear(Color.White);

            pictureBox1.Image = image;

            comboBox_calculationMethod.SelectedIndex = 0;
            textBox_t1.Text = "0,0";
            textBox_t2.Text = "1,0";
            textBox_X.Text = "100";
            textBox_Y.Text = "100";
            textBox_startX.Text = "100";
            textBox_endX.Text = "200";
            textBox_noRow.Text = "0";
        }

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            if (textBox_X.Text == "" || textBox_Y.Text == "")
            {
                MessageBox.Show("You have not entered the coordinates of the point");
            }
            else
            {
                Graphics.FromImage(image).Clear(Color.White);
                PointF point = new PointF(Convert.ToSingle(textBox_X.Text), Convert.ToSingle(textBox_Y.Text));
                points.Add(point);


                List<PointF> newPoints = new List<PointF>();
                if ((point.X > 500 || point.Y > 500) || (big == true))
                {
                    big = true;
                    float newMax = point.X > point.Y ? point.X : point.Y;
                    max = newMax > max ? newMax : max;
                    foreach (var p in points)
                    {
                        if (p.X == 0)
                            newPoints.Add(new PointF(0, pictureBox1.Height - (((500 - 10) * p.Y) / max)));

                        else if (p.Y == 0)
                            newPoints.Add(new PointF((((500 - 10) * p.X) / max), pictureBox1.Height - 0));

                        else
                            newPoints.Add(new PointF((((500 - 10) * p.X) / max), pictureBox1.Height - (((500 - 10) * p.Y) / max)));
                    }
                    DrawPoints(newPoints, points);

                    if (points.Count > 1)
                    {
                        if (selectMethod == 1)
                            BuildBezie(points);

                        else if (selectMethod == 2)
                        {
                            BuildBezieMatrix(points);

                        }

                        else
                            MessageBox.Show("You have not selected a calculation method");
                    }
                }
                else if (big == false)
                {
                    foreach (var p in points)
                    {
                        newPoints.Add(new PointF(p.X, pictureBox1.Height - p.Y));
                    }
                    DrawPoints(newPoints, points);
                    if (points.Count > 1)
                    {
                        if (selectMethod == 1)
                            BuildBezie(newPoints);

                        else if (selectMethod == 2)
                        {
                            BuildBezieMatrix(newPoints);

                        }

                        else
                            MessageBox.Show("You have not selected a calculation method");
                    }
                }
                pictureBox1.Image = image;
            }

        }
        private void DrawPoints(List<PointF> realCenter, List<PointF> center)
        {

            Brush brush = Brushes.Green;

            for (int i = 0; i < center.Count; i++)
            {
                Graphics.FromImage(image).FillEllipse(brush, realCenter[i].X - 3, realCenter[i].Y - 3, 6, 6);
                Graphics.FromImage(image).DrawString("(" + center[i].X + ";" + center[i].Y + ")", DefaultFont, brush, realCenter[i].X + 5, realCenter[i].Y - 15);
            }
        }

        public void BuildBezie(List<PointF> P)
        {


            float t1 = float.Parse(textBox_t1.Text);
            float t2 = float.Parse(textBox_t2.Text);
            float step = (t2 - t1) / 50.0f;
            PointF currentPoint = P[0];
            PointF lastPoint;
            DrawCharacteristicLine(P);
            for (float t = t1, i = 0; t < t2; t += step, i++)
            {
                lastPoint = currentPoint;
                currentPoint.X = Bezie_X(P, t);
                currentPoint.Y = Bezie_Y(P, t);

                Graphics.FromImage(image).DrawLine(penLine, lastPoint, currentPoint);
            }

        }
        private void BuildBezierMatrix(List<PointF> P)
        {
            int n = P.Count;
            float t1 = float.Parse(textBox_t1.Text);
            float t2 = float.Parse(textBox_t2.Text);
            float step = (t2 - t1) / 50.0f;
            DrawCharacteristicLine(P);
            Graphics g = Graphics.FromImage(image);
            PointF currentPoint;
            PointF lastPoint = P[0];


            float[] vectorT = new float[n + 1];
            matrixN = GenerateMatrixN(n);
            for (float t = t1; t <= t2; t += step)
            {
              

                vectorT = GenerateVectorT(n, t);
                currentPoint = CalculateBezierPoint(P, vectorT, matrixN);
                g.DrawLine(penLine, lastPoint, currentPoint);
                lastPoint = currentPoint;


            }


            pictureBox1.Image = image;
        }


        private PointF CalculateBezierPoint(List<PointF> P, float[] vectorT, float[,] matrixN)
        {
            int n = P.Count;
            PointF result = new PointF();

            for (int j = 0; j < n; j++)
            {
                result.X += vectorT[j] * matrixN[j, j] * P[j].X;
                result.Y += vectorT[j] * matrixN[j, j] * P[j].Y;

            }
            return result;
        }

        private float[] GenerateVectorT(int n, float t)
        {
            float[] vectorT = new float[n + 1];

            for (int i = 0; i < n; i++)
            {
                vectorT[i] = (float)Math.Pow(t, n - i);
            }

            return vectorT;
        }

        private float[,] GenerateMatrixN(int n)
        {
            float[,] matrixN = new float[n + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    int sign;
                    if (n % 2 == 0)
                    {
                        sign = (i + j) % 2 == 0 ? 1 : -1;
                    }
                    else
                    {
                        sign = (i + j) % 2 == 0 ? -1 : 1;
                    }
                    matrixN[i, j] = sign * BinomialCoefficient(n, i) * BinomialCoefficient(n - i, j);
                }
            }

            return matrixN;
        }



        public float Bezie_X(List<PointF> P, float t)
        {
            float X = 0;
            int n = P.Count - 1;
            for (int i = 0; i <= n; i++)
            {
                X += P[i].X * Bernstein(n, i, t);
            }
            return X;
        }

        public float Bezie_Y(List<PointF> P, float t)
        {
            float Y = 0;
            int n = P.Count - 1;
            for (int i = 0; i <= n; i++)
            {
                Y += P[i].Y * Bernstein(n, i, t);
            }
            return Y;
        }

        private float Bernstein(int n, int i, float t)
        {
            return BinomialCoefficient(n, i) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }

        private void txt_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }

        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) || ch == 8) { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only numbers can be entered in this field.");
            }





        }

        private void button_selectMethod_Click(object sender, EventArgs e)
        {
            if (comboBox_calculationMethod.SelectedIndex == 0)
            {
                selectMethod = 1;
            }
            else if (comboBox_calculationMethod.SelectedIndex == 1)
            {
                selectMethod = 2;
            }
            else
            {
                selectMethod = 0;
            }
        }

        private void button_findPoints_Click(object sender, EventArgs e)
        {
            float startX = float.Parse(textBox_startX.Text);
            float endX = float.Parse(textBox_endX.Text);
            int count = 0;
            foreach (PointF point in points)
            {
                if (point.X >= startX && point.X <= endX)
                {
                    count++;
                }
            }
            MessageBox.Show($"The number of points in the interval {startX}-{endX}: {count}");
        }

        private void btn_findMatrixElements_Click(object sender, EventArgs e)
        {
            int row = int.Parse(textBox_noRow.Text);
            PrintMatrixRow(matrixN, row);

        }
        public static void PrintMatrixRow(float[,] matrix, int row)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (row < 0 || row >= rows)
            {
                MessageBox.Show($"The row with index {row} does not exist in the matrix.");
                return;
            }

            string elementsRows = "";

            for (int j = 0; j < cols; j++)
            {
                elementsRows += matrix[row, j] + " ";
            }

            MessageBox.Show($"Elements of row {row}: {elementsRows}");
        }

        private float BinomialCoefficient(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            float result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= (n - i + 1);
                result /= i;
            }
            return result;
        }

        private void CalculateDiagonalSum(float[,] matrix)
        {
            int n = matrix.GetLength(0);
            float mainDiagonalSum = 0;
            float secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[i, i];
            }


            for (int i = 0; i < n; i++)
            {
                secondaryDiagonalSum += matrix[i, n - 1 - i];
            }

            string message = $"The sum of the main diagonal: {mainDiagonalSum}\n";
            message += $"The sum of the side diagonal: {secondaryDiagonalSum}";

            MessageBox.Show(message, "The sum of the elements of the diagonals", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sumDiagonals_Click(object sender, EventArgs e)
        {
            CalculateDiagonalSum(matrixN);
        }

        private void DrawCharacteristicLine(List<PointF> points)
        {
            if (points.Count < 2)
            {
                MessageBox.Show("There must be at least two points to draw a line.");
                return;
            }

            Graphics g = Graphics.FromImage(image);
            Pen penLine = new Pen(Color.Red, 2);

            for (int i = 0; i < points.Count - 1; i++)
            {
                g.DrawLine(penLine, points[i], points[i + 1]);
            }

            pictureBox1.Image = image;
        }
        public void BuildBezieMatrix(List<PointF> P)
        {
            float step = (float)(1.0 / 50);
            PointF currentPoint = P[0];
            PointF lastPoint;
            DrawCharacteristicLine(P);
            int n = P.Count();
            matrixN = GenerateMatrixN(n);
            for (float t = 0, i = 0; t < 1; t += step, i++)
            {
                lastPoint = currentPoint;
                currentPoint.X = Bezier_X(P, t);
                currentPoint.Y = Bezier_Y(P, t);


                if (i > 1)
                    Graphics.FromImage(image).DrawLine(penLine, lastPoint, currentPoint);
            }
        }

        public float Bezier_X(List<PointF> P, float t)
        {

            float X;
            if (P.Count() == 2)
                return (1 - t) * P[0].X + t * P[1].X;
            else
                X = (1 - t) * Bezier_X(P.GetRange(0, P.Count() - 1), t) + t * Bezie_X(P.GetRange(1, P.Count() - 1), t);
            return X;
        }

        public float Bezier_Y(List<PointF> P, float t)
        {
            float Y;
            if (P.Count() == 2)
                return (1 - t) * P[0].Y + t * P[1].Y;
            else
                Y = (1 - t) * Bezier_Y(P.GetRange(0, P.Count() - 1), t) + t * Bezie_Y(P.GetRange(1, P.Count() - 1), t);
            return Y;
        }
        private void ClearPictureBox()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics.FromImage(image).Clear(Color.White);
                points.Clear();
            }
        }




        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
        }
    }
}
