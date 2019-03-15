using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MVC_Basics___Assignment_1.Models
{
    public class GuessingGame
    {
        string guess = "";
        string stringResult = "";

        public string Guess(int guessNumber, int rndNumber)
        {
            if (guessNumber.Equals(0))
            {
                guess = "Please enter a number before press button.";
            }
            else if (guessNumber == rndNumber)
            {
                guess = "Congratulation!";

            }
            else
            {
                if (guessNumber < rndNumber)
                {
                    stringResult = "Your guess is below the number.";
                }
                else
                {
                    stringResult = "Your guess is above the number.";
                }
                guess = "Sorry! " + stringResult; // + " (" + rndNumber + ")";
            }

            return guess;
        }

        public static string TryNumbers(string tryNumbers, int guessNumber)
        {
            if (tryNumbers == "")
            {
                tryNumbers = Convert.ToString(guessNumber);
            }
            else
            {
                tryNumbers = tryNumbers + ", " + Convert.ToString(guessNumber);
            }
            return tryNumbers;
        }

        public static int RandomNumber()
        {
            Random rnd = new Random();
            int guessNumber = rnd.Next(1, 100);

            return guessNumber;
        }
    }
}
