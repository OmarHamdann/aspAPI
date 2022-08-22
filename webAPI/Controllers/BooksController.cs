using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webAPI.Controllers
{
    public class BooksController : ApiController
    {

        public string GetBook (string title ,string pages)
        {

            return string.Format("Title ={0}, Number of pages ={1}", title, pages);
        }
        

       

      
    }
}