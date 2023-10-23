using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxTest
{
    public class Mana
    {
        string couleur;
        int vie;

        public Mana(string couleur, int vie){
           this.couleur = couleur;
           this.vie = vie;
        }

        public void boireMana(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mana de couleur : "+ this.couleur + " quantité : "+ this.vie);
            Console.WriteLine();
        }
    }
}
