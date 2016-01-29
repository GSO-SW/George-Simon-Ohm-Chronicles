using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGSOTextgame_V_0_1;

namespace Textgaming_Schuetze
{
    public class Schuetze
    {
        public string ausbilder = "Schütze";
        public string Name = "Spieler";
        public string fremder = "Fremder";
        public string antwort1;
        public string antwort2;
        public string antwort3;
        public string antwort4;
        public string antwort5;
        public int geschick = 5;

        public Schuetze(string name)
        {
            Name = name;
            Layout.Design();
            Frage1();

            Console.ReadLine();
        }

        private void Frage1()
        {
            Console.Clear();
            Layout.Layout_Text2(5, ausbilder + ": Hallo junger Freund. Du willst also in der Kunst des Bogenschießens ausgebildet werden?");

            Console.ReadLine();
            Layout.Layout_Text2(7, Name + ": Ja, gerne.");
            Console.ReadLine();
            Layout.Layout_Text2(10, "Info: Du hast einen Bogen mit Pfeilen erhalten!");
            Layout.Layout_Text2(12, "Du begleitest den Schützen auf seiner abenteuerreichen Reise, bei der er dir den Umgang mit Pfeil und Bogen lehren möchte...");
            Console.ReadLine();
            Console.Clear();

            Frage2();
        }

        private void Frage2()
        {
            do
            {
                Layout.Layout_Text2(7, "...nach einiger Zeit kommt euch ein geheimnisvoller alter Mann entgegen. Ihr seht wie er auf euch zukommt und eine raue tiefe Stimme ertönt.\n");
                Layout.Layout_Text2(9, fremder + ": Hallo Reisende! Ich habe eine Geschichte für euch. Wollt ihr sie hören? [J=Ja / N=Nein]\t Antwort: ");
                antwort2 = Console.ReadLine();

                if (antwort2 == "j" || antwort2 == "J")
                {
                    Layout.Layout_Text2(11, Name + ": Ja, sehr gerne.");
                    Console.ReadLine();
                    Layout.Layout_Text2(13, fremder + ": Vor langer Zeit lebte hier ein Wesen. Schuppen wie eine Schlange. Flügel, größer wie die eines Adlers. Es speite Feuer ohne Ende");
                    Layout.Layout_Text2(14, "und fraß alles was ihm vor die Schnauze kam. Es hatte viele Namen. Wohl der bekannteste Name lautet Drachen. Nimmt euch in acht vor ihm.");
                    Console.ReadLine();
                    Layout.Layout_Text2(16, ausbilder + ": Danke das werden wir!");
                    Console.ReadLine();
                    Console.Clear();

                    Frage3();

                }
                else if (antwort2 == "n" || antwort2 == "N")
                {
                    Layout.Layout_Text2(11, Name + ": Nein alter Mann, für solch Sachen haben wir keine Zeit. Wir müssen weiter.");
                    Console.ReadLine();
                    Layout.Layout_Text2(13, fremder + ": Ihr Narren, selbst Schuld wenn euch was passieren sollte.");
                    Console.ReadLine();
                    Console.Clear();

                    Frage3();
                }
                else
                {
                    Layout.Layout_Text2(11, "Bitte gib j für ja und n für nein ein!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (antwort2 != "j" && antwort2 != "J" && antwort2 != "n" && antwort2 != "N");
        }

        private void Frage3()
        {
            do
            {
                Layout.Layout_Text2(5, "Du siehst auf deiner Reise ein Gnomlager wo eine Kiste liegt. Willst du zur Truhe gehen? [J=Ja / N=Nein]\t Antwort: ");
                antwort3 = Console.ReadLine();

                if (antwort3 == "j" || antwort3 == "J")
                {
                    Layout.Layout_Text2(7, "Du gehst zu dem Lager...");
                    Console.ReadLine();
                    Layout.Layout_Text2(8, "Plötzlich überrascht dich ein Gnom aus dem Hinterhalt!");
                    Console.ReadLine();
                    Layout.Layout_Text2(9, "Du kämpfst ohne nachzudenken und besiegst den Gnom.");
                    Console.ReadLine();
                    Layout.Layout_Text2(11, "Info: Der Goblin lässt Dietrich (x3) fallen.");
                    Console.ReadLine();
                    Layout.Layout_Text2(13, "Du gehst zur Truhe und versuchst sie mit dem Dietrich zu öffnen. Du benötigst 6 Geschick.");
                    Console.ReadLine();

                    Random rmd = new Random();
                    for (int i = 2; i >= 0; i--)
                    {
                        if (geschick >= rmd.Next(1, 10))
                        {
                            Console.Clear();
                            Layout.Layout_Text2(5, "Du hast die Truhe geöffnet! Die Truhe ist leer :D");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Layout.Layout_Text2(15, "Der Dietrich ist zerbrochen! Noch "+i+" Versuche.");
                            Console.ReadLine();
                            
                            if (i == 0)
                            {
                                Layout.Layout_Text2(16, "Du hast keine Dietriche mehr! Du konntest die Truhe nicht öffnen.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                     }
                    Frage4();
                  }
                else if (antwort3 == "n" || antwort3 == "N")
                {
                    Layout.Layout_Text2(7,"Ihr führt eure Reise fort den Weg entlang.");
                    Console.ReadLine();
                    Console.Clear();

                    Frage4();
                }
                else
                {
                    Layout.Layout_Text2(7, "Bitte gib j für ja und n für nein ein!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (antwort3 != "j" && antwort3 != "J" && antwort3 != "n" && antwort3 != "N");   
        }
        
        private void Frage4()
        {
            do
            {
                Layout.Layout_Text2(5, "Der Rest des Weges verläuft ruhig und ihr unterhaltet euch ein wenig... In Kürze nähert ihr euch einem Wald.");
                Layout.Layout_Text2(7, ausbilder + ": Was meinst du junger Gefährte? Sollen wir um den Wald herum oder hindurch? [1=herum/2=hindurch]\t Antwort: ");
                antwort4 = Console.ReadLine();

                if (antwort4 == "1")
                {
                    Layout.Layout_Text2(9, Name + ": Wir sollten außen herum gehen. Da sind weniger gefährliche Wesen.");
                    Console.ReadLine();
                    Layout.Layout_Text2(11, ausbilder + ": Bist du dir sicher? Der Weg ist gefährlich und schmal.");
                    Console.ReadLine();
                    Layout.Layout_Text2(13, Name + ": Das sollte kein Problem sein.");
                    Console.ReadLine();
                    Layout.Layout_Text2(15, ausbilder + ": Ok, dann gehen wir mal.");
                    Console.ReadLine();
                    Layout.Layout_Text2(17, "Ihr gelangt an einen Abgrund mit einem Baumstamm drüber um auf die andere Seite zu kommen. Ihr klettert vorsichtig drüber...");
                    Layout.Layout_Text2(18, "Doch dann stolpert ihr auf der anderen Seite über einen Stein und verletzt euch. Nach einiger Zeit gelangt ihr an einen Fels, ");
                    Layout.Layout_Text2(19, "wo ihr ein Brüllen hört. Ihr erschreckt euch und rennt in richtung Waldrand. Letztendlich kommt ihr am Waldausgang an.");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (antwort4 == "2")
                {
                    Layout.Layout_Text2(9, Name + ": Wir gehen durch. Die Wesen sind kein Problem.");
                    Console.ReadLine();
                    Layout.Layout_Text2(11, ausbilder + ": Gut, dann lasst uns gehen, aber wir sollten vorsichtig sein.");
                    Console.ReadLine();

                    Layout.Layout_Text2(13, "Ihr macht euch auf den Weg durch den Wald. Der Schütze zeigt euch wie ihr richtig mit dem Bogen umgeht um präzise euer Ziel zu treffen.");
                    Layout.Layout_Text2(14, "Nach einigen Probeschüssen gegen ein paar Baumstämme erweitert euer Ausbilder die Ziele und ihr werdet immer sicherer mit dem Bogen...");
                    Layout.Layout_Text2(15, "Die Zeit vergeht schnell und die Dämmerung bricht langsam ein.");
                    Console.ReadLine();
                    Layout.Layout_Text2(17, ausbilder + ": Habt ihr das auch gehört?");
                    Console.ReadLine();
                    Layout.Layout_Text2(19, Name + ": Ja, ein Knacken. Hörte sich an als ob jemand auf einen Ast getreten ist.");
                    Console.ReadLine();
                    Layout.Layout_Text2(21, ausbilder + ": Psst, da auf der linken Seite. Ein kleiner Troll. Ich glaube er hat uns noch nicht entdeckt!");
                    Console.ReadLine();
                    Layout.Layout_Text2(23, Name + ": Ja, ich sehe ihn!");

                    Console.ReadLine();
                    Console.Clear();

                    Frage5();
                }
                else
                {
                    Layout.Layout_Text2(9, "Bitte gib 1 oder 2 für deine Antwort an!");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (antwort4 != "1" && antwort4 != "2");
        }

        private void Frage5()
        {
            do
            {
                Layout.Layout_Text2(5, ausbilder + ": Nun überlasse ich dir die Wahl. Sollen wir ihn töten oder könnten wir ihn in eine Falle locken? [1=Töten / 2=Falle]\t Antwort: ");
                antwort5 = Console.ReadLine();

                if (antwort5 == "1")
                {
                    Layout.Layout_Text2(7, Name + ": Wir sollten ihn direkt töten. So kann ich meine Fähigkeiten mit dem Bogen erstmals unter Beweis stellen.");
                    Console.ReadLine();
                    Layout.Layout_Text2(9, ausbilder + ": Ist gut aber ich helfe dir. Sonst ist es zu gefährlich. Auch wenn er klein ist, Trolle sind gefährliche Wesen.");
                    Console.ReadLine();
                    Layout.Layout_Text2(11, Name + ": Aber was willst du machen? Du bist schon gebrechlich? ");
                    Console.ReadLine();
                    Layout.Layout_Text2(13, ausbilder + ": Vertrau mir. Ich sehe gebrechlich aus, aber ich weiß was ich tue.");
                    Console.ReadLine();
                    Layout.Layout_Text2(15, Name + ": Nun denn. Lass es uns Vesuchen.");
                    Console.ReadLine();
                    Layout.Layout_Text2(17, "Ihr schleicht euch an den Troll von hinten an greift schließlich den Troll an...");
                    Console.ReadLine();
                    Layout.Layout_Text2(18, "Nach mehreren Pfeilen in den Rücken des Trolls gehst du und dein Lehrer siegreich aus dem Kampf!");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (antwort5 == "2")
                {
                    Layout.Layout_Text2(7, Name + ": Ich denke wir sollten ihn in eine Falle locken. Ein direkter Angriff wäre zu gefährlich.");
                    Console.ReadLine();
                    Layout.Layout_Text2(9, ausbilder + ": Sehr weise, Trolle sind recht dumm. Habt ihr auch schon eine Idee wie?");
                    Console.ReadLine();
                    Layout.Layout_Text2(11, Name + ": Ich werfe einen Stein und locke ihn damit hier hin. Wenn er in die Falle tappt habe ich ihn genau im Visier");
                    Layout.Layout_Text2(12, "und kann ihn mit einem Pfeil töten.");
                    Console.ReadLine();
                    Layout.Layout_Text2(14, "Info: Du hast einen Stein geworfen. Der Troll läuft in die Richtung der Falle.");
                    Console.ReadLine();
                    Layout.Layout_Text2(15, "Der Troll läuft in die Falle und du schießt mit einem Pfeil auf den Troll. Er geht zu Boden und ist tot. Dabei lässt er Fleisch fallen.");
                    Layout.Layout_Text2(16, "Du und dein Begleiter machen eine Pause und essen was.");
                    Console.ReadLine();
                    Layout.Layout_Text2(17, "Ihr rennt weiter und landet beim Waldausgang, wo ihr ein schrecklich lautes Brüllen hört.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Layout.Layout_Text2(7, "Bitte gib 1 oder 2 für deine Antwort an!");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (antwort5 != "1" && antwort5 != "2");
            
        }

    }
}
