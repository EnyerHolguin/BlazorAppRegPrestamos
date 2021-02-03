using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorAppRegPrestamos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAppRegPrestamos.DAL;
using BlazorAppRegPrestamos.Models;

namespace BlazorAppRegPrestamos.BLL.Tests
{
    [TestClass()]
    public class PersonaBLLTests
    {
                  
    
            [TestInitialize]
          
            [TestMethod()]
            public void PersonasBLLTest()
            {
                Assert.Fail();
            }
       
        [TestMethod()]
        public void GuardarTest()
        {
            bool ok = false;
            Personas personas = new Personas()
            {
                PersonaId = 1,
                Nombres = "Enyer ",
                FechaNacimiento = DateTime.Now,
                Direccion = "Barrio Puerto Rico",
                Telefono = "000-000-0000",
                Balance = 0
            };

            
            Assert.IsTrue(ok);

          
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool ok = false;
           

            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Personas personas;
            bool ok = false;

            

            Assert.IsTrue(ok);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPersonasTest()
        {
            Assert.Fail();
        }

        public void GetPersonasTest1()
        {

        }
    }
}