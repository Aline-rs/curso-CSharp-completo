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

        public void ExibirResultado(string mensagem, double resultado, string casasDecimais)
        {
            Console.Write(mensagem);
            Console.WriteLine(resultado.ToString(casasDecimais));

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

        public double CalcularValorTotalPecas(int numeroPeca1, double valorUnitario1, int numeroPeca2, double valorUnitario2)
        {
            return (numeroPeca1 * valorUnitario1) + (numeroPeca2 * valorUnitario2);
        }

        public double CalcularAreaDoTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public double CalcularAreaDoTrapezio(double baseMaior, double baseMenor, double altura)
        {
            return ((baseMaior + baseMenor) * altura) / 2;
        }

        public double CalcularAreaDoQuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        public double CalcularAreaDoRetangulo(double largura, double altura)
        {
            return largura * altura;
        }
    }
}
