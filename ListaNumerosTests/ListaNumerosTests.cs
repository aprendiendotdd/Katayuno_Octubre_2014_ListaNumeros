using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ListaNumerosTests
{
  [TestFixture]
  public class ListaNumerosTests
  {
    [Test]
    public void ShouldExceptionWhenNumbersAreLessOrEqualZero() {
      var exception = Assert.Throws<ArgumentException>(() => ListaNumeros.ListaNumeros.Game(-1, 0));
      Assert.That(exception, Has.Message.EqualTo("Números menores o iguales que cero no permitidos"));
    }
    [Test]
    public void ShouldExceptionWhenNumber1GreatNumber2() {
      var exception = Assert.Throws<ArgumentException>(() => ListaNumeros.ListaNumeros.Game(2, 1));
      Assert.That(exception, Has.Message.EqualTo("Numero1 mayor que Numero2 no permitido"));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_1_Return2() {
      Assert.AreEqual(new List<int> { 2 }, ListaNumeros.ListaNumeros.Game(1, 1));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_2_Return2()
    {
      Assert.AreEqual(new List<int> { 2 }, ListaNumeros.ListaNumeros.Game(1, 2));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_3_Return_2_6()
    {
      Assert.AreEqual(new List<int> { 2, 6 }, ListaNumeros.ListaNumeros.Game(1, 3));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_4_Return_2_6()
    {
      Assert.AreEqual(new List<int> { 2, 6 }, ListaNumeros.ListaNumeros.Game(1, 4));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_5_Return_2_6_10()
    {
      Assert.AreEqual(new List<int> { 2, 6, 10 }, ListaNumeros.ListaNumeros.Game(1, 5));
    }
    [Test]
    public void WhenNumber1_1_And_Number2_11_Return_2_6_10_14_18_22()
    {
      Assert.AreEqual(new List<int> { 2, 6, 10, 14, 18, 22 }, ListaNumeros.ListaNumeros.Game(1, 11));
    }
  }
}
