using System;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int choice = 0;
            int n;
            while (choice == 0)
            {
                Console.WriteLine("Ask a Question:");
                Console.ReadLine();
                Random r = new Random();
                n = r.Next(5);
               
                switch (n)
                {
                    case 0:
                        Console.WriteLine("Yes");
                        break;
                    case 1:
                        Console.WriteLine("No");
                        break;
                    case 2:
                        Console.WriteLine("Possibly");
                        break;
                    case 3:
                        Console.WriteLine("Quite Likely");
                        break;
                    case 4:
                        Console.WriteLine("Try Again");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Enter 0 to go again Or 1 Quit");
               choice=Convert.ToInt32(Console.ReadLine());

            }

        }
 
    }

}
