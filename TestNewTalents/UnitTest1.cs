using System;
using Xunit;
using NewTalents2;

namespace TestNewTalents
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4,2,6)]
        [InlineData(3, 4, 7)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar( num1, num2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 3, 1)]
        public void TestSubtracao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtracao(num1, num2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(4, 3, 12)]
        public void TestMultiplicacao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicacao(num1, num2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(12, 3, 4)]
        public void TestDivisao(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Divisao(num1, num2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Divisao(3, 0));
        }
    }
}
