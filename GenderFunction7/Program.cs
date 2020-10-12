using System;

namespace GenderFunction7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender");
            string userInput = Console.ReadLine();
            Hello(userInput);
        }
        public static void Hello(string gender)
        {
            if (gender == "f")
            {
                Console.WriteLine("Hello, female");

            } else if (gender == "m")
            {
                Console.WriteLine("Hello, male");

            } else
            {
                Console.WriteLine("Hello unicorn");
            }





        }
       
        

        
            
                 
      
        
}   }







