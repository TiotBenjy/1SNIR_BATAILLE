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
        // Modélisation du jeu : Déclarer les variables 
        public const int PIQUE = 0, COEUR = 1, CARREAU = 2, TREFLE = 3; // couleurs 
        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14; // figures 

        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];

        // Todo - Déclarer les Queue et les stack ...

        public static int[] jeu = new int[32];

        public static Queue<int> partie = new Queue<int>();
        public static Queue<int> josse = new Queue<int>();
        public static Queue<int> lulu = new Queue<int>();
        public static Stack<int> tapisJ = new Stack<int>();
        public static Stack<int> tapisL = new Stack<int>();

        static void Main(string[] args)
        {
            CreerCarte();
            BattreCarte();
            Distribuerjeu();

            AffTab();

            Console.ReadKey();
        }
        
        static void AffTab()
        {
            Console.WriteLine("Jeu de joss : \n");

            foreach (int i in josse)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine("\nJeu de lulu : \n ");

            foreach (int i in lulu)
            {                
                Console.Write(i + "\t");
            }
        }

    }
}
