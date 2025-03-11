// See https://aka.ms/new-console-template for more information
using Aula02._1bim;
using System.Runtime.CompilerServices;

int opcao = 0;
do
{
    Console.WriteLine("Escolha a opção desejada:");
    Console.WriteLine("(0) Sair");
    Console.WriteLine("(1) Somar dois números");
    Console.WriteLine("(2) Converter Metros em Milímetros");
    Console.Write("Opção: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Somar();
            break;
        case 2:
            Convertedor();
            break;

    }
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
} while(opcao != 0);

void Somar()
{
    Console.Write("Informe o primeiro numero: ");
    var valor1 = Console.ReadLine();
    Console.Write("Informe o segundo numero: ");
    var valor2 = Console.ReadLine();
    if (int.TryParse(valor1, out var saidaValor1) && int.TryParse(valor2, out var saidaValor2))
    {
        SomaDoisNumeros somador = new SomaDoisNumeros();
        Console.WriteLine("Resultado: " + somador.Somar(saidaValor1, saidaValor2));
    }
    else
    {
        Console.WriteLine($"Os valores informados devem ser números inteiros. Valor1: {valor1} / Valor2 {valor2}");
    }
    
}

void Convertedor()
{
    bool entradaInvalida = true;
    do
    {
        try
        {
            Console.Write("Informe o valor em metros: ");
            var metros = int.Parse(Console.ReadLine());
            Console.WriteLine($"O valor {metros} metros corresponde a {MetrosMilimetros.ConverterMetrosEmMilimetros(metros)} milímetros");
            entradaInvalida = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("O valor informado foi inválido.\n" + e.Message);
        }

    } while (entradaInvalida);
}


