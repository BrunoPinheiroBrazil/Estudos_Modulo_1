namespace Estudos_Modulo_1.Services
{
  public interface IEstudoModulo1Services
  {
    int Soma2Mais2();
    double RaizQuadrada(int valor);
    int MultiplicaPorDez(int valor);
    int DividePorDois(int valor);
    string RetornaShrek();
    string RetornaInicialEFinal(string palavraInteira);
    string RetornaPosicao4DaStringPassada(string palavraInteira);
    string BuscaPosicaoQuatro(IEnumerable<string> listaDeTios);
    int ContaLista(List<string> listaDeTios);
    string BuscaTioPosicaoPersonalizada(List<string> listaDeTios, int posicao);
  }
  public class EstudoModulo1Services : IEstudoModulo1Services
  {
    #region Exercicios
    public int DividePorDois(int valor)
    {
      return 0;
    }

    public int MultiplicaPorDez(int valor)
    {
      return 0;
    }

    public string RetornaShrek()
    {
      return "";
    }

    #endregion

    #region Exemplos
    public double RaizQuadrada(int valor)
    {
      var raizQuadrada = Math.Sqrt(valor);
      return raizQuadrada;
    }

    public int Soma2Mais2()
    {
      var soma = 2 + 2;
      return soma;
    }

    public string RetornaInicialEFinal(string palavraInteira)
    {
      throw new NotImplementedException();
    }

    public string RetornaPosicao4DaStringPassada(string palavraInteira)
    {
      throw new NotImplementedException();
    }

    public string BuscaPosicaoQuatro(IEnumerable<string> listaDeTios)
    {
      throw new NotImplementedException();
    }

    public int ContaLista(List<string> listaDeTios)
    {
      throw new NotImplementedException();
    }

    public string BuscaTioPosicaoPersonalizada(List<string> listaDeTios, int posicao)
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}