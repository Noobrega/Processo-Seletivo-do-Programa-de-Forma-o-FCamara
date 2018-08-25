using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe5
    {
        private int CC;
        private string Nome;
        private double Saldo;

        public Exe5(int _cc, string _nome)
        {
            CC = _cc;
            Nome = _nome;
            Saldo = 0;
        }

        public Exe5(int _cc, string _nome, double _saldo)
        {
            CC = _cc;
            Nome = _nome;
            Saldo = 0;
        }

        public void AlteraNome(string _nome)
        {
            Nome = _nome;
        }

        public void Deposito(double _valor)
        {
            Saldo += _valor;
        }

        public void Saque(double _valor)
        {
            Saldo -= _valor;
        }

        public double getSaldo()
        {
            return Saldo;
        }

        public double getCC()
        {
            return CC;
        }
        public string getNome()
        {
            return Nome;
        }

    }
}
