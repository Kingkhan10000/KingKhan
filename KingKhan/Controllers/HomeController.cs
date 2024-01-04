using KingKhan.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace KingKhan.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _context;

        public List<Teachers> GetTeachers()
        {

            List<Teachers> teachers = _context.Teachers.ToList();
            return teachers;

        }
        public List<Students> GetStudents()
        {

            List<Students> students = _context.Students.ToList();
            return students;

        }
        public List<Parents> GetParents()
        {

            List<Parents> parents = _context.Parents.ToList();
            return parents;
        }

        public HomeController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            // first way by using dynamic
            //dynamic mymodels = new ExpandoObject();
            //mymodels.Teachers = GetTeachers();
            //mymodels.Parents = GetParents();
            //mymodels.Students = GetStudents();

            //another way by using ViewModel
            MyViewModel mymodels = new MyViewModel();
            mymodels.Teachers = GetTeachers();
            mymodels.Parents = GetParents();
            mymodels.Students = GetStudents();



            return View(mymodels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}