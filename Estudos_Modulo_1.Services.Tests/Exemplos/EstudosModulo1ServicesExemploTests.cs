using Xunit;

namespace Estudos_Modulo_1.Services.Tests.Exemplos
{
  public class EstudosModulo1ServicesExemploTests
  {
    private readonly IEstudoModulo1Services _services;

    public EstudosModulo1ServicesExemploTests()
    {
      _services = new EstudoModulo1Services();
    }

    [Fact(DisplayName = "Teste método exemplo 1 [Sucesso] - Calcula 2 + 2")]
    public void Calcula_2_Mais_2_Sucesso()
    {
      //Arrange
      var valorEsperado = 4;

      //Act
      var resultadoObtido = _services.Soma2Mais2();

      //Assert
      Assert.Equal(valorEsperado, resultadoObtido);
    }

    [Fact(DisplayName = "Teste método exemplo 2 [Sucesso] - Raiz Quadrada de 81")]
    public void RaizQuadradaDe81()
    {
      //Arrange
      var valorEsperado = 9;

      //Act
      var resultadoObtido = _services.RaizQuadrada(81);

      //Assert
      Assert.Equal(valorEsperado, resultadoObtido);
    }
  }
}