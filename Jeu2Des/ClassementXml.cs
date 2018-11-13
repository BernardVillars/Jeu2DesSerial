using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Jeu2Des
{
    public class ClassementXml:Classement
    {
        public override void Load(string rec)
        { 
            if(rec=="xml")
            {
                if (File.Exists("seri.xml"))
                {
                    Stream fichier = File.OpenRead("seri.xml");
                    XmlSerializer serializer = new XmlSerializer(typeof(ClassementXml));
                    Object obj = serializer.Deserialize(fichier);

                    //L'objet récupéré doit être casté dans sa classe pour qu'on puisse accéder à ces méthodes
                    Console.WriteLine(obj);
                    // je récupère le ou les atributs de l'objet que je désérialize et j'affecte leur valeur a leur attribut respectifs
                    this.Entrees = ((Classement)obj).Entrees;
                    fichier.Close();
                }
            }
        }
        public override void Save()
        {
            Stream fichier = File.Create("seri.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(ClassementXml));
            serializer.Serialize(fichier, this);
            fichier.Close();
        }
        public override string ToString()
        {
            return $"Jeu de dés sérialisable en xml";
        }
    }
}
