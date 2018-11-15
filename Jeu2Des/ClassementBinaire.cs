using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jeu2Des
{
    [Serializable]
    public class ClassementBinaire : Classement
    {

        public override void Load()
        {

            if (File.Exists("seri.txt"))
            {

                Stream fichier = File.OpenRead("seri.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                Object obj = serializer.Deserialize(fichier);

                //L'objet récupéré doit être casté dans sa classe pour qu'on puisse accéder à ces méthodes
                Console.WriteLine(obj);
                // je récupère le ou les atributs de l'objet que je désérialize et j'affecte leur valeur a leur attribut respectifs
                this.Entrees = ((Classement)obj).Entrees;
                fichier.Close();
            }

        }

        public override void Save()
        {
            Stream fichier = File.Create("seri.txt");
            BinaryFormatter serial = new BinaryFormatter();
            serial.Serialize(fichier, this);
            fichier.Close();
        }
        public override string ToString()
        {
            return $"Jeu de dés sérialisable en binaire";
        }
    }
}
