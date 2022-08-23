using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class BooksController : ApiController
    {

        public string GetBook (string title ,string pages)
        {

            return string.Format("Title ={0}, Number of pages ={1}", title, pages);
        }


        public string PostBook(string title, string pages)
        {

            return string.Format("Title ={0}, Number of pages ={1}", title, pages);
        }


        //using model (complex type)
        public string GetBook(book book)
        {

            return string.Format("Title ={0}, Number of pages ={1}", book.Title ,book.Pages);
        }


    }
}