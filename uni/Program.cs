﻿using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] startBoard =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            char[,] gameBoard = startBoard.Clone() as char[,];

            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true;

            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();

                if (nextIsPlayer1)
                {
                    nextIsPlayer1 = false;
                }
                else
                {
                    nextIsPlayer1 = true;
                }

                if (player1Won || player2Won)
                {
                    break;
                }
            }
        }
    }
}