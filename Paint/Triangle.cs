using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Triangle : Shape
    {
        private readonly SolidBrush brush;
        private readonly Pen selectionPen;
        private PointF center;
        private readonly PointF[] vertices;
        private bool isSelected;
        private float sideLength { set; get; }

        public Triangle(PointF center, float sideLength, Color color)
        {
            this.sideLength = sideLength;
            brush = new SolidBrush(color);
            selectionPen = new Pen(Color.AliceBlue, 4);
            isSelected = false;
            vertices = CalculateVertices(center, sideLength);
        }

        private PointF[] CalculateVertices(PointF center, float sideLength)
        {
            float height = (float)(Math.Sqrt(3) / 2 * sideLength);
            PointF vertex1 = new PointF(center.X, center.Y - (2.0f / 3.0f) * height);
            PointF vertex2 = new PointF(center.X - sideLength / 2, center.Y + (1.0f / 3.0f) * height);
            PointF vertex3 = new PointF(center.X + sideLength / 2, center.Y + (1.0f / 3.0f) * height);

            return new PointF[] { vertex1, vertex2, vertex3 };
        }

        public override void GetSize()
        {
            Console.WriteLine(sideLength);
        }

        public override void Fill(Graphics g)
        {
            g.FillPolygon(brush, vertices);

            if (isSelected)
            {
                DrawFrame(g);
            }
        }

        public override void DrawFrame(Graphics g)
        {
            g.DrawPolygon(selectionPen, vertices);
        }

        public override bool Contains(Point point)
        {
            PointF v0 = vertices[0];
            PointF v1 = vertices[1];
            PointF v2 = vertices[2];

            float dX = point.X - v2.X;
            float dY = point.Y - v2.Y;
            float dX21 = v2.X - v1.X;
            float dY12 = v1.Y - v2.Y;
            float D = dY12 * (v0.X - v2.X) + dX21 * (v0.Y - v2.Y);
            float s = dY12 * dX + dX21 * dY;
            float t = (v2.Y - v0.Y) * dX + (v0.X - v2.X) * dY;

            if (D < 0) return s <= 0 && t <= 0 && s + t >= D;
            return s >= 0 && t >= 0 && s + t <= D;
        }

        public override void Selected()
        {
            isSelected = true;
        }

        public override void DeSelected()
        {
            isSelected = false;
        }

        public override float GetPerimeter()
        {
            return 3 * Distance(vertices[0], vertices[1]);
        }

        public override float GetArea()
        {
            float sideLength = Distance(vertices[0], vertices[1]);
            return (float)(Math.Sqrt(3) / 4 * sideLength * sideLength);
        }

        private float Distance(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public override void ChangeColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = brush.Color;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                brush.Color = colorDialog.Color;
            }
        }

        public override Color GetColor()
        {
            return brush.Color;
        }
    }
}
