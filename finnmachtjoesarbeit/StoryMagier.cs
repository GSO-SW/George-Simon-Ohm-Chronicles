using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TheGSOTextgame_V_0_1;

namespace ConsoleApplication5
{
    public class StoryMagier
    {
        
        public static string ErsterTeil()
        {
            string sSelection;
            Layout.Layout_Text("Mediev : Seid gegrüßt junger Abenteurer.\nMediev : Mein Name ist Mediev.\nMediev : Ihr kommt gerade zur rechten Zeit mein hinterhältiger Lehrling\n\t klaute mir meinen Zauberstab!\nMediev : Ihr müsst mir helfen ihn zurück zu erlangen.\nMediev : Ich hab gehört er solle nach Dornstein geflohen seien\nMediev : Falls ihr mir helfen solltet werdet ihr eine Belohnung erhalten.");
            Console.ReadLine();
            Console.Clear();
            Layout.Layout_Text("Ihr beschließt dem Mann zu helfen und verlasst die Stadt\nIhr kommt zu einem Wegekreuz.\nAuf dem Wegekreuz sind 2 Richtungen angegeben.\n1.Norden Dornstein\n2.Osten Wasserfall");
            sSelection = Layout.Layout_Auswahl("Norden", "Osten", "", "");
            return sSelection;
        }

       
        public static string Wasserfall()
        {
           string sSelection;
            Console.Clear();
            Layout.Layout_Text("\nDu gehst richtung Wasserfall.\n\nAm Ufer des Wassers siehst du eine Frau stehen.\nSie scheint gerade Wäsche zu waschen.\nSie bemerkt dich nicht.\nWas willst du tuen?");
          sSelection = Layout.Layout_Auswahl("Dornstein", "Reden","x","x");
          return sSelection;
        }
        public static string gesprächFrau()
        {
            string sSelection;
            Console.Clear();
            Layout.Layout_Text("\nJena : Seid gegrüßt junger Mann.Mein name ist Jena\nJena : Habt ihr schon von diesem fiesen Magier gehört welcher in Dornstein\nJena : sein Unwesen treibt\nJena : Seht ihr den Wasserfall hinter mir?\nJena : Hinter ihm befindet sich ein Pfad in Richtung der nahe liegensten Stadt Bernsheim");
            Layout.Layout_Text("\nWillst du durch den Wasserfall gehen oder in Richtung Dornstein");
            sSelection = Layout.Layout_Auswahl("Wasserfall", "Dornstein", "x", "x");
            return sSelection;
        }
        public static string Dornstein()
        {
            string sSelection;
            Console.Clear();
            Layout.Layout_Text("\nDu kommst in Dornstein an und siehst dich um.\nDas Dorf scheint wie ausgestorben zu sein nirgendwo siehst du Menschen.\nDas einzige was man hört ist das schlagen auf den Amboss eines Schmiedes.\nHorst : Wohlan Abenteurer.\nHorst : Mein Name ist Horst.\nHorst : Seid ihr auf der Suche nach Arbeit?");
            sSelection = Layout.Layout_Auswahl("ja","nein","x","x");
            return sSelection;
        }

        public static string ArbeitSchmied()
        {
            string sSelection;
            Console.Clear();
            Layout.Layout_Text("\nHorst : Aah das wollte ich hören mein Freund.\nHorst : Nun wie ihr unschwer sehen könnt bin ich Schmied\nHorst : und um meine Arbeit verrichten zu können brauche ich meine Handwerksmaterialien.\nHorst : Doch ein Dieb stahl sie mir holt sie mir zurück!\nHosrst : Ich hörte er seie in  die nächste Stadt geflohen.");
            Layout.Layout_Text("\nWohin willst du gehen?");
            sSelection = Layout.Layout_Auswahl("Bernsheim", "Wasserfall", "x", "x");
            return sSelection;
        }
        public static string Arbeitsverweigerung()
        {
            string sSelection;
            Console.Clear();
            Layout.Layout_Text("\nHorst : He ihr seid wohl einer von der faulen Sorte.Ich hätte euch mit Wichtigen Informationen dienen können.\nWas wollt ihr nun tuen?");
            sSelection = Layout.Layout_Auswahl("Schmied reden", "Richtung Wasserfall", "x", "x");
            return sSelection;
        }
        public static void Bernsheim()
        {
            Console.Clear();
            Layout.Layout_Text("\n Du gelangst nach Bernsheim die Stadt ist um einiges größer als Dornstein\nDer Marktplatz ist überfüllt und voller Leute.\nDu hörst aus weiter Ferne ein lautes Brüllen.\nPanik bricht um dich herum aus.");
        }


        //  string eins   = "Mediev : Seid gegrüßt junger Abenteurer.";
        //  string zwei   = "\nMediev : Mein Name ist Mediev.";
        //  string drei   = "\nMediev : Ihr kommt gerade zur rechten Zeit mein hinterhältiger Lehrling\n\t klaute mir meinen Zauberstab!";
        //  string vier   = "\nMediev : Ihr müsst mir helfen ihn zurück zu erlangen.";
        //  string fuenf  = "\nMediev : Ich hab gehört er solle nach Dornstein geflohen seien\nMediev : Falls ihr mir helfen solltet werdet ihr eine Belohnung erhalten.";
        //Verlässt erste Stadt
        //  string sechs  = "Du fasst den Entschluss Mediev zu helfen \nund verlässt die Stadt in Richtung Norden";
        //  string sieben = "\n\nDu gelangst an ein Wegekreuz,es sind 3 Richtungen ausgeschildert.\n\n1.Norden : Dornstein\n2.Osten : Wasserfall\n3.Westen : Bärenwald";
        //  string acht   = "\nWohin willst du gehen?\n";
         

        //  VerzögerteAusgabe(eins);
        //  VerzögerteAusgabe(zwei);
        //  VerzögerteAusgabe(drei);
        //  VerzögerteAusgabe(vier);
        //  VerzögerteAusgabe(fuenf);
        //  Console.ReadLine();
        //  Console.Clear();
        //  VerzögerteAusgabe(sechs);
        //  VerzögerteAusgabe(sieben);
        //  VerzögerteAusgabe(acht);        
        //  int  auswahlRichtung = Convert.ToInt32(Console.ReadLine());
       
        //    //auswahl Richtung
        //    if (auswahlRichtung == 2)
        //      Console.ReadLine();
        //  {
        //      int sprechen1;
        //      Console.Clear();
        //      string wasserfallEins = "Du follgst dem Pfad richtung Wasserfall.";
        //      string wasserfallZwei = "\n\nAm Ufer des Wassers siehst du eine Frau stehen.\nSie scheint gerade Wäsche zu waschen.\nSie bemerkt dich nicht.\nWas willst du tuen?";
        //      string wasserfallDrei = "Willst du zurück gehen oder sie ansprechen?";
        //      string wasserfallVier = "\nJena : Seid gegrüßt junger Mann.\nJena : Mein Name ist Jena.";




        //      VerzögerteAusgabe(wasserfallEins);
        //      VerzögerteAusgabe(wasserfallZwei);
        //      VerzögerteAusgabe(wasserfallDrei);
        //      sprechen1 = Convert.ToInt32(Console.ReadLine());

        //      VerzögerteAusgabe(wasserfallVier);
        //      Console.ReadLine();
        //  }

 





        //}

        //public static void VerzögerteAusgabe(string ausgabe)
        //{
        //    foreach (Char item in ausgabe)
        //    {
        //        Console.Write(item);
        //        Thread.Sleep(10);
        //    }
        }

    }



