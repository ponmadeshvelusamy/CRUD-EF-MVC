using EFAppLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_EF_MVC.Controllers
{
    public class ConstituteController : Controller
    {
        public Iconstitute instance;
        //public ConstituteRepos instance;
        public ConstituteController(Iconstitute instan)
        {
            instance= instan;
        }
        // GET: ConstituteController
        public ActionResult Index()
        {
            try
            {
                var result = instance.Listall();
                return View("List", result);
            }
            catch (Exception ex)
            {
                return View("Error", ex.Message);
            }
        }

        // GET: ConstituteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConstituteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConstituteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstituteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConstituteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConstituteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConstituteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
