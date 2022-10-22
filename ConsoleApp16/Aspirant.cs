using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Aspirant : Student
    {
        string dissertqazia;
        public string Dissertqazia{ get; set; }
        public Aspirant(string name, string surname, string fathername,string dissertqazia)
        {
            Dissertqazia = dissertqazia;
        }
        public Aspirant()
           : this("Name", "Surname", "FN","Dissertazia po teme Matiz v c#") { }
        public override string ToString()
        {
            return base.ToString() + ", Dissertazia: " + dissertqazia;
        }

    }
}
