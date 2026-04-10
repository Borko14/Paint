namespace Paint
{
    internal abstract class Shape
    {
        public abstract void Fill(Graphics g);
        public abstract bool Contains(Point point);

        public abstract float GetPerimeter();

        public abstract float GetArea();

        public abstract void Selected();

        public abstract void DeSelected();

        public abstract void GetSize();
        public abstract void DrawFrame(Graphics g);

        public abstract void ChangeColor();

        public abstract Color GetColor();
    }
}