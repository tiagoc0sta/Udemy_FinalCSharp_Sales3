using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Udemy_FinalCSharp_Sales3.Models;

namespace Udemy_FinalCSharp_Sales3.Data
{
    public class Udemy_FinalCSharp_Sales3Context : DbContext
    {
        public Udemy_FinalCSharp_Sales3Context (DbContextOptions<Udemy_FinalCSharp_Sales3Context> options)
            : base(options)
        {
        }

        public DbSet<Udemy_FinalCSharp_Sales3.Models.Department> Department { get; set; }
    }
}
