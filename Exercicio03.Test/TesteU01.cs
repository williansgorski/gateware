using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio03.Test
{
    [TestClass]
    public class TesteU01
    {
        /// <summary>
        /// Exemplo básico de teste 
        /// </summary>
        [TestMethod]
        public void Test01()
        {
            Assert.IsTrue(Exercicio03.Execute.ExecuteMethod());

        }
    }
}
