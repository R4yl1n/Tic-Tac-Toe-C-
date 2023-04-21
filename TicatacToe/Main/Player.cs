using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Player 
    {
        public string Name { get; set; }

        public readonly string Symbol;

        public Player(string symbol, string name)
        {
            Name =  name;
            Symbol = symbol;
        }

    }
}
