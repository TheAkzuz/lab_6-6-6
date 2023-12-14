using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_4
{
    delegate string MyDelegate(string d_marka, int d_speed);


    class Mashins
    {
        public string M;
       
        public string A_class (string m, int s)
        {
            M = "Это машина B класса с названием  " + m + " онa имеет скорость "+s;
          
            Console.WriteLine(M);
            return M;
        }


        public string B_class (string m , int s)
        {
         
            M = "Это машина B класса с названием  " + m + " онa имеет скорость " + s;

            Console.WriteLine(M);

            
            return M;
        }

    }





    internal class Program
    {




        static void Main(string[] args)
        {
            Mashins Avtosolon_Mirona = new Mashins();

            MyDelegate propety = new MyDelegate(Avtosolon_Mirona.A_class) ;

            propety += Avtosolon_Mirona.B_class;

            propety("BMW", 250);

            Console.ReadLine();

        }
    }
}
