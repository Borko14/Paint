using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Square : Shape
    {
        private readonly SolidBrush brush;
        private PointF center;
        private SizeF size { set; get; }
        private bool isSelected;
        private readonly Pen selectionPen;

        public Square(PointF center, SizeF size, Color color)
        {
            this.center = center; 
            this.size = size;
            brush = new SolidBrush(color);
            selectionPen = new Pen(Color.AliceBlue, 4);
        }

        public override void Fill(Graphics g)
        {
            g.FillRectangle(brush, center.X - size.Width / 2, center.Y - size.Height / 2, size.Width, size.Height);
            if (isSelected) { DrawFrame(g); }
        }

        public override void DrawFrame(Graphics g)
        {
            g.DrawRectangle(selectionPen, center.X - size.Width / 2, center.Y - size.Height / 2, size.Width, size.Height);
        }

        public override void GetSize()
        {
            Console.WriteLine(size);
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
            return size.Width * 2;
        }

        public override float GetArea()
        {
            return size.Width * 4;
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