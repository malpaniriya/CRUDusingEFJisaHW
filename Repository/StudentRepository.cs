using CRUDusingEFJisaHW.Data;
using CRUDusingEFJisaHW.Models;

namespace CRUDusingEFJisaHW.Repository
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student student)
        {
            db.Students.Add(student);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result);
                res = db.SaveChanges();

            }
            return res;
        }

        public Student GetStudentById(int id)
        {
            var result = db.Students.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int res = 0;
            var result = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();
            if (result != null)
            {
                result.Name = student.Name;
                result.City = student.City;
                result.Grade = student.Grade;

                res = db.SaveChanges();
            }
            return res;
        }
    }
}
