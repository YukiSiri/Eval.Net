using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrie.BLL;
using Geometrie.BLL.Depots;
using Geometrie.DTO;
using Moq;

namespace Geometrie.Service.Tests
{
    //Fais moi les tests unitaires pour la couche service
    public class Cercle_Service_Tests
    {
        [Fact]
        public void CalculerPerimetre_Cercle()
        {
            //Fais des mock
            //Arrange
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };
            var cercleService = new Cercle_Service(depots.Object);

            //Act
            var perimetre = cercleService.calculerPerimetre(cercle);
            Assert.NotNull(perimetre);
            Assert.Equal(31.42, perimetre, 2);

        }
        [Fact]
        public void CalculerAire_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            var cercleService = new Cercle_Service(depots.Object);

            var aire = cercleService.calculerAire(cercle);
            Assert.NotNull(aire);
            Assert.Equal(78.54, aire, 2);
        }

        [Fact]
        public void Add_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.Add(cercle)).Returns(cercle);

            var cercleService = new Cercle_Service(depots.Object);

            var cercleAjoute = cercleService.Add(cercle);
            Assert.NotNull(cercleAjoute);
            Assert.Equal(cercle, cercleAjoute);
        }

        [Fact]
        public void Delete_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.Delete(cercle)).Returns(depots.Object);

            var cercleService = new Cercle_Service(depots.Object);

            var cercleSupprime = cercleService.Delete(cercle);
            Assert.NotNull(cercleSupprime);
            Assert.Equal(depots.Object, cercleSupprime);
        }

        [Fact]
        public void DeleteById_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.Delete(cercle)).Returns(depots.Object);

            var cercleService = new Cercle_Service(depots.Object);

            var cercleSupprime = cercleService.Delete(cercle);
            Assert.NotNull(cercleSupprime);
            Assert.Equal(depots.Object, cercleSupprime);
        }

        [Fact]
        public void GetAll_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.GetAll()).Returns(new List<Cercle_DTO> { cercle });

            var cercleService = new Cercle_Service(depots.Object);

            var cercles = cercleService.GetAll();
            Assert.NotNull(cercles);
            Assert.NotEmpty(cercles);

            Assert.Contains(cercles, c => c.Centre.X == 0 && c.Centre.Y == 0 && c.Rayon == 5);

        }

        [Fact]
        public void GetById_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.GetById(1)).Returns(cercle);

            var cercleService = new Cercle_Service(depots.Object);

            var cercleRecupere = cercleService.GetById(1);
            Assert.NotNull(cercleRecupere);
            Assert.Equal(cercle, cercleRecupere);
        }

        [Fact]
        public void Update_Cercle()
        {
            var depots = new Mock<IDepot<Cercle_DTO>>();

            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };

            depots.Setup(d => d.Update(cercle)).Returns(cercle);

            var cercleService = new Cercle_Service(depots.Object);

            var cercleModifie = cercleService.Update(cercle);
            Assert.NotNull(cercleModifie);
            Assert.Equal(cercle, cercleModifie);
        }

    }

}
