using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona(2005);

            Console.WriteLine("età:{0}", p.CalcolaEtà());

            Console.ReadLine();
        }
    }
}
