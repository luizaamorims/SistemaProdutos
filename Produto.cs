public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Id { get; set; }
    public double Preco { get; set; }



    public Produto()
    {

    }

    public string ToString()
    {
        return $"Nome: {Nome}, Marca: {Marca}, Cor: {Cor}, Id: {Id}, Preco: {Preco} \n";
    }


    public void CadastrarProduto()
    {
        Console.WriteLine("Qual produto deseja cadastrar?: ");
        Nome = Console.ReadLine();
        Console.WriteLine("Qual a marca do produto?: ");
        Marca = Console.ReadLine();
        Console.WriteLine("Qual a cor do produto?: ");
        Cor = Console.ReadLine();
        Console.WriteLine("Qual o id do produto?: ");
        Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual o preco do produto?: ");
        Preco = double.Parse(Console.ReadLine());
        Console.WriteLine(" \n Cadastrado com sucesso! \n");


    }

    public void ListarProdutos(List<Produto> produtos)
    {
        Console.WriteLine(" \nLista de produtos: \n");

        foreach (var produto in produtos)
        {
            Console.WriteLine(produto.ToString());

        }

        if (produtos.Count == 0)
        {
            Console.WriteLine(" \nNenhum produto cadastrado!");
        }

    }
    public void BuscarProduto(List<Produto> produtos)
    {
        Console.Write(" \nDigite o id do produto que deseja buscar: ");

        int id = int.Parse(Console.ReadLine());

        bool achou = false;

        foreach (var produto in produtos)
        {
            if (produto.Id == id)
            {

                Console.WriteLine(produto.ToString());
                achou = true;
            }
        }

        if (!achou)
        {
            Console.WriteLine(" \n Produto não encontrado!");
        }



    }

    public Produto RemoverProduto(List<Produto> produtos)
    {
        Console.Write(" \nDigite o id do produto que deseja remover: ");
        int id = int.Parse(Console.ReadLine());



        foreach (var produto in produtos)
        {
            if (produto.Id == id)
            {

                return produto;

            }

        }

        return null;



    }
}

