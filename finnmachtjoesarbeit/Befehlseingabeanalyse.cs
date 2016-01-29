using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finnmachtjoesarbeit
{
    class Befehlseingabeanalyse
    {
    }

    class Werkstatt
    {
        private string Standardtext = "Eine alte heruntergekommene Werkstatt. Rostige und kaputte Gegenstände liegen kreutz und quer im Raum verteilt. Die Guten Werkzeuge wurden wohl schon geklaut.";
        private string Umschautext = "Wird von einer Eigenschaft variabel erstellt";


        private bool MofaVorhanden = true;
        private string Mofa = "Mitten im Raum steht ein Mofa. Der Schlüssel steckt im Schloss. Auf den ersten Blick scheint es funktionstüchtig. ";

        private bool KanisterVorhanden = true;
        private string Kanister = "Auf der Werkbank liegt ein dreckiger Kanister und ein alter Schlauch. ";

        private bool SchraubenSchlüsselVorhanden = true;
        private string SchraubenSchlüssel = "Auf dem Boden liegt ein verrosteter Schraubenschlüssel. ";

        public string GetStandarttext
        {
            get { return Standardtext; }
        }

        public string GetSetUmschautext
        {
            get
            {
                string returntext = "";

                returntext += Mofa;
                returntext += Kanister;
                returntext += SchraubenSchlüssel;

                return returntext;
            }

        }


        //MOFA
        public string GetMofa
        {
            get
            {
                return Mofa;
            }
        }

        public bool GetSetMofaVorhanden
        {
            get { return MofaVorhanden; }
            set { MofaVorhanden = false; }

        }


        //BENZIN
        public string GetKanister
        {
            get
            {
                return Kanister;
            }
        }

        public bool GetSetBenzinVorhanden
        {
            get { return KanisterVorhanden; }
            set { KanisterVorhanden = false; }

        }


        //SchraubenSchlüssel
        public string GetSchraubenSchlüssel
        {
            get
            {
                return SchraubenSchlüssel;
            }
        }

        public bool GetSetSchraubenSchlüsselVorhanden
        {
            get { return SchraubenSchlüsselVorhanden; }
            set { SchraubenSchlüsselVorhanden = false; }

        }


    }
    class Angelshop
    {
        private string Standardtext = "Ein kleiner und einfach eingerichteter Angelshop mit Bildern \nund ausgestopften Fischen an der Wand \nund Fichködern in einer Schüssel auf dem Tresen.";
        private string Umschautext = "Wird von einer Eigenschaft variabel erstellt";


        private bool macheteVorhanden = true;
        private string machete = "In einer Vitrine an der Wand liegt eine große >Machete< mit scharfen Zacken an einer Klingenseite.\n ";

        private bool angelVorhanden = true;
        private string angel = "Eine >Angel< ohne Haken ist an die Wand angelehnt.\n ";

        private string bild = "An den Wänden hängen lauter Bilder von Fischern mit ihren Fängen.\n ";

        public string GetStandarttext
        {
            get { return Standardtext; }
        }

        public string GetSetUmschautext
        {
            get
            {
                string returntext = "";

                if (macheteVorhanden == true)
                {
                    returntext += machete;
                }

                if (angelVorhanden == true)
                {
                    returntext += angel;
                }

                returntext += bild;

                return returntext;
            }

        }

        //Machete
        public string GetMachete
        {
            get
            {
                return machete;
            }
        }

        public bool GetMacheteVorhanden
        {
            get { return macheteVorhanden; }
            set { macheteVorhanden = false; }

        }


        //Angel
        public string GetAngel
        {
            get
            {
                return angel;
            }
        }

        public bool GetAngelVorhanden
        {
            get { return angelVorhanden; }
            set { angelVorhanden = false; }

        }
        //Bild
        public string GetBild
        {
            get
            {
                return bild;
            }
        }



    }
    class KHRaum1
    {
        private string Aufwachtext = "... Plötzlich wachst du in einem Krankenhausbett auf. Völlig durchschwitzt realisierst du ,dass alles was du bis jetzt erlebt hast nur ein Traum war. In dem Zimmer ist ein TV welcher angeschaltet ist. Eine Nachrichtensprecherin spricht über einen sehr gefährlichen Virus welcher die Menschheit ausrotten könnte, da er sehr leicht übertragbar ist. Bisher bekannte Symptome sind Hautausschlag,Schwindelanfälle und Magenkrämpfe.";
        private string Standardtext = "";
        private string Umschautext = "Wird von einer Eigenschaft variabel erstellt";

        private string Fenster = "In der Wand ist ein Fenster. Es ist vergittert sodass niemand ausbrechen kann. ";

        private bool TürVerschlossen = true;
        private string Tür = "Die Eingangstür ist verschlossen.";

        private string Bett = "Am Rand des Raumes steht dein Bett. Es ist hart und ausgelegen. ";

        private string Fernseher = "Von der Decke hängt ein Fernseher. Es läuft Werbung. ";


        public string GetSetUmschautext
        {
            get
            {
                string returntext = "";

                returntext += Fenster;
                returntext += Bett;

                if (TürVerschlossen == true)
                {
                    returntext += Tür;
                }

                returntext += Fernseher;

                return returntext;
            }

        }


        public string GetAufwachtext
        {
            get { return Aufwachtext; }
        }

        public string GetStandardtext
        {
            get { return Standardtext; }
        }

        public string GetFenster
        {
            get { return Fenster; }
        }

        public bool GetTürVerschlossen
        {
            get { return TürVerschlossen; }
        }

        public string GetSetTür
        {
            get { return Tür; }
            set { Tür = "Die Eingangstür ist offen."; TürVerschlossen = false; }
        }

        public string GetBett
        {
            get { return Bett; }
        }



    }
    class KHRaum2
    {
        private string FirsttimeText = "Es rennt ein nackter Mann schreiend auf dich zu. " +
        "Sein ganzer Körper ist mit getroknetem Blut bedeckt. Sein bestes Stück tingelt beim rennen von Oberschenkel zu Oberschenkel." +
        "Er sieht sehr aggressiev aus.";

        private string Standardtext = "Du bist in einem Krankenhausraum. Er ist völlig zerstört.";
        private string Umschautext = "Wird von einer Eigenschaft variabel erstellt";



        private string Tür = "Die Tür ist aufgebrochen. ";

        private string Bett = "Das Bett ist zerstört und liegt verteilt im Zimmer rum. ";

        private bool SchlüsselVorhanden = true;
        private string Schlüssel = "In ihrer Kitteltasche blitzt ein goldener Schlüssel.";

        private string Leiche = "Am Boden im hinteren Teil des Zimmers lieg eine tote Frau in weißem Kittel.";

        private string UntersucheLeiche = "Die Leiche liegt wohl schon länger hier. Sie ist Blutüberströmt und voller Bissspuren.";


        public string GetSetUmschautext
        {
            get
            {
                string returntext = "";

                returntext += Bett;
                returntext += Tür;
                returntext += Leiche;

                return returntext;
            }

        }

        public string GetBett
        {
            get { return Bett; }
        }


        public string GetSetTür
        {
            get { return Tür; }
        }


        public string GetUntersucheLeiche
        {
            get
            {
                if (SchlüsselVorhanden == true)
                {
                    return UntersucheLeiche + " " + Schlüssel;
                }
                else
                {
                    return UntersucheLeiche;
                }
            }
        }


    }
    class kiosk
    {
        private string Standardtext = "Du stehst in einem verlassenen Kiosk.\n Es ist bis auf wenige Kleinigkeiten komplett geplündet.";
        private string Umschautext = "Wird von einer Eigenschaft variabel erstellt\n";

        private bool WasserflascheVorhanden = true;
        private string Wasserflasche = "Auf dem Boden liegt eine volle >Wasserflasche<\n";

        private bool SnickersVorhanden = true;
        private string Snickers = "In einer Ecke liegt ein angebissenes >Snickers<\n";


        public string GetSetUmschautext
        {
            get
            {
                string returntext = "";

                if (WasserflascheVorhanden == true)
                {
                    returntext = Wasserflasche;
                }

                if (SnickersVorhanden == true)
                {
                    returntext += Snickers;
                }

                if (WasserflascheVorhanden == false && SnickersVorhanden == false)
                {
                    returntext = "Hier gibt es nichts von Wert";
                }

                return returntext;
            }

        }


        //WASSERFLASCHE
        public string GetWasserflasche
        {
            get
            {
                return Wasserflasche;
            }
        }

        public bool GetWasserflascheVorhanden
        {
            get { return WasserflascheVorhanden; }
            set { WasserflascheVorhanden = false; }

        }


        //SNICKERS
        public string GetSnickers
        {
            get
            {
                return Snickers;
            }
        }

        public bool GetSetSnickersVorhanden
        {
            get { return SnickersVorhanden; }
            set { SnickersVorhanden = false; }

        }



    }
}
