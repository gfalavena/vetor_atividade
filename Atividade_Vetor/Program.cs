using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            char opcao = '1';

            Console.WriteLine("\t\t\t\t\tSISTEMA BANCÁRIO\t\t\t\t\t");
            while (opcao != 'q')
            {
                Console.WriteLine("\n\n\nBem vindo ao sistema de gerenciamento do banco. Escolha uma das opções abaixo: \n");
                Console.WriteLine("1.Cadastrar/Inserir\t  2.Listar\t 3.Incluir cliente prioritário\t  4.Retirar o cliente\t  6.(Q) Sair do Programa\t");
                opcao = Console.ReadKey().KeyChar;

                switch (opcao)
                {

                    case '1':

                        cliente.CadastrarCliente();
                        break;


                    case '2':

                        cliente.ListarCliente();
                        break;

                    case '3':

                        cliente.IncluirClientePrioritario();
                        break;

                    case '4':

                        cliente.RetirarCliente();
                        break;

                    case 'Q':
                        Environment.Exit(1);
                        break;

                }

            }
        }
    }
}
