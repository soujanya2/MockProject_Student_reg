using Microsoft.EntityFrameworkCore;
using MockProject1.Models;

namespace MockProject1.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext db;
        public StudentRepository(StudentContext _db)
        {
            db= _db;
        }
        public Student AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            var stud= db.Students.FirstOrDefault(x=>x.StudentID==student.StudentID);
            stud.Age=(int)((DateTime.Now-student.DateOfBirth).TotalDays/ 365.242199);
            db.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int studid)
        {
            var student = db.Students.SingleOrDefault(x => x.StudentID == studid);
            if(student!=null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return db.Students.SingleOrDefault(x => x.StudentID == id);
        }

        public bool Update(Student student)
        {
            var stud = db.Students.SingleOrDefault(x => x.StudentID == student.StudentID);
            if (stud != null)
            {
                stud.FirstName = student.FirstName;
                stud.LastName = student.LastName;
                stud.DateOfBirth = student.DateOfBirth;
                stud.CourseName = student.CourseName;
                stud.HobbiesName = student.HobbiesName;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
