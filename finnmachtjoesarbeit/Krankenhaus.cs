using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnmachtjoesarbeit
{
    class Krankenhouse
    {
        public void GameStart()
        {
            #region Variablen

            string antwort = "";
            string antwort2 = "";
            string zustand = "unverwundet";

            string türe = "nicht untersucht";
            string schlüssel = "nicht verfügbar";
            string hauptschlüssel = "nicht verfügbar";
            string waffe = "nicht verfügbar";
            string raum2 = "nicht betreten";

            string npc0 = "";
            string npc1 = "";
            string npc2 = "";
            string npc3 = "";

            string wiederholung = "Ja";
            string wiederholung2 = "Ja";
            string wiederholung3 = "Ja";

            string weg = "";

            string unfall = "nicht überprüft";

            #endregion

            #region Krankenhaus

            #region Krankenzimmer

            Console.Write("... Plötzlich wachst du in einem Krankenhausbett auf. Völlig durchschwitzt realisierst du ,dass alles was du bis jetzt erlebt hast nur ein Traum war. In dem Zimmer ist ein TV welcher angeschaltet ist.");
            Console.Write("Eine Nachrichtensprecherin spricht über einen sehr gefährlichen Virus welcher die Menschheit ausrotten könnte, da er sehr leicht übertragbar ist. Bisher bekannte Symptome sind Hautausschlag,");
            Console.WriteLine("Schwindelanfälle und Magenkrämpf...");
            Console.WriteLine("Der Fernseher flakert noch einmal kurz auf und das Bild erlischt.\n\n");

            Console.WriteLine("Für den folgenden Spielverlauf: Ihnen werden Eingabemöglichkeiten vorgegeben. Entweder Sie geben die Zahl des Befehls ein oder geben Exakt den Befehl ein!\nMit einer Beliebigen Taste folgt das Spiel.\n\nViel Spaß!");
            Console.ReadLine();
            Console.Clear();

            do
            {
                #region im Krankenzimmer

                Console.WriteLine("Was willst du machen?");
                Console.WriteLine("1. Aus dem Fenster schauen\n2. TV einschalten\n3. Weder noch");
                weg = Console.ReadLine();
                Console.Clear();

                if (weg == "Aus dem Fenster schauen" || weg == "1")

                    #region aus dem Fensterschauen

                    Console.WriteLine("Draußen scheint die Nacht, doch kannst du nicht schlafen. Das Fenster scheint aus festem Glas zu sein, welches nicht zerbricht.");

                    #endregion

                else if (weg == "TV einschalten" || weg == "2")

                    #region TV einschalten
                    Console.WriteLine("Du versuchst eine Zeit lang den Fernseher einzuschalten, aber anscheinend fehlt dem Krankenhaus der Strom.");


                else if (weg == "Weder noch" || weg == "3")
                    wiederholung = "Nein";

                else { }

                Console.ReadLine();
                Console.Clear();

                    #endregion
            } while (wiederholung != "Nein");

            wiederholung = "Ja";

            #region Krankenzimmer aufbrechen

            Console.WriteLine("Die Zimmertür ist abgeschlossen.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Du versuchst die Türe mit Gewalt aufzubrechen, doch schaffst du es nicht und verletzt dich.");
            zustand = "verwundet";
            Console.ReadLine();
            Console.Clear();

            Console.Write("Du zerstörst das Bett und brichst damit das schloss der Türe auf.");
            Console.ReadLine();
            Console.Clear();

            #endregion

                #endregion

            #region Erdgeschoss

            do
            {
                Console.WriteLine("Du bist im Erdgeschoss. Türen sind aufgebrochen und Zimmer sind leer. ");

                do
                {
                    #region Wohin soll es gehen?

                    Console.WriteLine("Dir stehen die Möglichkeiten in den offenen Keller zu gehen oder die abgeschlossene Türe zu untersuchen oder zum Ausgang zu gehen.");
                    Console.WriteLine("\n1. Gehe zu Keller\n2. Untersuche abgeschlossene Türe\n3. Zurück ins Krankenzimmer\n4. Gehe zum Ausgang");
                    weg = Console.ReadLine();
                    Console.Clear();

                    #endregion

                    if (weg == "Gehe zu Keller" || weg == "1")
                    {

                        #region Keller

                        #region Standardtext

                        Console.Write("Du betrittst den Keller.");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Anders als im Erdgeschoss ist es hier verwüstet.");
                        Console.Write("Auf dem Boden liegt das Leichnam einer Krankenschwester.");
                        Console.ReadLine();
                        Console.Clear();

                        #endregion Standardtext

                        do
                        {
                            Console.WriteLine("Du bist im Keller.");
                            Console.WriteLine("1. Gehe zu Erdgeschoss \n2. Untersuche Krankenschwester");
                            weg = Console.ReadLine();
                            Console.Clear();

                            #region Untersuche Krankenschwester

                            if (weg == "Untersuche Krankenschwester" || weg == "2")
                            {


                                if (waffe == "nicht verfügbar")
                                {

                                    #region Beil erhalten

                                    Console.WriteLine("Die Krankenschwester wurde mit einem Beil erschlagen, ich sollte dieses Sicherheitshalber mitnehmen.");
                                    Console.Write("Du erhältst ein Beil.");
                                    Console.ReadLine();

                                    npc0 = "untersucht";

                                    Console.Write("Admin: Nutze deine Items mit Bedacht, du kannst diese nur einmal verwenden");
                                    waffe = "Beil";

                                    Console.ReadLine();

                                    #endregion
                                }

                                else
                                {

                                    #region Beil im Besitz

                                    Console.Write("Die Krankenschwester starb wahrscheinlich beim Angriff mit dem Beil. Ruhe in Frieden");
                                    Console.ReadLine();

                                    #endregion

                                }

                                Console.Clear();

                                if (türe == "untersucht" && schlüssel != "verfügbar")
                                {

                                    #region Schlüssel erhalten

                                    Console.WriteLine("Sie hat einen Schlüssel bei sich. Auf diesen steht \"Raum 2\".");
                                    Console.Write("Ich sollte den mal mitnehmen.");
                                    Console.ReadLine();

                                    schlüssel = "verfügbar";

                                    #endregion

                                }

                                else { }

                            }

                            else if (weg == "1")
                                weg = "Gehe zu Erdgeschoss";

                            else { }

                            #endregion

                            Console.Clear();

                        } while (weg != "Gehe zu Erdgeschoss" || weg == "");



                        #endregion Keller
                    }

                    else if (weg == "Untersuche abgeschlossene Türe" || weg == "2")
                    {

                        #region verschlossene Türe

                        Console.WriteLine("Die Türe ist abgeschlossen, du brauchst einen Schlüssel um die Türe aufzuschließen. Auf der Türe steht geschrieben \"Raum 2\". ");
                        Console.WriteLine("Es sind Hilferufe von der anderen Seite der Türe zu hören.");

                        if (schlüssel == "nicht verfügbar")
                        {

                            if (npc0 == "untersucht")
                            {
                                Console.Write("Die Krankenschwester hatte doch einen Schlüssel bei sich..");
                                Console.ReadLine();
                            }

                            else { }

                            do
                            {
                                #region Raum 2 aufbrechen?

                                Console.WriteLine("Willst du die Türe aufbrechen?");
                                Console.WriteLine("\n-Ja\n-Nein");

                                Console.WriteLine();
                                antwort = Console.ReadLine();

                                #endregion


                                if (antwort == "Ja")
                                {
                                    #region Raum 2 aufbrechen

                                    if (waffe == "Beil")
                                    {

                                        do
                                        {
                                            Console.Clear();

                                            #region mit waffe aufbrechen?

                                            Console.WriteLine("Willst du das Beil nutzen, um die Tür aufzubrechen?");
                                            Console.Write("-Ja\nNein");

                                            antwort2 = Console.ReadLine();

                                            #endregion
                                            #region Ja

                                            if (antwort2 == "Ja")
                                            {
                                                Console.Write("Du verwendest {0} um die Tür zu öffnen, dabei bricht dieses ab.", waffe);
                                                waffe = "nicht verfügbar";
                                                Console.ReadLine();


                                                weg = "Raum 2";
                                                wiederholung3 = "Nein";
                                                wiederholung2 = "Nein";

                                            }

                                            #endregion
                                            #region Nein

                                            else if (antwort2 == "Nein")
                                            {
                                                Console.Write("Du brichst die Türe mit Körpergewalt auf und verstauchst dir dabei die Schulter.");
                                                zustand = "verletzt";
                                                Console.ReadLine();

                                                weg = "Raum 2";
                                                wiederholung3 = "Nein";
                                                wiederholung2 = "Nein";
                                            }

                                            #endregion

                                            else { }



                                        } while (wiederholung3 != "Nein");

                                    }

                                    else if (waffe == "nicht verfügbar")
                                    {
                                        #region Keine Waffe verfügbar

                                        Console.Write("Du brichst die Türe mit Körpergewalt auf und verstauchst dir dabei die Schulter.");
                                        zustand = "verletzt";
                                        Console.ReadLine();

                                        weg = "Raum 2";
                                        wiederholung2 = "Nein";

                                        Console.Clear();

                                        #endregion
                                    }
                                    #endregion
                                }

                                else if (antwort == "Nein")
                                {
                                    #region Raum 2 nicht aufbrechen

                                    wiederholung2 = "Nein";

                                    #endregion
                                }



                            } while (wiederholung2 != "Nein");

                            wiederholung2 = "Ja";

                        }



                        else if (schlüssel == "verfügbar")
                        {
                            #region Türe aufschließen

                            Console.Write("Du schließt die Türe mit dem Schlüssel auf.");
                            schlüssel = "nicht verfügbar";
                            weg = "Raum 2";
                            Console.ReadLine();

                            #endregion

                        }

                        #endregion

                        else { }

                        türe = "untersucht";
                        Console.ReadLine();
                        Console.Clear();

                    }

                    else if (weg == "Zurück ins Krankenzimmer" || weg == "3")
                    {
                        #region zurück zu Krankenzimmer

                        Console.Write("Hier gibt es nichts weiter zu finden, lieber bleibe ich draußen");
                        Console.ReadLine();
                        Console.Clear();

                        #endregion
                    }

                    else if (weg == "Gehe zum Ausgang" || weg == "4")
                    {
                        #region Ausgang

                        Console.Write("Das ist der Ausgang, für diesen brauche ich einen speziellen Schlüssel.");
                        Console.ReadLine();
                        Console.Clear();

                        #endregion
                    }

                    else
                    {

                        weg = "";
                    }

            #endregion

                } while (weg != "Raum 2" || weg == "");

                wiederholung = "nein";

            } while (wiederholung != "nein");



            #endregion

            #region Psychopath

            Console.WriteLine("Hinter der Tür ist ein Psychopath mit einer Zwangsjacke, er läuft auf dich zu.");

            wiederholung = "ja";
            Console.ReadLine();

            do
            {

                if (waffe == "Beil")
                {

                    do
                    {
                        #region töten oder weglaufen?

                        Console.WriteLine("Was hast du vor?");
                        Console.WriteLine("1. töten\n2. weglaufen");
                        npc1 = Console.ReadLine();
                        Console.Clear();

                        #endregion
                        #region töten

                        if (npc1 == "töten" || npc1 == "1")
                        {

                            if (zustand != "verletzt")
                            {
                                Console.WriteLine("Du stichst auf ihn mit dem Beil aus dem Keller ein.");
                                Console.Write("Raum 2 betreten");
                                Console.ReadLine();
                                Console.Clear();
                                waffe = "nicht verfügbar";
                            }
                            else if (zustand == "verletzt")
                            {
                                Console.WriteLine("Du hast nicht die Kraft dazu, nach dem Beil zu greifen.");
                                Console.Write("Er läuft auf dich zu und zerbeißt dich.");
                                Ende();
                                return;
                            }

                            wiederholung = "Nein";
                        }

                        #endregion


                        else if (npc1 == "weglaufen" || npc1 == "2")
                        {
                            #region Tod

                            Console.WriteLine("Es braucht nicht lange, bis er dich einholt, du stolperst und er zerbeißt dich.");
                            Ende();
                            return;

                            #endregion
                        }

                        else { }

                    } while (wiederholung != "Nein");
                }



                else if (waffe == "nicht verfügbar")
                {
                    #region Tod

                    Console.WriteLine("Der Psychopath läuft auf dich zu und zerbeißt dich.");
                    Console.ReadLine();
                    Ende();
                    return;

                    #endregion
                }



                else { }

            } while (wiederholung != "Nein");


            do
            {

                #region Raum 2
                Console.WriteLine("Du betrittst Raum 2.");
                raum2 = "betreten";

                do
                {

                    Console.WriteLine("Möchtest du dich in Raum 2 umschauen, oder zum Ausgang gehen?");
                    Console.Write("1. In Raum 2 umschauen\n2. Gehe zum Ausgang");
                    weg = Console.ReadLine();

                    if (weg == "In Raum 2 umschauen" || weg == "1")
                    {

                        Console.Write("Außer des Leichnam des Psychopaten liegt das ein weiteres Leichnam von jemanden, dessen Gesicht zerbissen wurde.");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Was möchtest du tun?");
                        Console.WriteLine("1. Leiche überprüfen\n2. Gehe zum Ausgang");

                        antwort = Console.ReadLine();

                        if (antwort == "Leiche überprüfen" || antwort == "1")
                        {

                            if (hauptschlüssel == "nicht verfügbar")
                            {

                                Console.Write("Die Leiche hat eine Sicherheitskarte bei sich, vielleicht klappt diese beim Ausgang.");
                                Console.ReadLine();

                                Console.Write("Du erhältst Hauptschlüssel");
                                hauptschlüssel = "verfügbar";
                                Console.ReadLine();
                                Console.Clear();

                            }

                            else if (antwort == "Leiche überprüfen" && hauptschlüssel == "verfügbar")
                                Console.Write("Das Gesicht der Leiche ist nicht zu erkennen.");

                        }

                        else if (antwort == "Gehe zum Ausgang" || antwort == "2")
                        {

                            #region Ausgang

                            if (hauptschlüssel == "verfügbar")
                            {
                                Console.WriteLine("Du verwendest die Sicherheitskarte und die Ausgangstüre öffnet sich. Da steht ein Name auf der Karte... BILLY YVES - Wissenschaftler.");
                                npc3 = "Billy Yves";
                                wiederholung2 = "Nein";
                                Console.ReadLine();

                                Console.Clear();
                                wiederholung = "Nein";
                                wiederholung2 = "Nein";
                            }

                            else if (hauptschlüssel == "nicht verfügbar")
                            {
                                Console.Write("Ich brauche erst noch einen Hauptschlüssel, um den Ausgang zu öffnen.");
                                Console.ReadLine();
                            }

                            #endregion
                        }

                    }

                #endregion

                    else if (weg == "Gehe zum Ausgang" || weg == "2")
                    {

                        if (hauptschlüssel == "verfügbar")
                        {

                            #region hauptschlüssel verfügbar

                            Console.WriteLine("Du verwendest die Sicherheitskarte und die Ausgangstüre öffnet sich. Da steht ein Name auf der Karte... BILLY YVES - Wissenschaftler.");
                            npc3 = "Billy Yves";
                            wiederholung2 = "Nein";
                            Console.ReadLine();

                            Console.Clear();
                            wiederholung = "Nein";
                            wiederholung2 = "Nein";

                            #endregion
                        }

                        else if (hauptschlüssel == "nicht verfügbar")
                        {
                            #region hauptschlüssel nicht verfügbar

                            Console.Write("Ich brauche erst noch einen Hauptschlüssel, um den Ausgang zu öffnen.");
                            Console.ReadLine();

                            #endregion
                        }

                    }

                    else { }

                } while (wiederholung2 != "Nein");

            } while (wiederholung != "Nein");

            wiederholung = "Ja";
            wiederholung2 = "Ja";


            #endregion

            Console.Write("Du verlässt das Krankenhaus.");
            Console.ReadLine();

            #endregion
        }


        private static void Ende()
        {
            Console.Write("Dead End");
            Console.ReadLine();
            Console.Write("Du stirbst.");
            Console.ReadLine();
        }
    }
}
