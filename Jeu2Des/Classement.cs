using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2Des
{
    // On a sortie la class Entree pour déléguer les tâches et sérialiser
    [Serializable]
    [DataContract]
    public abstract class Classement
    {
        [DataMember]
        private List<Entree> _Entrees = new List<Entree>();

        public List<Entree> Entrees
        {
            get { return _Entrees; }
            protected set { _Entrees = value; }
        }
        public Classement()
        {
           
        }

        public void AjouterEntree(string nomJoueur,int scoreJoueur)
        {
            Entree entree = new Entree(nomJoueur, scoreJoueur);
            if (!Entrees.Contains(entree))
            {
                Entrees.Add(entree);
            }          
        }
        public void TopN()
        {
            Entrees.Sort();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Scores triés du plus grand au plus petit :");
            Console.ResetColor();
            for (int i = 0; i < Entrees.Count; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine(Entrees[i]);
                }
            }
           
        }

        public abstract void Load();

        public abstract void Save();


    }
}
