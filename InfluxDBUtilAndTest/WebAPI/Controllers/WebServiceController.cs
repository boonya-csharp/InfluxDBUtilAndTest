using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class WebServiceController : Controller
    {
        public string Test(string q)
        {
            return "sql="+q;
        }
    }
}