using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_s_Concepts
{
    internal class Area
    {
       public int Length;
       public int Width;

        public Area()
        {
            Length = 0;
            Width = 0;
        }

        /// <summary>
        /// copy constructor
        /// it is a parameterised constructor
        /// it take the same class object as a parameter 
        /// it is used to copy one object into another object.
        /// </summary>
        /// <param name="aobj"></param>
        public Area(Area aobj)
        {
            Length = aobj.Length;
            Width = aobj.Width;
        }

        public void Show()
        {
            Console.WriteLine($"Length : {Length} Width : {Width}");
        }
    }

}
