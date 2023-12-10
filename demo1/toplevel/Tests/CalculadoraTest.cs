using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace toplevel;

[TestClass]
public class CalculadoraTests
{
  private Calculadora calculadora;

  [TestInitialize]
  public void Setup()
  {
    calculadora = new Calculadora();
  }

  [TestMethod]
  public void Factorial_CalculaFactorialDeCero()
  {

    int n = 0;
    int resultado = calculadora.Factorial(n);

    Assert.AreEqual(1, resultado);
  }

  [TestMethod]
  public void Factorial_CalculaFactorialDeDiez()
  {
    int n = 10;
    int resultado = calculadora.Factorial(n);

    Assert.AreEqual(3628800, resultado);
  }

  [TestMethod]
  public void Factorial_CalculaFactorialDeNumeroNegativo()
  {
    int n = -10;
    int resultado = calculadora.Factorial(n);

    Assert.AreEqual(-1, resultado);
  }

  [TestMethod]
  public void Factorial_CalculaFactorialDeUno()
  {
    int n = 1;

    int resultado = calculadora.Factorial(n);
    Assert.AreEqual(1, resultado);
  }

  [TestMethod]
  public void Factorial_CalculaFactorialDeCinco()
  {
    int n = 5;
    int resultado = calculadora.Factorial(n);

    Assert.AreEqual(120, resultado);
  }

  [TestMethod]
  public void RaizCuadrada_CalculaRaizCuadradaDeNueve()
  {
    int n = 9;
    double resultado = calculadora.RaizCuadrada(n);

    Assert.AreEqual(3, resultado);
  }

  [TestMethod]
  public void Cuadrado_CalculaCuadradoDeTres()
  {
    int n = 3;
    double resultado = calculadora.Cuadrado(n);

    Assert.AreEqual(9, resultado);
  }

  [TestMethod]
  public void LogBase10_CalculaLogBase10DeCien()
  {
    int n = 100;
    double resultado = calculadora.LogBase10(n);

    Assert.AreEqual(2, resultado);
  }

  [TestMethod]
  public void LogNatural_CalculaLogNaturalDeUno()
  {
    int n = 1;
    double resultado = calculadora.LogNatural(n);

    Assert.AreEqual(0, resultado);
  }

  [TestMethod]
  public void Exponencial_CalculaExponencialDeDos()
  {
    int n = 2;
    double resultado = calculadora.Exponencial(n);

    Assert.AreEqual(Math.Exp(2), resultado);
  }
}
