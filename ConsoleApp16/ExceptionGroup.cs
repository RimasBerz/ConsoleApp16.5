using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class ExceptionGroup
    {
        class PersonExceptionNameG : ArgumentException
        {
            public string Value { get; }
            public PersonExceptionNameG(string message, string value) : base(message)
            {
                Value = value;
            }
        }
        class PersonExceptionNumberG : ArgumentException
        {
            public int Value { get; }
            public PersonExceptionNumberG(string message, int value) : base(message)
            {
                Value = value;
            }
        }
    }
}
