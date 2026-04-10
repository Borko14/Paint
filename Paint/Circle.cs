using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class Circle : Shape
    {
        private readonly SolidBrush brush;
        private PointF center;
        private SizeF size { set; get; }
        private bool isSelected;
        private readonly Pen selectionPen;

        public Circle(PointF center, SizeF size, Color color)
        {
            this.center = center;
            this.size = size;
            isSelected = false;
            brush = new SolidBrush(color);
            selectionPen = new Pen(Color.AliceBlue, 4);
        }

        public override void Fill(Graphics g)
        {
            float x = center.X - size.Width / 2;
            float y = center.Y - size.Height / 2;
            float width = size.Width;
            float height = size.Height;
            g.FillEllipse(brush, x, y, width, height);
            if(isSelected) { DrawFrame(g); }
        }

        public override bool Contains(Point point)
        {
            float halfWidth = size.Width / 2;
            float halfHeight = size.Height / 2;

            float left = center.X - halfWidth;
            float right = center.X + halfWidth;
            float top = center.Y - halfHeight;
            float bottom = center.Y + halfHeight;

            return point.X >= left && point.X <= right && point.Y >= top && point.Y <= bottom;
        }

        public override void GetSize()
        {
            Console.WriteLine(size);
        }

        public override void DrawFrame(Graphics g)
        {
            g.DrawEllipse(selectionPen, center.X - size.Width / 2, center.Y - size.Height / 2, size.Width, size.Height);
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
            float radius = size.Width / 2;
            return 2 * MathF.PI * radius;
        }

        public override float GetArea()
        {
            float radius = size.Width / 2;
            return MathF.PI * radius * radius;
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
