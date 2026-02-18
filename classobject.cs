using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_s_Concepts
{
    public class classobject
    {
        public string istrName;
        public int iintId;
        public string istrEmail;
        
        public void getvalue(int aintId ,string astrName, string astrEmail=null )
        {
            istrName = astrName;
            iintId = aintId;
            istrEmail = astrEmail;
        }
        public void printvalues()
        {
            Console.WriteLine(iintId +" " +istrName + " "+istrEmail );
        }
     }
}
   