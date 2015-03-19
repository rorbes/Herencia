﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba_19_03_2015
{
    class esfera : figura
    {
        private double radio;
        private static double PI = 3.1416;

        public esfera(double radio)
        {
            this.radio = radio;
        }

        override public void calcularArea()
        {
            this.area = 4 * PI * radio * radio;
        }

        override public void calcularVolumen()
        {
            this.volumen = (4 / 3) * PI * radio * radio * radio;
        }
        override public void pintar()
        {

        }
    }
}
