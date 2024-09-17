using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio1.Entities
{
    internal class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal PrecoPorHora { get; set; }
        private List<string> Veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar:");
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            if (Veiculos.Any(x => x.ToLower() == placa.ToLower()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = 0;
                decimal valorTotal = 0;
                Console.Write($"O veículo {placa} foi tirado, e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não foi encontrado");
            }
        }
        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.Write("Os veículos estacionados são:");
            }
            else
            {
                Console.Write("Não há veículos estacionados.");
            }
        }
    }
}
