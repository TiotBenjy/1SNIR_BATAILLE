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

            for (int i = 0; i <= 15; i++)
            {
                josse.Enqueue(partie.Dequeue());
                lulu.Enqueue(partie.Dequeue());
            }
                
            else
                Console.WriteLine("josse a gagné");


        }
       
    }
}