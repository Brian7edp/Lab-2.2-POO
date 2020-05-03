using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Circulo
    {
        private int m_radio;

        public int Radio
        {
            get { return m_radio; }
            set { m_radio = value;}
        }

        public double CalcularPerimetro()
        {
            double p = Math.PI * (2 * Radio);
            return p;
        }

        public double CalcularSuperficie()
        {
            double a = Math.PI * Math.Pow(Radio, 2);
            return a;
        }
    }
}
