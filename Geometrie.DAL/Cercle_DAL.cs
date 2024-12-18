using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL
{
    public class Cercle_DAL
    {
        public int? Id { get; set; }
        public Point_DAL Centre { get; set; }
        public double Rayon { get; set; }

        public Cercle_DAL(Point_DAL centre, double rayon)
        {
            Centre = centre;
            Rayon = rayon;
        }

        public Cercle_DAL(int id, Point_DAL centre, double rayon)
            : this(centre, rayon)
        {
            Id = id;
        }


    }
}
