using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxTest
{
    class Program
    {
        static void Main(string[] args)
        {   
            Joueur joue = new Joueur("Thor", "Bleu");
            Vilian vic = new Vilian("Locky", "Rouge");
            
            joue.Affichage();
            Console.WriteLine();
            vic.Affichage();

            Console.WriteLine();
                Console.WriteLine("Vouliez vous commencé ? (O/N)");
                string saisie = Console.ReadLine().ToUpper();

                    if (saisie == "O")
                    {
                        
            jouer(new Joueur("Thor", "Bleu"));
                    }else if (saisie == "N")
                    {
                        
                Console.WriteLine("Au revoir...");
                        Environment.Exit(0);
                    }
            
        }
          static void jouer(Personnage monPers)
        {
            Vilian mons = new Vilian("Locky", "Rouge");

            while (!mons.isDead())
            {
                //Tour du  assa
                Console.ForegroundColor = ConsoleColor.Red;
                mons.Attaquer(monPers);
                Console.WriteLine();
                Console.ReadKey(true);

                if(monPers.isDead()){
                    break;
                }

                //Tour de l'acteur
                Console.ForegroundColor = ConsoleColor.Blue;
                monPers.Attaquer(mons);
                Console.WriteLine();
                Console.ReadKey(true);

            }
        }
    }
}
