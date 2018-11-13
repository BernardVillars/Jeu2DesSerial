using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu2Des
{
    static class Fabrique
    {
        public static Classement GetClassement(string cl)
        {
            if (cl=="binaire")
            {
                return new ClassementBinaire();
            }
            if (cl=="xml")
            {
                return new ClassementXml();
            }
            if (cl=="json")
            {
                return new ClassementJson();
            }
            return null;

        }
        
    }
}
