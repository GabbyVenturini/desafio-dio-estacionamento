using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dio_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Pede para o usuário digitar a placa do veículo
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Obtém a placa digitada pelo usuário e adiciona à lista de veículos
            string placa = Console.ReadLine();
            veiculos.Add(placa);

            // Exibe a placa digitada
            Console.WriteLine("Placa digitada: " + placa);
        }


        public void RemoverVeiculo()
        {
            // Pede para o usuário digitar
            Console.WriteLine("Digite a placa do veículo para retirar:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                //Pede para o usuário digitar quantas horas o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                //Realiza o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
                decimal horas = Math.Ceiling(Convert.ToDecimal(Console.ReadLine().Replace(".", ",")));

                decimal valorTotal = precoInicial + (horas * precoPorHora);

                //Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi retirado e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, nao reconheço a placa digitada. Confira se digitou corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                //Realiza um laço de repetição, que exibe os veículos estacionados
                foreach (String veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados no momento.");
            }
        }
    }
}
