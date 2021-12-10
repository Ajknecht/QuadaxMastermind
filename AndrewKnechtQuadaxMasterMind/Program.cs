using System;

namespace AndrewKnechtQuadaxMasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            int guessesRemaining = 10;
            string playerInput = "";
            int[] magicNumber = numberGenerator.GetRandomFourDigitNumber();
            string[] results = new string[4];
            bool isMatch = false;

            MastermindMenus mastermindMenus = new MastermindMenus();
            mastermindMenus.MainMenu();
            Console.ReadKey();
            mastermindMenus.Hint();
            Console.ReadKey();
            while (!isMatch && guessesRemaining != 0)
            {
                mastermindMenus.GuessesRemaining(guessesRemaining);
                playerInput = mastermindMenus.UpdatePlayerInput();
                results = numberGenerator.CompareInputVsMagicNumber(playerInput, magicNumber);
                mastermindMenus.ShowResultsToPlayer(results);
                foreach (string result in results)
                {
                    if (result != "(+)")
                    {
                        guessesRemaining = guessesRemaining - 1;
                        break;
                    }
                }
                if ((results[0] == "(+)") && (results[1] == "(+)") && (results[2] == "(+)") && (results[3] == "(+)"))
                {
                    isMatch = true;
                    break;
                    //mastermindMenus.VictoryScreen(results);
                }
            }
            if (guessesRemaining > 0 && isMatch)
            {
                mastermindMenus.VictoryScreen(results);
            }
            if (guessesRemaining == 0)
            {
                mastermindMenus.SorryScreen();
            }
        }
    }
}
