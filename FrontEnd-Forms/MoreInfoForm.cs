using BusinessLogic;
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
    public partial class MoreInfoForm : Form
    {

        private readonly IBookRepository bookRepository;
        public int id = 0;
        public MoreInfoForm()
        {
            InitializeComponent();
            this.bookRepository = new BookRepository();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            int boughtBooks = Convert.ToInt32(numericUpDown1.Value);
            bookRepository.UpdateBookQuantity(id, boughtBooks, "substract");
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Visible = true;
            confirmationForm.label1.Text = "You succesfuly bought " + boughtBooks + "books from: " + bookRepository.FindBookById(id).Name;
            this.Close();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            int soldBooks = Convert.ToInt32(numericUpDown2.Value);
            bookRepository.UpdateBookQuantity(id, soldBooks, "add");
            ConfirmationForm confirmationForm = new ConfirmationForm();
            confirmationForm.Visible = true;
            confirmationForm.label1.Text = "You succesfuly made " + soldBooks + "books from: " + bookRepository.FindBookById(id).Name;
            this.Close();
        }

        private void backToShoppingButton_Click(object sender, EventArgs e)
        {
            StartingForm startingForm = new StartingForm();
            startingForm.Visible = true;
            this.Close();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            bookRepository.DeleteBook(id);
            StartingForm startingForm = new StartingForm();
            startingForm.Visible = true;
            this.Close();
        }
    }
}
