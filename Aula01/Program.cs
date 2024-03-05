//altere o programa para calcular                         No "Do while", o codigo sera executado ao menos 1 vez indepedente de ser true ou false.

// imc = peso / altura * altura
using Aula01;
using System.Globalization;

bool entrada = true;
do
{
    try
    {
        Console.WriteLine("Informe o primero numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Calculadora calculadora = new Calculadora();
        Console.WriteLine($"A soma dos numeros {num1} + {num2} = {calculadora.Soma(num1, num2)}");
       entrada = false;
    }
    catch (FormatException e)
    {
        
    }
} while (entrada);

/*bool entrada = true;
do
{
    try
    {
        Console.WriteLine("Informe o peso atual: ");
        int peso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura atual: ");
        float altura = float.Parse(Console.ReadLine());
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);
Crie uma classe chamada calculadora, que possua um método que some dois numeros inteiros e retorne o resultado dessa soma. O nome do método deve ser soma;

