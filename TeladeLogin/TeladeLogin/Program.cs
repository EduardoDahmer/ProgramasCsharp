using System;

namespace Teladelogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UsuarioSistema = "Usuário";
            string Senha = "123";

            Console.Write("Usuário: ");
            string UsuarioInserido = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Senha: ");
            string SenhaInserida = Console.ReadLine();
            Console.WriteLine();

            if (UsuarioInserido != UsuarioSistema || SenhaInserida != Senha)
            {
                Console.WriteLine("Usuário ou senha inválidos");
                Console.WriteLine();
            }
            if (UsuarioInserido == UsuarioSistema && SenhaInserida == Senha)
            {
                Console.WriteLine($"Bem-Vindo, {UsuarioSistema} ");
                Console.WriteLine();
                Console.WriteLine("Por favor, diga-nos sua idade: ");
                Console.WriteLine();
                string idadeinserida = Console.ReadLine();
                int idade = Convert.ToInt16(idadeinserida);
                Console.WriteLine();
                if (idade <= 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acesso Liberado apenas ao sistema KIDS");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Acesso Liberado ao sistema de Adultos");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Por favor, diga-nos o sexo com o qual se identifica.");
                    Console.WriteLine();
                    Console.WriteLine("Ah, nossa empresa não possui preconceito, essa informação é confidencial e é apenas para fins de estudos!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite 1 para homem, 2 para mulher e 0 caso não se encaixe nessas duas opções");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    string digitoinserido = Console.ReadLine();
                    int digito = Convert.ToInt16(digitoinserido);
                    Console.WriteLine();
                    if (digito == 0)
                        Console.WriteLine("Certo. Não há problema algum! Essa opção poderá ser alterada no futuro!");
                    if (digito == 1)
                        Console.WriteLine("Certo. Você se identifica como homem!");
                    if (digito == 2)
                        Console.WriteLine("Certo. Você se identifica como mulher!");
                }
            }
            Console.ReadKey();
        }
    }
}


