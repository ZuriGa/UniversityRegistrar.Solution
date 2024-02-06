using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniversityRegistrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public DepartmentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments
          .Include(department => department.DepartmentJoinEntities)
          .ThenInclude(join => join.Course)
          .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCourse(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "CourseName");
      return View(thisDepartment);
    }

    [HttpPost]
    public ActionResult AddCourse(Department department, int courseId)
    {
#nullable enable
      CourseDepartment? departmentJoinEntity = _db.CourseDepartments.FirstOrDefault(join => (join.CourseId == courseId && join.DepartmentId == department.DepartmentId));
#nullable disable
      if (departmentJoinEntity == null && courseId != 0)
      {
        _db.CourseDepartments.Add(new CourseDepartment() { CourseId = courseId, DepartmentId = department.DepartmentId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = department.DepartmentId });
    }

    public ActionResult Edit(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost]
    public ActionResult Edit(Department department)
    {
      _db.Departments.Update(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      _db.Departments.Remove(thisDepartment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}