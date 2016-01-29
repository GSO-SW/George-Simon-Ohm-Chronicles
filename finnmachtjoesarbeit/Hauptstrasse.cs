using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnmachtjoesarbeit
{
    class Hauptstrasse
    {
        game gameclass = new game();
        Haus DaHaus;
        pAngelshop DaAngelshop;
        pKiosk DaKiosk;
        pWerkstatt DaWerkstatt;


        public void Strasse()
        {
            Autounfall y = new Autounfall(gameclass);
            y.vorfinden();
            DaHaus = new Haus(gameclass);
            DaAngelshop = new pAngelshop(gameclass);
            DaKiosk = new pKiosk(gameclass);
            DaWerkstatt = new pWerkstatt(gameclass);
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Du stehst auf der Hauptstrasse\n");
                Console.WriteLine("Standartbefehle : \ngehe zu x\nuntersuche x\numsehen\nweiter gehen\nzurück gehen\n");

                switch (Console.ReadLine())
                {
                    case "umsehen":
                        Console.Clear();
                        Console.WriteLine("Freigeschaltete Orte : \nKiosk\nAngelshop\nWohnhaus\nWerkstatt\nAutounfall");
                        if (gameclass.Infos == true)
                            Console.WriteLine("Safehouse");
                        Console.ReadKey();
                        break;

                    case "zurück gehen":
                        Console.WriteLine("Du stehst auf der Hauptstrasse\n");
                        Console.WriteLine("Standartbefehle : \ngehe zu x\nuntersuche x\numsehen\nweiter gehen\nzurück gehen\n");
                        break;

                    case "gehe zu Wohnhaus":
                        DaHaus.InfosFinden();
                        break;

                    case "gehe zu Autounfall":
                        Console.Clear();
                        y.rueckkehren();
                        Console.ReadKey();
                        break;

                    case "gehe zu Kiosk":
                        DaKiosk.KioskBetreten();
                        break;

                    case "gehe zu Werkstatt":
                        DaWerkstatt.WerkstattBetreten();
                        break;

                    case "gehe zu Angelshop":
                        DaAngelshop.AngelshopBetreten();
                        break;

                    case "gehe zu Safehouse":
                        if (gameclass.Infos == true)
                        {
                            if (gameclass.Mofa == true)
                            {
                                if (gameclass.KanisterSchlauch == true && gameclass.Kanistervoll == true)
                                {
                                    if (gameclass.Snickers == true && gameclass.Wasserflasche == true)
                                    {
                                        int z = 1;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        do
                                        {
                                            switch (z)
                                            {
                                                case 1:
                                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                                    Console.Clear();
                                                    z++;
                                                    break;
                                                case 2:
                                                    Console.BackgroundColor = ConsoleColor.Green;
                                                    Console.Clear();
                                                    z++;
                                                    break;
                                                case 3:
                                                    Console.BackgroundColor = ConsoleColor.Blue;
                                                    Console.Clear();
                                                    z++;
                                                    break;
                                                case 4:
                                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                                    Console.Clear();
                                                    z++;
                                                    break;
                                                case 5:
                                                    Console.BackgroundColor = ConsoleColor.Red;
                                                    Console.Clear();
                                                    z = 1;
                                                    break;
                                            }
                                            Console.SetCursorPosition(26, 9);
                                            Console.Write("Du hast das Spiel gewonnen !");
                                            Console.SetCursorPosition(26, 12);
                                            Console.Write("  Herzlichen Glückwunsch !");
                                            System.Threading.Thread.Sleep(35);
                                        } while (true);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Herzlichen Glückwunsch!");
                                        Console.ReadKey(true);
                                        Console.WriteLine("Du bist auf dem Weg verhungert ;)");
                                        Console.ReadKey(true);
                                        MainMenu menu = new MainMenu();
                                        menu.Tod();
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Das Safehouse ist zuweit entfernt um es zufuß zu erreichen\nDein Mofa hat Leider keinen Saft");
                                    Console.ReadKey(true);
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Das Safehouse ist zuweit entfernt um es zufuß zu erreichen");
                                Console.ReadKey(true);
                            }
                        }
                        break;
                }
            } while (true);
        }
    }
}
