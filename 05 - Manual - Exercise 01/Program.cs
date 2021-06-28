using System;
using Entities;
namespace _05___Manual___Exercise_01 {
    class Program {
        static void Main(string[] args) {           
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: "); string name = Console.ReadLine();
            Console.Write("Preço: "); double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: "); int amount = int.Parse(Console.ReadLine());
            Stock stock = new Stock(name, price, amount);
            Console.WriteLine(stock);
            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            stock.AddAmount(add);
            Console.WriteLine(stock);

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            int remove = int.Parse(Console.ReadLine());
            stock.RemoveAmount(add);
            Console.WriteLine(stock);
        }
    }
}
