﻿using Aloop;
using Lecture_23_10_2023_Alt.DB.Entity.GameAccounts;
using OopLab.DB.Entity;
using OopLab.DB.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab.UI
{
    public class ChooseOnePlayerUI
    {
        IGameService _gameService;
        public ChooseOnePlayerUI(IGameService gameService)
        {
            _gameService = gameService;
        }
        public void Action()
        {
            var game = (GameOnePlayerRating)_gameService.GetById(_gameService.GetAll().Count - 1);
            Console.Write("Виберіть, у якого гравця не зміниться рейтинг (1 або 2): ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                game.playRating1 = 0; game.playRating2 = game.playRating;
            }
            if (temp == 2)
            {
                game.playRating2 = 0; game.playRating1 = game.playRating;

            }
            else
            {
                Console.WriteLine("Введено некоректне значення!");
                Action();
            }
            _gameService.Update(game);
        }
    }
}
