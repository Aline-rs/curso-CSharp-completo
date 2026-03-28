using System.Globalization;

namespace cSharp_Projeto.Sessão_3.Exercicios_logica.Class
{
    public class EX
    {
        public void Ex1()
        {
            var exerciciosEstruturaSequencial = new ExerciciosEstruturaSequencial();

            int primeiroNumero = exerciciosEstruturaSequencial.LerInteiro("Digite o primeiro número: ");
            int segundoNumero = exerciciosEstruturaSequencial.LerInteiro("Digite o segundo número: ");

            int resultado = exerciciosEstruturaSequencial.Somar(primeiroNumero, segundoNumero);

            exerciciosEstruturaSequencial.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void Ex2()
        {
            var exerciciosEstruturaSequencial = new ExerciciosEstruturaSequencial();

            double raio = exerciciosEstruturaSequencial.LerDecimal("Digite o valor do raio: ");
            double area = (double)exerciciosEstruturaSequencial.CalcularAreaDoCirculo(raio);

            double resultado = area;

            exerciciosEstruturaSequencial.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX3()
        {
            var exerciciosEstruturaSequencial = new ExerciciosEstruturaSequencial();

            int a = exerciciosEstruturaSequencial.LerInteiro("Digite o valor de A: ");
            int b = exerciciosEstruturaSequencial.LerInteiro("Digite o valor de B: ");
            int c = exerciciosEstruturaSequencial.LerInteiro("Digite o valor de C: ");
            int d = exerciciosEstruturaSequencial.LerInteiro("Digite o valor de D: ");

            int resultado = exerciciosEstruturaSequencial.CalcularDiferenca(a, b, c, d);

            exerciciosEstruturaSequencial.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX4()
        {
            var exerciciosEstruturaSequencial = new ExerciciosEstruturaSequencial();

            int numeroFuncionario = exerciciosEstruturaSequencial.LerInteiro("Digite o número do funcionário: ");
            double horasTrabalhadas = exerciciosEstruturaSequencial.LerDecimal("Digite as horas trabalhadas: ");
            double valorHora = exerciciosEstruturaSequencial.LerDecimal("Digite o valor da hora: ");

            int resultado = (int)exerciciosEstruturaSequencial.CalcularSalarioHora(valorHora, horasTrabalhadas);
            exerciciosEstruturaSequencial.ExibirResultado(numeroFuncionario, resultado);
            Console.ReadLine();
        }
    }
}
