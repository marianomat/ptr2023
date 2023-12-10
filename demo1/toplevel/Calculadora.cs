
namespace toplevel;

public class Calculadora
{
  public int Factorial(int n)
  {
    if (n < 0)
      return -1;

    if (n == 1 || n == 0)
      return 1;
    else
    {
      return n * Factorial(n - 1);
    }
  }

  public double RaizCuadrada(int n)
  {
    return Math.Sqrt(n);
  }

  public double Cuadrado(int n)
  {
    return Math.Pow(n, 2);
  }

  public double LogBase10(int n)
  {
    return Math.Log10(n);
  }

  public double LogNatural(int n)
  {
    return Math.Log(n);
  }

  public double Exponencial(int n)
  {
    return Math.Exp(n);
  }




}
