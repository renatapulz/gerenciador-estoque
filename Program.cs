using System;

class Program
{
    public static void Main(string[] args)
    {
        GerenciadorEstoque gerenciador = new GerenciadorEstoque();

        int opcao = 0;
        string opcaoMsg = "\n================================\n" +
                            "Olá! Escolha a opção desejada:\n" +
                            "Digite 1 para cadastrar um novo veículo.\n" +
                            "Digite 2 para listar os veículos.\n" +
                            "Digite 3 para remover um veículo.\n" +
                            "Digite 4 para dar entrada no estoque.\n" +
                            "Digite 5 para retirar do estoque.\n" +
                            "Digite 0 para sair.\n" +
                            "================================\n\n";

        Console.WriteLine(opcaoMsg);
        opcao = Convert.ToInt32(Console.ReadLine());
    }
}