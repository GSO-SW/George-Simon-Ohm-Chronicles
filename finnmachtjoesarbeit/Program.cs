using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnmachtjoesarbeit
{
    class Program
    {
        static void Main(string[] args)
        {
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
        public void KioskBetreten()
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
                        if (legame.Wasserflasche == false)
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
                Console.WriteLine("Du kommst aus dem Krankenhaus raus du erkennst ,dass du dich in einer Kleinstadt befindest.\nAnscheinend sind die meisten Bürger schon geflohen.\nEs sind nur ein paar Menschen übrig geblieben die Taschen in ihre Autos laden und die Stadt verlassen wollen.\nPlötzlich verurachen zwei Autos einen tödlichen Unfall, in dem sie mitten auf der Straßen zusammen stoßen.\nEiner der Fahrer scheint noch zu leben.\nDu kannst zum Unfall gehen oder weggehen.\n");

                Console.Write("+>");
                Unfalleingabe = Console.ReadLine();

                //Benutzer geht nicht zum NPC
                if (Unfalleingabe == "gehe weg")
                {
                    falscheEingabe = false;
                }
                //Benutzer geht zum NPC
                if (Unfalleingabe == "gehe zum Unfall")
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
            do
            {
                Console.WriteLine("Die Autos sind totaler Schrott.\nDie werden sich keinen cm mehr bewegen.\nDu bist traurig über den Toten Verletzten.\n");

                string Autoeingabe = Console.ReadLine();
                //Benutzer fängt Benzin auf
                if (Autoeingabe == "fang das Benzin auf")
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
                    Console.WriteLine("Es Läuft Benzin aus dem Tank des einen Autos.");
                    if (legame.Kanistervoll == false)
                        Console.WriteLine("Villeicht kannst du es auffangen.\n");
                }

                else if (Autoeingabe == "gehe zur Straße")
                {
                    zurückZurStraße = true;
                }

            } while (zurückZurStraße == false);

        }
    }
}