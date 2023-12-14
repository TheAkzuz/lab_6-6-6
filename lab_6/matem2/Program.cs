using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matem2
{
    internal class Program
    {

        class matematika
        {
            public int a;
            public void calculate(int chislo)
            {
                int b = a * a;
                int c = a * a * a;
                int d = a * a * a * a;
                Console.WriteLine("Само число: " + a + "\nКвадрат: " + b + "\nКуб: " + c + "\nЧетвертая степень: " + d);

            }

        }
        delegate void Mydelegate(int chislo);
        static void Main(string[] args)
        {
            matematika primer = new matematika();

            Mydelegate del = new Mydelegate(primer.calculate);
            primer.a = 2;
            del(1);
            primer.a =3;
            del(2);
            primer.a = 4;
            del(3);


            Console.ReadLine();
        }
    }
}
