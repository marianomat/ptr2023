
using toplevel;

Console.WriteLine("Ingresar un numero entero...");

string entrada = Console.ReadLine();

int n = Int32.Parse(entrada);

Calculadora miCalculadora = new ();

var resultado = miCalculadora.Factorial(n);

Console.WriteLine($"El valor de {n}! = {resultado:N0}");