using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class HomeController : Controller
  {
  private readonly UniversityRegistrarContext _db;

  public HomeController(UniversityRegistrarContext db)
  {
    _db = db;
  }
  
    [HttpGet("/")]
    public ActionResult Index()
    {
      Course[] courses = _db.Courses.ToArray();
      Student[] students = _db.Students.ToArray();
      Department[] departments = _db.Departments.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("courses", courses);
      model.Add("students", students);
      model.Add("departments", departments);
      return View(model);
    }
  }
}