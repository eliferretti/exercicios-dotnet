using estrtutura_condicional;
// Estrutura condicional if, else, else if
// Documentação microsoft https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/selection-statements


// A estutura condicional verifica se uma condição é verdadeira para que seka executado um bloco de código.

// Dados a média de um aluno, verifique se ele está aprovado, reprovado ou em recuperação.

var media = 4;

/* 
se a média do aluno for maior ou igual a 7, será exibido que ele foi aprovado. 
Nesse caso sabemos que é uma condição falsa porque media não é maior ou igual a 7
Logo ele vai ignorar esse bloco de código e pular para proxima condição. 
*/
if (media >= 7) 
{
    Console.WriteLine($"O aluno está aprovado, sua mádia é {media}");
}
/*
Abaixo será testado se mádia é menor ou igual a 6 e maior ou igual a 5
a condição permanece falsa porque media é igual a 4
Logo esse bloco também será ignirado.
*/
else if (media <= 6 && media >= 5)
{
    Console.WriteLine($"O aluno está de reuperação, sua média é {media}");
}
/*
Por fim, qualquer outro resultado será verdadeiro caso nenum dos anteriores seja verdadeiro.
*/
else
{
    Console.WriteLine($"O aluno está reprovado, sua média é {media}");
}


var exercicios = new Exercicios();
exercicios.CalcularMedia();
