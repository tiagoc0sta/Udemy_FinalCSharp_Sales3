using System;


namespace Udemy_FinalCSharp_Sales3.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
       
    }
}