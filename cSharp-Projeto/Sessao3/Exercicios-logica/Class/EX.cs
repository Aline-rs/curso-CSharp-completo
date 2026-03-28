namespace cSharp_Projeto.Sessão_3.Exercicios_logica.Class
{
    public class EX : ExerciciosEstruturaSequencial
    {
        public void Ex1()
        {
            int primeiroNumero = LerInteiro("Digite o primeiro número: ");
            int segundoNumero = LerInteiro("Digite o segundo número: ");

            int resultado = Somar(primeiroNumero, segundoNumero);

            ExibirResultado("SOMA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void Ex2()
        {
            double raio = LerDecimal("Digite o valor do raio: ");
            double area = (double)CalcularAreaDoCirculo(raio);

            double resultado = area;

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

            ExibirResultado("DIFERENÇA = ", resultado, "F0");
            Console.ReadLine();
        }

        public void EX4()
        {

            int numeroFuncionario = LerInteiro("Digite o número do funcionário: ");
            double horasTrabalhadas = LerDecimal("Digite as horas trabalhadas: ");
            double valorHora = LerDecimal("Digite o valor da hora: ");

            int resultado = (int)CalcularSalarioHora(valorHora, horasTrabalhadas);
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
            ExibirResultado("VALOR A PAGAR: U$ ", resultado, "F2");
            Console.ReadLine();
        }
    }
}
