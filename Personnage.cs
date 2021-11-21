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
            //return position == lab.Arrivee;
        }
        public void DeplacementSuivant()
        {
            Console.WriteLine("Saisir nouvelle position : ");

            int x = position.Ligne;
            int y = position.Colonne;

            Console.Write(lab.toString());

            Console.Write("Entree case possible (z,q,s,d): ");
            char inputKey;
            bool possiblePosition = false;
            do
            {
                inputKey = Console.ReadKey().KeyChar;
                    
                for (int i=0;i< directionPossible(lab,position).Length;i++)
                {
                    if(inputKey == directionPossible(lab, position)[i] && inputKey!=' ')
                    {
                        possiblePosition = true;
                    }
                    Console.Write(directionPossible(lab, position)[i]);
                }
            } while (!possiblePosition);
                
            switch (inputKey)
            {
                case 'z':
                    Console.Write("up");
                    position = new Position(position.Ligne - 1, position.Colonne);
                    break;
                case 's':
                    Console.Write("down");
                    position = new Position(position.Ligne + 1, position.Colonne);
                    break;
                case 'q':
                    Console.Write("left");
                    position = new Position(position.Ligne, position.Colonne-1);
                    break;
                case 'd':
                    Console.Write("right");
                    position = new Position(position.Ligne, position.Colonne+1);
                    break;
                default:
                    break;
            }

            lab.MarquerPassage(position);
        }


        public static char[] directionPossible(Labyrinthe lab, Position position)
        {
            char[] key = new char[] {' ',' ',' ',' '};
            int x = position.Ligne;
            int y = position.Colonne;
            
            if (lab.Matrice[x, y - 1] == 0 || lab.Matrice[x, y - 1] == 3)
            {//Si la case du haut n'est pas un mur
                key[0] = 'q';
            }
            if (lab.Matrice[x - 1, y] == 0 || lab.Matrice[x - 1, y] == 3)
            {
                key[1] = 'z';
            }
            if(lab.Matrice[x, y + 1] == 0 || lab.Matrice[x, y + 1] == 3)
            {
                key[2] = 'd';
            }
            if (lab.Matrice[x + 1, y] == 0 || lab.Matrice[x + 1, y] == 3)
            {
                key[3] = 's';
            }
            return key;
        }
    }
}
