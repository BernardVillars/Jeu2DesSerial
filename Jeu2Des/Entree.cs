using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Jeu2Des
{

    [Serializable]
    public class Entree : IComparable
    {
        private string _NomJoueur;
        public string NomJoueur

        {
            get { return _NomJoueur; }
            set { _NomJoueur = value; }
        }
        private int _Score;
        public int Score

        {
            get { return _Score; }
            set { _Score = value; }
        }
        //Constructeur par défaut dont la désérialisation Xml à besoin
        public Entree()
        {
        }

        public Entree(string nomJoueur, int score)
        {
            _NomJoueur = nomJoueur;
            _Score = score;
        }
        public override int GetHashCode()
        {
            return Score.GetHashCode();
        }
        public int CompareTo(object obj)
        {
            Entree other = obj as Entree;
            if (other is Entree)
            {
                //*-1 permet de trier dans l'ordre décroissant
                return this.Score.CompareTo(other.Score) * -1;
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Nom du joueur: {NomJoueur}; Score: {Score}";
        }
    }
}
