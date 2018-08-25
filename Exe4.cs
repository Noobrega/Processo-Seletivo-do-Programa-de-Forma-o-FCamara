using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe4
    {
        private double Metros;
        private double ValLata = 80;

        public Exe4(double _metros)
        {
            Metros = _metros;
        }

        public int getLitros()
        {
            double litros = Metros / 3;
            return (int)Math.Round(Math.Abs(litros) + ((litros%3!=0)?+1:+0));
        }

        public int getLatas()
        {
            double latas = getLitros() / 18;
            return (int)Math.Round(Math.Abs(latas) + ((getLitros() % 18 != 0) ? +1 : +0));
        }

        public double getValor()
        {
            return getLatas() * ValLata;
        }
    }
}
