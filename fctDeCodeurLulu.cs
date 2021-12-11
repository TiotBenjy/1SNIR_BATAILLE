using System;
using System.Linq;
using System.Threading;

namespace Bataille
{
    internal partial class Program
    {
        //Partie Benjamin

        public static void CreerCarte()
        {
            Console.WriteLine("\n⏲️ Création des cartes. Veuillez patienter ...");

            int k = 0;

            for (int c = 0; c < 4; c++) //boucle pour chaque couleur
            {
                for (int f = 7; f < 15; f++) //Boucle pour chaque carte, on prends les nombres de 7 à 15
                {
                    carte[k] = f; //Ajout de la carte en fonction de l'itération en cours
                    couleur[k] = c; //Ajout de la couleur en fonction de l'itération en cours
                    k++; //Ajoute 1 au competeur d'indice des tableaux
                };
            };
        }

        public static void CouperJeu()
        {
            Console.WriteLine("\n⏲️ Le jeu va être coupé, Veuillez patienter ...");

            //gestion de la file

            var listeCartesPartie = partie.ToList(); //On copie la file dans une liste
            partie.Clear(); //on vide la file ou se trouve toutes les cartes

            //Gestion de la carte piochée

            Console.Write("\nJosse donnez un nombre entre 2 et 31 : ");
            int numCarteJosse = int.Parse(Console.ReadLine());

            while (numCarteJosse < 2 || numCarteJosse > 31)
            {
                Console.Write("\nJosse le nombre entré n'est pas valide, donnez un nouveau nombre entre 2 et 31 : ");
                numCarteJosse = int.Parse(Console.ReadLine()); //On récupère le nombre entrée
            };

            identifyCard("Josse", numCarteJosse);

            Console.WriteLine("\nlulu donnez un nombre entre 2 et 31 : ");
            int numCarteLulu = int.Parse(Console.ReadLine());

            while (numCarteLulu < 2 || numCarteLulu > 31)
            {
                Console.Write("\nLulu le nombre entré n'est pas valide, donnez un nouveau nombre entre 2 et 31 : ");
                numCarteLulu = int.Parse(Console.ReadLine());
            };

            identifyCard("Lulu", numCarteLulu);

            //Gestion du coupage des cartes
            josse.Enqueue(numCarteJosse);
            lulu.Enqueue(numCarteLulu);

            for (int c = 0; c < listeCartesPartie.Count; c++)
            {
                /* Vérification du nombre entré avec les valeurs du tableau
                 * Reconstruction de la file de carte qui constitue la partie
                 */

                if (listeCartesPartie[c] == numCarteJosse)
                    continue;
                else if (listeCartesPartie[c] == numCarteLulu)
                    continue;
                else
                    partie.Enqueue(listeCartesPartie[c]);
            }
        }

        public static void BattreCarte()
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
            // Vériification symboles des cartes

            if (carte[carteJ] > carte[carteL])
            {
                josse.Enqueue(carteL);
                josse.Enqueue(carteJ);

                if (Tapis.Count != 0)
                {
                    Tapis.Reverse();

                    if (Tapis.Count > 2)
                    {
                        for (int i = 0; i < Tapis.Count; i++)
                        {
                            josse.Enqueue(Tapis.Pop());
                            josse.Enqueue(Tapis.Pop());
                        };
                    }
                    else
                    {
                        josse.Enqueue(Tapis.Pop());
                        josse.Enqueue(Tapis.Pop());
                    };
                }
            }
            else if (carte[carteJ] < carte[carteL])
            {
                lulu.Enqueue(carteJ);
                lulu.Enqueue(carteL);

                if (Tapis.Count != 0)
                {
                    if (Tapis.Count > 2)
                    {
                        for (int i = 0; i < Tapis.Count; i++)
                        {
                            josse.Enqueue(Tapis.Pop());
                            josse.Enqueue(Tapis.Pop());
                        };
                    }
                    else
                    {
                        josse.Enqueue(Tapis.Pop());
                        josse.Enqueue(Tapis.Pop());
                    };
                };
            }
            else if (carte[carteJ] == carte[carteL])
            {
                if (josse.Count > 0 && lulu.Count > 0)
                {
                    Tapis.Push(josse.Dequeue());
                    Tapis.Push(lulu.Dequeue());

                    if (josse.Count != 0 && lulu.Count != 0)
                    {
                        Console.WriteLine("\n🃏 Les joueurs ont posé le même symbole ils ajoutent une carte à l'envers.");
                        Thread.Sleep(2000);

                        numTour++;
                        Console.WriteLine("\n\u231B Tour N°{0} En cours ...", (numTour + 1));

                        int newCarteJosse = josse.Dequeue();
                        int newCarteLulu = lulu.Dequeue();

                        identifyCard("Josse", newCarteJosse);
                        identifyCard("Lulu", newCarteLulu);

                        RamasserPli(newCarteJosse, newCarteLulu);
                    }
                }
            }
        }
    }
}