using System;

namespace LesPetitsPas_API.Interfaces
{
    public interface IAdminRepository
    {
        #region Bus
        public IEnumerable<Bus> Get();
        public Bus Get(int id);
        public Bus Create();
        public Bus Delete(int id);
        #endregion

        #region Person
        public IEnumerable<Person> Get();
        public Person Get(int id);
        public Person Create();
        public Person Delete(int id);
        #endregion

        #region Child
        public IEnumerable<Child> Get();
        public Child Get(int id);
        public Child Create();
        public Child Delete(int id);
        #endregion

        #region Guide
        // Ajouter une personne à la liste des accompagnateurs autorisés
        public int MakeGuide(int id);
        // Enlever une personne à la liste des accompagnateurs autorisés
        public int RemoveGuide(int id);
        #endregion

        #region Trusted
        // Ajouter une personne à la liste des personnes de confiance
        public int MakeTrusted(int ParentId, int PersonId);
        // Enlever une personne à la liste des accompagnateurs autorisés
        public int RemoveTrusted(int ParentId, int PersonId);
        #endregion

        #region ChildBus
        public int PutOnBus(int ChildId, int BusId);
        #endregion
        #region StaffBus
        public int PutStaffOnBus(int GuideId, int BusId, bool isDriver);
        #endregion
    }
}
1