using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Vetor
{
    internal class Cliente
    {
        public Cliente[] clien;
        public string nome;
        public int idade;
        public string rg;
        public string cpf;
        public int qntdfila = 0;
        public int prioridade = 0;

        public Cliente(string nome = "", int idade = 0, string rg = "", string cpf = "", bool prioridade = false)
        {
            clien = new Cliente[10];
            this.nome = nome;
            this.idade = idade;
            this.rg = rg;
            this.cpf = cpf;
            this.prioridade = 0;
        }


        public void CadastrarCliente()
        {
            if (qntdfila < 10)
            {
                Console.WriteLine("\nDigite o seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu rg: ");
                rg = Console.ReadLine();
                Console.WriteLine("Digite o seu cpf: ");
                cpf = Console.ReadLine();
                Console.WriteLine("Cliente cadastrado com sucesso!");
                Cliente cliente = new Cliente(nome, idade, rg, cpf);
                clien[qntdfila] = cliente;
                qntdfila++;
            }else {
                Console.WriteLine("Fila cheia!");
            }
        }




        public void ListarCliente()
        {

            if (qntdfila > 0)
            {
                for (int i = 0; i < clien.Length; i++)
                {
                    if (clien[i] != null)
                    {
                        Console.WriteLine("\n\nCliente:{0}", i + 1);
                        Console.WriteLine("Nome:" + clien[i].nome);
                        Console.WriteLine("Idade:" + clien[i].idade);
                        Console.WriteLine("RG:" + clien[i].rg);
                        Console.WriteLine("CPF:" + clien[i].cpf);
                        Console.WriteLine("Prioridade:" + clien[i].prioridade);
                        Console.WriteLine("Clientes na fila:" + qntdfila);
                    }
                }
            }
            else
            {
                Console.WriteLine("Fila esta vazia!");
            }
        }

        public void IncluirClientePrioritario()
        {
            if (qntdfila < 10)
            {
                Console.WriteLine("\nDigite o seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu rg: ");
                rg = Console.ReadLine();
                Console.WriteLine("Digite o seu cpf: ");
                cpf = Console.ReadLine();
                Console.WriteLine("Cliente com prioridade cadastrado com sucesso!");
                Cliente clienteprioriário = new Cliente(nome, idade, rg, cpf, true);

                for (int j = qntdfila - 1; j >= prioridade; j--)
                {
                    clien[j + 1] = clien[j];
                }
                clien[prioridade] = clienteprioriário; prioridade++; qntdfila++;
            }

        }

        public void RetirarCliente()
        {
            Cliente retirarCliente = clien[0];

            if (qntdfila > 0)
            {
                for (int i = 1; i < qntdfila; i++)
                {
                    clien[i - 1] = clien[i];
                }

                clien[qntdfila - 1] = null;
                qntdfila--;

                Console.WriteLine($"\n\nO cliente {retirarCliente.nome} foi retirado com sucesso!");
            }

        }
    }
}

