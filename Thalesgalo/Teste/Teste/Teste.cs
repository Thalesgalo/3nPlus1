using Biblioteca;
using Xunit;
using FluentAssertions;
using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;
using Xunit.Sdk;

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
        [InlineData(100, 171, 125)]
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

        [Theory]
        [InlineData(0)]
        [InlineData(-22)]
        public void VerificaNumeroZeroENegativo(int n)
        {
            //Arrange
            var resposta = 0;

            //Acts
            Action act = () => resposta = Calculos.NumeroDeCiclos(n);

            //Assert
            act.Should()
              .Throw<ArgumentException>()
              .WithMessage("Não pode ser numeros negativos");
        }
        
    }


}