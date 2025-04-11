using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Syranne Jahziel M. Maestro    |   BSIT 3-4
//APP DEV Activity #1   |   April 11, 2025

namespace MAESTRO_KpopCompatibility
{
    internal class KpopCompatibilityChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////===== K-POP COMPATIBILITY CHECKER =====/////\n");

            string userName = GetInput("What's your name?");
            string idolName = GetInput("Which K-pop idol would you like to check compatibility with?");
            string idolGroup = GetInput("What group is this idol from?");
            string biasPosition = GetInput("What’s their main position? (e.g., Main Vocalist, Dancer, Rapper)");

            Console.WriteLine("\nRate the following from 1 to 10 based on how much you value them in a bias:\n");

            int visuals = GetRating("Visuals");
            int vocals = GetRating("Vocals");
            int dance = GetRating("Dance Skills");
            int personality = GetRating("Personality");
            int stagePresence = GetRating("Stage Presence");

            int totalScore = visuals + vocals + dance + personality + stagePresence;
            double compatibilityPercent = (totalScore / 50.0) * 100;

            ShowResult(userName, idolName, idolGroup, biasPosition, compatibilityPercent);
        }

        static string GetInput(string prompt)
        {
            Console.Write($"{prompt} ");
            return Console.ReadLine();
        }

        static int GetRating(string trait)
        {
            Console.Write($"How important is {trait}? ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void ShowResult(string user, string idol, string group, string position, double percent)
        {
            Console.WriteLine("\n===== Compatibility Results =====\n");
            Console.WriteLine($"Fan Name: {user}");
            Console.WriteLine($"Chosen Idol: {idol} of {group}");
            Console.WriteLine($"Idol's Position: {position}");
            Console.WriteLine($"\nYour Compatibility Score: {percent}%");

            if (percent >= 90)
            {
                Console.WriteLine("\nSoulmates! You and your idol are a PERFECT match!");
            }
            else if (percent >= 70)
            {
                Console.WriteLine("\nHigh Compatibility! You definitely vibe well with your bias.");
            }
            else if (percent >= 50)
            {
                Console.WriteLine("\nNot bad! You have some differences, but that's what makes it interesting.");
            }
            else
            {
                Console.WriteLine("\nOpposites attract? You might admire from afar. Still iconic tho!");
            }

            Console.WriteLine("\nThanks for playing the K-Pop Compatibility Checker!");
        }
    }
}
