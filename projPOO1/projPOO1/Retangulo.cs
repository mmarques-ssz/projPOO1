using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO1
{
    class Retangulo
    {
        private int b;
        private int h;
        private int a;

        // Métodos de Interface (setters & getters)

        public void setBase(int p)
        {
            b = p;
        }

        public void setAltura(int p)
        {
            h = p;
        }

        public int getBase()
        {
            return b;
        }

        public int getAltura()
        {
            return h;
        }

        public int getArea()
        {
            return a;
        }

        public void calcularArea()
        {
            a = b * h;
        }
    }
}
