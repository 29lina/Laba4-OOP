using Aloop;
using Lecture_23_10_2023_Alt.DB.Entity.GameAccounts;
using Lecture_23_10_2023_Alt.DB.Services;
using OopLab.DB;
using OopLab.DB.Entity;
using OopLab.DB.Services;
using OopLab.DB.Services.Base;
using OopLab.Games;
using OopLab.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopLab
{
    public class Program
    {
        static void Main(string[] args)
        {

            var context = new DbContext();
            var accountService = new GameAccountService(context);
            var gameService = new GameService(context);
            // Встановлюємо кодування консолі на UTF-8 для підтримки спеціальних символів.
            Console.OutputEncoding = Encoding.UTF8;

            var starterChoose = new StarterChooseUI(accountService, gameService);
            starterChoose.Action();
        }

    }
}
