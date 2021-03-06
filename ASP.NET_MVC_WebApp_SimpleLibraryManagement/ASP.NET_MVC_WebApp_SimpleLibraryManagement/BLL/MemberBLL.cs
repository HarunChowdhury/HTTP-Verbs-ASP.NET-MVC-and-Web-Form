﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.DAL.Gateway;
using ASP.NET_MVC_WebApp_SimpleLibraryManagement.Models;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement.BLL
{
    public class MemberBLL
    {
        private MemberGateway aMemberGateway = new MemberGateway();
        public string CheckAndSaveBorrowBook(Book aBook, string number)
        {
            if (!IsExistsNumber(number))
            {

                return "Sorry, member Number doesn't exists";
            }
            else
            {


                string msg = aMemberGateway.Save(aBook, number);

                return msg;
            }
        }

        private bool IsExistsNumber(string number)
        {
            return aMemberGateway.IsExistsNumber(number);
        }
    }
}