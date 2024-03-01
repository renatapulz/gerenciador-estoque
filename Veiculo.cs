public class Veiculo
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public float Preco { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public string Marca { get; set; }
    public int Estoque { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}\n" +
               $"Nome: {Nome}\n" +
               $"Preço: {Preco:F2}\n" +
               $"Ano: {Ano}\n" +
               $"Cor: {Cor}\n" +
               $"Marca: {Marca}\n" +
               $"Estoque: {Estoque}\n";
    }

    public string VehicleSummaryInfo()
    {
        return $"ID: {Id}\n" +
               $"Nome: {Nome}\n";
    }
}