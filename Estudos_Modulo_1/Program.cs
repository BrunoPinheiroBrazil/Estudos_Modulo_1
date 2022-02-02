using Estudos_Modulo_1.Services;

namespace Estudos_Modulo_1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IEstudoModulo1Services _services = new EstudoModulo1Services();
      Console.WriteLine($"Soma de 2+2 é {_services.Soma2Mais2()}");
      Console.WriteLine($"A raiz quadrada de 81 é {_services.RaizQuadrada(81)}");
    }
  }
}