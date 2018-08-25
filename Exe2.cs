using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    public class Exe2
    {
        private int Inicio;
        private int Final;

        public Exe2(string tudo)
        {

            try
            {
                if (tudo.IndexOf(' ') > 0)
                {
                    Console.WriteLine("Valor Inicial: " + tudo.Substring(0, tudo.IndexOf(' ')));
                    Console.WriteLine("Final: " + tudo.Substring((1 + tudo.IndexOf(' ')), tudo.Length - (tudo.IndexOf(' ') + 1)));
                    Console.ReadKey();
                    Inicio = int.Parse(tudo.Substring(0, tudo.IndexOf(' ')));
                    Final = int.Parse(tudo.Substring((1 + tudo.IndexOf(' ')), tudo.Length - (tudo.IndexOf(' ') + 1)));
                    if(Inicio < Final)
                        Primos();
                    else
                        Console.WriteLine("O valor Inicial deve ser obrigatoriamente menor que o Final");
                }
                else
                    Console.WriteLine("Digite 2 números separando-os por espaço.");
            }
            catch { Console.WriteLine("Digite apenas números separando-os por um espaço."); }
        }
    
        public string Primos()
        {
            for (int i = Inicio; i <= Final; i++)
            {
                if (isPrimo(i))
                {
                    Console.Write(i + " ");
                }
            }
            return "Fim.";
        }

        public static bool isPrimo(int x)
        {
            if (x == 1) return true;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}