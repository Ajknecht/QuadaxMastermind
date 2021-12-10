using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKnechtQuadaxMasterMind
{
    class MastermindMenus
    {
        public void MainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine("               Hello and welcome to MasterMind!");
            Console.WriteLine("        I'm thinking of a number between 1111 and 6666!");
            Console.WriteLine(" Please enter a 4 digit number, where each digit is between 1 and 6");
            Console.WriteLine("");
            Console.WriteLine("         *Please press enter at any time to continue*");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public void Hint()
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine($"                    Psst... Here's a hint!");
            Console.WriteLine("    I'll print a minus (-) sign for every digit that is correct");
            Console.WriteLine("                     but in the wrong position");
            Console.WriteLine("");
            Console.WriteLine("    I'll print a plus (+) sign for every digit that is both correct");
            Console.WriteLine("                     and in the correct position");
            Console.WriteLine("");
            Console.WriteLine("    But if the digit is nowhere in the number I'm thinking of,");
            Console.WriteLine("                 I got nothing for you, my friend.");
            Console.WriteLine("");
            Console.WriteLine("                 Press Enter to start the game!");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public void GuessesRemaining(int i)
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine($"             You have {i} guesses remaining");
            Console.WriteLine("               Please enter your guess now:");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public void KeepGuessing()
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine("           I'm sorry that's not the right number");
            Console.WriteLine("        I'm thinking of a number between 0001 and 6666!");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public string UpdatePlayerInput()
        {
            return Console.ReadLine();
        }
        public void ShowResultsToPlayer(string[] results)
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine("                             TADA:");
            Console.WriteLine($"     Your results are: {results[0]} | {results[1]} | {results[2]} | {results[3]}");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public void VictoryScreen(string[] results)
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine("                         CONGRATULATIONS!");
            Console.WriteLine($"   Your results are: {results[0]} | {results[1]} | {results[2]} | {results[3]}");
            Console.WriteLine("                      THANK YOU FOR PLAYING!");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
        public void SorryScreen()
        {
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
            Console.WriteLine("                   Sorry, you're out of guesses!");
            Console.WriteLine($"                     Better luck next time!");
            Console.WriteLine("                      THANK YOU FOR PLAYING!");
            Console.WriteLine("");
            Console.WriteLine("====================================================================");
            Console.WriteLine("");
        }
    }
}
