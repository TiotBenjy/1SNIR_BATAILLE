using System;
using System.Collections.Generic;
using System.Threading;

namespace Bataille
{
    internal partial class Program
    {
        // Modélisation du jeu : Déclarer les variables
        public const int PIQUE = 0, COEUR = 1, CARREAU = 2, TREFLE = 3; // couleurs

        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14; // figures

        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];

        // Todo - Déclarer les Queue et les stack ...

        //Paquet de cartes
        public static int[] jeu = new int[32];

        public static Queue<int> partie = new Queue<int>(32);

        //Tas de chaque joueurs
        public static Queue<int> josse = new Queue<int>();

        public static Queue<int> lulu = new Queue<int>();

        public static Stack<int> Tapis = new Stack<int>();

        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            StartGame();

            Console.WriteLine("\n✨ Appuyez sur une touche pour commencer le jeu ...");
            Console.ReadKey();

            CreerCarte();
            Thread.Sleep(2000);
            BattreCarte();
            Thread.Sleep(3000);
            CouperJeu();
            Thread.Sleep(3000);
            Distribuerjeu();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            Jeu();
            displayWinners();

            /**
             DEBUG :
                AffTab();
             */
            Console.ReadKey();
            Credits();
            Console.WriteLine("\n✨ Appuyez sur une touche pour fermer le jeu ...");
            Console.ReadKey();
        }

        public static void StartGame()
        {
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄"
                + "\n█████░██░▄▄▄██░██░████░▄▄▀██░▄▄▄████░████░▄▄▀████░▄▄▀█░▄▄▀█▄▄░▄▄█░▄▄▀█▄░▄██░█████░█████░▄▄▄██"
                + "\n█████░██░▄▄▄██░██░████░██░██░▄▄▄████░████░▀▀░████░▄▄▀█░▀▀░███░███░▀▀░██░███░█████░█████░▄▄▄██"
                + "\n██░▀▀░██░▀▀▀██▄▀▀▄████░▀▀░██░▀▀▀████░▀▀░█░██░████░▀▀░█░██░███░███░██░█▀░▀██░▀▀░██░▀▀░██░▀▀▀██"
                + "\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        }

        private static void Credits()
        {
            Console.WriteLine("\n\n  ___             ___  "
                           + "\n (o o)           (o o)"
                           + "\n(  V  ) CRÉDITS (  V  )"
                           + "\n-m - m-------- - m - m--");

            Console.WriteLine("\n- Simon DELMOTTE");
            Console.WriteLine("- Benjamin GOURLEZ");
        }

        private static void AffTab()
        {
            Console.WriteLine("Jeu de joss : \n");

            foreach (int i in josse)
            {
                Console.Write(i + "\t ");
            }

            Console.WriteLine("\nJeu de lulu : \n ");

            foreach (int i in lulu)
            {
                Console.Write(i + "\t ");
            }
        }
    }
}