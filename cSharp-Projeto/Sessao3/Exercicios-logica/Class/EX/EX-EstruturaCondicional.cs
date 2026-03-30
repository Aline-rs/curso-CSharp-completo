using cSharp_Projeto.Sessao3.Exercicios_logica.Class.Métodos;

namespace cSharp_Projeto.Sessao3.Exercicios_logica.Class
{
    public class EstruturaCondicional
    {
        private readonly ExerciciosEstruturaCondicional _utils;

        public EstruturaCondicional()
        {
            _utils = new ExerciciosEstruturaCondicional();
        }

        public void EX1()
        {
            int numero = _utils.LerInteiro("Digite um número inteiro: ");
            string resultado = _utils.VerificarPositivoOuNegativo(numero);

            Console.Clear();

            _utils.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX2()
        {
            int numero = _utils.LerInteiro("Digite um número inteiro: ");
            string resultado = _utils.VerificarParOuImpar(numero);

            Console.Clear();

            _utils.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX3()
        {
            string resultado = _utils.VerificaNumeroMultiplo(0, 0);

            Console.Clear();

            _utils.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX4()
        {
            string resultado = _utils.CalculaDuracaoJogo(0, 0);

            Console.Clear();

            _utils.ExibirResultado(resultado);
            Console.ReadLine();
        }

        public void EX5()
        {
            int codigoProduto = _utils.LerInteiro("Digite o código do produto: ");
            int quantidade = _utils.LerInteiro("Digite a quantidade: ");

            double resultado = _utils.CalcularValorTotalConta(codigoProduto, quantidade);

            Console.Clear();

            _utils.ExibirResultado("TOTAL: R$ ", resultado, "F2");
            Console.ReadLine();
        }

        public void EX6()
        {
            double valor = _utils.LerDecimal("Digite um valor: ");

            string resultado = _utils.DescobrirIntervalo(valor);

            Console.Clear();

            _utils.ExibirResultado(resultado);
            Console.ReadLine();

        }

        public void EX7()
        {
            double x = _utils.LerDecimal("Digite o valor de X: ");
            double y = _utils.LerDecimal("Digite o valor de Y: ");

            string resultado = _utils.EncontrarQuadrante(x, y);
            Console.Clear();

            _utils.ExibirResultado(resultado);

            Console.ReadLine();
        }

        public void EX8()
        {
            double salario = _utils.LerDecimal("Digite o valor do salario: ");

            double imposto = _utils.CalcularImposto(salario);

            if (imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.Clear();
                _utils.ExibirResultado("R$ ", imposto, "F2");
            }

            Console.ReadLine();
        }
    }
}