namespace tipos_operadores_exercicios;

public class Exercicios
{
/* 
    Exercício 1
    Crie um método ConcatenaNome para concatenar seu nome completo.
    Crie duas váriáveis do tipo texto, armazene respectivamente seu primeiro nome e seu ultimo nome, 
    exiba na tela seu nome completo concatenando as variáveis.
*/
    public void ConcatenaNome()
    {
        string primeiroNome = "Eli";
        string ultimoNome = "Filho";

        Console.WriteLine($"Meu nome completo é: {primeiroNome} {ultimoNome}");
    }

/*
    Exercício 2
    Crie o metodo MediaAluno que leia primeiro nome e ultimo nome de um aluno,
    leia 3 notas e no final exiba seu nome completo e a média das notas.
*/
    public void MediaAluno()
    {
        var primeiroNome = "José";
        var ultimoNome = "da Silva";
        //var nomeCompleto = primeiroNome + " " + ultimoNome;
        var nomeCompleto = $"{primeiroNome} {ultimoNome}"; // poderia ser como a linha comentada acima, mas dessa forma é mais elegante.

        double nota1 = 4.5;
        double nota2 = 7;
        double nota3 = 6.2;
        double media = (nota1 + nota2 + nota3) / 3; 

        Console.WriteLine($"O nome do aluno é {nomeCompleto} e sua média é {media}");
    }

/*
    Exercício 3
    Crie um método Frete que exiba o endereço concatenado e calcule o frete de um produto.
    Endereço deve ter os seguintes dados: logradoura, número, cep, bairro, município e estado.
    O Frete deve levar em conta distância, peso e volume.
    Preço por km de distância R$1,20
    Preço por volume R$ 5,45 por metro cúbico
    Preço por grama R$ 0,30 
*/
    public void Frete()
    {

    }
}
