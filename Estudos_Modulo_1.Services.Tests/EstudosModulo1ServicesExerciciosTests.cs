using System.Collections.Generic;
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

    [Fact(DisplayName = "Teste Método Exercicio 1 [Sucesso] - O metodo deve retornar a primeira e a última letra da string que foi passada")]
    public void Retorna_Inicial_E_Final()
    {
      //Arrange 
      var palavraInteira = "GILMAR";

      //Act
      var inicialEFinal = _services.RetornaInicialEFinal(palavraInteira);

      //Assert
      Assert.Equal("GR", inicialEFinal);
    }

    [Fact(DisplayName = "Teste Método Exercicio 1 [Sucesso] - O metodo deve retornar a quarta letra da palavra que foi passada")]
    public void Retorna_Posicao_4_Da_String_Passada()
    {
      //Arrange 
      var palavraInteira = "TIANENA";

      //Act
      var letraPosicaoObtida = _services.RetornaAQuartaLetraDaPalavraPassada(palavraInteira);

      //Assert
      Assert.Equal("N", letraPosicaoObtida);
    }

    [Fact(DisplayName = "Teste Método Exercicio 1 [Sucesso] - Retornar o quarto item da lista passada e quantos itens existem na lista")]
    public void Retorna_O_Quarto_Item_Da_Lista()
    {
      //Arrange 
      var listaDeTios = new List<string>
      {
        "TIO JORGE",
        "TIA LUCIVANIA",
        "TIO LACO",
        "TIO GILMAR",
        "TIA ANGELA",
        "TIA NENA"
      };

      //Act
      var tioNumero4 = _services.BuscaPosicaoQuatro(listaDeTios);
      var tamanho = _services.ContaLista(listaDeTios);

      //Assert
      Assert.Equal("TIO GILMAR", tioNumero4);
      Assert.Equal(6, tamanho);
    }


    [InlineData(1, "TIA LUCIVANIA")]
    [InlineData(4, "TIA ANGELA")]
    [InlineData(5, "TIA NENA")]
    [InlineData(2, "TIO LACO")]
    [InlineData(0, "TIO JORGE")]
    [InlineData(10, "TIO DIRCEU")]
    [InlineData(11, "TIO DIRCEU")]
    [InlineData(8, "TIA TERA")]
    [InlineData(-1, "TIO JORGE")]
    [Theory(DisplayName = "Teste Método Exercício 1 [Sucesso] - Retornar a posição pedida por parametro para " +
      "o metodo e se a posição pedida for maior que o tamanho, retornar o último item da lista " +
      "e se for menor traz o primeiro item da lista")]
    public void Retorna_Posicao_Solicitada_Lista(int posicao, string tioEsperado)
    {
      //Arrange
      var listaDeTios = new List<string>
      {
        "TIO JORGE",
        "TIA LUCIVANIA",
        "TIO LACO",
        "TIO GILMAR",
        "TIA ANGELA",
        "TIA NENA",
        "TIA JOCIVANIA",
        "TIO JONES",
        "TIA TERA",
        "TIO DIRCEU"
      };

      //Act
      var tioEncontrado = _services.BuscaTioPosicaoPersonalizada(listaDeTios, posicao);

      //Assert
      Assert.Equal(tioEsperado, tioEncontrado);
    }

    [MemberData(nameof(OrdemCrescenteData))]
    [Theory(DisplayName = "Teste Método Exercicio 2 [Sucesso] - O metodo deve ordenar a lista passada em ordem crescente")]
    public void Retorna_Lista_Ordem_Crescente(IEnumerable<int> disorderedList, IEnumerable<int> expectedOrdenedList)
    {
      //Arrange
      //Act
      var currentOrderedList = _services.OrdenaListaCrescente(disorderedList);

      //Assert
      Assert.Equal(currentOrderedList, expectedOrdenedList);
    }

    [InlineData("NENA")]
    [InlineData("GILMAR")]
    [InlineData("LUCIVANIA")]
    [InlineData("JORGE")]
    [Theory(DisplayName = "Teste Método Exercicios 2 [Sucesso] - O metodo deve remover o item da lista pela palavra passada por parâmetro")]
    public void Remove_Item_Da_Lista_Pelo_Nome(string nomeParaRemover)
    {
      //Arrange
      var novaListaTios = new List<string>
      {
        "GEU",
        "ANGELA",
        "GILMAR",
        "TERA",
        "JOCIVANIA",
        "LUCIVANIA",
        "NENA",
        "ICA",
        "JORGE"
      };

      //Act
      _services.RemoveItemDaListaPorNome(nomeParaRemover, novaListaTios);

      //Assert
      Assert.Equal(8, novaListaTios.Count);
      Assert.Null(novaListaTios.Find(n => n == nomeParaRemover));
    }

    public static IEnumerable<object[]> OrdemCrescenteData()
    {
      yield return new object[] { new List<int> { 3, 2, 1 }, new List<int> { 1, 2, 3 } };
      yield return new object[] { new List<int> { 5, 4, 3, 2, 1 }, new List<int> { 1, 2, 3, 4, 5 } };
      yield return new object[] { new List<int> { 3, 2, 5, 4, 1 }, new List<int> { 1, 2, 3, 4, 5 } };
      yield return new object[] { new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
      yield return new object[] { new List<int> { 5, 2, 3, 1, 8, 10, 7, 4, 6, 9 }, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
    }
  }
}
