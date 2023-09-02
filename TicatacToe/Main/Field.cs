using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Field
    {

        public int Index { get; set; }
        public string Symbole { get; set; } = string.Empty;

        public Field(int index, string symbole)
        {
            Index = index;
            Symbole = symbole;
        }
        public bool IsEmpty()
        {
            if (Symbole == string.Empty) return true;
            return false;
        }
    }
}
