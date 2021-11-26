using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_FinalCSharp_Sales3.Data;
using Udemy_FinalCSharp_Sales3.Models;


namespace Udemy_FinalCSharp_Sales3.Services
{
    public class SalesRecordService 
    {
        private readonly Udemy_FinalCSharp_Sales3Context _context;

        public SalesRecordService(Udemy_FinalCSharp_Sales3Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                    .Include(x => x.Seller)
                    .Include(x => x.Seller.Department)
                    .OrderByDescending(x => x.Date)
                    .ToListAsync();
        }
    }
}