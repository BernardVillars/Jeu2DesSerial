using Jeu2Des;
using System;
using Persistance;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Le jeu est crée (avec ses 2 des et son classement)
            Jeu MonJeu = new Jeu(TypePersistance.Xml);
           
            //MonJeu.Load();
            //Jouons quelques parties ....

            MonJeu.JouerPartie(); //1ere partie avec un joueur par défaut
            MonJeu.JouerPartie(); //2eme partie avec un joueur par défaut
            MonJeu.JouerPartie("David"); //3eme partie
            MonJeu.JouerPartie("David"); //Encore une partie  
            MonJeu.JouerPartie("Sarah"); //Encore une partie 
            MonJeu.JouerPartie("Lucie"); //Encore une partie
            MonJeu.JouerPartie(); //Encore une partie 
            MonJeu.MeilleursScore();
            MonJeu.terminer();
            Console.ReadKey();
        }
    }
}
