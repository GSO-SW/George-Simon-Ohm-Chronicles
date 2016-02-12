using ConsoleApplication5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Textgaming_Schuetze;
using TheGSOTextgame_V_0_1;

namespace finnmachtjoesarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout.Design();
            game mygame = new game();
            MainMenu Menu = new MainMenu();
            Menu.Hauptmenu();
        }
    }

    class Haus
    {
        game legame;
        MainMenu menu = new MainMenu();
        bool InfosGefunden, infiziertegecleared, waffe;

        public Haus(game mygame)
        {
            legame = mygame;
        }
        public void InfosFinden()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            InfosGefunden = legame.Infos;
            infiziertegecleared = legame.HouseClear;
            waffe = legame.Machete;

            bool schlüssel = false;
            bool dings = false;
            bool dingss = true;
            bool entkommen = false;

            if (infiziertegecleared == false)
            {
                Console.WriteLine("Du öffnest die Haustür und hörst aus dem Inneren ein Röcheln\nMöchtest du das Haus betreten?");
                do
                {
                    switch (Console.ReadLine())
                    {
                        case "Ja":
                        case "ja":
                            Console.Clear();
                            Console.WriteLine("Im Flur angekommen rennen mehrere Infizierte auf dich zu\nDu kannst sie >angreifen< oder >flüchten<");
                            do
                            {
                                switch (Console.ReadLine())
                                {
                                    case "angreifen":
                                        if (waffe == true)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Du konntest erfolgreich alle Infizierten aufschlitzen =b\nWat nu?");
                                            infiziertegecleared = true;
                                            dings = false;
                                            dingss = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Obwohl es dir gelang einen gegner mit deinen blossen Händen zu erdrosseln,\nHattest du ohne Waffe leider keine Chance gegen die Übermacht an Infizierten.\nUnlocked Archievment! [get Killed]");
                                            menu.Tod();
                                        }
                                        break;
                                    case "flüchten":
                                        Random likehood = new Random();
                                        int x = likehood.Next(0, 2);
                                        if (x == 0)
                                        {
                                            Console.WriteLine("Du bist erfolgreich entkommen"); dingss = false; entkommen = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Diesmal warst du Leider nicht schnell genug\nDie Infizierten haben dich eingeholt, überrumpelt und brutal siziert");
                                            menu.Tod();
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Das kannst du hier leider nicht machen");
                                        break;
                                    case "Ersma zu Penny":
                                        Console.WriteLine("gz");
                                        dings = true;
                                        break;
                                }
                            } while (dingss == true);
                            break;
                        case "Nein":
                        case "nein":
                            Console.Clear();
                            Console.WriteLine("Du kehrst zur Hauptstrasse zurück");
                            dings = false;
                            entkommen = true;
                            break;
                        default:
                            Console.WriteLine("auch gut, das war aber eine ja/nein frage...");
                            dings = true;
                            break;
                    }
                }
                while (dings == true);

            }
            else
                Console.WriteLine("Du stest in einem Flur\nZu deinen Füßen die geschändeten Leichen,\ndie du bei deinem letzten Besuch zurückgelassen hast");
            if (entkommen == false)
            {
                do
                {
                    switch (Console.ReadLine())
                    {
                        case "weiter gehen":
                            Console.Clear();
                            Console.WriteLine("Du kommst in ein Wohnzimmer");
                            do
                            {
                                switch (Console.ReadLine())
                                {
                                    case "umsehen":
                                        Console.WriteLine("Ein verwüßtetes Wohnzimmer\nAlle Türen, ausser die aus der du gekommen bist, wurden verrammelt.\nEin schimmelndes >Sofa< wurde vor die Hintertür geschoben.\nDer zugehörige Fernseher flimmert fröhlich vor sich her.\nVon der Einbauküche ist nur noch ein verbeulter >Kühlschrank< übrig geblieben.\nVorm Fenster steht ein IKEA->Schreibtisch<.\nEs herrscht ein furchtbarer Gestank, aus einer ecke kommen >Fliegen<");
                                        break;
                                    case "untersuche Sofa":
                                        Console.WriteLine("Unter einem Kissen findest du etwas Crack,\nleider hast du keine Verwendung dafür :/");
                                        break;
                                    case "untersuche Kühlschrank":
                                        Console.WriteLine("Ein Haufen schimmliges Essen und eine niegel-nagelneue Hochzeitstorte\nLeider hast du vor kurzem beschlossen dich gesünder zu ernähren.");
                                        if (schlüssel == false)
                                            Console.WriteLine("Im Gefrierfach liegt ein Schlüssel\nSchlüssel erhalten :)");
                                        schlüssel = true;
                                        break;
                                    case "untersuche Fliegen":
                                        Console.WriteLine("Bei näherer betrachtung entdeckst du,\ndass die Fliegen um einen zerfressenen Kadaver kreisen.\nKönnte mal eine Katze gewesen sein.... oder ein Kind");
                                        break;
                                    case "untersuche Schreibtisch":
                                        Console.WriteLine("Ein holzgearbeiteter IKEA-Schreibtisch. 2 Schubladen wurden herausgerissen,\nDie letzte ist verschlossen.");
                                        if (schlüssel == false)
                                            Console.WriteLine("Vielleicht findest du ja irgendwo einen Schlüssel");
                                        else
                                        {
                                            Console.WriteLine("Du öffnest die Schublade mit dem Schlüssel aus dem Kühlschrank\nIm inneren sind Informationen über ein Safehouse in deiner Nähe");
                                            InfosGefunden = true;
                                        }
                                        break;
                                    case "zurück gehen":
                                        if (schlüssel == true)
                                        {
                                            Console.WriteLine("vorm Rausgehen legst du den Schlüssel zurück in den Kühlschrank");
                                            Console.ReadKey(true);
                                            schlüssel = false;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("Du stehst wieder im Flur.\nDie Leichen haben sich in deiner Abwesenheit\neine Fangemeinde aus Ratten zugelegt");
                                        dingss = true;
                                        break;
                                    default:
                                        Console.WriteLine("eventuell würde ich diese Idee vorher nochmal überdenken");
                                        break;
                                }
                            } while (dingss == false);
                            break;
                        case "zurück gehen":
                            Console.WriteLine("Du kehrst zur Hauptstrasse zurück");
                            dings = true;
                            break;
                        case "umsehen":
                            Console.WriteLine("Auf dem Boden liegen diverse >Körperteile<\nÜber der einzigen Tür hängt ein >Schild<");
                            break;
                        case "untersuche Leichen":
                        case "untersuche Körperteile":
                            Console.WriteLine("Du perverses schwein... hier gibts keinen loot");
                            break;
                        case "untersuche Schild":
                            Console.WriteLine("Eine Holztafel mit der aufschrift\n'Home sweet Home'");
                            break;
                    }
                } while (dings == false);
            }
            Console.ReadKey(true);

            legame.Infos = InfosGefunden;
            legame.HouseClear = infiziertegecleared;
        }
    }
    class pAngelshop
    {
        game legame;
        Angelshop a = new Angelshop();
        bool Angel, waffe, rausgehen;

        public pAngelshop(game mygame)
        {
            legame = mygame;
        }
        public void AngelshopBetreten()
        {
            Angel = legame.Angel;
            waffe = legame.Machete;

            rausgehen = false;
            Console.Clear();
            Console.WriteLine(a.GetStandarttext);
            do
            {
                switch (Console.ReadLine())
                {
                    case "umsehen":
                        Console.WriteLine(a.GetSetUmschautext);
                        break;
                    case "untersuche Machete":
                        if (waffe == false)
                        {
                            Console.WriteLine("Machete erhalten");
                            a.GetMacheteVorhanden = false;
                            waffe = true;
                        }
                        break;
                    case "untersuche Angel":
                        if (Angel == false)
                        {
                            Console.WriteLine("Angel erhalten");
                            a.GetAngelVorhanden = false;
                            Angel = true;
                        }
                        break;
                    case "zurück gehen":
                        rausgehen = true;
                        Console.WriteLine("Du kehrst zur Hauptstrasse zurück");
                        legame.Angel = Angel;
                        legame.Machete = waffe;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("NEIN");
                        break;
                }
            } while (rausgehen == false);
        }
    }
    class pWerkstatt
    {
        game legame;
        Werkstatt a = new Werkstatt();
        bool pMofa;
        bool pKanister;
        bool rausgehen;
        public pWerkstatt(game mygame)
        {
            legame = mygame;
        }
        public void WerkstattBetreten()
        {
            pMofa = legame.Mofa;
            pKanister = legame.KanisterSchlauch;

            rausgehen = false;
            Console.Clear();
            Console.WriteLine(a.GetStandarttext);
            do
            {
                switch (Console.ReadLine())
                {
                    case "umsehen":
                        Console.WriteLine(a.GetSetUmschautext);
                        break;
                    case "untersuche Mofa":
                        if (legame.Mofa == false)
                        {
                            Console.WriteLine("Das Mofa springt an. Das braucht bestimmt keiner mehr.");
                            a.GetSetMofaVorhanden = false;
                            legame.Mofa = true;
                        }
                        break;
                    case "untersuche Kanister":
                        if (legame.KanisterSchlauch == false)
                        {
                            Console.WriteLine("Benzinkanister erhalten");
                            a.GetSetBenzinVorhanden = false;
                            legame.KanisterSchlauch = true;
                        }
                        break;
                    case "zurück gehen":
                        rausgehen = true;
                        Console.WriteLine("Du kehrst zur Hauptstrasse zurück");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("NEIN");
                        break;
                }
            } while (rausgehen == false);
        }
    }
    class pKiosk
    {
        game legame;
        kiosk a = new kiosk();
        bool rausgehen;

        public pKiosk(game mygame)
        {
            legame = mygame;
        }
        public void KioskBetreten()
        {

            rausgehen = false;
            Console.Clear();
            Console.WriteLine("Du stehst in einem ranzigen Kiosk");
            do
            {
                switch (Console.ReadLine())
                {
                    case "umsehen":
                        Console.WriteLine(a.GetSetUmschautext);
                        break;
                    case "untersuche Wasserflasche":
                        if (legame.Wasserflasche == false)
                        {
                            Console.WriteLine("Wasserflasche erhalten");
                            a.GetWasserflascheVorhanden = false;
                            legame.Wasserflasche = true;
                        }
                        break;
                    case "untersuche Snickers":
                        if (legame.Snickers == false)
                        {
                            Console.WriteLine("Snickers erhalten");
                            a.GetSetSnickersVorhanden = false;
                            legame.Snickers = true;
                        }
                        break;
                    case "zurück gehen":
                        rausgehen = true;
                        Console.WriteLine("Du kehrst zur Hauptstrasse zurück");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("NEIN");
                        break;
                }
            } while (rausgehen == false);
        }
    }
    class Autounfall
    {
        game legame;
        public Autounfall(game mygame)
        {
            legame = mygame;
        }
        public void vorfinden()
        {
            bool falscheEingabe = true;
            string Unfalleingabe = "";

            //Solange der BEnutzer nichts vernünftiges eingibt
            do
            {
                Console.Clear();
                //Autounfall standardtext
                Console.WriteLine("Du kommst aus dem Krankenhaus raus du erkennst ,dass du dich in einer Kleinstadt befindest.\nAnscheinend sind die meisten Bürger schon geflohen.\nEs sind nur ein paar Menschen übrig geblieben die Taschen in ihre Autos laden und die Stadt verlassen wollen.\nPlötzlich verurachen zwei Autos einen tödlichen Unfall, in dem sie mitten auf der Straßen zusammen stoßen.\nEiner der Fahrer scheint noch zu leben.");
                Console.WriteLine("Du kannst :\n-weiter gehen\n-zum Unfall gehen\n");
                Console.Write("+>");
                Unfalleingabe = Console.ReadLine();

                //Benutzer geht nicht zum NPC
                if (Unfalleingabe == "weiter gehen")
                {
                    falscheEingabe = false;
                    legame.Infos = false;
                }
                //Benutzer geht zum NPC
                if (Unfalleingabe == "zum Unfall gehen")
                {
                    Console.WriteLine("Du kannst dem Verletzten helfen, Informationen fordern oder weggehen.\n");
                    bool NPCsequenzBeendet = false;

                    do
                    {
                        Console.Write("+>");
                        string eingabeAutounfall = Console.ReadLine();

                        //Benutzer erpresst den NPC
                        if (eingabeAutounfall == "fordere Informationen")
                        {
                            Console.WriteLine("Okay Okay.\nIst ja gut.\nEs gibt ein Paar Kilometer die Straße runter einen Stützpunkt.\nDa sind Soldaten die haben ein Gegenmittel! ...\nJetzt hilf mir\n");
                            legame.Infos = true;
                            string eingabeAutounfall2 = "";
                            //solange bis es eine richtige Eingabe gab
                            do
                            {

                                Console.Write("+>");
                                eingabeAutounfall2 = Console.ReadLine();


                                //Benutzer hilf dem Npc
                                if (eingabeAutounfall2 == "hilf dem Verletzten")
                                {
                                    Console.WriteLine("Danke.\nDu bist ein korrekter Typ.\nHier es gibt noch etwas was du wissen solltest.\nDu bist Infiziert.\nDas erkenne ich an dem Aussschlag an deinen Armen.");
                                    Console.WriteLine("Der Verletzte stirbt an seinen Wunden.");
                                }
                                //Benutzer geht weg
                                else if (eingabeAutounfall2 == "geh weg")
                                {
                                    Console.WriteLine("Du Hurensohn. Du sollst in der Hölle schmoren!!");
                                    Console.WriteLine("Der Verletzten stirbt an seinen Wunden.");
                                }

                                else
                                {
                                    Console.WriteLine("Gib mal was ordentliches ein man!!");
                                }

                            } while (eingabeAutounfall2 != "hilf dem Verletzten" || eingabeAutounfall2 != "geh weg");

                            NPCsequenzBeendet = true;
                        }
                        //Benutzer geht weg
                        else if (eingabeAutounfall == "gehe weg")
                        {
                            Console.WriteLine("Der Verletzte stirbt an seinen Wunden.");
                            NPCsequenzBeendet = true;
                        }
                        //Benutzer hilft NPC
                        else if (eingabeAutounfall == "hilf dem Verletzte")
                        {
                            Console.WriteLine("Danke. Du bist ein korrekter Typ.\nHier es gibt noch etwas was du wissen solltest. Du bist Infiziert.\nDas erkenne ich an dem Aussschlag an deinen Armen.\nDu solltest eine Möglichkeit finden zu dem Stützpunkt nache der Stadt zu kommen.\nDie haben ein Gegenmittel.\n");
                            legame.Infos = true;
                            Console.WriteLine("Der Verletzte stirbt an seinen Wunden.");
                            NPCsequenzBeendet = true;
                        }

                        else
                        {

                        }

                    } while (NPCsequenzBeendet == false);

                    falscheEingabe = false;
                }

                else
                {

                }


            } while (falscheEingabe == true);
        }
        public void rueckkehren()
        {
            bool zurückZurStraße = false;
            Console.WriteLine("Die Autos sind totaler Schrott.\nDie werden sich keinen cm mehr bewegen.\nDu bist traurig über den Toten Verletzten.\n");
            do
            {
                string Autoeingabe = Console.ReadLine();
                //Benutzer fängt Benzin auf
                if (Autoeingabe == "untersuche Benzin")
                {
                    //Benutzer hat den Kanister
                    if (legame.KanisterSchlauch == true)
                    {
                        Console.WriteLine("Nun hast du einen Kanister Benzin.\n");

                        legame.Kanistervoll = true;
                    }
                    //Benutzer hat keinen Kanister
                    else
                    {
                        Console.WriteLine("Du kannst das Benzin nicht mit bloßen Händen auffangen!!");
                    }

                }

                else if (Autoeingabe == "umsehen")
                {
                    Console.WriteLine("Es Läuft >Benzin< aus dem Tank des einen Autos.");
                    if (legame.Kanistervoll == false)
                        Console.WriteLine("Villeicht kannst du es auffangen.\n");
                }

                else if (Autoeingabe == "zurück gehen")
                {
                    zurückZurStraße = true;
                }

            } while (zurückZurStraße == false);

        }
    }


    class Episode1
    {
        public void StartNewGame()
        {
            int staerke, intelligenz, charisma, geschick, ausdauer, ent, atributzeahler;
            string name, fk;
            bool fehler = false;

            //random + attribute programmieren

            Console.Write("Bitte geben Sie ihren Namen ein: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hallo {0} :)", name);
            Console.Clear();

            staerke = 0;
            intelligenz = 0;
            charisma = 0;
            geschick = 0;
            ausdauer = 0;
            atributzeahler = 21;
            ent = 0;

            do
            {
                do
                {
                    do
                    {
                        do
                        {
                            Console.WriteLine("{0}\nDu hast folgene Skillwerte:", name);
                            Console.WriteLine("[1]Stärke = {0}\n[2]Intelligenz = {1}\n[3]Charisma = {2}\n[4]Geschick = {3}\n[5]Ausdauer = {4}\n", staerke, intelligenz, charisma, geschick, ausdauer);
                            Console.WriteLine("Du hast noch {0} Atributpunkte", atributzeahler);
                            Console.Write("{0}, bitte weise deine Skillpunkte zu, indem du die Nummer des Attributes eingibst und mit Enter bestätigst: ", name);
                            string zuweisung = Console.ReadLine();

                            if (zuweisung == "1")
                            {
                                ent = Convert.ToInt32(zuweisung);
                                fehler = true;
                            }
                            else if (zuweisung == "2")
                            {
                                ent = Convert.ToInt32(zuweisung);
                                fehler = true;
                            }
                            else if (zuweisung == "3")
                            {
                                ent = Convert.ToInt32(zuweisung);
                                fehler = true;
                            }
                            else if (zuweisung == "4")
                            {
                                ent = Convert.ToInt32(zuweisung);
                                fehler = true;
                            }
                            else if (zuweisung == "5")
                            {
                                ent = Convert.ToInt32(zuweisung);
                                fehler = true;
                            }
                            else
                            {
                                Console.WriteLine("Bitte nur Zahlen von 1 bis 5 eingeben!");
                                Console.ReadLine();
                                Console.Clear();
                                fehler = false;
                            }
                        } while (fehler == false);

                        if (ent <= 5)
                        {
                            if (ent == 1)
                            {
                                if (staerke < 10)
                                {
                                    staerke = staerke + 1;
                                    atributzeahler--;
                                }
                                else
                                {
                                    Console.Write("Ein Skill kann nicht höher als 10 gesetzt werden.");
                                    Console.ReadLine();
                                }
                            }
                            else if (ent == 2)
                            {
                                if (intelligenz < 10)
                                {
                                    intelligenz = intelligenz + 1;
                                    atributzeahler--;
                                }
                                else
                                {
                                    Console.Write("Ein Skill kann nicht höher als 10 gesetzt werden.");
                                    Console.ReadLine();
                                }

                            }
                            else if (ent == 3)
                            {
                                if (charisma < 10)
                                {
                                    charisma = charisma + 1;
                                    atributzeahler--;
                                }
                                else
                                {
                                    Console.Write("Ein Skill kann nicht höher als 10 gesetzt werden.");
                                    Console.ReadLine();
                                }
                            }
                            else if (ent == 4)
                            {
                                if (geschick < 10)
                                {
                                    geschick = geschick + 1;
                                    atributzeahler--;
                                }
                                else
                                {
                                    Console.Write("Ein Skill kann nicht höher als 10 gesetzt werden.");
                                    Console.ReadLine();
                                }
                            }
                            else if (ent == 5)
                            {
                                if (ausdauer < 10)
                                {
                                    ausdauer = ausdauer + 1;
                                    atributzeahler--;
                                }
                                else if (ausdauer == 10)
                                {
                                    Console.Write("Ein Skill kann nicht höher als 10 gesetzt werden.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Sie haben keine Zahl eingegeben! ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bitte nur Zahlen eingeben!");
                        }

                        Console.Clear();
                    } while (atributzeahler > 0);

                    do
                    {
                        Console.WriteLine("[1]Stärke = {0}\n[2]Intelligenz = {1}\n[3]Charisma = {2}\n[4]Geschick = {3}\n[5]Ausdauer = {4}\n", staerke, intelligenz, charisma, geschick, ausdauer);
                        Console.WriteLine("Bist du mit deiner Atributverteilung zufrieden?");
                        Console.WriteLine("[1] Ja\n[2] Nein");
                        Console.Write("Bitte gib deine Antwort ein, indem du die Zahl eingibst: ");
                        fk = Convert.ToString(Console.ReadLine());

                        if (fk == "1")
                        {
                            ent = Convert.ToInt32(fk);
                            fehler = true;
                        }
                        else if (fk == "2")
                        {
                            ent = Convert.ToInt32(fk);
                            fehler = true;
                        }
                        else
                        {
                            Console.WriteLine("Bitte nur Zahlen von 1 bis 2 eingeben.");
                            fehler = false;
                            Console.ReadLine();
                        }

                        Console.Clear();


                    } while (fehler == false);

                    if (ent == 2)
                    {
                        staerke = 0;
                        intelligenz = 0;
                        charisma = 0;
                        geschick = 0;
                        ausdauer = 0;
                        atributzeahler = 21;
                    }

                    Console.Clear();

                } while (ent == 2);


                Console.Clear();

                Console.Write("Deine Daten\nName: {0}\n\nAtribute:\nStärke: {1}\nIntelligen: {2}\nCharisma: {3}\nGeschick: {4}\nAusdauer: {5}\n", name, staerke, intelligenz, charisma, geschick, ausdauer);
                Console.WriteLine("Willst du das Spiel mit diesen Daten starten?\n[1] Ja\n[2]Nein");
                Console.Write("Bitte gib die Zahl deiner Antwort ein: ");
                ent = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (ent == 2);

            Layout.Design();
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Hussmann\Documents\Visual Studio 2013\Projects\MiniAnwendungen\MiniAnwendungen\Musik\Release.wav");
            //simpleSound.Play();
            //string name = "Peter";
            Console.Clear();
            Layout.Layout_Text2(1, "*Du wachst in einer Höhle auf*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Du wirst von einem hellem Licht geblendet*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Wow was war das den jetzt...?");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*schwerfälliges Aufstehen*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Wie bin ich den hier gelandet? ");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Was willst du nun machen?\n\n1\tHöhle erkunden\n2\tHöhle verlassen");
            string wahl;

            do
            {
                Console.Write("\nEingabe: ");
                wahl = Console.ReadLine();
                Console.Clear();
                if (wahl == "1")
                {
                    Layout.Layout_Text2(1, "*erkundet die Höhle*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Oh mein Gott...");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "...");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Steine...,nichts als Steine");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n\n1\tSteine weiter beobachten\n2\tHöhle verlassen");

                    string wahl2;

                    do
                    {
                        Console.Write("\nEingabe: ");
                        wahl2 = Console.ReadLine();
                        Console.Clear();
                        if (wahl2 == "1")
                        {
                            Layout.Layout_Text2(1, "*beobachten*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Wow..., echt cool");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "...");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*Höhle verlassen*");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (wahl2 == "2")
                        {
                            Layout.Layout_Text2(1, "*Höhle verlassen*");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Was willst du nun machen?\n\n1\tSteine weiter beobachten\n2\tHöhle verlassen");

                        }
                    } while (wahl2 != "1" && wahl2 != "2");
                }
                else if (wahl == "2")
                {
                    Layout.Layout_Text2(1, "*Höhle verlassen*");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Höhle erkunden\n2\t Höhle verlassen ");
                }
            } while (wahl != "1" && wahl != "2");
            Layout.Layout_Text2(1, "Endlich draußen..., wow was für eine fantasiereiche Welt ");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Oh Ich glaub ich seh eine Stadt");
            Console.ReadLine();
            Console.Clear();

            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Zur Stadt gehen\n2\t Die Landschaft erkunden");


            do
            {
                Console.Write("\nEingabe: ");
                wahl = Console.ReadLine();
                Console.Clear();
                if (wahl == "1")
                {
                    Layout.Layout_Text2(1, "*geht zur Stadt*");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (wahl == "2")
                {
                    Layout.Layout_Text2(1, "*erkunde Landschaft*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Oh ein Brunnen..");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Brunnen herunter klettern\n2\t Zurück zur Stadt");
                    string wahl2;
                    do
                    {
                        Console.Write("\nEingabe: ");
                        wahl2 = Console.ReadLine();
                        Console.Clear();
                        if (wahl2 == "1")
                        {
                            Layout.Layout_Text2(1, "*klettere runter*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "ohhh hier ist es ja Dunkel und nass");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ich seh dort etwas im Wasser... Ein leichtes leuchten");
                            Console.ReadLine();
                            Console.Clear();
                            string wahl3;
                            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Tauchen um zu sehen was dort ist\n2\t Hoch klettern und zur Stadt gehen");
                            do
                            {
                                Console.Write("\nEingabe: ");
                                wahl3 = Console.ReadLine();
                                Console.Clear();
                                if (wahl3 == "1")
                                {
                                    Layout.Layout_Text2(1, "*Tauchen*");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "*Schwimmen zum licht*");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "(Ein leuchtender Stein...?)");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "*berühren*");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.Write("Woshhhhhhhhhhhhhhhhhhhhh");
                                    Console.ReadLine();
                                    for (int i = 0; i <= 100; i++)
                                    {
                                        Console.Write("Teleportation: " + i + " %");
                                        Thread.Sleep(70);
                                        Console.Clear();
                                    }
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "Jetzt bin ich in der Stadt gelandet");
                                    Console.ReadLine();
                                }
                                else if (wahl3 == "2")
                                {
                                    Layout.Layout_Text2(1, "*Klettere hoch*");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "*gehe zur Stadt*");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Tauchen um zu sehen was dort ist\n2\t Hoch klettern und zur Stadt gehen");

                                }
                            } while (wahl3 != "1" && wahl3 != "2");
                        }
                        else if (wahl2 == "2")
                        {
                            Layout.Layout_Text2(1, "*gehe zur Stadt*");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Brunnen herunter klettern\n2\t Zurück zur Stadt");

                        }
                    } while (wahl2 != "1" && wahl2 != "2");

                }
                else
                {
                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Zur Stadt gehen\n2\t Landschaft erkunden");
                }
            } while (wahl != "1" && wahl != "2");

            Console.Clear();
            Console.Write("Endlich bin ich in der Stadt...");

            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Zum Marktplatz gehen\n2\t Zum Kirchenplatz gehen");

            do
            {
                Console.Write("\nEingabe: ");
                wahl = Console.ReadLine();
                Console.Clear();
                if (wahl == "1")
                {
                    Layout.Layout_Text2(1, "*gehe zum Marktplatz*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Unbekannte Person : Hallo warte mal?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ja was ist?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Unbekannte Person : Du siehst aus wie ein Abenteurer");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ja, weil ich einer bin (Dumme Frage)");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Unbekannte Person : Meine Frau wurde von einem Troll entführt und Sie in die Mine gebracht ?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ja und was soll ich jetzt machen? ");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Unbekannte Person : Sie retten du Dumm Dödel ");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ok ich bin Bereit Sie zu Befriedigen ehhhhh ich meine befreihen");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Unbekannte Person : Viel Glück (Was für eine Missgeburt)");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (wahl == "2")
                {
                    Layout.Layout_Text2(1, "*gehe zum Kirchenplatz*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Pater : Amen Mein Bruder " + name);
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Woher kennst du meinen Namen?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Pater : Weil ich Pater Byrol bin");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ok du bist eine verwunderlicher alter Greis ");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Pater Byrol : Du Bastard, wenn nennst du hier Greis..?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ok..., es tut mir Leid");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Pater Byrol : Sag mal Bruder " + name + " ..Bist du gläubig? ");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun antworten?\n1\t Ja\n2\t Nein\n3\t Du bist ein ungläubiger Pater Byrol ");
                    string wahl2;

                    do
                    {
                        Console.Write("\nEingabe: ");
                        wahl2 = Console.ReadLine();
                        Console.Clear();
                        if (wahl2 == "1")
                        {
                            Layout.Layout_Text2(1, "Ja");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Pater Byrol : Gut..., Gott sei mit dir");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*du wurdest gesegnet*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Danke Pater");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*gehe zum Marktplatz*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Hallo warte mal?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja was ist?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Du siehst aus wie ein Abenteurer");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja, weil ich einer bin (Dumme Frage)");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Meine Frau wurde von einem Troll entführt und in die Mine gebracht ?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja und was soll ich jetzt machen? ");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Sie retten du Dumm Dödel ");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ok ich bin Bereit Sie zu Befriedigen ehhhhh ich meine befreihen");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Viel Glück (Was für eine Missgeburt)");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (wahl2 == "2")
                        {
                            Layout.Layout_Text2(1, "Nein");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Pater Byrol : Du seist verflucht ungläubiger");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ach halt die Fresse");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Pater Byrol : inspektum Patronum (Zauberspruch) ");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*du wurdest verflucht*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Achja..?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Simsalabim *Facecum* trifft dein Kinn");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Spiel : Pater Byrol *wurde besamt* Fluch wurde von " + name + " entfernt und wurde *gesegnet*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*gehe zum Marktplatz*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Hallo warte mal?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja was ist?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Du siehst aus wie ein Abenteurer");
                            Console.ReadLine(
                                );
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja, weil ich einer bin (Dumme Frage)");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Meine Frau wurde von einem Troll entführt und in die Mine gebracht ?");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ja und was soll ich jetzt machen? ");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Sie retten du Dumm Dödel ");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Ok ich bin Bereit Sie zu Befriedigen, ehhhhh ich meinte zu befreihen");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Unbekannte Person : Viel Glück (Was für eine Missgeburt)");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (wahl2 == "3")
                        {
                            Layout.Layout_Text2(1, "Pater Byrol : Du seist verflucht ungläubiger");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Pater Byrol verwandelt sich in ein Keuchheitsgürtel");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Keuschheitsgürtel *springt " + name + " ins Gesicht *");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*" + name + " erstickt*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "*" + name + " ist gestorben*");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "GAMEOVER");
                            Console.ReadLine();
                            Console.Clear();
                            StartNewGame();
                            //Ende
                        }
                        else
                        {
                            Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                            Console.ReadLine();
                            Console.Clear();
                            Layout.Layout_Text2(1, "Was willst du nun antworten?\n1\t Ja\n2\t Nein\n3\t Du bist ein ungläubiger Pater Byrol ");



                        }
                    } while (wahl2 != "1" && wahl2 != "2" && wahl2 != "3");

                }
                else
                {
                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Zum Marktplatz gehen\n2\t Zum Kirchenplatz gehen");


                }
            } while (wahl != "1" && wahl != "2");

            Layout.Layout_Text2(1, "*gehe zur Mine*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Wow ist das ein Riesiges Tor ");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Spiel : *Tor öffnet sich*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Betrete die Mine*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Oh eine Truhe");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Truhe öffnen\n2\t Gegen Truhe treten \n3\t Anzünden ");
            int geschik = 8;
            do
            {
                Console.Write("\nEingabe: ");
                wahl = Console.ReadLine();
                Console.Clear();
                if (wahl == "1")
                {
                    Random rdm = new Random();
                    if (geschik >= rdm.Next(1, 10))
                    {
                        Layout.Layout_Text2(1, "*öffne Truhe*");
                        Console.ReadLine();
                        Console.Clear();
                        Layout.Layout_Text2(1, "ohhhhhhh wie süß.....");
                        Console.ReadLine();
                        Console.Clear();
                        Layout.Layout_Text2(1, "ein Kuchen mit einer Lunte die brennt ");
                        Console.ReadLine();
                        Console.Clear();
                        Layout.Layout_Text2(1, "*Kuchen wird gegessen*");
                        Console.ReadLine();
                        Console.Clear();
                        Layout.Layout_Text2(1, "*passiert nichts*");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Layout.Layout_Text2(1, "*Fehlgeschlagen*");
                        Console.ReadLine();
                        Console.Clear();
                        Layout.Layout_Text2(1, "Truhe : Du bist ein Waschlappen");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (wahl == "2")
                {
                    Layout.Layout_Text2(1, "*gegen Truhe treten*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Es passiert nichts*");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (wahl == "3")
                {
                    Layout.Layout_Text2(1, "*Truhe anzünden*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Truhe brennt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Truhe verbrannt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Es passiert nichts*");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t Truhe öffnen\n2\t Gegen Truhe treten \n3\t Anzünden ");


                }
            } while (wahl != "1" && wahl != "2" && wahl != "3");
            Layout.Layout_Text2(1, "*gehe weiter*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Unbekannte Person : Ahhhhhhh Hilfe, Hilfee... Hiilfeeee!");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Was war das denn jetzt war das die Frau der Unbekannten Person?");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Sprintet zur Unbekannten Personen*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "(Ahhhhhhhh ein risiger Troll)");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*beobachte Troll aus der Ferne*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t weg locken und Frau befreien\n2\t Schuh ausziehen und gegen Troll werfen\n3\t Anschreien\n4\tReden ");



            do
            {
                Console.Write("\nEingabe: ");
                wahl = Console.ReadLine();
                Console.Clear();
                if (wahl == "1")
                {
                    Layout.Layout_Text2(1, "*Stein wurf*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll geht zum Stein*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*schleiche zur Frau*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Frau befreien*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll schaut fragwürdig den Stein an*");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (wahl == "2")
                {
                    Layout.Layout_Text2(1, "*Schuh wird ausgezogen und geworfen*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll wird getroffen*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*critical Hit*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll stirbt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Spiel : " + name + " gewinnt");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (wahl == "3")
                {
                    Layout.Layout_Text2(1, "*Anschreien*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll fällt auf " + name + "*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " stirbt");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "GameOver");
                    Console.ReadLine();
                    Console.Clear();
                    StartNewGame();
                    //Gameover
                }
                else if (wahl == "4")
                {
                    Layout.Layout_Text2(1, "Warum hälst du Sie gefangen?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Troll : Ich hatte noch nie eine Freundin...");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ja ok, Ich versteh das, aber das ist 'meine' Freundin");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll wird ganz Sauer vor wut*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Troll wird so sauer, das sein Kopf explodiert*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Spiel : " + name + " gewinnt");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Layout.Layout_Text2(1, "Die Eingegbene Ziffer/Buchstabe ist ungültig");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Was willst du nun machen?\n1\t weg locken und Frau befreien\n2\t Schuh ausziehen und gegen Troll werfen\n3\t Anschreien\n4\tReden ");


                }
            } while (wahl != "1" && wahl != "2" && wahl != "3" && wahl != "4");

            Layout.Layout_Text2(1, "*Frau gerettet*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*gehe zur stadt*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Wähle jetzt deine Ausbildung?");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Nun kannst du eine Ausbildung auswählen, je nach Wahl ändert sich die Story!");
            Thread.Sleep(2500);
            Console.WriteLine("[1] Soldat\n[2]Magier\n[3]Dieb\n[4]Schütze");
            Thread.Sleep(2500);
            Console.Write("Bitte die Zahl deiner Ausbildung eingeben: ");
            

            do
            {
                string ausbwahl = Console.ReadLine();
                if (ausbwahl == "1")
                {
                    ent = Convert.ToInt32(ausbwahl);
                    fehler = true;
                }
                else if (ausbwahl == "2")
                {
                    ent = Convert.ToInt32(ausbwahl);
                    fehler = true;
                }
                else if (ausbwahl == "3")
                {
                    ent = Convert.ToInt32(ausbwahl);
                    fehler = true;
                }
                else if (ausbwahl == "4")
                {
                    ent = Convert.ToInt32(ausbwahl);
                    fehler = true;
                }
                else
                {
                    Console.WriteLine("Bitte nur Zahlen von 1 bis 4 eingeben!");
                    fehler = false;
                }
            } while (fehler == false);

            if (ent == 1)
            {
                string eingabe1;
                //string name = "Bahamut";
                Layout.Layout_Text2(10, @"In der Stadt treffe ich ein Soldaten Ausbilder..");
                Thread.Sleep(250);
                Layout.Layout_Text2(11, @"Der Soldat trägt eine Drachenrüstung");
                Thread.Sleep(250);
                Layout.Layout_Text2(12, @"die ich zuvor so noch nie gesehen habe.");
                Thread.Sleep(250);
                Layout.Layout_Text2(13, @"Die Drachenschuppen leuchten und ");
                Thread.Sleep(250);
                Layout.Layout_Text2(14, @"sind härter als jedes jenseits bekannten Material");
                Thread.Sleep(350);
                Layout.Layout_Text2(15, @"Das Schwert, das in seiner Scheide steckt, strahlt starke Macht aus..");
                Thread.Sleep(350);
                Layout.Layout_Text2(16, @"Anscheinend ist er ein sehr hochrangiger Drachentöter,");
                Thread.Sleep(350);
                Layout.Layout_Text2(17, @"da er einen Helm mit dem Drachentötersymbol besitzt...");
                Thread.Sleep(350);
                Layout.Layout_Text2(18, @"Er schaut grimmig, es scheint, als ob die Gegend um ihn herum sich,");
                Thread.Sleep(350);
                Layout.Layout_Text2(19, @"plötzlich verdunkelt. Seine Gegenwart strahlt Macht und Furcht aus.");
                Thread.Sleep(500);
                Layout.Layout_Text2(20, @"Der Soldat sprach mich an: ,, Du Knabe, du schaust aus wie ein junger, ");
                Thread.Sleep(350);
                Layout.Layout_Text2(21, @"Held, möchtest du die Lehre eines Soldaten beginnen?Ja(J) oder Nein(N)‘‘. ");
                Thread.Sleep(950);

                string sEingabe;
                    sEingabe = Console.ReadLine();
                Console.Clear();
                do
                {


                    if (sEingabe == "A" || sEingabe == "a")
                    {
                        Layout.Layout_Text2(10, @"Soldat: Nun denn begebe dich in meine Halle");
                        Thread.Sleep(500);
                        Console.Clear();
                        Layout.Layout_Text2(11, name + ":Okey");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(12, @"Soldat: Du wirst nun ein Training beginnen..");
                        Thread.Sleep(200);
                        Layout.Layout_Text2(13, "Soldat: Deine Kräfte werden entfesselt und deine wahre Stärke wird gezeigt.");
                        Thread.Sleep(500);
                        Console.Clear();
                        Layout.Layout_Text2(14, name + ":Nach einem Monat,habe ich meine 'Lehre' mit Bravur abgeschlossen");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(15, "Soldat: Nun geh und finde deinen eigenen Weg du Bastard");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(16, name + ":Danke dir Bruder hab dich auch lieb ");
                        Thread.Sleep(500);
                        Console.Clear();

                    }
                    else if (sEingabe == "B" || sEingabe == "b")
                    {
                        Layout.Layout_Text2(10, "Soldat: Viel Glück in dieser Welt du Dödel");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(11, name + ":Halt den Rand du alter Sack");
                        Thread.Sleep(500);
                        Console.Clear();
                        Layout.Layout_Text2(12, "Du bist auf dem Weg zum Wald....");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(13, "plötzlich ertöhnt eine Stimme : Geld her oder du stirbst!!!!!!!");
                        Thread.Sleep(2500);
                        Layout.Layout_Text2(14, name + ":Wer ist da ?");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(15, "Der Dieb springt vom Baum runter und haut dich K.O.");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(16, name + @":Ahhhhh....Man hab ich Kopfschmerzen...!");
                        Thread.Sleep(2500);
                        Layout.Layout_Text2(17, "Scheiße meine Sachen sind weg!!!!!");
                        Thread.Sleep(2500);
                        Console.Clear();
                        Layout.Layout_Text2(18, "Du kehrst zurück zum Soldaten und erklärst was passiert ist...");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(19, @"Soldat: Hahahaha, kleiner Wicht ab in die Arena mit dir!!!");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(20, "Morgen um 6:00 Uhr pünktlich zum Training");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(21, name + ":Jaja....");
                        Thread.Sleep(500);
                        Console.Clear();
                        Layout.Layout_Text2(22, "Es dauert einen Monat ...");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(23, "Doch es hat sich gelohnt..Ich habe gelernt mit meinen Kräften umzugehen.");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(24, "Nun bin ich den kommenden Abenteuer gewaffnet!");
                        Thread.Sleep(500);
                        Console.Clear();
                    }

                } while (sEingabe == "a" || sEingabe == "A" || sEingabe == "b" || sEingabe == "B");

                do
                {


                    Layout.Layout_Text2(10, "Im Dorf machen Gerüchte über ein Drachen die Runde");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(11, "Möchtest du  den Drachen suchen (A) Willst du zu in die Kneipe gehen(B) ?");
                    Thread.Sleep(5500);
                    eingabe1 = Convert.ToString(Console.ReadLine());
                    if (eingabe1 == "A" || eingabe1 == "a")
                    {
                        Layout.Layout_Text2(10, "Auf geht es zum Drachen...");
                        Thread.Sleep(500);
                        Console.Clear();
                        Layout.Layout_Text2(10, "laut dorfbewohner ist der Drache in der  Svitov Höhle");
                        Thread.Sleep(500);
                        Layout.Layout_Text2(11, name + ":Ich muss mich beeilen...");
                        Thread.Sleep(500);



                        Console.Clear();
                    }
                    else if (eingabe1 == "B" || eingabe1 == "b")

                        Layout.Layout_Text2(10, "Mal sehen ob ich in der Kneipe informationen bekomme..");
                    Thread.Sleep(500);
                    Console.Clear();
                    Layout.Layout_Text2(11, "Ahh .. das ist also die Dorfkneipe.. ziemlich Schäbig");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(12, name + ":Hey.. Wirt ein Bierkrug für mich..");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(13, "Wirt: Hier dein Bier.. Knabe du bist nicht von hier oder..");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(14, "Wirt: Erzähl mir was dich hier hin verschlagen hat.");
                    Thread.Sleep(2500);
                    Console.Clear();

                    Layout.Layout_Text2(10, name + "Ich bin auf der Suche nach dem Drachen");
                    Thread.Sleep(500);
                    Console.Clear();
                    Layout.Layout_Text2(11, "Wirt: Was du suchst den Drachen ?? HAHAHAHA");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(12, name + ":Lach nicht so dreckig.. Du Hurensohn");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(13, "Wirt: Du wirst niemals den Drachidaktylie besiegen");
                    Thread.Sleep(500);
                    Layout.Layout_Text2(14, name + "Halt dein Maul du Missgeburt! ");
                    Thread.Sleep(2500);
                    Layout.Layout_Text2(15, name + "Deine Mutter die Hure hätte lieber abtreiben sollen! ");
                    Thread.Sleep(2500);
                    Layout.Layout_Text2(16, "Wirt: Hahaha, du gefällst mir junger knabe also gut... ");
                    Thread.Sleep(2500);
                    Layout.Layout_Text2(17, "Wirt:Der Drache wurde zuletzt in der Svitov Höhle gesichtet. ");
                    Thread.Sleep(2500);
                    Layout.Layout_Text2(18, "Wirt:Begebe dich dorthin, wenn du zurück kommst gibt es ein Gratis Bier. ");
                    Thread.Sleep(2500);
                    Layout.Layout_Text2(19, name + "Geht doch,alter Sack... Ich will das bier dann Kalt ;). ");
                    Thread.Sleep(2500);
                    Console.Clear();

                    Layout.Layout_Text2(1, "Du begibst dich auf dem Weg zum Drachen");
                    Console.Clear();


                } while (eingabe1 == "a" || eingabe1 == "A" || eingabe1 == "b" || eingabe1 == "B");
            }
            else if (ent == 2)
            {
                Layout.Design();
                string sSelection;

                sSelection = StoryMagier.ErsterTeil();

                switch (sSelection)
                {
                    case "A1":
                        sSelection = StoryMagier.Dornstein();
                        switch (sSelection)
                        {
                            case "A1":
                                sSelection = StoryMagier.ArbeitSchmied();
                                switch (sSelection)
                                {
                                    case "A1":
                                        StoryMagier.Bernsheim();
                                        Console.ReadLine();
                                        break;

                                    case "A2":
                                        StoryMagier.Wasserfall();
                                        break;
                                    case "A3":

                                        break;
                                    case "A4":

                                        break;

                                }
                                break;

                            case "A2":
                                sSelection = StoryMagier.Wasserfall();
                                switch (sSelection)
                                {
                                    case "A1":
                                        sSelection = StoryMagier.Dornstein();

                                        break;


                                    case "A2":
                                        StoryMagier.gesprächFrau();
                                        switch (sSelection)
                                        {
                                            case "A1":
                                                StoryMagier.Dornstein();
                                                break;
                                            case "A2":
                                                StoryMagier.Bernsheim();
                                                Console.ReadLine();
                                                break;

                                        }
                                        break;
                                }
                                break;

                        }
                        break;//LELELE
                    case "A2":
                        sSelection = StoryMagier.Wasserfall();
                        switch (sSelection)
                        {
                            case "A1":
                                sSelection = StoryMagier.Dornstein();

                                break;


                            case "A2":
                                StoryMagier.gesprächFrau();
                                switch (sSelection)
                                {
                                    case "A1":
                                        StoryMagier.Dornstein();
                                        break;
                                    case "A2":
                                        StoryMagier.Bernsheim();
                                        Console.ReadLine();
                                        break;

                                }




                                break;

                        }
                        break;



                }
            }
            else if (ent == 3)
            {
                Layout.Design();
                string entscheidungSchatulleKlauen;
                string antwort1Dieb;



                //Für Spielername die Variable nutzen
                Layout.Layout_Text2(10, "Spielername: Hey bist du der den sie \"den Dieb\" nennen?");
                Thread.Sleep(1000);
                Layout.Layout_Text2(13, "Dieb: Ja das bin ich..... Wer möchte das wissen?");
                Thread.Sleep(1000);
                Layout.Layout_Text2(15, "Spielername: Ich bin Spieler. Ich wurde von NpcXY geschickt mich von dir in der Kunst des Tricksen und Täuschens unterrichten zu lassen");
                Thread.Sleep(1000);
                Layout.Layout_Text2(17, "Dieb: Bist du dir sicher, dass du ein Dieb werden willst und die Dinge auf eine hinterliste Art und Weise erledigen willst");
                Layout.Layout_Text2(18, "Dieb: Wenn ja, dann werde ich dir dies beibringen. indem du ein paar Aufgaben erledigen musst damit du eine Grundausbildung absolvierst");
                Layout.Layout_Text2(19, "Dieb: Falls nicht, gehe hinfort und wähle einen anderen Lehrer bei dem du die Lehre antreten willst, du findest diese weiter die Straße runter!(J/N)");
                antwort1Dieb = Console.ReadLine();
                Console.Clear();

                do
                {
                    if (antwort1Dieb == "j" || antwort1Dieb == "J")
                    {
                        Layout.Layout_Text2(10, "Spielername: Ja ich bin mir sicher.");
                        Layout.Layout_Text2(12, "Dieb: Dann werden wir mit der Ausbildung beginnen!");
                        Layout.Layout_Text2(13, "Dieb: Zuerst, laufe zurück in die Stadt und sieh dich auf dem Kirchplatz um und bringe mir das goldene Kreuz des Priesters!");
                        Layout.Layout_Text2(14, "Dieb: Er bewahrt es in einer goldenen Schatulle unter dem Altar auf");
                        Layout.Layout_Text2(16, "Du begibst dich zurück Richtung Marktplatz, dort angekommen gehst du auf die Kirche zu");
                        Layout.Layout_Text2(17, "Du gehst in die Kirche , dort ist ausser einer älteren Frau niemand");
                        Layout.Layout_Text2(18, "Wie möchtest du Vorgehen?");
                        Layout.Layout_Text2(20, "Du gehst ohne zu zögern hinter den Altar und nimmst die Schatulle an dich und verlässt ohne Groß nachzudenken die Kirche");
                        Layout.Layout_Text2(21, "Du versuchst die ätere Dame zu bestechen");
                        Layout.Layout_Text2(23, "A = drauf zu gehen     B = bestechen");
                        entscheidungSchatulleKlauen = Console.ReadLine();
                        Console.Clear();

                        if (entscheidungSchatulleKlauen == "a" || entscheidungSchatulleKlauen == "A")
                        {
                            Layout.Layout_Text2(10, "Du gehst zielgerichtet auf den Altar zu und greifst unter den Altar.");
                            Layout.Layout_Text2(11, "Du bekommst ein etwa Milchkarton großes goldenes Kästchen zu fassen, es ist für seine Größe sehr schwer.");
                            Layout.Layout_Text2(12, "Die alte Dame sieht das du zum Altar gehst , sieht aber nicht genau was du dort tust.");
                            Layout.Layout_Text2(13, "Du schaffst es trotz allerdem die Schatulle in deiner Manteltasche verschwinden zu lassen");
                            Layout.Layout_Text2(14, "Schnellen Schrittes verlässt du die Kirche");
                            Layout.Layout_Text2(15, "Du begibst dich zurück zu deinem Lehrer und überreichst im das Kästchen");
                            Layout.Layout_Text2(16, "Spielername: Ich habe was ihr wolltet. Nur ist es verschlossen");
                            Layout.Layout_Text2(17, "Dieb: Na dann mach es auf.");
                            Layout.Layout_Text2(18, "Spielername: Aber wie ?");
                            Layout.Layout_Text2(19, "Dieb: Hier , nimm das. \"Du erhälst einen Dietrich\"");
                            Layout.Layout_Text2(21, "Spielername: Ok dann werde ich das tun");
                            Thread.Sleep(5000);
                            Console.Clear();

                            Layout.Layout_Text2(10, "*klick*\n     die Schatulle öffnet sich nach einiger Zeit des Rumprobierens");
                            Layout.Layout_Text2(12, "Spielername: Ich habs!");
                            Layout.Layout_Text2(13, "Dieb: Sehr gut");
                            Layout.Layout_Text2(14, "Spielername: Hier das Kreuz");
                            Layout.Layout_Text2(15, "Dieb: Dann mal zur nächsten und letzten Aufgabe");
                            Console.Clear();
                            Layout.Layout_Text2(10, "Dieb: Der Priester , dem das Kreuz gehört ,er steckt sich von Kirchensteuer einen Großteil ein.");
                            Layout.Layout_Text2(12, "Dieb: Für dieses Verhalten muss er leider verschwinden");
                            Layout.Layout_Text2(13, "Spielername: Ohhh ok wenn es sein muss");
                            Console.Clear();
                            Layout.Layout_Text2(10, "Du begibst dich zurück zur Kirche");
                            Layout.Layout_Text2(11, "Du öffnest die Türen zur Kirche , die alte Frau ist mittlerweile gegangen");
                            Layout.Layout_Text2(12, "Du gehst hinein , und siehst dich um");
                            Thread.Sleep(3500);
                            Layout.Layout_Text2(14, "Der Priester steht mit dem Rücken zu dir.");
                            Layout.Layout_Text2(16, "Du schleichst dich an und zückst deinen Dolch");
                            Layout.Layout_Text2(17, "Mit einem schnellem Hieb versinkt der Dolch zwischen den Halswirbeln");
                            Layout.Layout_Text2(19, "Du wischst das das Blut von der Klinge");
                            Thread.Sleep(2000);
                            Layout.Layout_Text2(20, "Und machst dich zurück zum Dieb....");
                            Thread.Sleep(3000);
                            Console.Clear();


                            Layout.Layout_Text2(10, "Spielername: Auftrag wurde ausgeführt");
                            Layout.Layout_Text2(11, "Dieb: Sehr gut");
                            Layout.Layout_Text2(12, "Spielername: Was nun?");
                            Layout.Layout_Text2(13, "Dieb: Wir sind fertig");

                            Console.Clear();
                            Thread.Sleep(3000);

                            Layout.Layout_Text2(10, "Nach deiner Ausbildung machst du dich in Richtung der des Drachen auf was wird dich da erwarten?");

                            break;
                            //ende



                        }
                        else if (entscheidungSchatulleKlauen == "b" || entscheidungSchatulleKlauen == "B")
                        {
                            Layout.Layout_Text2(10, "Du setzt dich neben die ältere Dame , den Kopf gesenkt");
                            Layout.Layout_Text2(12, "Spielername: Guten Tag gnädige Frau, ich bin im Auftrag der Kirche hier.");
                            Layout.Layout_Text2(13, "Spielername: Ich wurden dazu beauftragt dies hier *einen kleinen Geldbeutel hervor hol*");
                            Layout.Layout_Text2(14, "Spielername: Allen frommen Bürgerinnen und Bürgern zu geben");
                            Layout.Layout_Text2(15, "Alte Dame: Ab....Aber ich kann das nicht...");
                            Layout.Layout_Text2(16, "Spielername: Doch nehmen sie und feiern sie mit ihrer Familie");
                            Layout.Layout_Text2(17, "Alte Dame: Vielen Dank!");

                            Thread.Sleep(3000);
                            Console.Clear();

                            Layout.Layout_Text2(10, "Du gehst zum Altar und nimmst mit aller Ruhe das Kästchen hinaus");
                            Layout.Layout_Text2(11, "Du bekommst ein etwa Milchkarton großes goldenes Kästchen zu fassen, es ist für seine Größe sehr schwer.");
                            Layout.Layout_Text2(12, "Du steckst es ein und gehst zurück zu dem Dieb");
                            Layout.Layout_Text2(16, "Spielername: Ich habe was ihr wolltet. Nur ist es verschlossen");
                            Layout.Layout_Text2(17, "Dieb: Na dann mach es auf.");
                            Layout.Layout_Text2(18, "Spielername: Aber wie ?");
                            Layout.Layout_Text2(19, "Dieb: Hier , nimm das. \"Du erhälst einen Dietrich\"");
                            Layout.Layout_Text2(21, "Spielername: Ok dann werde ich das tun");
                            Console.Clear();
                            Layout.Layout_Text2(10, "...");
                            Thread.Sleep(5000);
                            Console.Clear();





                            Layout.Layout_Text2(10, "*klick*\n     die Schatulle öffnet sich nach einiger Zeit des Rumprobierens");
                            Layout.Layout_Text2(12, "Spielername: Ich habs!");
                            Layout.Layout_Text2(13, "Dieb: Sehr gut");
                            Layout.Layout_Text2(14, "Spielername: Hier das Kreuz");
                            Layout.Layout_Text2(15, "Dieb: Dann mal zur nächsten und letzten Aufgabe");
                            Console.Clear();
                            Layout.Layout_Text2(10, "Dieb: Der Priester , dem das Kreuz gehört ,er steckt sich von Kirchensteuer einen Großteil ein.");
                            Layout.Layout_Text2(12, "Dieb: Für dieses Verhalten muss er leider verschwinden");
                            Layout.Layout_Text2(13, "Spielername: Ohhh ok wenn es sein muss");
                            Console.Clear();
                            Layout.Layout_Text2(10, "Du begibst dich zurück zur Kirche");
                            Layout.Layout_Text2(11, "Du öffnest die Türen zur Kirche , die alte Frau ist mittlerweile gegangen");
                            Layout.Layout_Text2(12, "Du gehst hinein , und siehst dich um");
                            Thread.Sleep(3500);
                            Layout.Layout_Text2(14, "Der Priester steht mit dem Rücken zu dir.");
                            Thread.Sleep(1000);
                            Layout.Layout_Text2(16, "Du schleichst dich an und zückst deinen Dolch");
                            Thread.Sleep(1500);
                            Layout.Layout_Text2(17, "Mit einem schnellem Hieb versinkt der Dolch zwischen den Halswirbeln");
                            Thread.Sleep(2000);
                            Console.Clear();

                            Layout.Layout_Text2(19, "Du wischst das das Blut von der Klinge");
                            Layout.Layout_Text2(20, "Und machst dich auf den weg zurück zum Dieb....");
                            Thread.Sleep(3000);
                            Console.Clear();


                            Layout.Layout_Text2(10, "Spielername: Auftrag wurde ausgeführt");
                            Layout.Layout_Text2(11, "Dieb: Sehr gut");
                            Layout.Layout_Text2(12, "Spielername: Was nun?");
                            Layout.Layout_Text2(13, "Dieb: Wir sind fertig");

                            Thread.Sleep(3000);
                            Console.Clear();

                            Layout.Layout_Text2(10, "Nach deiner Ausbildung machst du dich in Richtung der des Drachen auf was wird dich da erwarten?");
                            break;
                        }
                    }

                    else if (antwort1Dieb == "n" || antwort1Dieb == "N")
                    {
                        Layout.Layout_Text2(10, "Spieler: Ich muss noch einmal darüber nachdenken");
                        //kurze Wartezeit
                        Layout.Layout_Text2(12, "Dieb: Ok dann soll es so sein");
                        break;
                    }

                    else
                    {
                        Layout.Layout_Text2(10, "Dieb: Wie bitte , ich habe dich nicht verstanden (bitte J oder N eingeben)");
                        antwort1Dieb = Console.ReadLine();
                        Console.Clear();
                    }

                } while (antwort1Dieb != "j" || antwort1Dieb != "J" || antwort1Dieb != "n" || antwort1Dieb != "N");


                Console.ReadLine();
            }
            else
            {
                Schuetze neu = new Schuetze(name);
            }

            //string name = "peter";
            Layout.Layout_Text2(1, "Durch die gesammelten Informationen weiß ich das der Drache den Sie 'Acnologia' nennen auf dem Drachenberg ist");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Auf geht's zum Drachenberg");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*gehe zum Drachenberg*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "So nach ca. 5000 stufen hab ich es Geschafft..");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Warte, was seh ich da rechts...?");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Ein riesieger Aufzug in den Bergen..., leck mich doch am Zückerli");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "So wo ist der verdammte Drache jetzt?");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Suche Drachen*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Drache konnte nicht gefunden werden*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*Doch plötzlich geht die Aufzugstür auf und plötzlich, kommt der Drache aus dem Aufzug hervor*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "*ein leichtes schmunzeln überkommt dich*");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Drache Acnologia : Was bist du denn für ein Zwerg?");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Drache Acnologia : Anscheinend kommt das essen jetzt schon von allein");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text2(1, "Was antwortest du jetzt?\n\n1\t Schuh ausziehen und gegen Drachen werfen\n2\tMit Fäusten angreiffen\n3\tWeglaufen\n4\tAufgeben");

            string eingabeX = Console.ReadLine();
            do
            {
                if (eingabeX == "1")
                {
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Schuh ausziehen und gegen Drachen werfen*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Drache wird getroffen*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Drache erleidet keinen Schaden*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Drache Acnologia : Was war das den jetzt?");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "ehhh, mein Stärkster Angriff");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Drache hustet*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " fliegt vom berg*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " fällt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " landet in einem See*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Wow, das war knapp");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Ich sollte zurück in die Stadt und mir bessere Ausrüstung kaufen");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*ssssssssssssshhhhhhhhhhh*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Eine Kreatur taucht aus dem Wasser auf und frisst dich*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "GameOver");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabeX == "2")
                {
                    Layout.Layout_Text2(1, "*sprintet auf den Drachen zu*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*bevor du den Drachen erreichts, bekommst du eine Schwanz hieb ab*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*du fliegst mit voller geschwindigkeit gegen die Wand*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*dein Körper wurde zermatscht, so das man es wie ein Fleischsmoothie austrinken kann*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " stirbt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "GameOver");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabeX == "3")
                {
                    Layout.Layout_Text2(1, "*laufe weg*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*stolpern über einen Kieselstein*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*" + name + " stirbt*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "GameOver");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabeX == "4")
                {
                    Layout.Layout_Text2(1, "*ziehe 'weiße' Socke aus*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*halte Socke in die Luft und schwingst sie*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "Drache Acnologia : Ich akzeptiere deine Feige aktion");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "*Drache verspeist " + name + "*");
                    Console.ReadLine();
                    Console.Clear();
                    Layout.Layout_Text2(1, "GameOver");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {

                }
            } while (eingabeX != "1" || eingabeX != "2" || eingabeX != "3" || eingabeX != "4");




            Console.ReadKey();








        }
    }
}