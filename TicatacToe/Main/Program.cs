using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerXName = getNames();
            waitSeconds(1);
            string playerYName = getNames();

            Board board = new Board();
            Timecounter timer = new Timecounter();
            Player playerX = new Player("X",playerXName);
            Player playerO = new Player("O",playerYName);
            var turn = 0;



            timer.StartTimer();

            while (board.CheckIfWon() == string.Empty) //who won actually?
            {
                board.PrintBoard();
                if (turn % 2 == 0)
                {
                    board.MakeAPlay(playerX.Symbol, playerX.Name);
                    waitSeconds(1);
                    turn++;
                }
                else
                {
                    board.MakeAPlay(playerO.Symbol, playerO.Name);
                    waitSeconds(1);
                    turn++;
                }
                
            }
            string winner;
            if (board.CheckIfWon().Contains("x")){
                winner = playerX.Name;
            }
            else { winner = playerO.Name; }
            timer.StopTimer();
            Console.WriteLine($"Congratulations {winner} you won this round");

            Console.ReadKey();
        }

        static string getNames()
        {
            Console.WriteLine("whats your name player?:");
            string name = Console.ReadLine();
            return name;

        }

        static void waitSeconds(int time)
        {
            System.Threading.Thread.Sleep(time*1000);
        }
      
    }
}
