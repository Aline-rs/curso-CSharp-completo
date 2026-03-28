namespace cSharp_Projeto.Sessão_3.Exercicios_logica.Class
{
    public class EX : ExerciciosEstruturaSequencial
    {
        public void Ex1()
        {
            int primeiroNumero = LerInteiro("Digite o primeiro número: ");
            int segundoNumero = LerInteiro("Digite o segundo número: ");

            int resultado = Somar(primeiroNumero, segundoNumero);

            Console.Clear();

            ExibirResultado("SOMA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void Ex2()
        {
            double raio = LerDecimal("Digite o valor do raio: ");
            double area = CalcularAreaDoCirculo(raio);

            double resultado = area;

            Console.Clear();

            ExibirResultado("A=", resultado, "F4");
            Console.ReadLine();
        }

        public void EX3()
        {
            int a = LerInteiro("Digite o valor de A: ");
            int b = LerInteiro("Digite o valor de B: ");
            int c = LerInteiro("Digite o valor de C: ");
            int d = LerInteiro("Digite o valor de D: ");

            int resultado = CalcularDiferenca(a, b, c, d);

            Console.Clear();

            ExibirResultado("DIFERENÇA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void EX4()
        {

            int numeroFuncionario = LerInteiro("Digite o número do funcionário: ");
            double horasTrabalhadas = LerDecimal("Digite as horas trabalhadas: ");
            double valorHora = LerDecimal("Digite o valor da hora: ");

            double resultado = CalcularSalarioHora(valorHora, horasTrabalhadas);

            Console.Clear();

            ExibirResultado("NUMBER = ", numeroFuncionario, "F0");
            ExibirResultado("SALARY = U$ ", resultado, "F2");
            Console.ReadLine();
        }

        public void EX5()
        {
            int codigoPeca1 = LerInteiro("Digite o código da peça 1: ");
            int numeroPeca1 = LerInteiro("Digite o número de peças 1: ");
            double valorUnitarioPeca1 = LerDecimal("Digite o valor unitário da peça 1: ");

            int codigoPeca2 = LerInteiro("Digite o código da peça 2: ");
            int numeroPeca2 = LerInteiro("Digite o número de peças 2: ");
            double valorUnitarioPeca2 = LerDecimal("Digite o valor unitário da peça 2: ");

            double resultado = CalcularValorTotalPecas(numeroPeca1, valorUnitarioPeca1, numeroPeca2, valorUnitarioPeca2);

            Console.Clear();

            ExibirResultado("VALOR A PAGAR: R$ ", resultado, "F2");
            Console.ReadLine();
        }

        public void EX6()
        {
            double valorA = LerDecimal("Digite o valor de A: ");
            double valorB = LerDecimal("Digite o valor de B: ");
            double valorC = LerDecimal("Digite o valor de C: ");

            double triangulo = CalcularAreaDoTriangulo(valorA, valorC);
            double circulo = CalcularAreaDoCirculo(valorC);
            double trapezio = CalcularAreaDoTrapezio(valorA, valorB, valorC);
            double quadrado = CalcularAreaDoQuadrado(valorB);
            double retangulo = CalcularAreaDoRetangulo(valorA, valorB);

            Console.Clear();

            ExibirResultado("TRIANGULO: ", triangulo, "F3");
            ExibirResultado("CIRCULO: ", circulo, "F3");
            ExibirResultado("TRAPEZIO: ", trapezio, "F3");
            ExibirResultado("QUADRADO: ", quadrado, "F3");
            ExibirResultado("RETANGULO: ", retangulo, "F3");
            Console.ReadLine();
        }
    }
}
