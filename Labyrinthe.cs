using System;
using System.Collections.Generic;
using System.Text;

namespace A2S3TD6
{
    class Labyrinthe
    {

        int[,] matrice;
        int nbLignes;
        int nbColonnes;

        Position depart;
        Position arrivee;

        public Labyrinthe(string[] schema, int nbLignes, int nbColonnes)
        {
            
            if (schema != null && schema.Length != 0 && nbLignes > 0 && nbColonnes > 0)
            {
                this.nbLignes = nbLignes;
                this.nbColonnes = nbColonnes;

                this.matrice = new int[nbLignes, nbColonnes];

                for (int i = 0; i < schema.Length; i++)
                {
                    for (int j = 0; j < schema[i].Length; j++)
                    {
                        
                        if (schema[i][j] == '*')
                        {
                            matrice[i, j] = 1;
                        }
                        else
                        {
                            if (schema[i][j] == 'd')
                            {
                                depart = new Position(i, j);
                                matrice[i, j] = 2;
                            }
                            else
                            {
                                if (schema[i][j] == 'a')
                                {
                                    arrivee = new Position(i, j);
                                    matrice[i, j] = 3;
                                }
                                else
                                {
                                    if (schema[i][j] == '-')
                                    {
                                        matrice[i, j] = 0;
                                    }
                                    else { matrice[i, j] = 4; }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.nbLignes = 1;
                this.nbColonnes = 1;
                this.matrice = new int[,] { };
            }
        }

        public Position Depart
        {
            get { return depart; }
        }
        public Position Arrivee
        {
            get { return arrivee; }
        }
        public int[,] Matrice
        {
            get { return matrice; }
        }

        public bool EstUnMur(Position pos)
        {
            if (matrice[pos.Ligne,pos.Colonne] == 1)
            {
                return true;
            }
            else { return false; }
        }
        public bool EstOccupee(Position pos)
        {
            if (matrice[pos.Ligne, pos.Colonne] == 4)
            {
                return true;
            }
            else { return false; }
        }
        public bool MarquerPassage(Position pos)
        {
            if (EstOccupee(pos) == false && EstUnMur(pos) == false)
            {
                matrice[pos.Ligne, pos.Colonne] = 4;
                return true;
            }
            else return false;
        }
        
        public string toString()
        {
            string txt = "";
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    
                    if (matrice[i,j] == 1)
                    {
                        txt += '*';
                    }
                    if (matrice[i, j] == 2)
                    {
                        txt += 'd';
                    }
                    if (matrice[i, j] == 3)
                    {
                        txt += 'a';

                    }
                    if (matrice[i, j] == 4)
                    {
                        txt += '.';
                    }
                    if (matrice[i, j] == 0)
                    {
                        txt += ' ';
                    }

                }
                txt += "\n";
            }
            //txt += "depart : "+depart.toString() + " arrivee : " + arrivee.toString();
            return txt;
        }

    }
}
