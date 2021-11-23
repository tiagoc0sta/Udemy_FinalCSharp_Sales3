using Udemy_FinalCSharp_Sales3.Models;
using System.Linq;
using Udemy_FinalCSharp_Sales3.Data;
using System.Collections.Generic;

namespace Udemy_FinalCSharp_Sales3.Services
{
    public class DepartmentService 
    {
        private readonly Udemy_FinalCSharp_Sales3Context _context;

        public DepartmentService(Udemy_FinalCSharp_Sales3Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}