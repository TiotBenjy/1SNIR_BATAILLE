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
        
        public static void Distribuerjeu()
        {
            //Enqueue();
            //Dequeue();


           for ( int i = 0; i < 16; i++ )
            {
                josse.Enqueue(partie.Dequeue());
                lulu.Enqueue(partie.Dequeue());
            }
        }
       
    }
}