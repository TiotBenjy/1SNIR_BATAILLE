using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bataille
{
    partial class Program//simon
    {
        
        public static void Distribuerjeu()
        {
            //Enqueue();
            //Dequeue();

            for (int i = 0; i <= 15; i++)
            {
                josse.Enqueue(partie.Dequeue());//remplissage de la queue avec les 16 premieres carte de la queue partie
                lulu.Enqueue(partie.Dequeue());//remplissage de la queue avec les 16 dernieres carte de la queue partie
            }
        }
       
    }
}