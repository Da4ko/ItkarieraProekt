using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsAndDBcontext
{
    public class Book
    {
        private int id;
        private string name;
        private string description;
        private string imageUrl;
        private string author;
        private string genre;
        private decimal price;
        private int quantity;

        
        public int Id
        {
            get { return id;}
            set {
                if (value >= 1) 
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("id cannot be zero or negative");
                }
             }
        }

        
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be less than 3 characters");
                }
                else 
                {
                    name = value;
                }

             }
        }

        
        public string Description
        {
            get { return description; }
            set {
                if (value.Length < 5) 
                {
                    throw new ArgumentException("Description cannot be less than 5 characters");
                }
                else 
                { 
                    description = value; }          
                }
        }

       
        public string ImageUrl
        {
            get { return imageUrl; }
            set {
                if (!value.StartsWith("http"))
                {
                    throw new ArgumentException("Invalid URL");
                }
                else 
                {
                    imageUrl = value;
                }
                
                
            }
        }

      
        public string Author
        {
            get { return author; }
            set 
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Author name must be more than 3 characters");
                }
                else
                {
                    author = value;
                }
                
            
            }
        }


        public string Genre
        {
            get { return genre; }
            set { 
                 if(value.Length>0) genre = value; 
                 else throw new ArgumentException("Genre can't be null");
            }
        }

       
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
                else throw new ArgumentException("Price has to be a positive number");
            }
        }

       
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > -1) { quantity = value; }
                else { throw new ArgumentException("Quantity can not be a negative number"); }
            }
        }


        public Book(string name, string description, string imageUrl, string author, string genre, decimal price, int quantity)
        {
            
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            Author = author;
            Genre = genre;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nDescription: {Description}\nAuthor: {Author}\nGenre: {Genre}\nPrice: {Price}\nQuantity: {Quantity}";
        }
    }
}
