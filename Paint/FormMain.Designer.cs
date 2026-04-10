namespace Paint
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SquareButton = new RadioButton();
            CircleButton = new RadioButton();
            SumPerimeter = new Button();
            Last = new Button();
            TriangleButton = new RadioButton();
            Info = new Button();
            ColorButton = new Button();
            colorDialog1 = new ColorDialog();
            TotalArea = new Button();
            Save = new Button();
            Load = new Button();
            SuspendLayout();
            // 
            // SquareButton
            // 
            SquareButton.AutoSize = true;
            SquareButton.ForeColor = SystemColors.ActiveCaption;
            SquareButton.Location = new Point(12, 12);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(61, 19);
            SquareButton.TabIndex = 0;
            SquareButton.Text = "Square";
            SquareButton.UseVisualStyleBackColor = true;
            // 
            // CircleButton
            // 
            CircleButton.AutoSize = true;
            CircleButton.ForeColor = SystemColors.ActiveCaption;
            CircleButton.Location = new Point(79, 12);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(55, 19);
            CircleButton.TabIndex = 1;
            CircleButton.Text = "Circle";
            CircleButton.UseVisualStyleBackColor = true;
            // 
            // SumPerimeter
            // 
            SumPerimeter.Location = new Point(739, 12);
            SumPerimeter.Name = "SumPerimeter";
            SumPerimeter.Size = new Size(126, 33);
            SumPerimeter.TabIndex = 2;
            SumPerimeter.Text = "SumOfAllPerimeters";
            SumPerimeter.UseVisualStyleBackColor = true;
            SumPerimeter.Click += SumPerimeter_Click;
            // 
            // Last
            // 
            Last.Location = new Point(880, 12);
            Last.Name = "Last";
            Last.Size = new Size(87, 33);
            Last.TabIndex = 3;
            Last.Text = "Last";
            Last.UseVisualStyleBackColor = true;
            Last.Click += Last_Click;
            // 
            // TriangleButton
            // 
            TriangleButton.AutoSize = true;
            TriangleButton.ForeColor = SystemColors.ActiveCaption;
            TriangleButton.Location = new Point(140, 12);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.RightToLeft = RightToLeft.No;
            TriangleButton.Size = new Size(66, 19);
            TriangleButton.TabIndex = 4;
            TriangleButton.Text = "Triangle";
            TriangleButton.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            Info.Location = new Point(440, 15);
            Info.Name = "Info";
            Info.Size = new Size(65, 30);
            Info.TabIndex = 5;
            Info.Text = "Info";
            Info.UseVisualStyleBackColor = true;
            Info.Click += Info_Click;
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(529, 15);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(68, 30);
            ColorButton.TabIndex = 6;
            ColorButton.Text = "Color";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // TotalArea
            // 
            TotalArea.Location = new Point(615, 15);
            TotalArea.Name = "TotalArea";
            TotalArea.Size = new Size(103, 30);
            TotalArea.TabIndex = 7;
            TotalArea.Text = "SumOfAllAreas";
            TotalArea.UseVisualStyleBackColor = true;
            TotalArea.Click += TotalArea_Click;
            // 
            // Save
            // 
            Save.Location = new Point(995, 12);
            Save.Name = "Save";
            Save.Size = new Size(88, 33);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Load
            // 
            Load.Location = new Point(1108, 12);
            Load.Name = "Load";
            Load.Size = new Size(91, 33);
            Load.TabIndex = 9;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1370, 749);
            Controls.Add(Load);
            Controls.Add(Save);
            Controls.Add(TotalArea);
            Controls.Add(ColorButton);
            Controls.Add(Info);
            Controls.Add(TriangleButton);
            Controls.Add(Last);
            Controls.Add(SumPerimeter);
            Controls.Add(CircleButton);
            Controls.Add(SquareButton);
            DoubleBuffered = true;
            Name = "FormMain";
            Text = "FromMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton SquareButton;
        private RadioButton CircleButton;
        private Button SumPerimeter;
        private Button Last;
        private RadioButton TriangleButton;
        private Button Info;
        private Button ColorButton;
        private ColorDialog colorDialog1;
        private Button TotalArea;
        private Button Save;
        private Button Load;
    }
}
