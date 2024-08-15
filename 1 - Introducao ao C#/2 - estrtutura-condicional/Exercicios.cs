namespace estrtutura_condicional;

public class Exercicios
{
/*
Crie um método chamado CalcularMedia que leia nome, sobrenome, 3 notas de um aluno para que seja calculada a média.
Deve ser exibido seu nome completo, sua média e o resultado final
Se o resultado final for maior ou iual a 7 o aluno está aprovado.
Se o resultado final for menor que 7 e maior que 4 o aluno está em recuperação.
Se o resultado final for menor que 5 o aluno está reprovado.
*/
    public void CalcularMedia()
    {
        Console.WriteLine("Digite o primeiro nome do aluno: ");
        string primeiroNome = Console.ReadLine();

        Console.WriteLine("Informe o ultimo nome do aluno: ");
        string ultimoNome = Console.ReadLine();

        Console.WriteLine("Informe a primeira nota: ");
        double primeiraNota = (double)Console.ReadLine();

        Console.WriteLine("Informe a segunda nota: ");
        double segundaNota = (double)Console.ReadLine();

        Console.WriteLine($"Nome completo: {primeiroNome} {ultimoNome}");
    }
}
