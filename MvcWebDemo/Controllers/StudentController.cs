using MvcWebDemo.Models;
using MvcWebDemo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebDemo.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new StudentViewModel());
        }

        [HttpPost]
        public ActionResult Create(StudentViewModel viewModel)
        {
            StudentService service = new StudentService();
            if (service.IsDaySectionStudent(viewModel))
            {
                return View("Detail", viewModel);
            }
            return View("Create", viewModel);
            return View();
        }

    }
}
