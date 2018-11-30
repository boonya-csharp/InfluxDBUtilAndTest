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
        public string Test(string db,string u,string p,string q)
        {
            return "db="+db + ",u=" + u+ ",p="  +p+",sql="+q;
        }
    }
}