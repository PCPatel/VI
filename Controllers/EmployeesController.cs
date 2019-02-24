using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using VI.Models;
using VI.ViewModels;

namespace VI.Controllers
{
    public class EmployeesController : Controller
    {
        private EmpDbContext db = new EmpDbContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.PayMaster);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            var vm = new EmployeeViewModel();
            ViewData["Countries"] = new SelectList(db.Countries.ToList(), "Id", "Name", "Select country");
            return View(vm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
