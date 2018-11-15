using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public interface IPersistance 
    {
        object Load(Type type);
        void Save(object objet);

    }
}
