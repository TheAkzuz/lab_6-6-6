using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasswithEvent
{
    internal class Program
    {
        public delegate void EventHandler();

        class IgralnayaKost
        {
            Random r;

            public event EventHandler max;

            public IgralnayaKost()
            {
                r = new Random();
            }

            public int random()
            {
                //Случайное число от 1 до 6
                int res = r.Next(6) + 1;



                if (res == 6)
                {
                    max();
                }
                return res;
            }
        }

        public static void Metodobrabotchik()
        {
            Console.WriteLine("Выпало максимальное количество очков");
        }




        static void Main(string[] args)
        {
            IgralnayaKost brosok = new IgralnayaKost();

            brosok.max += new EventHandler(Metodobrabotchik);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("{0}", brosok.random());
            }

            Console.ReadLine();
        }
    }
}
