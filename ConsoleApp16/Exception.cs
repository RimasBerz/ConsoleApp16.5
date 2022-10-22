using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class StudentNotNormalException : Exception
    {

        public StudentNotNormalException() { }

        public StudentNotNormalException(string message) : base(message)
        {
            if (message == " Гитлер" || message == "Gitler")
            {
                Console.WriteLine("Ne gitler");
            }
            else
            {
                Console.WriteLine("Молодец");
            }
        }
    }
    class PersonExceptionName : ArgumentException
    {
        public string Value { get; }
        public PersonExceptionName(string message, string value) : base(message)
        {
            Value = value;
        }
    }
   
}
