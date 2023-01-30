using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
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

            public async Task<List<Department>> FindAllAsync()
            {
                return await _context.Department.OrderBy(x => x.Name).ToListAsync();
            }
            public void Insert(Seller obj)
            {
                obj.Department = _context.Department.First();
                _context.Add(obj);
                _context.SaveChanges();
            }
        }
    }
