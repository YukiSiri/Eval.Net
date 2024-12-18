using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrie.API.Controllers;
using Geometrie.DTO;
using Moq;


namespace Geometrie.API.Tests
{
    public class Cercle_Controller_Tests
    {
        [Fact]
        public void Cercle_Controller_Constructor()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            Assert.NotNull(controller);

        }

        [Fact]
        public void Cercle_Controller_Add()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };
            controller.Add(cercle);
            service.Verify(s => s.Add(cercle));
        }

        [Fact]
        public void Cercle_Controller_Delete()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };
            controller.Delete(cercle);
            service.Verify(s => s.Delete(cercle));
        }

        [Fact]
        public void Cercle_Controller_DeleteById()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            var id = 1;
            controller.Delete(id);
            service.Verify(s => s.Delete(id));
        }

        [Fact]
        public void Cercle_Controller_GetAll()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            controller.GetAll();
            service.Verify(s => s.GetAll());
        }

        [Fact]
        public void Cercle_Controller_GetById()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            var id = 1;
            controller.GetById(id);
            service.Verify(s => s.GetById(id));
        }

        [Fact]
        public void Cercle_Controller_Update()
        {
            var service = new Mock<ICercle_Service>();
            var controller = new Cercle_Controller(service.Object);
            var cercle = new Cercle_DTO
            {
                Centre = new Point_DTO { X = 0, Y = 0 },
                Rayon = 5
            };
            controller.Update(cercle);
            service.Verify(s => s.Update(cercle));
        }
    }
}
