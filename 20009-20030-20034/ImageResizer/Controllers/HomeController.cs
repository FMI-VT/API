using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImagerLib;
using System.IO;
using System.Drawing;
using ImageResizer.Models;

namespace ImageResizer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Add", "Image");
        }
    }
}