using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly EmployeeDbContext _dbContext = new EmployeeDbContext();

        // GET: /Department
        public ActionResult Index()
        {
            var department = _dbContext.Department.ToList();
            return View(department);
        }

        // GET: /Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Department.Add(department);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: /Department/Edit/1
        public ActionResult Edit(int id)
        {
            var department = _dbContext.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: /Department/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: /Department/Delete/1
        public ActionResult Delete(int id)
        {
            var department = _dbContext.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: /Department/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var department = _dbContext.Department.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            _dbContext.Department.Remove(department);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}