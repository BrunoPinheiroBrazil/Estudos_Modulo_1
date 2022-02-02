using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Estudos_Modulo_1.Services.Tests
{
  public class EstudosModulo1ServicesExerciciosTests
  {
    private readonly IEstudoModulo1Services _services;

    public EstudosModulo1ServicesExerciciosTests()
    {
      _services = new EstudoModulo1Services();
    }

    [Fact(DisplayName = "Teste método exercício 1 [Sucesso] - Pega o número passado por parâmetro e multiplica por 10")]
    public void Multiplica_Por_10_Sucesso()
    {
      //Arrange
      var valorEsperado = 40;

      //Act
      var resultadoObtido = _services.MultiplicaPorDez(4);

      //Assert
      Assert.Equal(valorEsperado, resultadoObtido);
    }

    [Fact(DisplayName = "Teste método exercício 1 [Sucesso] - Pega o número passado por parâmetro e divide por 2")]
    public void Divide_Por_2_Sucesso()
    {
      //Arrange
      var valorEsperado = 20;

      //Act
      var resultadoObtido = _services.DividePorDois(40);

      //Assert
      Assert.Equal(valorEsperado, resultadoObtido);
    }

    [Fact(DisplayName = "Teste método exercício 1 [Sucesso] - O metodo deve retornar uma string que contenha pelo menos Shrek escrito uma vez")]
    public void Retorna_O_Nome_Shrek()
    {
      //Arrange
      var valorEsperado = "Shrek";

      //Act
      var resultadoObtido = _services.RetornaShrek();

      //Assert
      Assert.Contains(valorEsperado, resultadoObtido);
    }
  }
}
