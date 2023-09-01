using Biblioteca;
using Xunit;
using FluentAssertions;
using Microsoft.VisualBasic;

namespace Teste
{
    public class Teste
    {
        [Fact]
        public void VinteEDois()
        {
            //Arrange
            var Valor = 22;
            var resposta = 0;

            //Act
            resposta = Calculos.NumeroDeCiclos(Valor);

            //Assert
            resposta.Should().Be(16);
        }
        
        [Theory]
        [InlineData(1, 10, 20)]
        [InlineData(100, 200, 125)]
        [InlineData(201, 210, 89)]
        [InlineData(900, 1000, 174)]
        public void VerificaNumerosDeSaida(int start, int end, int respostaEsperada)
        {
            //Act
            var resposta = Calculos.CalculoDeSaida(start, end);

            //Assert
            resposta.Should().Be(respostaEsperada);
        }
        public void zero()
        {
            //Arrange
            var Valor = 1;
            var resposta = 0;

            //Act
            resposta = Calculos.NumeroDeCiclos(Valor);

            //Assert
            resposta.Should().Be(1);
        }
    }


}