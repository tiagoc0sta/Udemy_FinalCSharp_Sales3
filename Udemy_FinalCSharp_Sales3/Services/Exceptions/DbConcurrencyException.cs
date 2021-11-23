using System;


namespace Udemy_FinalCSharp_Sales3.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    { 
        public DbConcurrencyException(string message) : base(message)
        {

        }
        
    }
}