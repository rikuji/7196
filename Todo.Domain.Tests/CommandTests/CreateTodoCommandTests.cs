using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommad = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommad = new CreateTodoCommand("Lavar a louça", "Lucas Valenzuela", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _invalidCommad.Validate();
            _validCommad.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommad.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommad.Valid, true);
        }
    }
}
