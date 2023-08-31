using Biblioteca;
using Xunit;
using FluentAssertions;

namespace Teste
{
    public class Teste
    {
        [Fact]
        public void ZeroNaoENarcisista()
        {
            //Arrange
            var Valor = 22;
            var resposta = 0;

            //Act
            resposta = Calculos.NumeroDeCiclos(Valor);

            //Assert
            resposta.Should().Be(16);
        }
    }
}