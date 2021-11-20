using System;
using System.Collections.Generic;
using System.Text;

namespace A2S3TD6
{
    class Position
    {

        int ligne;
        int colonne;

        public Position(int ligne, int colonne)
        {
            if (ligne >= 0) this.ligne = ligne;
            else this.ligne = 0;
            if (colonne >= 0) this.colonne = colonne;
            else this.colonne = colonne;
        }

        public int Ligne
        {
            get { return ligne; }
            set { if (ligne >= 0) ligne = value;
                else ligne= 0;
            }
        }
        public int Colonne
        {
            get { return colonne; }
            set
            {
                if (colonne >= 0) colonne = value;
                else colonne = 0;
            }
        }


        public string toString()
        {
            return ligne.ToString() + ' ' + colonne.ToString();
        }
        public bool EstEgale(Position position)
        {
            bool same = false;

            if(position.Ligne==this.ligne && position.Colonne == this.colonne)
            {
                same = true;
            }

            return same;
        }
    }
}
