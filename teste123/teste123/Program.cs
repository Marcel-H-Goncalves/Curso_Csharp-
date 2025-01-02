using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastroDeProdutos
{
    // Classe Produto representando cada item no sistema
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }

    class Program
    {
        // Lista de produtos
        static List<Produto> listaProdutos = new List<Produto>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n--- Sistema de Cadastro de Produtos ---");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Buscar Produto por ID");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        BuscarProduto();
                        break;
                    case "4":
                        RemoverProduto();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }

        // Função para adicionar produto
        static void AdicionarProduto()
        {
            Produto novoProduto = new Produto();

            Console.Write("Informe o ID do Produto: ");
            novoProduto.Id = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nome do Produto: ");
            novoProduto.Nome = Console.ReadLine();

            Console.Write("Informe o Preço do Produto: ");
            novoProduto.Preco = double.Parse(Console.ReadLine());

            listaProdutos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        // Função para listar produtos
        static void ListarProdutos()
        {
            if (listaProdutos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                Console.WriteLine("\n--- Lista de Produtos ---");
                foreach (Produto p in listaProdutos)
                {
                    Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}, Preço: R${p.Preco:F2}");
                }
            }
        }

        // Função para buscar produto por ID
        static void BuscarProduto()
        {
            Console.Write("Informe o ID do Produto que deseja buscar: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = listaProdutos.Find(p => p.Id == id);

            if (produto != null)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: R${produto.Preco:F2}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        // Função para remover produto
        static void RemoverProduto()
        {
            Console.Write("Informe o ID do Produto que deseja remover: ");
            int id = int.Parse(Console.ReadLine());

            Produto produto = listaProdutos.Find(p => p.Id == id);

            if (produto != null)
            {
                listaProdutos.Remove(produto);
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
    }
}
