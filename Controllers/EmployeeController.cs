using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Models;
using System.Linq;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _dbContext = new EmployeeDbContext();

        // GET: /Employee
        public ActionResult Index()
        {
            var employee = _dbContext.Employee.Include(e => e.Department).ToList();
            return View(employee);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            ViewBag.Department = _dbContext.Department.ToList();
            return View();
        }

        // POST: /Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employee.Add(employee);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Department = _dbContext.Department.ToList();
            return View(employee);
        }
    }
}    