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
            var result = (from c in db.Person_Table
                          select new Grid_Tables
                          {   ID=c.ID,
                              Title=c.Title,
                              FirstName=c.FirstName,
                              LastName=c.LastName,
                          }).ToList();
            return View(result);
        }
    }
}