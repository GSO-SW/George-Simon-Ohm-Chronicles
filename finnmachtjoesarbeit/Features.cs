using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGSOTextgame_V_0_1
{
    public class Features
    {
        public static void WriteAtPosition(int x,int y, string sText)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sText);
        }

    }
}
