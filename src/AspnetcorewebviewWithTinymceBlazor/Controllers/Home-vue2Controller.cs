using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetcorewebviewWithTinymceBlazor.Controllers
{
    public class Home_vue2Controller : Controller
    {
        // GET: Home_vue2Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home_vue2Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home_vue2Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home_vue2Controller/Create
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

        // GET: Home_vue2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home_vue2Controller/Edit/5
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

        // GET: Home_vue2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home_vue2Controller/Delete/5
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
