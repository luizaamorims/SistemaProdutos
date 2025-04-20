namespace SistemaProdutos
{
    internal class Program
    {
        static List<Produto> produtos = new List<Produto>();
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Seja bem vindo ao sistema de cadastro de produtos --------\n");


            int opcao = 0;


            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Buscar Produto");
                Console.WriteLine("4 - Remover Produto");
                Console.WriteLine("5 - Sair \n");

                Console.Write("Digite sua opcao: ");
                opcao = int.Parse(Console.ReadLine());

                Produto p1 = new Produto();

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto(p1);
                        break;
                    case 2:
                        ListarProdutos(p1);
                        break;
                    case 3:
                        BuscarProduto(p1);
                        break;
                    case 4:
                        RemoverProduto(p1);
                        break;
                    case 5:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        break;

                }

            } while (opcao != 5);

        }

        static void CadastrarProduto(Produto p1)
        {

            p1.CadastrarProduto();

            produtos.Add(p1);
        }

        static void ListarProdutos(Produto p1)
        {

            p1.ListarProdutos(produtos);

        }

        static void BuscarProduto(Produto p1)
        {
            p1.BuscarProduto(produtos);
        }

        static void RemoverProduto(Produto p1)
        {

            Produto resp = p1.RemoverProduto(produtos);

            if (resp == null)
            {
                Console.WriteLine("Produto não encontrado");
            }
            else
            {
                produtos.Remove(resp);
                Console.WriteLine("Produto removido com sucesso \n");
            }


        }
    }
}

