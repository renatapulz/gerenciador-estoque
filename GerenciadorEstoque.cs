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
        Console.WriteLine(novoVeiculo.VehicleSummaryInfo());
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


    public void RemoverVeiculo()
    {
        if (veiculos.Length != 0)
        {
            int removido = 0;
            int id;
            Console.WriteLine("Escolha um dos veículos abaixo para excluir:\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(veiculos[i].VehicleSummaryInfo());
            }
            Console.WriteLine("\nDigite o ID do veículo a ser removido:");
            id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                if (veiculos[i].Id == id)
                {
                    removido = 1;
                    for (int y = i; y < size - 1; y++)
                    {
                        veiculos[y] = veiculos[y + 1];
                    }

                    // Diminui em 1 a contagem dos veículos.
                    size--;
                    //Redimensiona o vetor para ter um elemento a menos
                    Array.Resize(ref veiculos, veiculos.Length - 1);
                    Console.WriteLine($"Veículo ID: {id} REMOVIDO!.\n");
                    break;
                }
            }
            if (removido == 0)
            {
                Console.WriteLine($"Veículo ID: {id} não encontrado.\n");
            }
        }
        else
        {
            Console.WriteLine("Sem veículos cadastrados.");
        }
    }

    public void AdicionarEstoque()
    {
        if (veiculos.Length != 0)
        {
            int id;
            int encontrado = 0;
            int quantidade;
            Console.WriteLine("Escolha um dos veículos abaixo para dar entrada no estoque:\n");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(veiculos[i].VehicleSummaryInfo());
            }
            Console.WriteLine("\nDigite o ID do veículo escolhido:");
            id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                if (veiculos[i].Id == id)
                {
                    encontrado = 1;
                    Console.WriteLine($"Quantidade de estoque do veículo {veiculos[i].Nome}: {veiculos[i].Estoque}");
                    Console.WriteLine("Digite a quantidade a ser adicionada ao estoque: ");
                    quantidade = int.Parse(Console.ReadLine());
                    veiculos[i].Estoque += quantidade;
                    Console.WriteLine($"Estoque atualizado para {veiculos[i].Estoque}");
                }
            }
            if (encontrado == 0)
            {
                Console.WriteLine($"Veículo ID: {id} não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Sem veículos cadastrados.");
        }
    }
}