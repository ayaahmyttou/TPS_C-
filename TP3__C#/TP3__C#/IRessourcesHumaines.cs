using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal interface IRessourcesHumaines
    {
        public void afficher_enseignants();
        public int rechercher_enseignant(int code);
    }
}
