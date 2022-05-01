using cicd.services;
using Xunit;

namespace cicd.teste
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var resultado = new CalculadoraService().calcular(1, 1);

            Assert.Equal(2, resultado);
        }
    }
}