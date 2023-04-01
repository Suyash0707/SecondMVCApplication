using Microsoft.AspNetCore.Mvc;
using SecondDOTNETApp.Models;

namespace SecondDOTNETApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index() 
        {
            SecondMvcappContext db = new SecondMvcappContext();
            var students = db.Students.ToList();

            return View(students);
        }
    }
}
