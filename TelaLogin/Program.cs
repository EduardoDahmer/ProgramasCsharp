using System;

namespace TelaLogin

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

            if(UsuarioInserido != UsuarioSistema || SenhaInserida != Senha)
            {
                Console.WriteLine("Usuário ou senha inválidos");
                Console.WriteLine();
            }
            if(UsuarioInserido == UsuarioSistema && SenhaInserida == Senha)
            {
                Console.WriteLine("Acesso Liberado");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
