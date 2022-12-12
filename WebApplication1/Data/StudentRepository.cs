using System.Linq.Expressions;
using System.Transactions;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentRepository : Repository<Student>, IRepositoryStudent
    {
        private readonly UniversityContext _Context;
        public StudentRepository() 
        {
            this._Context = UniversityContext.Instance(); ;
        }

        

        public IEnumerable<string?> GetCourses()
        {
            return _Context.Student.Select(s => s.course).Distinct().ToList();
        }
    }
}
