using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Triangle
{

    public class TestedClass
    {
        public bool Triangle(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            else return false;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
        }
    }
}
