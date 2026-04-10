using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Paint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public float perimeter;
        public float Area;
        public Type? type;
        public Color color;

        private void Form2_Load(object sender, EventArgs e)
        {
            label1Text.Text = perimeter.ToString();
            label2Text.Text = Area.ToString();
            if(type != null)
                label3Text.Text = type.ToString();
            label4Color.Text = color.ToString();
        }
    }
}
