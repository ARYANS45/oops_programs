namespace OOP_s_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
             class_object(); 
             cons_des();
             useofgarbage();
            
             exofstatic();
             copycons();
            
            //Console.WriteLine(useofconstructor.sintobjectcount);
            Console.ReadLine();

        }
        public static void class_object()
        {
            Console.WriteLine("This is a simple class and object program");

            classobject lobj = new classobject();
            lobj.getvalue(17, "aryan", "arya@gmail.com");
            lobj.printvalues();

            classobject lobj2 = lobj;
            lobj.getvalue(18, "sagar");
            lobj.printvalues();
        }
        public static void cons_des()
        {
            Console.WriteLine("Progarm for Constructor and destructor ");
            useofconstructor lobject = new useofconstructor();

            useofconstructor lobject2 = new useofconstructor(45, "Amar", "Amar@gmail.com");
            lobject2.printvalues();

            useofconstructor lobject3 = new useofconstructor(93, "Sumit", "Sumit@gmail.com");
            lobject3.printvalues();
        }
        public static void useofgarbage()
        {
            for (int i = 0; i < 100100; i++)

            {
                useofconstructor lobject3 = new useofconstructor(93, "Sumit", "Sumit@gmail.com");

                if (i % 100 == 0)
                {
                    GC.Collect();
                }
            }
        }

         public static void exofstatic()
         {
            useofstatic obj = new useofstatic("Aryan", 21);
            useofstatic obj2 = new useofstatic("omkar", 22);
            useofstatic.display();

            static12.show();
         }

       public static void copycons()
       {
          Area lobj = new Area();
          lobj.Length = 20;
          lobj.Width = 15;
          lobj.Show();

          Area lobjDuplicate = new Area(lobj);
          lobjDuplicate.Show();
      }
    }
}

