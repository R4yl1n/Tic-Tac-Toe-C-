using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Board
    {
        public Board()
        {
            FillDictionary();
        }


        #region FieldsLogic
        public List<Field> Fields = new List<Field>();

        private void FillDictionary()
        {
            var fields = new List<Field>();
            for (int i = 0; i <= 8; i++)
            {
                fields.Add(new Field(i, string.Empty));
            }
            Fields = fields;
        }
        #endregion

        #region PrintBoard
        public void PrintBoard()
        {
            for (int i = 0; i <= 8;)
            {


                if (i % 3 == 0 && i != 0)
                {
                    Console.Write("\n___________\n");
                }

                Console.Write($"{Fields[i]} |");
                i++;
            }
        }

        //create space in between play
        public void Linebreak()
        {
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("");
            }
        }

        internal void setField(int place)
        {
            throw new NotImplementedException();
        }
        #endregion

        public void setField(int place, string symbole)
        {
            if (Fields[place].IsEmpty())
            {
                Fields[place].Symbole = symbole;
            }
        }
    }
}
