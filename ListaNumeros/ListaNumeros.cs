﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaNumeros
{
  public class ListaNumeros
  {
    public static List<int> Juego(int numero1, int numero2)
    {
      if (numero1 <= 0 || numero2 <= 0)
        throw new ArgumentException("Números menores o iguales que cero no permitidos");
      if (numero1 > numero2) 
      throw new ArgumentException("Numero1 mayor que Numero2 no permitido");
      return new List<int> {2};
    }
  }
}
