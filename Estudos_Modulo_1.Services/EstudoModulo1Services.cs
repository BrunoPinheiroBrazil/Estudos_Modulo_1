namespace Estudos_Modulo_1.Services
{
  public interface IEstudoModulo1Services
  {
    public int Soma2Mais2();
    public double RaizQuadrada(int valor);
    public int MultiplicaPorDez(int valor);
    public int DividePorDois(int valor);
    public string RetornaShrek();
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
    #endregion
  }
}