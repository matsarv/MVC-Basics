using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Basics___Assignment_1.Models;

namespace MVC_Basics___Assignment_1.Controllers
{
    public class GuessingGameController : Controller
    {
        public const string SessionKeyRndNumber = "_RndNumber";
        public const string SessionKeyTryNumber = "_TryNumber";

        [HttpGet]
        public IActionResult Index()
        {
            int rndNumber = GuessingGame.RandomNumber();
            ViewBag.Rnd = rndNumber;

            HttpContext.Session.Clear();

            if (string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyRndNumber)))
            {
                HttpContext.Session.SetInt32(SessionKeyRndNumber,rndNumber);
                HttpContext.Session.SetString(SessionKeyTryNumber, "");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(int guessNumber, string autoRestart)
        {
            var rndNumber = HttpContext.Session.GetInt32(SessionKeyRndNumber);
            var tryNumbers = HttpContext.Session.GetString(SessionKeyTryNumber);

            string tryingNumbers = "";
            string startAgain = "";

            tryNumbers = GuessingGame.TryNumbers(tryNumbers, guessNumber);

            HttpContext.Session.SetString(SessionKeyTryNumber, tryNumbers);

            GuessingGame guessingGame = new GuessingGame();

            string guessResult = guessingGame.Guess(guessNumber, (int)rndNumber);

            if (guessResult == "Congratulation!")
            {
                tryingNumbers = "The number was " + rndNumber + " and your guessing numbers are: " + tryNumbers;

                // Button when finish guessing
                ViewBag.Restart = "Show";

                // Autorestart when finish guessing
                //startAgain = "You can now continue guessing on a new number.";
                //int getRndNumber = GuessingGame.RandomNumber();
                //HttpContext.Session.SetInt32(SessionKeyRndNumber, getRndNumber);
                //HttpContext.Session.SetString(SessionKeyTryNumber, "");

                // Redirect to run HttpGet
                //return RedirectToAction("Index", "GuessingGame");
            }

            ViewBag.Index = guessResult + autoRestart;
            ViewBag.Numbers = tryingNumbers;
            ViewBag.Again = startAgain;
            ViewBag.Rnd = rndNumber;

            return View();
        }
    }
}