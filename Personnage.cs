using System;
using System.Collections.Generic;
using System.Text;

namespace A2S3TD6
{
    class Personnage
    {
        Labyrinthe lab;
        Position position;

        public Personnage(Labyrinthe lab)
        {
            this.lab = lab;
            this.position = lab.Depart;
        }

        public bool EstArrivee()
        {
            if (lab.Matrice[lab.Arrivee.Ligne,lab.Arrivee.Colonne] == 4)
            {
                return true;
            }
            else return false;
        }
        public void DeplacementSuivant()
        {
            Console.WriteLine("Saisir nouvelle position : ");

            int x = position.Ligne;
            int y = position.Colonne;

            

            if(lab.Matrice[x-1,y] == 0|| lab.Matrice[x - 1, y] == 3 ||
                lab.Matrice[x,y+1]==0||lab.Matrice[x,y+1]==3||
                lab.Matrice[x+1,y]==0||lab.Matrice[x+1,y]==3||
                lab.Matrice[x,y-1]==0||lab.Matrice[x,y-1]==3)
            {
                Console.Write("Entree case possible : ");



            }


            Console.WriteLine(lab.toString());
        }


    }
}
