using tipos_operadores_exercicios;

// Esse exercício visa conhecer alguns tipos e operadores existentes no C#
// Usamos variáveis para alocar dados na memória.

// Tipo string
var minhaVariavelTipoString  = "meu texto"; // a variável foi iniciada com a string "meu texto" mas poderia ser qualquer outro texto ou até mesmo vazia.
string minhaOutraVariavelTipoString = string.Empty; // variável iniciada como vazia.

// Tipo inteiro
var numeroInteito = 0; // variável int iniciada com 0
int outroInteiro = 10; // iniciada com 10

// Tipo double
var meuDouble = 9.55;
double meuOutroDouble = 0;


// Atribuição - adicionar valor a uma variável
minhaOutraVariavelTipoString = "Meu texto novo atribuído"; // note que tipo texto sempre é atribuido com "" aspas. 
outroInteiro = 45;
meuDouble = 10.99 + outroInteiro;

// Concatenação - unir strings
minhaOutraVariavelTipoString = "dotnet é " + "melhor que java"; // resultado = "dotnet é melhor que java"
minhaVariavelTipoString = minhaVariavelTipoString + minhaOutraVariavelTipoString; // aqui concatenamos os valores dar variáveis

// matemáticos
double numeral1 = 100;
double numeral2 = 45;
double resultado = numeral1 - numeral2;
Console.WriteLine("o resultado da subtração é: " + resultado);

resultado = numeral1 + numeral2;
Console.WriteLine("o resultado da soma é: " + resultado);

Console.WriteLine("o resultado da divisão é: " + numeral1 / numeral2); // note que aqui faço o calculo sem atribuir a variável resultado.

resultado = numeral1 * numeral2;
Console.WriteLine("o resultado da multiplicação é " + resultado);


var exercicios = new Exercicios();

Console.WriteLine("Exercício 1");
exercicios.ConcatenaNome();

Console.WriteLine("Exercício 2");
exercicios.MediaAluno();
