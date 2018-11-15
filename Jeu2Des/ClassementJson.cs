using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Jeu2Des
{
    [DataContract]
    public class ClassementJson :Classement
    {

        public override void Load()
        {
            if (File.Exists("seri.json"))
            {
                Stream fichier = File.OpenRead("seri.json");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Entree>));
                List<Entree> listRecup = (List<Entree>)serializer.ReadObject(fichier);

                this.Entrees = listRecup;
                fichier.Close();
            }
        }
        public override void Save()
        {
            Stream fichier = File.Create("seri.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Entree>));
            serializer.WriteObject(fichier, this.Entrees);
            fichier.Close();
        }
        public override string ToString()
        {
            return $"Jeu de dés sérialisable en Json";
        }
    }
}
