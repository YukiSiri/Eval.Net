using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrie.BLL.Depots;
using Geometrie.DAL;
using Geometrie.DTO;
using Geometrie.BLL;

namespace Geometrie.Service
{
    public class Cercle_Service : IDepot<Cercle_DTO>
    {
        private GeometrieContext context;
        private IDepot<Cercle_DTO> depot;

        public Cercle_Service(IDepot<Cercle_DTO> depot)
        {
            ArgumentNullException.ThrowIfNull(depot, nameof(depot));
            this.depot = depot;
        }


        public Cercle_DTO Add(Cercle_DTO element)
        {
            var Cercle = new Cercle_DAL(new Point_DAL(element.Centre.X, element.Centre.Y), element.Rayon);
            var cercle = depot.Add(element);
            return new Cercle_DTO
            {
                Id = cercle.Id,
                Centre = new Point_DTO { X = cercle.Centre.X, Y = cercle.Centre.Y },
                Rayon = cercle.Rayon
            };
        }

        public double calculerAire(Cercle_DTO cercle)
        {
            //arrange
            double aire = 0;
            //act
            aire = Math.PI * Math.Pow(cercle.Rayon, 2);
            //assert
            return aire;
        }

        public double calculerPerimetre(Cercle_DTO cercle)
        {
            return 2 * Math.PI * cercle.Rayon;
        }

        public IDepot<Cercle_DTO> Delete(Cercle_DTO element)
        {
            return depot.Delete(element);
        }

        public IDepot<Cercle_DTO> Delete(int Id)
        {
            return depot.Delete(Id);
        }

        public IEnumerable<Cercle_DTO> GetAll()
        {
            var cercles = depot.GetAll();
            return cercles.Select(c => new Cercle_DTO
            {
                Id = c.Id,
                Centre = new Point_DTO { X = c.Centre.X, Y = c.Centre.Y },
                Rayon = c.Rayon
            });
        }

        public Cercle_DTO GetById(int id)
        {
            var cercle = depot.GetById(id);
            return new Cercle_DTO
            {
                Id = cercle.Id,
                Centre = new Point_DTO { X = cercle.Centre.X, Y = cercle.Centre.Y },
                Rayon = cercle.Rayon
            };
        }

        public Cercle_DTO Update(Cercle_DTO element)
        {
            var cercle = depot.Update(element);
            return new Cercle_DTO
            {
                Id = cercle.Id,
                Centre = new Point_DTO { X = cercle.Centre.X, Y = cercle.Centre.Y },
                Rayon = cercle.Rayon
            };
        }
    }
}
