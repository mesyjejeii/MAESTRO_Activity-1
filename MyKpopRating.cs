using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Syranne Jahziel M. Maestro    |   BSIT 3-4
//APP DEV Activity #1   |   April 11, 2025

namespace MAESTRO_Activity__1
{
    internal class MyKpopRating
    {
        static void Main(string[] args)
        {
        //user input
            Console.WriteLine("/////===== Who is your favorite K-Pop Idol? =====/////\n");

            Console.Write("What's your Name? ");
            string name = Console.ReadLine();

            Console.Write("Who's your favorite K-pop Idol? ");
            string idol = Console.ReadLine();

            Console.Write("What's the name of their Group? ");
            string groupName = Console.ReadLine();

            Console.Write("Are they from a Boy or Girl Group? ");
            string groupType = Console.ReadLine();

            Console.Write("What Generation are they from? (1st to 6th): ");
            string generation = Console.ReadLine();

            //asking for ratings based on idol and group
            Console.Write("\nOn a scale of 1 to 10...");
            
            Console.Write("\nHow much do you like {0}? ", idol);
            int idolRating = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much do you like their Group? ");
            int groupRating = Convert.ToInt32(Console.ReadLine());

            //calculate the total rating
            int totalScore = CalculateRating(idolRating, groupRating);

            ShowFanReport(name, idol, groupName, groupType, generation, idolRating, groupRating, totalScore);
        }

        //function to calculate total rating
        static int CalculateRating(int idol, int group)
        {
            return idol + group;
        }

        //displaying output
        static void ShowFanReport(string fanName, string idolName, string groupName, string type, string gen, int idolRating, int groupRating, int score)
        {
            Console.WriteLine("\n-----oooooooooooooooooooooooooooooooooooooooooooooooooo-----");
            Console.WriteLine("\nResults!\n");
            Console.WriteLine($"Name: {fanName}");
            Console.WriteLine($"Favorite Idol: {idolName}");
            Console.WriteLine($"Group: {groupName}");
            Console.WriteLine($"Group Type: {type}");
            Console.WriteLine($"Generation: {gen}\n");
            Console.WriteLine("-----oooooooooooooooooooooooooooooooooooooooooooooooooo-----");

            Console.WriteLine($"\n{fanName}, you’ve got great taste! {idolName} really is something special.");

            Console.WriteLine($"\nYour K-Pop Ratings...");
            Console.WriteLine($"{idolName}'s: {idolRating}/10");
            Console.WriteLine($"{groupName}'s: {groupRating}/10");

            Console.WriteLine($"\nYour Total Rating: {score}/20");

            //make a fan rating summary
            if (score >= 18)
            {
                Console.WriteLine("You’re a SUPER FAN! Keep supporting!");
            }
            else if (score >= 12)
            {
                Console.WriteLine("You’re a loyal fan! Keep on slaying!");
            }
            else
            {
                Console.WriteLine("You’re a casual fan, but still awesome!");
            }

            Console.WriteLine("\nThanks for sharing your love for K-pop! Keep streaming!!!");

            Console.WriteLine("\n-------------------------------------------------");

        }
    }
}