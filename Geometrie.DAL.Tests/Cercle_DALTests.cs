using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL.Tests
{
    public class Cercle_DALTests
    {
        [Fact]
        public void Cercle_DAL_Centre_Rayon()
        {
            // Arrange
            Point_DAL centre = new Point_DAL(1, 2);
            double rayon = 3;

            // Act
            Cercle_DAL cercle = new Cercle_DAL(centre, rayon);

            // Assert
            Assert.Equal(centre, cercle.Centre);
            Assert.Equal(rayon, cercle.Rayon);
        }

        [Fact]
        public void Cercle_DAL_Id_Centre_Rayon()
        {
            // Arrange
            int id = 1;
            Point_DAL centre = new Point_DAL(1, 2);
            double rayon = 3;

            // Act
            Cercle_DAL cercle = new Cercle_DAL(id, centre, rayon);

            // Assert
            Assert.Equal(id, cercle.Id);
            Assert.Equal(centre, cercle.Centre);
            Assert.Equal(rayon, cercle.Rayon);
        }
    }
}
