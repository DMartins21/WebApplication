using System;
using WebApplication.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using WebApplication.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebApplication.Services
{
    public class SalesRecordService
    {
        private readonly WebApplicationContext _context;

        public SalesRecordService(WebApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDataAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= minDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

    }
}
