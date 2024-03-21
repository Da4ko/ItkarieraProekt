using Repositories;
using ModelsAndDBcontext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Drawing.Printing;

namespace FrontEnd_Forms
{
    public partial class StartingForm : Form
    {
        private readonly IBookRepository bookRepository;
        private Panel panel;

        public StartingForm()
        {
            InitializeComponent();
            this.bookRepository = new BookRepository();
            this.Resize += (sender, e) =>
            {
                if (panel != null)
                {
                    AdjustLayout();
                }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            this.Controls.Add(panel);
            AdjustLayout();
        }

        protected void AdjustLayout()
        {
            panel.Controls.Clear();


            int itemsPerRow = Math.Max((panel.ClientSize.Width - 100) / 300, 1);

            int itemWidth = (panel.ClientSize.Width - (itemsPerRow + 1) * 50) / itemsPerRow;
            int itemHeight = 300;
            int buttonWidth = itemWidth;
            int buttonHeight = 50;
            int spacingX = 50;
            int spacingY = 50;

            int count = 0;
            foreach (Book book in this.bookRepository.GetAllBooks())
            {

                int row = count / itemsPerRow;
                int col = count % itemsPerRow;


                int xPos = spacingX + col * (itemWidth + spacingX);
                int yPos = spacingY + row * (itemHeight + buttonHeight + spacingY);


                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new System.Drawing.Point(xPos, yPos);
                pictureBox.Size = new System.Drawing.Size(itemWidth, itemHeight);
                pictureBox.BackColor = System.Drawing.Color.LightGray;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Load(book.ImageUrl);
                panel.Controls.Add(pictureBox);


                Button button = new Button();
                button.Text = "More Information";
                button.Location = new System.Drawing.Point(xPos, yPos + itemHeight);
                button.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                button.Click += (sender, ev) =>
                {
                    // Handle button click event
                    MoreInfoForm moreInfoForm = new MoreInfoForm();
                    moreInfoForm.Visible = true;
                    string description = book.Description; // Assuming 'book' is an instance of a Book class with a Description property

                    moreInfoForm.label1.Text = book.ToString();
                    moreInfoForm.pictureBox1.Load(book.ImageUrl);
                    moreInfoForm.id = book.Id;
                    base.Visible = false;

                };
                // Styling the button
                button.BackColor = Color.LightBlue;
                button.Font = new Font(button.Font.FontFamily, 10, FontStyle.Bold); // Set font size and style
                button.FlatStyle = FlatStyle.Flat; // Make the button flat
                button.FlatAppearance.BorderSize = 0; // Remove border
                button.Padding = new Padding(10);




                panel.Controls.Add(button);

                count++;
            }
            label1.Text = count.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddANewBookForm addANewBookForm = new AddANewBookForm();
            addANewBookForm.Visible = true;
            base.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}