using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille
{
    partial class Program
    {
        static void fct1()
        {
           /* Console.WriteLine("Hello fct1!");
            carte[0] = PIQUE;
            Console.WriteLine(CARREAU);*/
           
        }

        
        static void CreerCarte()
        {
            int i = 0;

            for (int c = 0; c < 4; c++)
            {
                for (int f = 7; f < 15; f++)
                {
                    carte[i] = f;
                    couleur[i] = c;
                    i++;
                };
            };
        }

        static void BattreCarte()
        {
            Random aleatoire = new Random();

            int a = 0;

            for(int i = 0; i < 32; i++)
            {
                a = aleatoire.Next(0,31);
                jeu[i] = a;
            }

            foreach(int i in jeu)
            {
                partie.Enqueue(i);
            }
        }

    }
}