using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Xml.Schema;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //create index
        {
            return View();
        }
    }
}