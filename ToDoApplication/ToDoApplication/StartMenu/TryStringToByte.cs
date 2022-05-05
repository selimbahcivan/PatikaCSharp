using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class TryStringToByte
    {
        public static byte StringToByte(string inputString)
        {
            if (Byte.TryParse(inputString, out byte outputByte))
            {
                return outputByte;
            }
            return 1;
        }
    }
}
