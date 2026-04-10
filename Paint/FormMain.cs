using System;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;


namespace Paint
{
    public partial class FormMain : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private Color[] knownColors = new Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Purple, Color.White, Color.Pink };
        Random random = new Random();
        private Shape? selectedShape;
        private Image? loadedImage;
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                int randomSize = new Random().Next(100, 300);
                Point mouseLocation = new Point(e.Location.X, e.Location.Y);
                int randomIndex = random.Next(knownColors.Length);
                Color randomColor = knownColors[randomIndex];
                if (SquareButton.Checked == true)
                {
                    var square = new Square(e.Location, new SizeF(randomSize, randomSize), randomColor);
                    shapes.Add(square);
                }
                else if (CircleButton.Checked == true)
                {
                    var circle = new Circle(e.Location, new SizeF(randomSize, randomSize), randomColor);
                    shapes.Add(circle);
                }
                else if (TriangleButton.Checked == true)
                {
                    var triangle = new Triangle(e.Location, randomSize, randomColor);
                    shapes.Add(triangle);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                bool shapeFound = false;
                for (int i = shapes.Count - 1; i >= 0; --i)
                {
                    if (shapes[i].Contains(e.Location))
                    {
                        shapeFound = true;
                        if (selectedShape != null)
                        {
                            selectedShape.DeSelected();
                        }
                        selectedShape = shapes[i];
                        selectedShape.Selected();
                        shapes.Add(selectedShape);
                        shapes.RemoveAll(s => s.Equals(selectedShape));
                        shapes.Add(selectedShape);
                        break;
                    }
                    if(!shapeFound && selectedShape != null)
    {
                        selectedShape.DeSelected();
                        selectedShape = null;
                    }
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (loadedImage != null)
            {
                e.Graphics.DrawImage(loadedImage, new Point(0, 0));
            }

            foreach (Shape shape in shapes)
            {
                shape.Fill(e.Graphics);
            }

        }

        private void SumPerimeter_Click(object sender, EventArgs e)
        {
            Type shapeType = typeof(Shape);
            float totalPerimeter = 0;
            if (CircleButton.Checked == true)
            {
                shapeType = typeof(Circle);
            }
            else if (SquareButton.Checked == true)
            {
                shapeType = typeof(Square);
            }
            else if (TriangleButton.Checked == true)
            {
                shapeType = typeof(Triangle);
            }
            var filterTypes = shapes.Where(shapes => shapes.GetType() == shapeType);
            totalPerimeter = filterTypes.Sum(shapes => shapes.GetPerimeter());
            MessageBox.Show($"Total Perimeter of {shapeType.Name.ToLower()} is: {totalPerimeter}");
        }

        private void TotalArea_Click(object sender, EventArgs e)
        {
            Type shapeType = typeof(Shape);
            float totalArea = 0;
            if (CircleButton.Checked == true)
            {
                shapeType = typeof(Circle);
            }
            else if (SquareButton.Checked == true)
            {
                shapeType = typeof(Square);
            }
            else if (TriangleButton.Checked == true)
            {
                shapeType = typeof(Triangle);
            }
            var filterTypes = shapes.Where(shapes => shapes.GetType() == shapeType);
            totalArea = filterTypes.Sum(shapes => shapes.GetArea());
            MessageBox.Show($"Total Area of {shapeType.Name.ToLower()} is: {totalArea}");
        }

        private void Last_Click(object sender, EventArgs e)
        {
            if (shapes.Any())
            {
                var element = shapes.Last();
                shapes.Remove(element);
                Invalidate();
            }
            else
                MessageBox.Show("There are no shapes to remove!", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                Form2 form2 = new Form2();
                form2.perimeter = selectedShape.GetPerimeter();
                form2.Area = selectedShape.GetArea();
                form2.type = selectedShape.GetType();
                form2.color = selectedShape.GetColor();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("No shape selected.", "Warning!");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                selectedShape.ChangeColor();
                Invalidate();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp",
                Title = "Save the Image of the Shapes",
                DefaultExt = "png" 
            };

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                using (Bitmap bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(this.BackColor);
                        foreach (Shape shape in shapes)
                        {
                            shape.Fill(g);
                        }
                    }

                    bitmap.Save(saveFileDialog.FileName);
                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image to Load"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    loadedImage = Image.FromFile(openFileDialog.FileName);

                    Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}