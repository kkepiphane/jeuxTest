using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxTest
{
    public class Vilian : Personnage
    {
       public Vilian(string pseudo, string couleur):base(pseudo, couleur){
           pointVie = 50;
           degaMin = 4;
           degaMax = 8;
       }
    }
}
