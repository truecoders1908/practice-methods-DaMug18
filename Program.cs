using System;

namespace Practice_Method
{
    class Program
    {
        public static string returnString()
        {
            return "This is a string";

        }
        public static int returnint()
        {
            return 3;
        }

            public static bool returnBool()
        {
            return true;
        }

    
        static void Main(string[] args)
        {
            int myint = Program.returnint();
            Console.WriteLine(myint);
            {
                string mystring = Program.returnString();
                Console.WriteLine(mystring);
                {
                    bool mybool = Program.returnBool();
                    Console.WriteLine(mybool);
                }

            }
            
             
           
        }
    }
}
