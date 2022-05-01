using Cow_and_Bulls_game.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cow_and_Bulls_game.Controllers
{
    public class GameController : Controller
    {
        GameData result = new GameData();
        public IActionResult GamePage()
        {
            return View();
        }
        public IActionResult GameResult(GameData GuessedNumber)
        {
            int bulls = 0;
            int cows = 0;
            var day = DateTime.Now.ToString("dd");
            var Hour = DateTime.Now.ToString("HH");
            string guessedNumber = GuessedNumber.number;
            string curentTime = $"{day}{Hour}";
            
            //If the guessed number is equal to the secret number
            if (int.Parse(guessedNumber) == int.Parse(curentTime))
            {
                result.isWon = true;
                result.msg = "You Win";
                result.bulls = 4; 
                result.turns = Turn.turn +1;
                return View(result);
            }

            //If the guess number is not equal to the secret number 
            else
            {
                result.isWon = false;
                result.turns = Turn.turn + 1;
                Turn.turn++;

                for (int i = 0; i < 4; i++)
                {
                    //Counting the total number of bulls and If match with any digit then removing the digit & position
                    if (guessedNumber[i] == curentTime[i])
                    {
                        curentTime.Remove(curentTime.IndexOf(curentTime[i]));
                        guessedNumber.Remove(guessedNumber.IndexOf(guessedNumber[i]));
                        bulls++;
                    }

                }
                foreach (char c in guessedNumber)
                {
                    //Counting the total number of cows and If match with any digit then removing the digit 
                    if (curentTime.Contains(c))
                    {
                        cows++;
                        curentTime.Remove(curentTime.IndexOf(c));
                    }
                }

                //Displaying the result here If user loose the game
                result.msg = "The secret number and the guess number are different.";
               
                result.bulls = bulls;
                result.cows = cows;
                return View(result);
            }
        }
    }
}
