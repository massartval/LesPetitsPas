using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Interfaces
{
    internal interface IGuid
    {
        // Ajouter une personne à la liste des accompagnateurs autorisés
        public int MakeGuide(int id);
        // Enlever une personne à la liste des accompagnateurs autorisés
        public int RemoveGuide(int id);
    }
}
