// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora");

Console.WriteLine("Digite o primeiro numero");
double num1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
double num2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
int operacao=Convert.ToInt32(Console.ReadLine());

switch (operacao)
{
    case 1:
        Console.WriteLine($"Resultado {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"Resultado {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"Resultado {num1 * num2}");
        break;
    case 4:
        if(num2 != 0)
         Console.WriteLine($"Resultado {num1 / num2}");
        else
         Console.WriteLine("Erro : divisão por 0 não e permitida");
        break;
    default:
    Console.WriteLine("Operção invalida");
     break;
}
