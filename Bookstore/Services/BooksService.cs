using Bookstore.Contracts;
using Bookstore.Models;
using Bookstore.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.Services
{
    public class BooksService : IBooksService
    {
        
        private readonly DBconnection _dbconnection;
        public BooksService()
        {
            _dbconnection = new DBconnection();
        }
        public bool AddBook(Book book)
        {
            return _dbconnection.AddBook(book);
        }
        public bool deletebook(int id)
        {
            return _dbconnection.delete(id);
        }

        public Book EditBook(int bookId)
        {
            Book book = _dbconnection.Edit1(bookId);
            return book;
        }
        public bool EditBookDetails(Book book)
        {
            return _dbconnection.EditBook(book);
        }

        public List<Book> GetBooks()
        {
            return _dbconnection.GetBooks();
            

        }

    }
}
