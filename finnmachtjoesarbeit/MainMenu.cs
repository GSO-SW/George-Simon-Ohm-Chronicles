using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnmachtjoesarbeit
{
    class MainMenu
    {
        public void Tod()
        {
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(26, 9);
            Console.Write("      GAME OVER");
            Console.SetCursorPosition(26, 12);
            Console.Write("Press any Key to Restart");
            Console.ReadKey(true);
            Hauptmenu();
        }

        public void Hauptmenu()
        {
            ConsoleKeyInfo op = new ConsoleKeyInfo();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetCursorPosition(2, 2);
            Console.Write("Hauptmenü");
            Console.SetCursorPosition(2, 4);
            Console.Write("Kapitel 1");
            Console.SetCursorPosition(2, 6);
            Console.Write("Kapitel 2");
            Console.SetCursorPosition(2, 8);
            Console.Write("Spiel schließen");

            int i = 0;
            do
            {
                op = Console.ReadKey();
                switch (op.Key)
                {
                    case ConsoleKey.UpArrow:
                        switch (i)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Kapitel 1");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                i = 1;
                                break;
                            case 1:
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Kapitel 1");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                i = 1;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.Write("Kapitel 1");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                i = 2;
                                break;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        switch (i)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Kapitel 1");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                i = 1;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.Write("Kapitel 1");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                i = 2;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.SetCursorPosition(2, 2);
                                Console.Write("Hauptmenü");
                                Console.SetCursorPosition(2, 4);
                                Console.Write("Kapitel 1");
                                Console.SetCursorPosition(2, 6);
                                Console.Write("Kapitel 2");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(2, 8);
                                Console.Write("Spiel schließen");
                                Console.ForegroundColor = ConsoleColor.White;
                                i = 3;
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (i)
                        {
                            case 0:
                                break;
                            case 1:
                                Episode1 e1 = new Episode1();
                                e1.StartNewGame();
                                break;
                            case 2:
                                Krankenhouse k = new Krankenhouse();
                                k.GameStart();
                                Hauptstrasse q = new Hauptstrasse();
                                q.Strasse();
                                break;
                            case 3:
                                Hauptstrasse zt = new Hauptstrasse();
                                zt.Strasse();
                                break;
                        }
                        break;
                    default:
                        break;
                }

            } while (true);
        }
    }
}
