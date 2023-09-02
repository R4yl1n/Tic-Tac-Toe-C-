using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GameHandler
    { 
        Board Board = new Board();

        //prints the play board

        public void MakeAPlay(string symbole, string name)
        {

            Console.WriteLine($"where do you want to place{symbole}choose from 0-8, {name}");
            var whereToPlace = Console.ReadLine();
            if (Int32.TryParse(whereToPlace, out int Place))
            {
                if (Place >= 0 && Place <= 9)
                {
                    Board.setField(Place, symbole);
                }
                else
                {
                    MakeAPlay(symbole, name);
                }
            }
            else
            {
                MakeAPlay(symbole, name);
            }
        }

        #region functions 
        public string CheckIfWon()
        {

            if (cordinatesSymbolPairs[0] == cordinatesSymbolPairs[1] && cordinatesSymbolPairs[0] == cordinatesSymbolPairs[2])
            {
                return cordinatesSymbolPairs[0];
            }
            else if (cordinatesSymbolPairs[3] == cordinatesSymbolPairs[4] && cordinatesSymbolPairs[3] == cordinatesSymbolPairs[5])
            {
                return cordinatesSymbolPairs[3];
            }
            else if (cordinatesSymbolPairs[6] == cordinatesSymbolPairs[7] && cordinatesSymbolPairs[6] == cordinatesSymbolPairs[8])
            {
                return cordinatesSymbolPairs[6];
            }
            else if (cordinatesSymbolPairs[0] == cordinatesSymbolPairs[3] && cordinatesSymbolPairs[0] == cordinatesSymbolPairs[6])
            {
                return cordinatesSymbolPairs[0];
            }
            else if (cordinatesSymbolPairs[1] == cordinatesSymbolPairs[4] && cordinatesSymbolPairs[1] == cordinatesSymbolPairs[7])
            {
                return cordinatesSymbolPairs[1];
            }
            else if (cordinatesSymbolPairs[2] == cordinatesSymbolPairs[5] && cordinatesSymbolPairs[2] == cordinatesSymbolPairs[8])
            {
                return cordinatesSymbolPairs[2];
            }
            else if (cordinatesSymbolPairs[0] == cordinatesSymbolPairs[4] && cordinatesSymbolPairs[0] == cordinatesSymbolPairs[8])
            {
                return cordinatesSymbolPairs[0];
            }
            else if (cordinatesSymbolPairs[2] == cordinatesSymbolPairs[4] && cordinatesSymbolPairs[2] == cordinatesSymbolPairs[6])
            {
                return cordinatesSymbolPairs[2];
            }

            else return "false";
        }

        #endregion


    }
}
