using NUnit.Framework;
using Wijsheid.Domain;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarNomeNulo()
        {
            Aluno aluno = new Aluno();
            Assert.IsFalse(aluno.IsValid());
        }

        [Test]
        public void ValidarNomeVazio()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "";
            Assert.IsFalse(aluno.IsValid());
        }

        [Test]
        public void ValidarNomeComEspacoEmBranco()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = " ";
            Assert.IsFalse(aluno.IsValid());
        }

        [Test]
        public void TesteDeBuild()
        {
            Assert.Fail("ERRO");
        }
    }
}