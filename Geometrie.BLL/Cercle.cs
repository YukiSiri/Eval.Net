using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Cercle : IForme
    {

        public int? Id { get; set; }
        public Point Centre { get; set; }
        public double Rayon { get; set; }

        public Cercle(int? id, Point centre, double rayon)
        {
            Id = id;
            Centre = centre;
            Rayon = rayon;
        }

        internal DAL.Cercle_DAL ToDAL()
        {
            if(Id == null)
                return new DAL.Cercle_DAL(Centre.ToDAL(), Rayon);
            return new DAL.Cercle_DAL(Id.Value, Centre.ToDAL(), Rayon);
        }

        public double CalculerPerimetre() => 2 * Math.PI * Rayon;

        public double CalculerAire() => Math.PI * Math.Pow(Rayon, 2);

    }
}
