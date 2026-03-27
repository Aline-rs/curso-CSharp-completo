namespace cSharp_Projeto.Sessão_3.Exercicios_logica
{
    public class ExerciciosEstruturaSequencial
    {
        public int Somar(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public int LerNumero(string mensagem)
        {
            Console.WriteLine(mensagem);

            return int.Parse(Console.ReadLine());
        }

        public void ExibirResultado(int resultado)
        {
            Console.WriteLine($"SOMA = {resultado}");
        }
    }
}
