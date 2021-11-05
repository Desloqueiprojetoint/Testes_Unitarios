using Desloquei.Models;
using System;
using System.Globalization;

namespace Desloquei
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite '1' para cadastrar novo Usuário ou '2' para cadastrar novo Motorista");

            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    CadastrarUsuario();
                    break;
                case "2":
                    CadastrarMotorista();
                    break;                  

            }
            
            static void CadastrarUsuario()
            {
                Usuario a = new Usuario();

                Console.WriteLine("Nome:");
                a.Nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("E-mail:");
                a.Email = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Senha:");
                a.Senha = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Telefone:");
                a.Telefone = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Data de nascimento:");
                var data = new CultureInfo("pt-BR");
                string dateString = Console.ReadLine();
                DateTime nascimento = DateTime.Parse(dateString, data.DateTimeFormat);
                a.DataNascimento = nascimento;
                Console.WriteLine();
            }

            static void CadastrarMotorista()
            {
                Motorista b = new Motorista();

                Console.WriteLine("Nome:");
                b.Nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("E-mail:");
                b.Email = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Senha:");
                b.Senha = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Telefone:");
                b.Telefone = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Data de nascimento:");
                var data = new CultureInfo("pt-BR");
                string dateString = Console.ReadLine();
                DateTime nascimento = DateTime.Parse(dateString, data.DateTimeFormat);
                b.DataNascimento = nascimento;
                Console.WriteLine();

                Console.WriteLine("CNH:");
                b.Cnh = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Validade da CNH:");                
                string dataString = Console.ReadLine();
                DateTime cnh = DateTime.Parse(dataString, data.DateTimeFormat);
                b.ValidadeCnh = cnh;
                Console.WriteLine();

                Console.WriteLine("Categoria CNH:");
                b.CategoriaCnh = Console.ReadLine();
                Console.WriteLine();

            }

        }
    }
}
