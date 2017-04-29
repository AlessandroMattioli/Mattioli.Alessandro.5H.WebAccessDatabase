using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mattioli.Alessandro._5H.WebAccessDatabase.Models;
using System.Data;

namespace Mattioli.Alessandro._5H.WebAccessDatabase.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Query(string Query)
        {
            Query dal = new Query("PrenotazioniViaggi.accdb");
            DataTable table = dal.Getdata(Query);
            return View(table);
        }
    }
}