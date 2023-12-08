
namespace toplevel;

public class Calculadora
{
  public int Factorial(int n)
  {
    if (n == 1)
      return 1;
    else
    {
      return n * Factorial(n - 1);
    }
  }
}
