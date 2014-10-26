using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ListaNumeros;

namespace ListaNumerosTests
{
  [TestFixture]
  public class ListaNumerosTests
  {
    [Test]
    public void ShouldExceptionWhenNumbersAreLessOrEqualZero() {
      var exception = Assert.Throws<ArgumentException>(() => ListaNumeros.ListaNumeros.Juego(-1, 0));
      Assert.That(exception, Has.Message.EqualTo("Números menores o iguales que cero no permitidos"));
    }
    [Test]
    public void ShouldExceptionWhenNumber1GreatNumber2() {
      var exception = Assert.Throws<ArgumentException>(() => ListaNumeros.ListaNumeros.Juego(2, 1));
      Assert.That(exception, Has.Message.EqualTo("Numero1 mayor que Numero2 no permitido"));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_1_Return2() {
      Assert.AreEqual(new List<int> { 2 }, ListaNumeros.ListaNumeros.Juego(1, 1));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_2_Return2()
    {
      Assert.AreEqual(new List<int> { 2 }, ListaNumeros.ListaNumeros.Juego(1, 2));
    }
  }
}
