using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3__C_
{
    internal class RH implements IRessourcesHumaines
    {
        private Liste<Personnel> GRH;
    public RH()
    {
        GRH = new Liste<Personnel>();
    }
    public void afficher_enseignants()
    {
        foreach (Personnel p in GRH)
        {
            if (p is Enseignant)
            {
                p.Afficher();
            }
        }
    }
    public int rechercher_enseignant(int code)
    {
        for (int i = 0; i < GRH.Count; i++)
        {
            if (GRH[i] is Enseignant)
            {
                if (((Enseignant)GRH[i]).Code == code)
                {
                    return i;
                }
            }
        }
        return -1;
    }


}
}
