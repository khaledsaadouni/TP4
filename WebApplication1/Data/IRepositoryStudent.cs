using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public interface IRepositoryStudent:IRepository<Student>
    {
        public IEnumerable<string?> GetCourses(); 
    }
}
