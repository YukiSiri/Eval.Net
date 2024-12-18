using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL.Tests
{
    public class CercleTests
    {
        [Fact]
        public void Geometrie_BLL_Cercle_Constructor()
        {
            //Arrange
            int id = 1;
            Point centre = new Point(1, 2);
            double rayon = 3;

            //Act
            Cercle cercle = new Cercle(id, centre, rayon);

            //Assert
            Assert.Equal(id, cercle.Id);
            Assert.Equal(centre, cercle.Centre);
            Assert.Equal(rayon, cercle.Rayon);

        }

        [Fact]
        public void Geometrie_BLL_Cercle_CalculerPerimetre()
        {
            //Arrange
            int id = 1;
            Point centre = new Point(1, 2);
            double rayon = 3;
            Cercle cercle = new Cercle(id, centre, rayon);

            //Act
            double perimetre = cercle.CalculerPerimetre();

            //Assert
            Assert.Equal(2 * Math.PI * rayon, perimetre);
        }

        [Fact]
        public void Geometrie_BLL_Cercle_CalculerAire()
        {
            //Arrange
            int id = 1;
            Point centre = new Point(1, 2);
            double rayon = 3;
            Cercle cercle = new Cercle(id, centre, rayon);

            //Act
            double aire = cercle.CalculerAire();

            //Assert
            Assert.Equal(Math.PI * Math.Pow(rayon, 2), aire);
        }


    }
}
