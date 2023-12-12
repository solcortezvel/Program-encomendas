using System;
using System.Collections.Generic;
using ex0tutorial5.Entities.Enums;
using ex0tutorial5.Entities;

namespace ex0tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t---------- Dados do cliente ----------\n");
            Console.Write("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dn))
            {
                Client cl = new Client(nomeCliente, email, dn);
                Console.WriteLine(cl.ToString());
            }
            List<Product> listaProducts = new List<Product>();
            string nomeProduto;
            Console.WriteLine("\n\n##### Dados do produto #####\n");
            Console.WriteLine("Oprimir ENTER para terminar");
            do
            {
                Console.Write("Nome: ");
                nomeProduto = Console.ReadLine();
                if (nomeProduto != "")
                {
                    Console.Write("Preço (PVP): ");
                    double pvp = double.Parse(Console.ReadLine());
                    Product p = new Product(nomeProduto, pvp);
                    listaProducts.Add(p);
                }
            } while (nomeProduto!="");
            Console.WriteLine("\n\t---------- Lista de produtos ----------\n");
            foreach(Product p in listaProducts)
                Console.WriteLine(p);
        }
    }
}
