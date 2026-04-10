namespace Paint
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Perimeter = new Label();
            label1Text = new Label();
            label1 = new Label();
            label2Text = new Label();
            label2 = new Label();
            label3Text = new Label();
            label3 = new Label();
            label4Color = new Label();
            SuspendLayout();
            // 
            // Perimeter
            // 
            Perimeter.AutoSize = true;
            Perimeter.ForeColor = SystemColors.ActiveCaption;
            Perimeter.Location = new Point(50, 56);
            Perimeter.Name = "Perimeter";
            Perimeter.Size = new Size(58, 15);
            Perimeter.TabIndex = 0;
            Perimeter.Text = "Perimeter";
            // 
            // label1Text
            // 
            label1Text.AutoSize = true;
            label1Text.ForeColor = SystemColors.ActiveCaption;
            label1Text.Location = new Point(128, 55);
            label1Text.Name = "label1Text";
            label1Text.Size = new Size(0, 15);
            label1Text.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(50, 88);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Area";
            // 
            // label2Text
            // 
            label2Text.AutoSize = true;
            label2Text.ForeColor = SystemColors.ActiveCaption;
            label2Text.Location = new Point(128, 88);
            label2Text.Name = "label2Text";
            label2Text.Size = new Size(0, 15);
            label2Text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(50, 23);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label3Text
            // 
            label3Text.AutoSize = true;
            label3Text.ForeColor = SystemColors.ActiveCaption;
            label3Text.Location = new Point(124, 27);
            label3Text.Name = "label3Text";
            label3Text.Size = new Size(0, 15);
            label3Text.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(50, 126);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Color";
            // 
            // label4Color
            // 
            label4Color.AutoSize = true;
            label4Color.ForeColor = SystemColors.ActiveCaption;
            label4Color.Location = new Point(124, 126);
            label4Color.Name = "label4Color";
            label4Color.Size = new Size(0, 15);
            label4Color.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label4Color);
            Controls.Add(label3);
            Controls.Add(label3Text);
            Controls.Add(label2);
            Controls.Add(label2Text);
            Controls.Add(label1);
            Controls.Add(label1Text);
            Controls.Add(Perimeter);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Perimeter;
        private Label label1Text;
        private Label label1;
        private Label label2Text;
        private Label label2;
        private Label label3Text;
        private Label label3;
        private Label label4Color;
    }
}