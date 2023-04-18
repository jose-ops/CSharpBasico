using ExecicioEnumeracaoComposicao.Entities;
using ExecicioEnumeracaoComposicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioEnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cliente data: ");
            string Name = Console.ReadLine();
            Console.Write("Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Birth date:");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente client = new Cliente(Name, Email, dateTime);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<= n; i++)
            {
                Console.WriteLine($"how many items #{i} data:");
                Console.WriteLine($"nome");
                string nome = Console.ReadLine();
                Console.WriteLine($"Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nome, price);

                Console.Write("Quantity: ");
                int quantit = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
