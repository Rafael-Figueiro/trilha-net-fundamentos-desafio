using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private List<string> veiculos;  // Lista para armazenar as placas dos veículos
        private decimal precoInicial;
        private decimal precoPorHora;

        // Construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            veiculos = new List<string>();
        }

        // Método para adicionar veículo
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            // Aqui você pode fazer a validação da placa ou outras verificações necessárias
            // Exemplo: verificar se a placa já está na lista
            if (!veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo com esta placa já cadastrado.");
            }
        }

        // Método para remover veículo
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");
            string placa = Console.ReadLine();

            // Aqui você pode fazer a validação da placa ou outras verificações necessárias
            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        // Método para listar veículos
        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de veículos:");
            foreach (var placa in veiculos)
            {
                Console.WriteLine(placa);
            }
        }
    }
}
