using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            string selectedShape = comboBoxShape.SelectedItem.ToString();
            Bitmap bmp = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            if (selectedShape == "Bezier Curve")
            {
                // Отримання координат точок для кривої Безьє
                float x1 = float.Parse(textBoxX1.Text);
                float y1 = float.Parse(textBoxY1.Text);
                float x2 = float.Parse(textBoxX2.Text);
                float y2 = float.Parse(textBoxY2.Text);
                float x3 = float.Parse(textBoxX3.Text);
                float y3 = float.Parse(textBoxY3.Text);
                float x4 = float.Parse(textBoxX4.Text);
                float y4 = float.Parse(textBoxY4.Text);

                // Побудова кривої Безьє
                Pen pen = new Pen(Color.Blue, 2);
                PointF[] bezierPoints = {
                    new PointF(x1, y1),
                    new PointF(x2, y2),
                    new PointF(x3, y3),
                    new PointF(x4, y4)
                };
                g.DrawBeziers(pen, bezierPoints);
            }
            else if (selectedShape == "Koch Fractal")
            {
                // Отримання координат вершин трикутника та порядку фракталу Коха
                float x1 = float.Parse(textBoxX1.Text);
                float y1 = float.Parse(textBoxY1.Text);
                float x2 = float.Parse(textBoxX2.Text);
                float y2 = float.Parse(textBoxY2.Text);
                float x3 = float.Parse(textBoxX3.Text);
                float y3 = float.Parse(textBoxY3.Text);
                int order = int.Parse(textBoxOrder.Text);

                Pen pen = new Pen(Color.Red, 2);
                DrawKochFractal(g, pen, new PointF(x1, y1), new PointF(x2, y2), order);
                DrawKochFractal(g, pen, new PointF(x2, y2), new PointF(x3, y3), order);
                DrawKochFractal(g, pen, new PointF(x3, y3), new PointF(x1, y1), order);
            }

            pictureBoxCanvas.Image = bmp;
        }

        private void DrawKochFractal(Graphics g, Pen pen, PointF p1, PointF p2, int order)
        {
            if (order == 0)
            {
                g.DrawLine(pen, p1, p2);
            }
            else
            {
                PointF a = new PointF(
                    (2 * p1.X + p2.X) / 3,
                    (2 * p1.Y + p2.Y) / 3);

                PointF b = new PointF(
                    (2 * p2.X + p1.X) / 3,
                    (2 * p2.Y + p1.Y) / 3);

                float angle = (float)Math.PI / 3;
                float dx = b.X - a.X;
                float dy = b.Y - a.Y;
                PointF c = new PointF(
                    (float)(a.X + dx * Math.Cos(angle) - dy * Math.Sin(angle)),
                    (float)(a.Y + dx * Math.Sin(angle) + dy * Math.Cos(angle)));

                DrawKochFractal(g, pen, p1, a, order - 1);
                DrawKochFractal(g, pen, a, c, order - 1);
                DrawKochFractal(g, pen, c, b, order - 1);
                DrawKochFractal(g, pen, b, p2, order - 1);
            }
        }
    }
}
