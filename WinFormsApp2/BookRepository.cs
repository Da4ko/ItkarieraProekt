    using ModelsAndDBcontext;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BookRepository :IBookRepository
    {
       
        public Book CreateBook(string name,string description, string imageUrl, string author, string genre, decimal price, int quantity)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            var book = new Book(name,description,imageUrl,author,genre,price,quantity);
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return book;
        }
        public Book FindBookByName(string name)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Books.Find(name);
        }

        public Book FindBookById(int id)
        {

            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Books.Find(id);
        }
        public List<Book> GetAllBooks()
        {

            using ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Books.ToList();
        }

        public void UpdateBookQuantity(int id, int quantity, string action)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            Book book=dbContext.Books.Find(id);
            if(action.Equals("substract"))
            book.Quantity -= quantity;
            else
            book.Quantity += quantity;
            dbContext.SaveChanges();

        }
        public void DeleteBook(int bookId)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();
            Book bookToRemove = dbContext.Books.Find(bookId);
            dbContext.Books.Remove(bookToRemove);
            dbContext.SaveChanges();

        }
    }
}
