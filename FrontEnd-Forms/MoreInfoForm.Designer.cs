namespace FrontEnd_Forms
{
    partial class MoreInfoForm
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            backToShoppingButton = new Button();
            DeleteBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(597, 424);
            button1.Name = "button1";
            button1.Size = new Size(249, 64);
            button1.TabIndex = 0;
            button1.Text = "SELL BOOKS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(12, 424);
            button2.Name = "button2";
            button2.Size = new Size(336, 66);
            button2.TabIndex = 1;
            button2.Text = "MAKE MORE COPIES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(366, 12);
            label1.Name = "label1";
            label1.Size = new Size(230, 287);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(597, 391);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(249, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 391);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(336, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // backToShoppingButton
            // 
            backToShoppingButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            backToShoppingButton.Location = new Point(366, 302);
            backToShoppingButton.Name = "backToShoppingButton";
            backToShoppingButton.Size = new Size(230, 57);
            backToShoppingButton.TabIndex = 6;
            backToShoppingButton.Text = "back to shopping";
            backToShoppingButton.UseVisualStyleBackColor = true;
            backToShoppingButton.Click += backToShoppingButton_Click;
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.BackColor = Color.LightCoral;
            DeleteBookButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DeleteBookButton.Location = new Point(639, 12);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(175, 86);
            DeleteBookButton.TabIndex = 7;
            DeleteBookButton.Text = "delete book";
            DeleteBookButton.UseVisualStyleBackColor = false;
            DeleteBookButton.Click += DeleteBookButton_Click;
            // 
            // MoreInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 498);
            Controls.Add(DeleteBookButton);
            Controls.Add(backToShoppingButton);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MoreInfoForm";
            Text = "MoreInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        public Label label1;
        public PictureBox pictureBox1;
        private Button backToShoppingButton;
        private Button DeleteBookButton;
    }
}