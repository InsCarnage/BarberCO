using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Barberco.Models;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Barberco.Areas.User.Controllers
{
    [AllowAnonymous]
    [Area("User")]
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            //Fetch all files in the Folder (Directory).
            string[] filePaths = Directory.GetFiles("../Barberco/wwwroot/Images/");

            //Copy File names to Model collection.
            List<ProductModel> files = new List<ProductModel>();
            foreach (string filePath in filePaths)
            {
                files.Add(new ProductModel { FileName = Path.GetFileName(filePath) });
            }

            return View(files);
        }
    }
}
