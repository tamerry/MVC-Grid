using System.Linq;
using System.Web.Mvc;
using TabloCalısma.Models;

namespace TabloCalısma.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ara()
        {
            DatabaseEntities db = new DatabaseEntities();
            var result = (
                from c in db.Tbl_Emp
                          select new Grid_Tables
                          {   EmpNo=c.EmpNo,
                          EName=c.EName,
                          Job=c.Job,
                          HireDate=c.HireDate,
                          Sal=c.Sal,
                          Comm=c.Comm,

                          }).ToList();
            return View(result);
        }
    }
}