using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxTest
{
    public class Joueur : Personnage
    {

        public Joueur(string pseudo, string couleur):base(pseudo, couleur){
           pointVie = 40;
           degaMin = 3;
           degaMax = 7;
       }

       //On fera appel a cette methode pour attaquer
       
    }
}
