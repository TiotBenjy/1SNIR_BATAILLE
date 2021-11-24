using System;

namespace Bataille
{
    partial class Program
    {
        static void fct2()
        {
            
        }

         
         static void CreerCartes()
         {
            int i = 0;

            for(int c = 0; c < 4; c++)
            {
                for(int f = 7; f < 15; f++)
                {
                    carte[i] = f;
                    couleur[i] = c;
                    i++;
                };
            };
         }
    }
}