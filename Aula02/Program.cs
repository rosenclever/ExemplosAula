// See https://aka.ms/new-console-template for more information
using Aula02._1bim;

Console.WriteLine("Informe a sua idade: ");
int idade;
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Idade:" + idade);

int valor1 = 10;
valor1 += 20; // valor1 = valor1 + 20;

SomaDoisNumeros somador;
somador = new SomaDoisNumeros();

Console.WriteLine("Resultado: " + somador.Somar(20, 22));
