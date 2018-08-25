using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FCamara_Proc_Seletivo
{
    class Program
    {
        static void Exercicio2()
        {
            string escolha;
            Console.WriteLine(@"Deseja digitar os números inicial e final?(S\N)");
            escolha = Console.ReadLine().ToUpper();
            Exe2 exe2;
            if(escolha != "S")
                exe2 = new Exe2("1 100000");
            else
            {
                Console.WriteLine("Digite o numero de inicio e final separados apenas com um espaço");
                Console.WriteLine("Exemplo 1 13");
                try
                {
                    escolha = Console.ReadLine();
                    exe2 = new Exe2(escolha);
                }
                catch
                {
                    Console.WriteLine("Digite apenas números");
                    Console.ReadKey();

                }
            }
        }

        static void Exercicio3()
        {
            try
            {
                int horas;
                Console.WriteLine("Digite o número de horas trabalhadas");
                horas = int.Parse(Console.ReadLine());
                double Minimo;
                Console.WriteLine("Digite o salário minimo");
                Minimo = int.Parse(Console.ReadLine());
                Exe3 exe3 = new Exe3(horas, Minimo);
                Console.WriteLine("Valor da Hora: " + exe3.getValorHora());
                Console.WriteLine("Salário Bruto: " + exe3.getBruto());
                Console.WriteLine("Imposto: " + exe3.getImposto());
                Console.WriteLine("Salário Liquido: " + exe3.getSalario());
            }
            catch
            {
                Console.WriteLine("Digite apenas números");
                Console.ReadKey();

            }
        }

        static void Exercicio4()
        {
            try
            {
                int metros;
                Console.WriteLine("tamanho em metros quadrados da área a ser pintada");
                metros = int.Parse(Console.ReadLine());
                Exe4 exe4 = new Exe4(metros);
                Console.WriteLine("Litros: " + exe4.getLitros());
                Console.WriteLine("Latas: " + exe4.getLatas());
                Console.WriteLine("Valor Total: R$" + exe4.getValor());
            }
            catch
            {
                Console.WriteLine("Digite apenas números");
                Console.ReadKey();
            }
        }

        static void Exercicio5()
        {
            int cc;
            Console.WriteLine("Digite o número da conta corrente ");
            cc = int.Parse(Console.ReadLine());
            string nome;
            Console.WriteLine("Digite o nome do correntista ");
            nome = Console.ReadLine();
            string escolha;
            Console.WriteLine(@"Deseja inserir saldo?(S\N)");
            escolha = Console.ReadLine().ToUpper();
            Exe5 exe5;
            if (escolha == "S")
            {
                double valor;
                Console.WriteLine("Digite o saldo inicial ");
                valor = double.Parse(Console.ReadLine());
                exe5 = new Exe5(cc,nome,valor);
            }
            else
                exe5 = new Exe5(cc,nome);
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Exercicio 5");
                Console.WriteLine("(1) - Número da conta");
                Console.WriteLine("(2) - Saldo");
                Console.WriteLine("(3) - Deposito");
                Console.WriteLine("(4) - Saque");
                Console.WriteLine("(5) - Alterar nome");
                Console.WriteLine("(6) - Para SAIR");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números");
                    Console.ReadKey();
                    op = 0;
                }
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(exe5.getNome());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("R$" + exe5.getSaldo().ToString("f2"));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        double dep;
                        Console.WriteLine("Digite o valor do deposito ");
                        dep = double.Parse(Console.ReadLine());
                        exe5.Deposito(dep);
                        Console.WriteLine("Saldo atual R$" + exe5.getSaldo().ToString("f2"));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        double saq;                       
                        Console.WriteLine("Digite o valor do saque ");
                        saq = double.Parse(Console.ReadLine());
                        exe5.Saque(saq);
                        Console.WriteLine("Saldo atual R$" + exe5.getSaldo().ToString("f2"));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite o novo Nome ");
                        nome = Console.ReadLine();
                        exe5.AlteraNome(nome);
                        Console.WriteLine("Nome atual " + exe5.getNome());
                        Console.ReadKey();
                        break;
                }
            } while (op != 6);
        }

        static void Exercicio6(Exe6 exe6, string palavra)
        {
            Console.Clear();
            double ladoA, ladoB;
            Console.WriteLine("Digite o valor do Comprimento " + palavra + " em centimetro");
            try
            {
                ladoA = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor do Largura " + palavra + " em centimetro");
                try
                {
                    ladoB = double.Parse(Console.ReadLine());
                    exe6.setLados(ladoA, ladoB);
                    int op;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(" Menu do " + palavra);
                        Console.WriteLine("(1) - Mudar o valor dos Lados");
                        Console.WriteLine("(2) - Retorna o valor dos Lados");
                        Console.WriteLine("(3) - Retorna Área");
                        Console.WriteLine("(4) - Retorna Perímetro");
                        Console.WriteLine("(5) - Próximo");
                        try
                        {
                            op = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Digite apenas números");
                            Console.ReadKey();
                            op = 0;
                        }
                        switch (op)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Digite o valor do Comprimento " + palavra + " em centimetro");
                                ladoA = double.Parse(Console.ReadLine());
                                Console.WriteLine("Digite o valor do Largura " + palavra + " em centimetro");
                                ladoB = double.Parse(Console.ReadLine());
                                exe6.setLados(ladoA, ladoB);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Comprimento " + exe6.getComprimento() + " cm");
                                Console.WriteLine("Largura " + exe6.getLargura() + " cm");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Área " + exe6.getArea() + "cm²");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Perímetro " + exe6.getPerimetro() + "cm");
                                Console.ReadKey();
                                break;
                        }

                    } while (op != 5);
                }
                catch
                {
                    Console.WriteLine("Digite apenas números");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Digite apenas números");
                Console.ReadKey();

            }
        }

        static void Exercicio62(Exe6 Piso, Exe6 Local)
        {
            Console.Clear();
            double qtdPisos = Local.getArea() / Piso.getArea();
            int Pisototal = (int)Math.Round(Math.Abs(qtdPisos) + ((qtdPisos % 1 != 0) ? +1 : +0));
            double pebase = Local.getPerimetro() * 10;
            double rodape = pebase / Piso.getArea();
            int rodapeinteira = (int)Math.Round(Math.Abs(rodape) + ((rodape % 1 != 0) ? +1 : +0));
            Console.WriteLine("Quantidade de Pisos para o chão é de " + Pisototal + " unidades");
            Console.WriteLine("Quantidade de Pisos para o rodapé é de " + rodapeinteira + " unidades");
            Console.WriteLine("Quantidade de Pisos totais é de " + (Pisototal + rodapeinteira) + " unidades");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int escolha;
            do
            {
                Console.Clear();
                Console.WriteLine(" Menu Principal");
                Console.WriteLine("(1) - Exercicio 1");
                Console.WriteLine("(2) - Exercicio 2");
                Console.WriteLine("(3) - Exercicio 3");
                Console.WriteLine("(4) - Exercicio 4");
                Console.WriteLine("(5) - Exercicio 5");
                Console.WriteLine("(6) - Exercicio 6");
                Console.WriteLine("(7) - Para SAIR");
                try
                {
                    escolha = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números");
                    Console.ReadKey();
                    escolha = 0;

                }
                switch (escolha)
                {
                    case 1: // Exercicio 1
                        Console.Clear();
                        Exe1 exe1 = new Exe1(2005, 1000, 1.5);
                        Console.WriteLine(exe1.getSalario());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Exercicio2();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Exercicio3();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Exercicio4();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Exercicio5();
                        break;
                    case 6:
                        Console.Clear();
                        Exe6 piso = new Exe6();
                        Exercicio6(piso, "Piso");
                        Exe6 local = new Exe6();
                        Exercicio6(local, "Local");
                        Exercicio62(piso, local);
                        break;
                }

            } while (escolha != 7);
        }
    }
}
