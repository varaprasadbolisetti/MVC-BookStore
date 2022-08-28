using Bookstore.Contracts;
using Bookstore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.Services
{
    public class BooksService : IBooksService
    {
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=BookStore;Integrated Security=True;Persist Security Info=True;";
        public bool AddBook(Book book)
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO BOOK (BOOKNAME, AUTHOR, PUBLISHEDDATE, ISACTIVE) VALUES(@BOOKNAME,@AUTHOR,@PUBLISHEDDATE,@ISACTIVE)", con);

                    sqlCommand.Parameters.Add(new SqlParameter("BOOKNAME", book.BookName));
                    sqlCommand.Parameters.Add(new SqlParameter("AUTHOR", book.Author));

                    sqlCommand.Parameters.Add(new SqlParameter("PUBLISHEDDATE", DateTime.Now));

                    sqlCommand.Parameters.Add(new SqlParameter("ISACTIVE", true));

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
           

        }
        public bool deletebook(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("delete FROM BOOK where ID=@id", con);
                    sqlCommand.Parameters.Add(new SqlParameter("id", id));

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;

            }
         }
                   
        public List<Book> GetBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BOOK", con);

                    var books = sqlCommand.ExecuteReader();
                    List<Book> booksList = new List<Book>();
                    while(books.Read())
                    {
                        booksList.Add(new Book
                        {
                            Id = books.GetInt32(0),
                            BookName = books.GetString(1),
                            Author = books.GetString(2),
                            PublishedDate = books.GetDateTime(3)
                        });
                    }
                    return booksList;
                }
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
            
        }
        
    }
}
