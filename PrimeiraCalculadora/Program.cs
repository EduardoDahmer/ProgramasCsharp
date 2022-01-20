using System;

namespace PrimeiraCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo à calculadora");
            Console.WriteLine("Para calcular, digite o primeiro número: ");
            string numero1 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Digite o segundo número: ");
            string numero2 = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Agora, diga o operador ( - + / *) ");
            string operador = Console.ReadLine();

            int numeroconvertido1 = Convert.ToInt16(numero1);
            int numeroconvertido2 = Convert.ToInt16(numero2);

            if (operador == "-" )
            {
                Console.WriteLine("O valor da operação é: " + (numeroconvertido1 - numeroconvertido2));   
            }
            if (operador == "+")
            {
                Console.WriteLine("O valor da operação é: " + (numeroconvertido1 + numeroconvertido2));

            }
            if (operador == "*")
            {
                Console.WriteLine("O valor da operação é: " + (numeroconvertido1 * numeroconvertido2));
            }
            if (operador == "/" & numeroconvertido2 != 0)
            {
                
                Console.WriteLine("O valor da operação é: " + (numeroconvertido1 / numeroconvertido2));
            }
            if (operador == "/" & numeroconvertido2 == 0)
            {
                Console.WriteLine("Não é possível realizar a divisão por 0 ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar");
            Console.ReadKey();
        }
    }
}
