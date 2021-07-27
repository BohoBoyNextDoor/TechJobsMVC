using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ListController.ColumnChoices;
            return View();
        }

        [HttpPost]
        public IActionResult Search(string column, string value)
        {
            if ((column == "") || (value == ""))
            {
                ViewBag.Jobs = TechJobsMVC.Data.JobData.FindAll();
            }
            else
            {
                ViewBag.Jobs = TechJobsMVC.Data.JobData.FindByColumnAndValue(column, value);
            }
            return View();
        }


        // TODO #3: Create an action method to process a search request and render the updated search view. 
    }
}
