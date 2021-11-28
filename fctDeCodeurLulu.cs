using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Bataille
{
    internal partial class Program
    {
        //Benjamin

        private static void fct1()
        {
            /* Console.WriteLine("Hello fct1!");
             carte[0] = PIQUE;
             Console.WriteLine(CARREAU);*/
        }

        public static Queue<int> TempTas = new Queue<int>();

        private static void CreerCarte() //Fonction création cartes
        {
            Console.WriteLine("\n⏲️ Création des cartes. Veuillez patienter ...");

            int k = 0;

            for (int c = 0; c < 4; c++) //boucle pour chaque couleur
            {
                for (int f = 7; f < 15; f++) //Boucle pour chaque carte, on prends les nombres de 7 à 15
                {
                    carte[k] = f;
                    couleur[k] = c;
                    k++;
                };
            };
        }

        private static void BattreCarte()
        {
            Console.WriteLine("\n⌛ Mélange des cartes en cours. Veuillez patienter ...");

            // Ajoute au tableau toutes les valeurs de 0 à 31
            jeu = Enumerable.Range(0, 32).ToArray();

            Random rnd = new Random();

            // Pour chaque valeur du tableuau
            for (int i = 0; i < jeu.Length; i++)
            {
                int j = rnd.Next(i, jeu.Length); // On génère un nombre entre le l'index du tableau et le nombre de valeurs du tableau

                int temp = jeu[i]; // On stoque la valeur de l'itération dans une variable temp
                jeu[i] = jeu[j]; // On inverse la valeur de litération avec la valeur de l'index générée
                jeu[j] = temp; // On remplace la valeur par la valeur temporaire
            }

            foreach (int carte in jeu)
            {
                //Console.WriteLine(carte);
                partie.Enqueue(carte);
            };
        }

        public static void RamasserPli(int carteJ, int carteL)
        {
            int newCarteJosse = 0, newCarteLulu = 0;

            if (carte[carteJ] > carte[carteL])
            {
                tapisJ.Push(carteJ);
                tapisJ.Push(carteL);

                if (TempTas.Count != 0)
                {
                    foreach (int carte in TempTas)
                        tapisJ.Push(carte);
                }
            }
            else if (carte[carteJ] < carte[carteL])
            {
                tapisL.Push(carteJ);
                tapisL.Push(carteL);

                if (TempTas.Count != 0)
                {
                    foreach (int carte in TempTas)
                        tapisJ.Push(carte);
                }
            }
            else if (carte[carteJ] == carte[carteL])
            {
                if (josse.Count != 0 && lulu.Count != 0)
                {
                    TempTas.Enqueue(josse.Dequeue());
                    TempTas.Enqueue(lulu.Dequeue());

                    if (josse.Count != 0 && lulu.Count != 0)
                    {
                        Console.WriteLine("\n🃏 Les joueurs ont posé le même symbole ils ajoutent une carte à l'envers.");
                        Thread.Sleep(2000);

                        numTour++;
                        Console.WriteLine("\n\u231B Tour N°{0} En cours ...", (numTour + 1));

                        newCarteJosse = josse.Dequeue();
                        newCarteLulu = lulu.Dequeue();

                        identifyCard(newCarteJosse, newCarteLulu);
                        RamasserPli(newCarteJosse, newCarteLulu);
                    }
                }
            }
        }
    }
}