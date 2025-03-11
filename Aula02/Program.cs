// See https://aka.ms/new-console-template for more information
using Aula02._1bim;

Console.WriteLine("Informe a sua idade: ");
int idade;
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Idade:" + idade);

int valor1 = 10;
valor1 += 20; // valor1 = valor1 + 20;

SomaDoisNumeros somador = new SomaDoisNumeros();

Console.WriteLine("Resultado: " + somador.Somar(20, 22));

bool entradaInvalida = true;
do
{
    try
    {
        Console.Write("Informe o valor em metros: ");
        int metros = int.Parse(Console.ReadLine());
        Console.WriteLine($"O valor {metros} metros corresponde a {MetrosMilimetros.ConverterMetrosEmMilimetros(metros)} milímetros");
        entradaInvalida = false;
    }
    catch (Exception e)
    {
        Console.WriteLine("O valor informado foi inválido.\n" + e.Message);
    }

} while (entradaInvalida);

