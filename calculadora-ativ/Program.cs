using System;

class Program
{
    static void Main(string[] args)
    {
        double numero1, numero2, resultado;
        int operacao;

        while (true)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da Divisão");
            Console.WriteLine("0 - Sair");

            operacao = int.Parse(Console.ReadLine());

            if (operacao == 0)
            {
                break;
            }

            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;
                case 5:
                    resultado = numero1 % numero2;
                    Console.WriteLine("O resultado do resto da divisão é: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
