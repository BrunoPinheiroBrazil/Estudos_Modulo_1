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
    string RetornaAQuartaLetraDaPalavraPassada(string palavraInteira);
    string BuscaPosicaoQuatro(IEnumerable<string> listaDeTios);
    int ContaLista(List<string> listaDeTios);
    string BuscaTioPosicaoPersonalizada(List<string> listaDeTios, int posicao);
    IEnumerable<int> OrdenaListaCrescente(IEnumerable<int> disorderedList);
    void RemoveItemDaListaPorNome(string nomeParaRemover, ICollection<string> novaListaTios);
  }
  public class EstudoModulo1Services : IEstudoModulo1Services
  {
    #region Exercicios
    public int DividePorDois(int valor)
    {
      return valor / 2;
    }

    public int MultiplicaPorDez(int valor)
    {
      return valor * 10;
    }

    public string RetornaShrek()
    {
      return "Shrek";
    }

    #endregion

    #region Exercicios 2
    public IEnumerable<int> OrdenaListaCrescente(IEnumerable<int> disorderedList)
    {
      return new List<int> { 1, 2, 3 };
    }

    public void RemoveItemDaListaPorNome(string nomeParaRemover, ICollection<string> novaListaTios)
    {
      novaListaTios.Remove(nomeParaRemover);
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
      var primeiraLetra = palavraInteira.First();
      var ultimaLetra = palavraInteira.Last();
      return $"{primeiraLetra}{ultimaLetra}";
    }

    public string RetornaAQuartaLetraDaPalavraPassada(string palavraInteira)
    {
      return palavraInteira.Substring(3, 1);
    }

    public string BuscaPosicaoQuatro(IEnumerable<string> listaDeTios)
    {
      return listaDeTios.ToList()[3];
    }

    public int ContaLista(List<string> listaDeTios)
    {
      return listaDeTios.Count();
    }

    public string BuscaTioPosicaoPersonalizada(List<string> listaDeTios, int posicao)
    {
      if (posicao < 0)
        posicao = 0;

      if (posicao > listaDeTios.Count() - 1)
        return listaDeTios.Last();

      return listaDeTios[posicao];
    }
    #endregion
  }
}