using Geometrie.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geometrie.BLL.Depots
{
    public class Cercle_Depot : IDepot<Cercle_DAL>
    {
        private List<Cercle_DAL> cercles = new List<Cercle_DAL>();

        public Cercle_DAL Add(Cercle_DAL element)
        {
            var Cercle_DAL = new Cercle_DAL(element.Centre, element.Rayon);
            Cercle_DAL.Id = cercles.Count + 1;
            cercles.Add(Cercle_DAL);
            return Cercle_DAL;
        }

        public IDepot<Cercle_DAL> Delete(Cercle_DAL element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            cercles.Remove(element);
            return this;
        }

        public IDepot<Cercle_DAL> Delete(int Id)
        {
            var cercle = GetById(Id);
            if (cercle != null)
            {
                Delete(cercle);
            }

            return this;
        }

        public IEnumerable<Cercle_DAL> GetAll()
        {
            return cercles;
        }

        public Cercle_DAL GetById(int id)
        {
            return cercles.FirstOrDefault(c => c.Id == id);
        }

        public Cercle_DAL Update(Cercle_DAL element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            var cercle = GetById(element.Id.Value);
            if (cercle != null)
            {
                cercle.Centre = element.Centre;
                cercle.Rayon = element.Rayon;
            }

            return cercle;
        }
    }
}