using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matem3
{
    internal class Program
    {
        delegate void Mydelegate(int chislo);

        class matematika
        {
            public int a;
            public void calculatesamochislo(int chislo)
            {
                Console.WriteLine("Само число: " + a);
            }
            public void calculatecvadrat(int chislo)
            {
                int b = a * a;
                Console.WriteLine("\nКвадрат: " + b);
            }
            public void calculatecub(int chislo)
            {
                int c = a * a * a;
                Console.WriteLine("\nКуб: " + c);
            }
        }

        static void Main(string[] args)
        {
            matematika primer = new matematika();
            Mydelegate del = new Mydelegate(primer.calculatesamochislo);

            del += new Mydelegate(primer.calculatecvadrat);
            del += new Mydelegate(primer.calculatecub);
            primer.a = 2;
            del(2);

            Console.ReadLine();
        }
    }
}
