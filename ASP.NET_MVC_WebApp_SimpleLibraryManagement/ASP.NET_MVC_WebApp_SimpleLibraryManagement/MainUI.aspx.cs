using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.BLL;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.Models;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement
{
    public partial class MainUI : System.Web.UI.Page
    {
        private BookBLL aBookBll;
        private MemberBLL aMemberBll;
        private Book aBook;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                aBook = new Book();
                List<Book> books = books = aBookBll.GetAllBooks();

                selectBookDropDownList.DataTextField = "Title";
                selectBookDropDownList.DataValueField = "Id";
                selectBookDropDownList.DataSource = books;

                selectBookDropDownList.DataBind();
            }

        }

        private string author;
        private string publisher;
        private string title;
        protected void selectBookDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            aBook = new Book();
            aBookBll = new BookBLL();
            title = selectBookDropDownList.SelectedItem.Text;
            aBook = aBookBll.GetBookByTitle(title);

            authorTextBox.Text=aBook.Author;
            publisherTextBox.Text=aBook.Publisher;
            author=aBook.Author;
            publisher=aBook.Publisher;

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            aBook = new Book();
            aMemberBll = new MemberBLL();
            aBook.Title =selectBookDropDownList.SelectedItem.Text;
            aBook.Author = authorTextBox.Text;
            aBook.Publisher = publisherTextBox.Text;
            string number=numberTextBox.Text;
            string msg =aMemberBll.CheckAndSaveBorrowBook(aBook,number);

            messageLabel.Text = msg;
        }

        protected void showSelectedNumBooksButton_Click(object sender, EventArgs e)
        {

        }
    }
}