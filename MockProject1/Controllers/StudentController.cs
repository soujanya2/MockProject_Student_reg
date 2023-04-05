using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MockProject1.Models;
using MockProject1.Repository;

namespace MockProject1.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository repo;
        private StudentContext db;
        public StudentController(IStudentRepository _repo, StudentContext _db)
        {
            repo = _repo;
            db = _db;
        }
        public IActionResult ViewAll()
        {
            IEnumerable<Student> studentlist=repo.GetAllStudents();
            return View(studentlist);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBag.courses = new SelectList(db.Courses, "CourseName", "CourseName");
            ViewBag.hobbies = new SelectList(db.Hobbys, "HobbyName", "HobbyName");
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student id)
        {
            if (ModelState.IsValid)
            {
                ViewBag.today = DateTime.Now;
                Student student = repo.AddStudent(id);
                return RedirectToAction("ViewAll");
            }
            return View();
        }
        public IActionResult UpdateStudent(int id)
        {
            ViewBag.Courses = new SelectList(db.Courses, "CourseName", "CourseName");
            ViewBag.Hobbies = new SelectList(db.Hobbys, "HobbyName", "HobbyName");
            Student student = repo.GetStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                if (repo.Update(student))
                {
                    return RedirectToAction("GetAllStudents");
                }
            }
            return View();  
        }
        public IActionResult Delete(int id)
        {
            if(repo.DeleteStudent(id))
            {
                return RedirectToAction("ViewAll");
            }
            throw new NotImplementedException();
        }
    }
}
