using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstRandomRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;
            
            Random randomGen = new Random();
            
            Console.WriteLine("Press any key to spin the roulette.");
            Console.WriteLine("And try to hit the 10!");
            Console.ReadKey();
            Start:
            int random1 = randomGen.Next(1, 6);
            int random2 = randomGen.Next(1, 6);
            int output = Add(random1, random2);
            Console.WriteLine(output);
            
            if(output == 10)
            {
                Console.WriteLine("BULLSEYE!");
            }else if (output == 9)
            {
                Console.WriteLine("So close!");
            }else if (output == 8)
            {
                Console.WriteLine("Almost had it!");
            }
            tries++;
            while(output != 10)
            {
                Console.ReadKey();
                goto Start;
            }
            Console.WriteLine("You hit the jackpot after " + tries + " tries.");
            Thread.Sleep(2000);


        }


       public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }
    

    }
}
