using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheGSOTextgame_V_0_1
{
    public class Layout
    {
        public static void Design()
        {
            int width;
            int height;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            width = 120 ;
            height = 30 ;
            Console.SetWindowSize(width, height);
            Console.Title = "George-Simon-Ohm Chronicles: 1. Episode Dragons`n Dungeons";
        }
        public static void Layout_Text(string sText)
        {
            Console.SetCursorPosition(5, 5);
            foreach (Char item in sText)
            {
                Console.Write(item);
                Thread.Sleep(35);
            }
        }
        public static string Layout_Auswahl(string sText1, string sText2, string sText3, string sText4)
        {
            string sInput;
            string sSelection = null;
            bool bRightInput = false;
            Features.WriteAtPosition(5, 20, sText1);
            Features.WriteAtPosition(25, 20, sText2);
            Features.WriteAtPosition(5, 23, sText3);
            Features.WriteAtPosition(25, 23, sText4);
            

            

            do
            {
                Features.WriteAtPosition(5, 25, "Bitte Auswahl Eingeben:");
                Features.WriteAtPosition(5, 26, "Ihre Auswahl:");
                sInput = Console.ReadLine();
                if (sInput == sText1)
                {
                    sSelection = "A1";
                    bRightInput = true;
                }
                else if (sInput == sText2) 
                {
                    sSelection = "A2";
                    bRightInput = true;
                }
                else if (sInput == sText3) 
                {
                    sSelection = "A3";
                    bRightInput = true;
                }
                else if (sInput == sText4) 
                {
                    sSelection = "A4";
                    bRightInput = true;
                }
                else
	            {
                    bRightInput = false;
                    Features.WriteAtPosition(30, 26, "|Ungültige Eingabe");
                }

            } while (bRightInput == false);
            return sSelection;
        }
        public static void Layout_Text2(int x,string sText)
        {
            Console.SetCursorPosition(5, x);
            foreach (Char item in sText)
            {
                Console.Write(item);
                Thread.Sleep(35);
            }
        }
    }
}
