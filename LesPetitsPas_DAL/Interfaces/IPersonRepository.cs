using LesPetitsPas_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesPetitsPas_DAL.Interfaces
{
    public interface IPersonRepository
    {
        //public IEnumerable<Person> Get();
        public Person Get(int id);
        public Person Create(Person person);
        //public Person Delete(int id);



        // Ajouter une personne à la liste des personnes de confiance
        public int MakeTrusted(int ParentId, int PersonId);
        // Enlever une personne à la liste des accompagnateurs autorisés
        //public int RemoveTrusted(int ParentId, int PersonId);
    }
}
