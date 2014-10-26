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
  }
}
