using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Start();
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void Start()
        { 

        int selection = Choice();

            switch (selection)
            {
            case 1:
            Tiger Tiger = new Tiger(95, 200, 55, "Tiger");
            Tiger.Description();
            Console.WriteLine("To exit press Escape, and any other key to continue");
            break;
            case 2:
            Lion Lion = new Lion(120, 190, 70, "Lion");
            Lion.Description();
            Console.WriteLine("To exit press Escape, and any other key to continue");
            break;
            case 3:
            Leopard Leopard = new Leopard(65, 31, 50, "Leopard");
            Leopard.Description();
            Console.WriteLine("To exit press Escape, and any other key to continue");
            break;
            default:
            Console.WriteLine("Wow! Your input is incorrect");
            Console.WriteLine("To exit press Escape, and any other key to continue");
            break;
            }
        }

        public static int Choice()
        {                
                Console.WriteLine("\n" + "Select the breed of big cats:");
                Console.WriteLine(" For information about Tiger, press 1");
                Console.WriteLine(" For information about Lion, press 2");
                Console.WriteLine(" For information about Leopard, press 3");
                Console.WriteLine("Type 1 or 2 or 3:");
                int selection = Convert.ToInt32(Console.ReadLine());
                return selection;
        }
        
    }
}
