using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nous allons définir un interval borné. Entrez la borne haute");
            int borne_haute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Continuons. Entrez la borne basse");
            int borne_basse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Merci !! ;)");
            Console.WriteLine("Entrez un autre nombre pour verifier si il est dans l'interval");
            int a_test = Convert.ToInt32(Console.ReadLine());
            int resultat = 0;
            if (a_test < borne_basse)
            {
                Console.WriteLine(" tu as ecrit " + a_test + " qui est plus petit que " + borne_basse + " , le minimum");
                resultat = borne_basse;
            }
            else if (a_test > borne_haute)
            {
                Console.WriteLine(" tu as ecrit " + a_test + " which is higher than " + borne_haute + " which is the maximum");
                resultat = borne_haute;
            }
            else { Console.WriteLine("Votre nombre " + a_test + " est dans l'interval"); }
            Console.WriteLine("Résultat : " + resultat);
            Console.ReadLine();
        }
    }
}
