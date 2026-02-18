using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_s_Concepts
{
    public class useofconstructor
    {
        public int iintId;
        public string istrName;
        public string istrEmail;
        public static int sintobjectcount=0;
        
        public useofconstructor ()   //Default Constructor
        {
            istrName = "undefined";
            istrEmail = "undefined";
            Console.WriteLine("I am in Default Constructor");
            sintobjectcount++;
            Console.WriteLine("Total objects created : " +sintobjectcount);
        }

        public useofconstructor(int aintId, string astrName,string astrEmail=null) //Parameterized Constructor
        {
            iintId = aintId;
            istrName = astrName;
            istrEmail = astrEmail;
            Console.WriteLine("I am in Parameterized Constructor");
            
            sintobjectcount++;
            Console.WriteLine("Total objects created : " + sintobjectcount);

        }

        public void printvalues()
        {
            Console.WriteLine(iintId+" "+istrName+" "+istrEmail);
        }
        
        ~useofconstructor()
        {
            Console.WriteLine("*******************I am in Destructor");
            sintobjectcount--;
        }

     }
}
