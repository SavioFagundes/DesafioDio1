using DesafioDio1.Entities;
using System.Collections.Generic;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0, precoPorHora = 0;
            Console.WriteLine("Digite o preço inicial:");
            precoInicial = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o preço por hora:");
            precoPorHora = decimal.Parse(Console.ReadLine());

            Estacionamento estacionamentoGeral = new Estacionamento(precoInicial, precoPorHora);

            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine()) // ou elif >>
                {
                    case "1":
                        estacionamentoGeral.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamentoGeral.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamentoGeral.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção não contida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}
