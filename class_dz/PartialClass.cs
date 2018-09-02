using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dz
{
    partial class Pie
    {
        public DateTime GetDate()
        {
            return dateCreate;
        }

        public static bool IsNumber(string numberAsString, ref int number)
        {
            try
            {
                number = int.Parse(numberAsString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
