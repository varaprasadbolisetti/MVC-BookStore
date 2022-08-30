using Bookstore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Services
{
    public class DBconnection
    {

        private readonly string connectionString = "Data Source=localhost;Initial Catalog=BookStore;Integrated Security=True;Persist Security Info=True;";
        private readonly SqlConnection _Connection;
        public DBconnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            _Connection = con;
            //_Connection.Open();

        }
        public bool AddBook(Book book)
        {

            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO BOOK (BOOKNAME, AUTHOR, PUBLISHEDDATE, ISACTIVE) VALUES(@BOOKNAME,@AUTHOR,@PUBLISHEDDATE,@ISACTIVE)", _Connection);

                sqlCommand.Parameters.Add(new SqlParameter("BOOKNAME", book.BookName));
                sqlCommand.Parameters.Add(new SqlParameter("AUTHOR", book.Author));

                sqlCommand.Parameters.Add(new SqlParameter("PUBLISHEDDATE", DateTime.Now));

                sqlCommand.Parameters.Add(new SqlParameter("ISACTIVE", true));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                ;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {

                _Connection.Close();
            }
        }

        

        public bool delete(int id)
        {

            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete FROM BOOK where ID=@id", _Connection);
                sqlCommand.Parameters.Add(new SqlParameter("id", id));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                _Connection.Close();
            }
        }
        public List<Book> GetBooks()
        {
            try
            {
                _Connection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BOOK", _Connection);

                var books = sqlCommand.ExecuteReader();
                List<Book> booksList = new List<Book>();
                while (books.Read())
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
            catch (Exception ex)
            {
                return new List<Book>();
            }
            finally
            {
                _Connection.Close();
            }


        }
        public Book Edit1(int id)
        {
            try
            {
                Book book1 = null;
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select *from Book where ID=@id", _Connection);
                sqlCommand.Parameters.AddWithValue("@id", id);


                var book = sqlCommand.ExecuteReader();
                while (book.Read())
                {
                    book1 = new Book()
                    {
                        Id = book.GetInt32(book.GetOrdinal("ID")),
                        BookName = book.GetString(book.GetOrdinal("BookName")),
                        Author = book.GetString(book.GetOrdinal("Author")),
                        PublishedDate = book.GetDateTime(book.GetOrdinal("PublishedDate")),
                        IsActive = book.GetBoolean(book.GetOrdinal("IsActive"))


                    };
                }
                return book1;
            }
            catch (Exception ex)
            {
                return new Book();
            }
            finally
            {
                _Connection.Close();
            }
        }
        public bool EditBook(Book book)
        {

            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Book set BookName = @BookName, Author = @Author where Id = @Id;", _Connection);
                sqlCommand.Parameters.Add(new SqlParameter("BookName", book.BookName));
                sqlCommand.Parameters.Add(new SqlParameter("Author", book.Author));
               sqlCommand.Parameters.Add(new SqlParameter("Id", book.Id));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _Connection.Close();
            }
        }
    

            public bool AddStudent(Student stu)
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert Student(StudentName,StudentGender,StudentCourse,StudentJoindate)values(@0,@1,@2,@3);", _Connection);
                sqlCommand.Parameters.Add(new SqlParameter("0", stu.StudentName));
                sqlCommand.Parameters.Add(new SqlParameter("1", stu.StudentCourse));
                sqlCommand.Parameters.Add(new SqlParameter("2", stu.StudentGender));
                sqlCommand.Parameters.Add(new SqlParameter("3", DateTime.Now));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _Connection.Close();
            }



        }
        public List<Student> GetStudents()
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from Student", _Connection);
                var stud = sqlCommand.ExecuteReader();
                List<Student> studlist = new List<Student>();
                while (stud.Read())
                {
                    studlist.Add(new Student
                    {
                        StudentId = stud.GetInt32(0),
                        StudentName = stud.GetString(1),
                        StudentGender = (char)stud.GetString(2)[0],
                        StudentCourse = stud.GetString(3),
                        StudentJoindate = stud.GetDateTime(4)
                    });
                }
                return studlist;

            }

            catch (Exception ex)
            {
                return new List<Student>();
            }
            finally
            {
                _Connection.Close();
            }
        }
        public bool deleteStudent(int studentId)
        {
            _Connection.Open();
            try
            {

                SqlCommand sqlCommand = new SqlCommand("delete FROM student where StudentId=@studentId", _Connection);
                sqlCommand.Parameters.Add(new SqlParameter("studentId", studentId));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                _Connection.Close();
            }

        }
        public Student Edit(int id)
        {
            try
            {
                Student student1 = null;
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select *from student where StudentId=@id", _Connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                

                var student = sqlCommand.ExecuteReader();
                while (student.Read())
                {
                    student1 = new Student()
                    {
                        StudentId = student.GetInt32(student.GetOrdinal("StudentId")),
                        StudentName = student.GetString(student.GetOrdinal("StudentName")),
                        StudentCourse = student.GetString(student.GetOrdinal("StudentCourse")),
                        StudentGender = (char)student.GetString(student.GetOrdinal("StudentGender"))[0],
                        StudentJoindate = student.GetDateTime(student.GetOrdinal("StudentJoindate"))

                    };
                }
                return student1;
            }
            catch (Exception ex)
            {
                return new Student();
            }
            finally
            {
                _Connection.Close();
            }

        }

        public bool EditStudent(Student student)
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Student set StudentName = @StudentName, StudentCourse = @StudentCourse, StudentGender = @StudentGender where StudentId = @StudentId;", _Connection);
                sqlCommand.Parameters.Add(new SqlParameter("StudentName", student.StudentName));
                sqlCommand.Parameters.Add(new SqlParameter("StudentCourse", student.StudentCourse));
                sqlCommand.Parameters.Add(new SqlParameter("StudentGender", student.StudentGender));
                sqlCommand.Parameters.Add(new SqlParameter("StudentId", student.StudentId));

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;

                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                _Connection.Close();
            }
        }


    }
}

