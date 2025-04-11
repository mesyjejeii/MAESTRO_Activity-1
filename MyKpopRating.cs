using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Syranne Jahziel M. Maestro    |   BSIT 3-4
//APP DEV Activity #1   |   April 11, 2025

namespace SimpleKpopMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== K-POP IDOL MATCH ====\n");

            Console.Write("What’s your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("\nChoose one:\n1. Energetic & Funny\n2. Calm & Cool\n3. Stylish & Elegant");
            Console.Write("Your vibe (1-3): ");
            int vibe = Convert.ToInt32(Console.ReadLine());

            string match = "";

            switch (vibe)
            {
                case 1:
                    match = "Hoshi (SEVENTEEN)";
                    break;
                case 2:
                    match = "IU";
                    break;
                case 3:
                    match = "Lisa (BLACKPINK)";
                    break;
                default:
                    match = "a unique mix of many idols!";
                    break;
            }

            Console.WriteLine($"\n{name}, your idol match is: {match} 💖");
        }
    }
}