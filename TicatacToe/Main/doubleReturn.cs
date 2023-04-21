using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class DoubleReturn
    {
        public List<string> BoolAndString(bool Value, string Message)
        {
            var doublepack = new List<string>(){Value.ToString(), Message };
            return doublepack;
        }

        private bool CheckIfContainTrue(List<string> doublepack)
        {
            if (doublepack.Contains("true")){
                return true;
            }
            else return false;
        }
        

         
    }
}
