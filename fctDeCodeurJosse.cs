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

            for (int i = 0; i < 16; i++)
            {
                josse.Enqueue(partie.Dequeue());// remplissage
                lulu.Enqueue(partie.Dequeue());//
            }
        }

        public static void Jeu()
        {
            Console.WriteLine("\n🎮 Lancement du jeu ...");

            tapisJ.Clear();
            tapisL.Clear();

            while (josse.Count > 0 && lulu.Count > 0)
            {
                int carteJosse = josse.Dequeue();
                int carteLulu = lulu.Dequeue();

                Console.WriteLine("\n\u231B Tour N°{0} En cours ...", (numTour + 1));

                identifyCard(carteJosse, carteLulu);
                RamasserPli(carteJosse, carteLulu);

                numTour++;
                Thread.Sleep(1000);
            };

            Console.WriteLine("\n🎯 Partie terminée ! Voici les résultats :");
        }

        public static void displayWinners()
        {
            int pointsJosse = 0, pointsLulu = 0;

            foreach (int NCarte in tapisL)
                pointsLulu = pointsLulu + carte[NCarte];

            foreach (int NCarte in tapisJ)
                pointsJosse = pointsJosse + carte[NCarte];

            if (pointsJosse == pointsLulu)
            {
                Console.WriteLine("\n💢 Les 2 joueurs ont le même score avec {0} points !", pointsLulu);
            }
            else if (pointsJosse > pointsLulu)
            {
                if (TempTas.Count != 0)
                    foreach (int NCarte in TempTas)
                        pointsJosse = pointsJosse + carte[NCarte];

                Console.WriteLine("\n✅ Joss à gagné la bataille avec {0} points !", pointsJosse);
                Console.WriteLine("❌ Lulu à perdu la bataille avec {0} points !", pointsLulu);
            }
            else
            {
                if (TempTas.Count != 0)
                    foreach (int NCarte in TempTas)
                        pointsLulu = pointsLulu + carte[NCarte];

                Console.WriteLine("\n✅Lulu à gagné la bataille avec {0} points !", pointsLulu);
                Console.WriteLine("❌ Joss à perdu la bataille avec {0} points !", pointsJosse);
            }
        }

        public static void identifyCard(int carteJosse, int carteLulu)
        {
            if (couleur[carteJosse] == COEUR)
            {
                if (carte[carteJosse] == SEPT)
                {
                    Console.WriteLine("Josse joue la carte 7 de Coeur");
                }
                else if (carte[carteJosse] == HUIT)
                {
                    Console.WriteLine("Josse joue la carte 8 de Coeur");
                }
                else if (carte[carteJosse] == NEUF)
                {
                    Console.WriteLine("Josse joue la carte 9 de Coeur");
                }
                else if (carte[carteJosse] == DIX)
                {
                    Console.WriteLine("Josse joue la carte 10 de Coeur");
                }
                else if (carte[carteJosse] == VALET)
                {
                    Console.WriteLine("Josse joue la carte Valet de Coeur");
                }
                else if (carte[carteJosse] == DAME)
                {
                    Console.WriteLine("Josse joue la carte Dame de Coeur");
                }
                else if (carte[carteJosse] == ROI)
                {
                    Console.WriteLine("Josse joue la carte Roi de Coeur");
                }
                else if (carte[carteJosse] == AS)
                {
                    Console.WriteLine("Josse joue la carte AS de Coeur");
                }
            }
            else if (couleur[carteJosse] == CARREAU)
            {
                if (carte[carteJosse] == SEPT)
                {
                    Console.WriteLine("Josse joue la carte 7 de Carreau");
                }
                else if (carte[carteJosse] == HUIT)
                {
                    Console.WriteLine("Josse joue la carte 8 de Carreau");
                }
                else if (carte[carteJosse] == NEUF)
                {
                    Console.WriteLine("Josse joue la carte 9 de Carreau");
                }
                else if (carte[carteJosse] == DIX)
                {
                    Console.WriteLine("Josse joue la carte 10 de Carreau");
                }
                else if (carte[carteJosse] == VALET)
                {
                    Console.WriteLine("Josse joue la carte Valet de Carreau");
                }
                else if (carte[carteJosse] == DAME)
                {
                    Console.WriteLine("Josse joue la carte Dame de Carreau");
                }
                else if (carte[carteJosse] == ROI)
                {
                    Console.WriteLine("Josse joue la carte Roi de Carreau");
                }
                else if (carte[carteJosse] == AS)
                {
                    Console.WriteLine("Josse joue la carte AS de Carreau");
                }
            }
            else if (couleur[carteJosse] == PIQUE)
            {
                if (carte[carteJosse] == SEPT)
                {
                    Console.WriteLine("Josse joue la carte 7 de Pique");
                }
                else if (carte[carteJosse] == HUIT)
                {
                    Console.WriteLine("Josse joue la carte 8 de Pique");
                }
                else if (carte[carteJosse] == NEUF)
                {
                    Console.WriteLine("Josse joue la carte 9 de Pique");
                }
                else if (carte[carteJosse] == DIX)
                {
                    Console.WriteLine("Josse joue la carte 10 de Pique");
                }
                else if (carte[carteJosse] == VALET)
                {
                    Console.WriteLine("Josse joue la carte Valet de Pique");
                }
                else if (carte[carteJosse] == DAME)
                {
                    Console.WriteLine("Josse joue la carte Dame de Pique");
                }
                else if (carte[carteJosse] == ROI)
                {
                    Console.WriteLine("Josse joue la carte Roi de Pique");
                }
                else if (carte[carteJosse] == AS)
                {
                    Console.WriteLine("Josse joue la carte AS de Pique");
                }
            }
            else if (couleur[carteJosse] == TREFLE)
            {
                if (carte[carteJosse] == SEPT)
                {
                    Console.WriteLine("Josse joue la carte 7 de Trèfle");
                }
                else if (carte[carteJosse] == HUIT)
                {
                    Console.WriteLine("Josse joue la carte 8 de Trèfle");
                }
                else if (carte[carteJosse] == NEUF)
                {
                    Console.WriteLine("Josse joue la carte 9 de Trèfle");
                }
                else if (carte[carteJosse] == DIX)
                {
                    Console.WriteLine("Josse joue la carte 10 de Trèfle");
                }
                else if (carte[carteJosse] == VALET)
                {
                    Console.WriteLine("Josse joue la carte Valet de Trèfle");
                }
                else if (carte[carteJosse] == DAME)
                {
                    Console.WriteLine("Josse joue la carte Dame de Trèfle");
                }
                else if (carte[carteJosse] == ROI)
                {
                    Console.WriteLine("Josse joue la carte Roi de Trèfle");
                }
                else if (carte[carteJosse] == AS)
                {
                    Console.WriteLine("Josse joue la carte AS de Trèfle");
                }
            }

            if (couleur[carteLulu] == COEUR)
            {
                if (carte[carteLulu] == SEPT)
                {
                    Console.WriteLine("Lulu joue la carte 7 de Coeur");
                }
                else if (carte[carteLulu] == HUIT)
                {
                    Console.WriteLine("Lulu joue la carte 8 de Coeur");
                }
                else if (carte[carteLulu] == NEUF)
                {
                    Console.WriteLine("Lulu joue la carte 9 de Coeur");
                }
                else if (carte[carteLulu] == DIX)
                {
                    Console.WriteLine("Lulu joue la carte 10 de Coeur");
                }
                else if (carte[carteLulu] == VALET)
                {
                    Console.WriteLine("Lulu joue la carte Valet de Coeur");
                }
                else if (carte[carteLulu] == DAME)
                {
                    Console.WriteLine("Lulu joue la carte Dame de Coeur");
                }
                else if (carte[carteLulu] == ROI)
                {
                    Console.WriteLine("Lulu joue la carte Roi de Coeur");
                }
                else if (carte[carteLulu] == AS)
                {
                    Console.WriteLine("Lulu joue la carte AS de Coeur");
                }
            }
            else if (couleur[carteLulu] == CARREAU)
            {
                if (carte[carteLulu] == SEPT)
                {
                    Console.WriteLine("Lulu joue la carte 7 de Carreau");
                }
                else if (carte[carteLulu] == HUIT)
                {
                    Console.WriteLine("Lulu joue la carte 8 de Carreau");
                }
                else if (carte[carteLulu] == NEUF)
                {
                    Console.WriteLine("Lulu joue la carte 9 de Carreau");
                }
                else if (carte[carteLulu] == DIX)
                {
                    Console.WriteLine("Lulu joue la carte 10 de Carreau");
                }
                else if (carte[carteLulu] == VALET)
                {
                    Console.WriteLine("Lulu joue la carte Valet de Carreau");
                }
                else if (carte[carteLulu] == DAME)
                {
                    Console.WriteLine("Lulu joue la carte Dame de Carreau");
                }
                else if (carte[carteLulu] == ROI)
                {
                    Console.WriteLine("Lulu joue la carte Roi de Carreau");
                }
                else if (carte[carteLulu] == AS)
                {
                    Console.WriteLine("Lulu joue la carte AS de Carreau");
                }
            }
            else if (couleur[carteLulu] == PIQUE)
            {
                if (carte[carteLulu] == SEPT)
                {
                    Console.WriteLine("Lulu joue la carte 7 de Pique");
                }
                else if (carte[carteLulu] == HUIT)
                {
                    Console.WriteLine("Lulu joue la carte 8 de Pique");
                }
                else if (carte[carteLulu] == NEUF)
                {
                    Console.WriteLine("Lulu joue la carte 9 de Pique");
                }
                else if (carte[carteLulu] == DIX)
                {
                    Console.WriteLine("Lulu joue la carte 10 de Pique");
                }
                else if (carte[carteLulu] == VALET)
                {
                    Console.WriteLine("Lulu joue la carte Valet de Pique");
                }
                else if (carte[carteLulu] == DAME)
                {
                    Console.WriteLine("Lulu joue la carte Dame de Pique");
                }
                else if (carte[carteLulu] == ROI)
                {
                    Console.WriteLine("Lulu joue la carte Roi de Pique");
                }
                else if (carte[carteLulu] == AS)
                {
                    Console.WriteLine("Lulu joue la carte AS de Pique");
                }
            }
            else if (couleur[carteLulu] == TREFLE)
            {
                if (carte[carteLulu] == SEPT)
                {
                    Console.WriteLine("Lulu joue la carte 7 de Trèfle");
                }
                else if (carte[carteLulu] == HUIT)
                {
                    Console.WriteLine("Lulu joue la carte 8 de Trèfle");
                }
                else if (carte[carteLulu] == NEUF)
                {
                    Console.WriteLine("Lulu joue la carte 9 de Trèfle");
                }
                else if (carte[carteLulu] == DIX)
                {
                    Console.WriteLine("Lulu joue la carte 10 de Trèfle");
                }
                else if (carte[carteLulu] == VALET)
                {
                    Console.WriteLine("Lulu joue la carte Valet de Trèfle");
                }
                else if (carte[carteLulu] == DAME)
                {
                    Console.WriteLine("Lulu joue la carte Dame de Trèfle");
                }
                else if (carte[carteLulu] == ROI)
                {
                    Console.WriteLine("Lulu joue la carte Roi de Trèfle");
                }
                else if (carte[carteLulu] == AS)
                {
                    Console.WriteLine("Lulu joue la carte AS de Trèfle");
                }
            }
        }
    }
}