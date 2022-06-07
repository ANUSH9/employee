using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           employee obj = new employee();
            string a = obj.Insertemp();
            Console.WriteLine(a);
            
           
            Console.ReadLine();
           
        }
    }
}
