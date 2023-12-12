using System;
using System.Collections.Generic;
using System.Text;

namespace ex0tutorial5.Entities
{
    class OrderItem
    {
        private Product produto;
        private int quantity;
        private double price;
        public OrderItem(Product produto, int quantity, double price)
        {
            this.produto = produto;
            this.quantity = quantity;
            this.price = price;
        }
        public override string ToString()
        {
            return $"\n\n##### Dados do item encomendado #####\n\tProduto: {produto.ToString()}\n\tQuantidade: {quantity}\n\tPreço (PVP): {price:f2}";
        }
    }
}
