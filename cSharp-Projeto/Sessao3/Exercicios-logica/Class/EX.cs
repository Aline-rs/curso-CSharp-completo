namespace cSharp_Projeto.Sessão_3.Exercicios_logica.Class
{
    public class EX
    {
        private readonly ExerciciosEstruturaSequencial _utils;

        public EX()
        {
            _utils = new ExerciciosEstruturaSequencial();
        }

        public void Ex1()
        {
            int primeiroNumero = _utils.LerInteiro("Digite o primeiro número: ");
            int segundoNumero = _utils.LerInteiro("Digite o segundo número: ");

            int resultado = _utils.Somar(primeiroNumero, segundoNumero);

            Console.Clear();

            _utils.ExibirResultado("SOMA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void Ex2()
        {
            double raio = _utils.LerDecimal("Digite o valor do raio: ");
            double area = _utils.CalcularAreaDoCirculo(raio);

            double resultado = area;

            Console.Clear();

            _utils.ExibirResultado("A=", resultado, "F4");
            Console.ReadLine();
        }

        public void EX3()
        {
            int a = _utils.LerInteiro("Digite o valor de A: ");
            int b = _utils.LerInteiro("Digite o valor de B: ");
            int c = _utils.LerInteiro("Digite o valor de C: ");
            int d = _utils.LerInteiro("Digite o valor de D: ");

            int resultado = _utils.CalcularDiferenca(a, b, c, d);

            Console.Clear();

            _utils.ExibirResultado("DIFERENÇA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void EX4()
        {

            int numeroFuncionario = _utils.LerInteiro("Digite o número do funcionário: ");
            double horasTrabalhadas = _utils.LerDecimal("Digite as horas trabalhadas: ");
            double valorHora = _utils.LerDecimal("Digite o valor da hora: ");

            double resultado = _utils.CalcularSalarioHora(valorHora, horasTrabalhadas);

            Console.Clear();

            _utils.ExibirResultado("NUMBER = ", numeroFuncionario, "F0");
            _utils.ExibirResultado("SALARY = U$ ", resultado, "F2");
            Console.ReadLine();
        }

        public void EX5()
        {
            int codigoPeca1 = _utils.LerInteiro("Digite o código da peça 1: ");
            int numeroPeca1 = _utils.LerInteiro("Digite o número de peças 1: ");
            double valorUnitarioPeca1 = _utils.LerDecimal("Digite o valor unitário da peça 1: ");

            int codigoPeca2 = _utils.LerInteiro("Digite o código da peça 2: ");
            int numeroPeca2 = _utils.LerInteiro("Digite o número de peças 2: ");
            double valorUnitarioPeca2 = _utils.LerDecimal("Digite o valor unitário da peça 2: ");

            double resultado = _utils.CalcularValorTotalPecas(numeroPeca1, valorUnitarioPeca1, numeroPeca2, valorUnitarioPeca2);

            Console.Clear();

            _utils.ExibirResultado("VALOR A PAGAR: R$ ", resultado, "F2");
            Console.ReadLine();
        }

        public void EX6()
        {
            double valorA = _utils.LerDecimal("Digite o valor de A: ");
            double valorB = _utils.LerDecimal("Digite o valor de B: ");
            double valorC = _utils.LerDecimal("Digite o valor de C: ");

            double triangulo = _utils.CalcularAreaDoTriangulo(valorA, valorC);
            double circulo = _utils.CalcularAreaDoCirculo(valorC);
            double trapezio = _utils.CalcularAreaDoTrapezio(valorA, valorB, valorC);
            double quadrado = _utils.CalcularAreaDoQuadrado(valorB);
            double retangulo = _utils.CalcularAreaDoRetangulo(valorA, valorB);

            Console.Clear();

            _utils.ExibirResultado("TRIANGULO: ", triangulo, "F3");
            _utils.ExibirResultado("CIRCULO: ", circulo, "F3");
            _utils.ExibirResultado("TRAPEZIO: ", trapezio, "F3");
            _utils.ExibirResultado("QUADRADO: ", quadrado, "F3");
            _utils.ExibirResultado("RETANGULO: ", retangulo, "F3");
            Console.ReadLine();
        }
    }
}
