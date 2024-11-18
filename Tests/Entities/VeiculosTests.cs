using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Entities;
using Aplication.UseCase;

namespace Tests.Entities
{
    [TestClass]
    public class VeiculosTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenPlacaVeiculoIsInvalid()
        {
            var placa = new Veiculos("123");
            Assert.IsTrue(placa.Invalid);
        }
        [TestMethod]
        public void ShouldReturnErrorWhenPlacaVeiculoIsValid()
        {
            var placa = new Veiculos("JIY3754");
            Assert.IsTrue(placa.Valid);
        }
    }
}
