using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Music_Store.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Hola desde Store.Index()";
        }

        //
        // GET /Store/Browser
        public string Browse(string genre) {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            
            return message; 
        }

        //
        // GET: /Store/Details
        public string Details(int id) {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}
