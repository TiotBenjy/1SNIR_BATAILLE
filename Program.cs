using System;

namespace Bataille
{
    partial class Program
    {
        // Modélisation du jeu : Déclarer les variables 
        public const int PIQUE = 0, COEUR = 1, CARREAU = 2, TREFLE = 3; // couleurs 
        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14; // figures 

        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];
        // Todo - Déclarer les Queue et les stack ...
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(PIQUE);
            CreerCarte();
            fct2();
        }
    }
}
