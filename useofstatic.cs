using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_s_Concepts
{
    public class useofstatic
    {
        public String istrname;
        public static int iintage;
        public  useofstatic()
        {
            Console.WriteLine("i am in default constructor");
        }
        public useofstatic(string astrname, int aintage)
        {
            Console.WriteLine("i am in parameter constructor");

            istrname = astrname;
            iintage = aintage; 
            Console.WriteLine(istrname+" "+iintage);
         }
         static void display()
        {
            Console.WriteLine("I am in static method ");
            Console.WriteLine("*********************************************");


        }
        static useofstatic()
         {
            Console.WriteLine("i am in static constructor ");
         }
    } 
    static  class static12
    {
       public static int number;
        public  static void show()
        {
            Console.WriteLine("I am in static class ");

            number=20;
            Console.WriteLine("Number = "+number);
        }
         static static12()
        {
            Console.WriteLine("i am in static constructor of static12 class");
        }
    }
}
