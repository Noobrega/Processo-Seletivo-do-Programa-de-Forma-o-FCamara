using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe6
    {
        private double Comprimento, Largura;

        public void setLados(double _comprimento, double _largura)
        {
            Comprimento = _comprimento;
            Largura = _largura;
        }

        public double getComprimento()
        {
            return Comprimento;
        }

        public double getLargura()
        {
            return Largura;
        }

        public double getArea()
        {
            return Comprimento * Largura;
        }

        public double getPerimetro()
        {
            return 2 * (Comprimento + Largura);
        }
    }
}
