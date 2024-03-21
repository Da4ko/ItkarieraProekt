namespace FrontEnd_Forms
{
    partial class StartingForm
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
            addNewBookButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // addNewBookButton
            // 
            addNewBookButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addNewBookButton.Location = new Point(817, 12);
            addNewBookButton.Name = "addNewBookButton";
            addNewBookButton.Size = new Size(254, 28);
            addNewBookButton.TabIndex = 1;
            addNewBookButton.Text = "Add new book";
            addNewBookButton.UseVisualStyleBackColor = true;
            addNewBookButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(472, 16);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 0;
            label1.Text = "Add a new book to library";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // StartingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1136, 618);
            Controls.Add(addNewBookButton);
            Controls.Add(label1);
            Name = "StartingForm";
            Text = "Bookstore";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addNewBookButton;
        private Label label1;
    }
}