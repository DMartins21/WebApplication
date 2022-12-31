using System.Collections.Generic;
using System.Linq;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Services
{
    public class DepartmentService
    {
            private readonly WebApplicationContext _context;

            public DepartmentService(WebApplicationContext context)
            {
                _context = context;
            }

            public List<Department> FindAll()
            {
                return _context.Department.OrderBy(x => x.Name).ToList();
            }
            public void Insert(Seller obj)
            {
                obj.Department = _context.Department.First();
                _context.Add(obj);
                _context.SaveChanges();
            }
        }
    }
