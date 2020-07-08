using APIExample.Core.Repositories;
using NUnit.Framework;

namespace APIExample.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // agora sim recuperamos os dados de uma camada compartilhada, que pode ser testada individualmente.
            var clientes = ClienteRepository.ListAll();
            Assert.IsTrue(clientes != null);
            Assert.Pass("Não são retornados dados nulos da busca de clientes.");
        }
    }
}