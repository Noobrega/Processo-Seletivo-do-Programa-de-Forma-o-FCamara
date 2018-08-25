using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe3
    {
        private int Horas;
        private double SalarioMin;
        const double tximposto = 0.03;

        public Exe3(int _Horas, double _SalarioMin)
        {
            Horas = _Horas;
            SalarioMin = _SalarioMin;
        }

        public double getValorHora()
        {
            return SalarioMin * 0.1;
        }

        public double getBruto()
        {
            return Horas * getValorHora();
        }

        public double getImposto()
        {
            return tximposto * getBruto();
        }

        public double getSalario()
        {
            return getBruto() - getImposto();
        }
    }
}
