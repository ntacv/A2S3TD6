using System;

namespace A2S3TD6
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] schema1 = { "*******", "*d----*", "**---a*", "*******" };
            Labyrinthe lab = new Labyrinthe(schema1, 4, 7);
            Personnage personne = new Personnage(lab);

            do
            {
                personne.DeplacementSuivant();
                
            } while (!personne.EstArrivee());
            EndOfGame();

        }
        static void EndOfGame()
        {
            Console.Clear();
            Console.WriteLine("VOUS AVEZ GAGNE!!!!");
        }
    }
}
