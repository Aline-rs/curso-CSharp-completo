using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace cSharp_Projeto.Sessao3.Exercicios_logica.Class.Métodos
{
    public class ExerciciosEstruturaCondicional
    {
        public string VerificarPositivoOuNegativo(int valor)
        {
            if (valor > 0)
            {
                return "NAO NEGATIVO";

            }
            else if (valor < 0)
            {
                return "NEGATIVO";
            }
            else
            {
                return "NAO NEGATIVO";
            }
        }

        public int LerInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);
            return int.Parse(Console.ReadLine());
        }

        public double LerDecimal(string mensagem)
        {
            Console.WriteLine(mensagem);

            return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void ExibirResultado(string mensagem, double resultado, string casasDecimais)
        {
            Console.Write(mensagem);
            Console.WriteLine(resultado.ToString(casasDecimais, CultureInfo.InvariantCulture));

        }

        public void ExibirResultado(string resultado)
        {
            Console.Write(resultado);
        }

        public string VerificarParOuImpar(int valor)
        {
            if (valor % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "IMPAR";
            }
        }

        public string VerificaNumeroMultiplo(int a, int b)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                return "Sao Multiplos";
            }
            else
            {
                return "Nao sao Multiplos";
            }
        }

        public string CalculaDuracaoJogo(int horaInicial, int horaFinal)
        {
            string[] valores = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(valores[0]);
            horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            return "O JOGO DUROU " + duracao + " HORA(S)";
        }

        public double CalcularValorTotalConta(int codigo, int quantidade)
        {
            switch (codigo)
            {
                case 1:
                    return quantidade * 4.00;
                case 2:
                    return quantidade * 4.50;
                case 3:
                    return quantidade * 5.00;
                case 4:
                    return quantidade * 2.00;
                case 5:
                    return quantidade * 1.50;
                default:
                    return 0.00;
            }
        }

        public string DescobrirIntervalo(double valor)
        {
            if (valor > 25 && valor <= 50)
            {
                return "Intervalo [25,50]";
            }
            if (valor >= 0 && valor <= 25)
            {
                return "Intervalo [0,25]";
            }
            if (valor >= 75 && valor <= 100)
            {
                return "Intervalo(75, 100]";
            }
            else
            {
                return "Fora do intervalo";
            }
        }

        public string EncontrarQuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return "Q1";
            }
            else if (x < 0 && y > 0)
            {
                return "Q2";
            }
            else if (x < 0 && y < 0)
            {
                return "Q3";
            }
            else if (x > 0 && y < 0)
            {
                return "Q4";
            }
            else
            {
                return "Origem";
            }
        }

        public double CalcularImposto(double salario)
        {
            if (salario <= 2000.0)
            {
                return 0.0;
            }
            else if (salario <= 3000.0)
            {
                return (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                return (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                return (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
        }
    }
}