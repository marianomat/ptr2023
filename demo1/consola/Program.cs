//  using mensajes;

using toplevel;

namespace demo1;

internal class Program
{
  int campo;  //  esto no es una variable, es un campo de la clase

  static void Main(string[] args)
  {
    string x;

    System.Int32 xx = -1;

    int xxx = xx;
    Console.WriteLine(Mensaje.ObtenerMensaje());

    // Tarea 01

    Calculadora calculadora = new Calculadora();
    Console.WriteLine(calculadora.Factorial(10));


    /* Namespace: unión lógica de clases, permite que las clases convivan dentro de un grupo conceptual
     * Assembly: código que es ejecutado por el net runtime, cada assembly representa un proyecto */



  }
}