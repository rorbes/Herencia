using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba_19_03_2015
{
    abstract class figura : IFigura
    {
        protected double area;
        protected double volumen;
        protected String texto;

        abstract public void calcularArea();
        abstract public void calcularVolumen();
        abstract public void pintar();

        public void cambiarTexto(String txt)
        {
            texto = txt;
        }
    }

}