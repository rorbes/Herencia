using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba_19_03_2015
{
    public interface IFigura
    {
        void pintar();

        void calcularArea();

        void calcularVolumen();

        void cambiarTexto(String txt);
    }
}
