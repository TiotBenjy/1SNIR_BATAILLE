using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bataille
{
    partial class Program
    {

        //Benjamin 

        static void fct1()
        {
           /* Console.WriteLine("Hello fct1!");
            carte[0] = PIQUE;
            Console.WriteLine(CARREAU);*/
           
        }

        
        static void CreerCarte() //Fonction création cartes
        {
            int i = 0;

            for (int c = 0; c < 4; c++) //boucle pour chaque couleur
            {
                for (int f = 7; f < 15; f++) //Boucle pour chaque carte, on prends les nombres de 7 à 15
                {
                    carte[i] = f;
                    couleur[i] = c;
                    i++;
                };
            };
        }

        static void BattreCarte()
        {
            // Ajoute au tableau toutes les valeurs de 0 à 31
            jeu = Enumerable.Range(0, 32).ToArray();

            Random rnd = new Random();

            // Pour chaque valeur du tableuau
            for(int i = 0; i < jeu.Length; i++)
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

        static void RamasserPli()
        {
            josse.Enqueue(tapisL.Pop());
        }

        public static int GenerateRandomInt()
        {
            int minVal = 0, maxVal = 31;

            var rnd = new byte[4];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(rnd);
            var i = Math.Abs(BitConverter.ToInt32(rnd, 0));

            return Convert.ToInt32(i % (maxVal - minVal + 1) + minVal);
        }

        
    }
}