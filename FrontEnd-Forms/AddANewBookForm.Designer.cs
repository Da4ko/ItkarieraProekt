namespace FrontEnd_Forms
{
    partial class AddANewBookForm
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
            addANewBookButton = new Button();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            ImageUrlTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            GenreTextBox = new TextBox();
            PriceTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // addANewBookButton
            // 
            addANewBookButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addANewBookButton.Location = new Point(427, 197);
            addANewBookButton.Name = "addANewBookButton";
            addANewBookButton.Size = new Size(292, 128);
            addANewBookButton.TabIndex = 0;
            addANewBookButton.Text = "Add a new book";
            addANewBookButton.UseVisualStyleBackColor = true;
            addANewBookButton.Click += addANewBookButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(95, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(164, 27);
            NameTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(95, 104);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(164, 27);
            DescriptionTextBox.TabIndex = 2;
            // 
            // ImageUrlTextBox
            // 
            ImageUrlTextBox.Location = new Point(95, 167);
            ImageUrlTextBox.Name = "ImageUrlTextBox";
            ImageUrlTextBox.Size = new Size(164, 27);
            ImageUrlTextBox.TabIndex = 3;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(95, 232);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(164, 27);
            AuthorTextBox.TabIndex = 4;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(95, 298);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(164, 27);
            GenreTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(95, 363);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(164, 27);
            PriceTextBox.TabIndex = 6;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(95, 425);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(164, 27);
            QuantityTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 47);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(266, 107);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(268, 170);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 10;
            label3.Text = "ImageUrl";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(268, 239);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 11;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(272, 301);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 12;
            label5.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(272, 363);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 13;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(265, 428);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 14;
            label7.Text = "Quantity";
            // 
            // AddANewBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 507);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QuantityTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(ImageUrlTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(addANewBookButton);
            Name = "AddANewBookForm";
            Text = "AddANewBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addANewBookButton;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private TextBox ImageUrlTextBox;
        private TextBox AuthorTextBox;
        private TextBox GenreTextBox;
        private TextBox PriceTextBox;
        private TextBox QuantityTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}