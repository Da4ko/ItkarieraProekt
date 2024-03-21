using BusinessLogic;
using ModelsAndDBcontext;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_Forms
{
    public partial class AddANewBookForm : Form
    {
        private readonly IBookRepository bookRepository;
        public AddANewBookForm()
        {
            InitializeComponent();
            this.bookRepository = new BookRepository();
        }

        private void addANewBookButton_Click(object sender, EventArgs e)
        {

            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            string imageUrl = ImageUrlTextBox.Text;
            string author = AuthorTextBox.Text;
            string genre = GenreTextBox.Text;
            decimal price = decimal.Parse(PriceTextBox.Text);
            int quantity = int.Parse(QuantityTextBox.Text);

            bookRepository.CreateBook(name, description, imageUrl, author, genre, price, quantity);
            this.Close();
            StartingForm startingForm = new StartingForm();
            startingForm.Visible = true;
        }
    }
}
