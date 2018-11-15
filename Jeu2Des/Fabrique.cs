using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    static class Fabrique
    {
        public static Classement CreerPersistance(TypePersistance type)
        {
            if (type == TypePersistance.Xml)
                return new ClassementXml();
            if (type == TypePersistance.Json)
                return new ClassementJson();
            return new ClassementBinaire();
        }

    }
}
