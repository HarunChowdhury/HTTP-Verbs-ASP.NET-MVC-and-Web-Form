using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.Models;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement.DAL.Gateway
{
    public class BookGateway:Gateway
    {
        public BookGateway()
            : base("ConnecString")
        {
            
        }


        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            Connection.Open();

            var query = "SELECT * FROM Book";
            Command.CommandText = query;
            SqlDataReader aReade = Command.ExecuteReader();
            while (aReade.Read())
            {
                Book aBook = new Book();
                aBook.Id = Convert.ToInt32(aReade["ID"]);
                aBook.Title = aReade["Title"].ToString();
                aBook.Author = aReade["Author"].ToString();
                aBook.Publisher = aReade["Publisher"].ToString();
              

                books.Add(aBook);
            }
            aReade.Close();
            Connection.Close();
            return books;

        }

        public Book GetBookByTitle(string title)
        {
            Connection.Close();
            var query = "SELECT * FROM Book WHERE Title='"+title+"'";
            Command.CommandText = query;
            SqlDataReader aDataReader = Command.ExecuteReader();

            Book aBook = new Book();
            while (aDataReader.Read())
            {
                aBook.Author = aDataReader["Author"].ToString();
                aBook.Publisher = aDataReader["Publisher"].ToString();

            }

            aDataReader.Close();
            Connection.Close();
            return aBook;
        }
    }
}