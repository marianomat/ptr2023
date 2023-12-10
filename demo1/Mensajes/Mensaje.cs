
namespace demo1;

public class Mensaje
{
  public static string ObtenerMensaje()
  {
    string resultado = "Hola, Mundo!!";
    int x = 1234;
    DateTime fecha = new(1810, 5, 25);

    Console.WriteLine($"{fecha}");
    return resultado;
  }
}