namespace estrtutura_condicional;

public class Exercicios
{
    /*
    Crie um método chamado CalcularMedia que leia nome, sobrenome, 3 notas de um aluno para que seja calculada a média.
    Deve ser exibido seu nome completo, sua média e o resultado final
    Se o resultado final for maior ou igual a 7 o aluno está aprovado.
    Se o resultado final for menor que 7 e maior que 4 o aluno está em recuperação.
    Se o resultado final for menor que 5 o aluno está reprovado.
    */
    public void CalcularMedia()
    {
        Console.Write("Digite o primeiro nome do aluno: ");
        string primeiroNome = Console.ReadLine(); // Console.Readline() Faz a leitura do dado inserido pelo teclado.

        Console.Write("Informe o ultimo nome do aluno: ");
        string ultimoNome = Console.ReadLine();

        string nomeCompleto = $"{primeiroNome} {ultimoNome}";

        Console.Write("Informe a primeira nota: ");
        double primeiraNota = double.Parse(Console.ReadLine()); //double.Parse() converte um tipo string em double.

        Console.Write("Informe a segunda nota: ");
        double segundaNota = double.Parse(Console.ReadLine());

        Console.Write("Informe a terceira nota: ");
        double terceiraNota = double.Parse(Console.ReadLine());

        double media = (primeiraNota + segundaNota + terceiraNota) / 3;

        if (media >= 7) 
        {
            Console.WriteLine($"O aluno {nomeCompleto} teve a média {media} e foi aprovado!!");
        }
        else if(media >= 5 && media <= 6)
        {
            Console.WriteLine($"O aluno {nomeCompleto} teve a média {media} e está de recuperação!!");
        }
        else 
        {
            Console.WriteLine($"O aluno {nomeCompleto} teve a média {media} e foi reprovado!!");
        }
    }

    /*
    Crie um método chamado CalcularFrete() que leia os dados do endereço: logradouro, número, bairro, cep, município, uf.
    Leia a distância, peso, volume, calcule o frete.
    volume R$5,50 por m³
    peso R$2,20 por kg
    Distancia R$1,25 km
    Deverão ser exibidos ao final da execução, endereço completo e valor do frete.
    O valor mínimo do frete são R$20,00
    Se o volume passar de 2m³ será cobrado um adicional de R$259,90
    Se a distância for maior que 200km será cobrado R$1,10 por km
    Se a distância for menor que 10km o frete será o valor mínimo
     */
    public void CalcularFrete() 
    { 

    }
}
