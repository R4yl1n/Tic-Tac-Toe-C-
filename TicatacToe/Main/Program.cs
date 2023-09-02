using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


//constructor im Board für Board class wo alles zügs macht im Board zb DICT erstelle
//Player cload en overload für de constructor
//clean everything
//logik aufgaben aufteilen

//Fieldclassene erstellen
//bool richtig bennenen zb ISvalid oder isrunning

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerXName = getNames();
            waitSeconds(1);
            string playerYName = getNames();

            GameHandler board = new GameHandler();
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
