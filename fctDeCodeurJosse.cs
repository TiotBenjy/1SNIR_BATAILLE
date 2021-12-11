using System;
using System.Threading;

namespace Bataille
{
    internal partial class Program
    {
        public static int nbreTours = 16;
        public static int numTour = 0;

        public static void Distribuerjeu()
        {
            Console.WriteLine("\n⏳ Distribution des cartes en cours ...");

            for (int i = 0; i < (partie.Count / 2); i++)
            {
                josse.Enqueue(partie.Dequeue());// remplissage
                lulu.Enqueue(partie.Dequeue());//
            }
        }

        public static void Jeu()
        {
            Console.WriteLine("\n🎮 Lancement du jeu ...");

            while (josse.Count > 0 || lulu.Count > 0)
            {
                if (josse.Count == 0)
                {
                    break;
                }
                else if (lulu.Count == 0)
                {
                    break;
                }
                else
                {
                    int carteJosse = josse.Dequeue();
                    int carteLulu = lulu.Dequeue();

                    Console.WriteLine("\n\u231B Tour N°{0} En cours ...", (numTour + 1));

                    identifyCard("Josse", carteJosse);
                    identifyCard("Lulu", carteLulu);
                    RamasserPli(carteJosse, carteLulu);

                    numTour++;
                    Thread.Sleep(300);
                };
            };
        }

        public static void displayWinners()
        {
            if (josse.Count == 0)
            {
                Console.WriteLine("\nLa dernière carte de Josse à été posée ! " +
                    "\n\n🎯 Partie terminée ! " +
                    "La bataille fut longue mais Lulu à toute les cartes en main et à gagné la partie !");
            }
            else if (lulu.Count == 0)
            {
                Console.WriteLine("\nLa dernière carte de Lulu à été posée ! " +
                    "\n\n🎯 Partie terminée ! " +
                    "La bataille fut longue mais Josse à toute les cartes en main et à gagné la partie !");
            }
            else
            {
                return;
            }
        }

        public static void identifyCard(string joueur, int carteJoueur)
        {
            //Détermination Symbole et couleur carte
            int figureCarteJ = carte[carteJoueur];
            string figureJ = "";

            int couleurCarteJ = couleur[carteJoueur];
            string couleurJ = "";

            switch (figureCarteJ)
            {
                case SEPT:
                    figureJ = "SEPT";
                    break;

                case HUIT:
                    figureJ = "HUIT";
                    break;

                case NEUF:
                    figureJ = "NEUF";
                    break;

                case DIX:
                    figureJ = "DIX";
                    break;

                case VALET:
                    figureJ = "VALET";
                    break;

                case DAME:
                    figureJ = "DAME";
                    break;

                case ROI:
                    figureJ = "ROI";
                    break;

                case AS:
                    figureJ = "AS";
                    break;
            };

            switch (couleurCarteJ)
            {
                case PIQUE:
                    couleurJ = "PIQUE";
                    break;

                case COEUR:
                    couleurJ = "COEUR";
                    break;

                case CARREAU:
                    couleurJ = "CARREAU";
                    break;

                case TREFLE:
                    couleurJ = "TREFLE";
                    break;
            };

            Console.WriteLine(joueur + " à pioché la carte " + figureJ + " de " + couleurJ);
        }
    }
}