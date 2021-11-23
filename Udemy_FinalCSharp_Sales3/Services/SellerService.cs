using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Udemy_FinalCSharp_Sales3.Data;
using Udemy_FinalCSharp_Sales3.Models;
using Microsoft.EntityFrameworkCore;

namespace Udemy_FinalCSharp_Sales3.Services
{
    public class SellerService 
    {
       private readonly Udemy_FinalCSharp_Sales3Context _context;
       
       public SellerService(Udemy_FinalCSharp_Sales3Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }  

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    
    }
}