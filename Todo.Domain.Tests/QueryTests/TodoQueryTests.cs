using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;


namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", "outrousuario", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 2", "outrousuario", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 3", "lucasvalenzuela", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 4", "outrousuario", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 5", "lucasvalenzuela", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_lucasvalenzuel()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("lucasvalenzuela")).ToList();
            Assert.AreEqual(2, result.Count());
        }
    }
}
