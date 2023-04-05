using MockProject1.Models;

namespace MockProject1.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student AddStudent(Student student);
        Student GetStudent(int id);
        bool Update(Student student);
        bool DeleteStudent(int studid);
    }
}
