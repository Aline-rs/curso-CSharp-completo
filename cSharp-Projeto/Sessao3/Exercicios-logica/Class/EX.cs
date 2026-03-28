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
    }
}
