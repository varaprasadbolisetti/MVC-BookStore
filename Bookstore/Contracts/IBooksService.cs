using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Contracts
{
    public interface IBooksService
    {
        bool AddBook(Book book);
        List<Book> GetBooks();
        bool deletebook(int id);


    }
}
