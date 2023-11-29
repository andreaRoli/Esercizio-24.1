using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato c=new Quadrato();

            Console.WriteLine("Inserisci la misura del lato");
            c.Lato=float.Parse(Console.ReadLine());

            float superficie = c.Lato * c.Lato;

            Console.WriteLine("L'are del quadrato è: {0}", superficie);
            Console.ReadLine();
        }
    }
}
