using System;
using Xunit;
using NewTalents2;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,2,6)]
        [InlineData(3, 7, 10)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar( num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(14, 3, 11)]
        public void TestSubtracao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtracao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 3, 12)]
        public void TestMultiplicacao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicacao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(12, 3, 4)]
        public void TestDivisao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Divisao(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Divisao(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();
            calc.Somar(1, 5);
            calc.Somar(3, 3);
            calc.Somar(4, 2);
            calc.Somar(6, 0);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
