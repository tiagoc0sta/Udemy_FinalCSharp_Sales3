using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Udemy_FinalCSharp_Sales3.Data;
using Udemy_FinalCSharp_Sales3.Models;

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
    
    }
}