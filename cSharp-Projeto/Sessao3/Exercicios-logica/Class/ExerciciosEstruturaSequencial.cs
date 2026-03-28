namespace cSharp_Projeto.Sessão_3.Exercicios_logica
{
    public class ExerciciosEstruturaSequencial
    {
        public int Somar(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public int LerInteiro(string mensagem)
        {
            Console.WriteLine(mensagem);

            return int.Parse(Console.ReadLine());
        }

        public double LerDecimal(string mensagem)
        {
            Console.WriteLine(mensagem);

            return double.Parse(Console.ReadLine());
        }

        public void ExibirResultado(int resultado)
        {
            Console.WriteLine($"Resultado = {resultado}");
        }

        public void ExibirResultado(double resultado)
        {
            Console.WriteLine($"Resultado = {resultado:F4}");
        }
        public void ExibirResultado(int numeroFuncionario, double resultado)
        {
            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {resultado:F2}");
        }

        public double CalcularAreaDoCirculo(double raio)
        {
            const double pi = 3.14159;
            return pi * Math.Pow(raio, 2);
        }

        public int CalcularDiferenca(int a, int b, int c, int d)
        {
            return (a * b - c * d);

        }

        public double CalcularSalarioHora(double valorHora, double horasTrabalhadas)
        {
            return valorHora * horasTrabalhadas;
        }
    }
}
