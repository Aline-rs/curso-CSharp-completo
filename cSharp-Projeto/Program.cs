using cSharp_Projeto.Sessão_3.Exercicios_logica;

class Program
{
    static void Main(string[] args)
    {

        // EXERCICIO 01 

        var exerciciosEstruturaSequencial = new ExerciciosEstruturaSequencial();

        int primeiroNumero = exerciciosEstruturaSequencial.LerNumero("Digite o primeiro número: ");
        int segundoNumero = exerciciosEstruturaSequencial.LerNumero("Digite o segundo número: ");

        int resultado = exerciciosEstruturaSequencial.Somar(primeiroNumero, segundoNumero);

        exerciciosEstruturaSequencial.ExibirResultado(resultado);
        Console.ReadLine();
    }
}