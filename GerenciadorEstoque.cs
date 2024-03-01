using System;

public class GerenciadorEstoque
{
    Veiculo[] veiculos = new Veiculo[0];
    int size = 0;

    public void AdicionarVeiculo()
    {
        Veiculo novoVeiculo = new Veiculo();
        Console.WriteLine("Informe o nome do veículo a ser cadastrado:");
        novoVeiculo.Nome = Console.ReadLine();
        Console.WriteLine("Informe o preço:");
        novoVeiculo.Preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o ano:");
        novoVeiculo.Ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a cor:");
        novoVeiculo.Cor = Console.ReadLine();
        Console.WriteLine("Para finalizar, informe a marca:");
        novoVeiculo.Marca = Console.ReadLine();
        novoVeiculo.Id = size + 1;
        novoVeiculo.Estoque = 0;
        Console.WriteLine("\nVeículo adicionado:");
        Console.WriteLine("-------");
        Console.WriteLine(novoVeiculo.ToString());
        size++;

        Veiculo[] novoVetor = new Veiculo[veiculos.Length + 1];

        for (int i = 0; i < veiculos.Length; i++)
        {
            Veiculo item = veiculos[i];
            novoVetor[i] = item;
        }
        novoVetor[novoVetor.Length - 1] = novoVeiculo;
        veiculos = novoVetor;
    }

    public void ListarVeiculos()
    {
        if (veiculos.Length != 0)
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("LISTA DE VEÍCULOS");
            Console.WriteLine("_______________________\n");
            foreach (Veiculo veiculo in veiculos)
            {
                Console.WriteLine(veiculo.ToString());
                Console.WriteLine("----------------------------");
            }
        }
        else
        {
            Console.WriteLine("Sem veículos cadastrados.");
        }
    }

}