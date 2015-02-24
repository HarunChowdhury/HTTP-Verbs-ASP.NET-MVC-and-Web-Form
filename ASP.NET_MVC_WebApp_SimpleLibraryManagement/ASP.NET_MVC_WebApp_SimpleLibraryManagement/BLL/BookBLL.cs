using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.DAL.Gateway;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.Models;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement.BLL
{
    public class BookBLL
    {
        private BookGateway aBookGateway;
        private Book aBook;
        public BookBLL()
        {
            aBookGateway = new BookGateway();
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            books = aBookGateway.GetAllBooks();
            return books;
        }

        public Book GetBookByTitle(string title)
        {
            aBook = new Book();
            aBook=aBookGateway.GetBookByTitle(title);
            return aBook;
        }
    }
}