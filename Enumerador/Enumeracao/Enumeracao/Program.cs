using Enumeracao.Entidades;
using System;
using Enumeracao.Entidades.Enums;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = OrderStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);

            string txt = OrderStatus.PagamentoPendente.ToString();//cash Enum para string

            //OrderStatus os = Enum.Parse<OrderStatus>("Entregue"); string para enum

            Console.WriteLine(txt);

            Console.ReadLine();

        }
    }
}
