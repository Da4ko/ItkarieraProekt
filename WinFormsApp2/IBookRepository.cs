
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsAndDBcontext;


namespace Repositories
{
    public interface IBookRepository
    {
        public Book CreateBook(string name, string description, string imageUrl, string author, string genre, decimal price, int quantity);
        public Book FindBookByName(string name);
        public Book FindBookById(int id);

        public List<Book> GetAllBooks();

        public void UpdateBookQuantity(int id,int quantity,string action);

        public void DeleteBook(int id);
    }
}
