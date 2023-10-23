using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxTest
{
    public abstract class Personnage
    {
       protected string pseudo{set; get;}
       protected string couleur{set; get;}
       protected bool nivoVie = false; // Voir la personnage meurt ou pas
       protected int pointVie;
       protected int degaMax;
       protected int degaMin;
       protected Random ram = new Random();

       public Personnage(string pseudo, string couleur){
           this.pseudo = pseudo;
           this.couleur = couleur;
       }

       //On fera appel a cette methode pour attaquer
       public void Attaquer(Personnage uneEntite){
            int degats = ram.Next(degaMin, degaMax);

            uneEntite.PerdrePointVie(degats);
            
            Console.WriteLine(this.pseudo + "(" + this.pointVie+")" + "attaque : "+ uneEntite.pseudo);
            Console.WriteLine(uneEntite.pseudo + " a perdu (" + degats+")" + " de vie");
            Console.WriteLine("Il reste que (" + uneEntite.pointVie+")" + "attaque : "+ uneEntite.pseudo);

            if (uneEntite.nivoVie)
            {
                Console.WriteLine(uneEntite.pseudo + " est mort "); 
            }

             if (uneEntite.pointVie >= 19 && uneEntite.pointVie <= 21)
           {
               int mana = ram.Next(10, 15);
               Mana ma = new Mana("Vert", mana);
               uneEntite.pointVie = mana + uneEntite.pointVie;
               ma.boireMana();
               Console.WriteLine(uneEntite.pseudo + " a gagné de mana de quatité ("+ mana + ") Vie Total = "+uneEntite.pointVie); 
           }
       }
       //Cette Methode permettra de perdre de vie

       protected void PerdrePointVie(int pointVie){
        

           this.pointVie -=pointVie;

           if (this.pointVie <= 0)
           {
               this.pointVie = 0;
               nivoVie = true;
           }
           

          
       }

       public bool isDead(){
           return  this.nivoVie;
       }

         //On fera appel a cette methode pour attaquer
       public void Affichage(){
            Console.WriteLine("Personnage : "+ this.pseudo + " à une Couleur : "+ this.couleur);

       }
    }
}
