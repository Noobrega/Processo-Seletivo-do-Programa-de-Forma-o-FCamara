using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe1
    {
        private int AnoAtual;
        private int AnoInicio;
        private double Salario;
        private double Pct;

        public Exe1(int _AnoInicio, double _Salario, double _Pct)
        {
            AnoAtual = DateTime.Now.Year;
            AnoInicio = _AnoInicio;
            Salario = _Salario;
            Pct = _Pct;
        }

        public string getSalario()
        {
            if (AnoInicio <= AnoAtual)
            {
                Console.WriteLine("Salário de " + AnoInicio + " é de R$" + Salario.ToString("f2") + " aumento de aproximadamente " + Pct.ToString("f2") + "%");
                double bruto = Salario * (1 + Pct / 100);
                AnoInicio += 1;
                Salario = bruto;
                Pct *= 2;
                getSalario();
            }
            return "Fim.";
        }
    }
}