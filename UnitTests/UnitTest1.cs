using ModelsAndDBcontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Akka.Actor.Setup;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class BookRepositoryTests
    {
        private ApplicationDbContext dbContext;
        private BookRepository bookRepository;

        [Setup]
        public void Setup()
        {
            dbContext = new ApplicationDbContext();
            bookRepository = new BookRepository();
        }

        [TearDown]
        public void TearDown()
        {

            foreach (var book in dbContext.Books.ToList())
            {
                dbContext.Books.Remove(book);
            }
            dbContext.SaveChanges();
        }

        [Test]
        public void CreateBook_ShouldAddNewBookToDatabase()
        {
            // Arrange
            string name = "Test Book";
            string description = "Test description";
            string imageUrl = "test.jpg";
            string author = "Test Author";
            string genre = "Test Genre";
            decimal price = 10.99m;
            int quantity = 5;

            // Act
            var createdBook = bookRepository.CreateBook(name, description, imageUrl, author, genre, price, quantity);

            // Assert
            Assert.IsNotNull(createdBook);
            Assert.AreEqual(name, createdBook.Name);
            Assert.AreEqual(description, createdBook.Description);
            Assert.AreEqual(imageUrl, createdBook.ImageUrl);
            Assert.AreEqual(author, createdBook.Author);
            Assert.AreEqual(genre, createdBook.Genre);
            Assert.AreEqual(price, createdBook.Price);
            Assert.AreEqual(quantity, createdBook.Quantity);
        }

        [Test]
        public void FindBookByName_ShouldReturnCorrectBook()
        {
            // Arrange
            string name = "Test Book";
            Book expectedBook = new Book
            {
                Name = name,
                // Set other properties as needed
            };
            dbContext.Books.Add(expectedBook);
            dbContext.SaveChanges();

            // Act
            var foundBook = bookRepository.FindBookByName(name);

            // Assert
            Assert.IsNotNull(foundBook);
            Assert.AreEqual(expectedBook.Name, foundBook.Name);
            // Assert other properties as needed
        }

        [Test]
        public void FindBookById_ShouldReturnCorrectBook()
        {
            // Arrange
            int id = 1;
            Book expectedBook = new Book
            {
                Id = id,
                // Set other properties as needed
            };
            dbContext.Books.Add(expectedBook);
            dbContext.SaveChanges();

            // Act
            var foundBook = bookRepository.FindBookById(id);

            // Assert
            Assert.IsNotNull(foundBook);
            Assert.AreEqual(expectedBook.Id, foundBook.Id);
            // Assert other properties as needed
        }

        [Test]
        public void GetAllBooks_ShouldReturnAllBooks()
        {
            // Arrange
            var expectedBooks = new List<Book>
    {
        new Book { /* Set properties for book 1 */ },
        new Book { /* Set properties for book 2 */ },
        // Add more books as needed
    };
            foreach (var book in expectedBooks)
            {
                dbContext.Books.Add(book);
            }
            dbContext.SaveChanges();

            // Act
            var allBooks = bookRepository.GetAllBooks();

            // Assert
            Assert.AreEqual(expectedBooks.Count, allBooks.Count);
            CollectionAssert.AreEqual(expectedBooks, allBooks);
        }

        [Test]
        public void UpdateBookQuantity_ShouldUpdateQuantity()
        {
            // Arrange
            int id = 1;
            int initialQuantity = 10;
            var book = new Book
            {
                Id = id,
                Quantity = initialQuantity
                // Set other properties as needed
            };
            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            // Act
            int quantityToAdd = 5;
            bookRepository.UpdateBookQuantity(id, quantityToAdd, "add");
            var updatedBook = dbContext.Books.Find(id);

            // Assert
            NUnit.Framework.Assert.AreEqual(initialQuantity + quantityToAdd, updatedBook.Quantity);
        }

        [Test]
        public void DeleteBook_ShouldRemoveBookFromDatabase()
        {
            // Arrange
            int id = 1;
            var book = new Book
            {
                Id = id,
                // Set other properties as needed
            };
            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            // Act
            bookRepository.DeleteBook(id);
            var deletedBook = dbContext.Books.Find(id);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNull(deletedBook);
        }
    }
}