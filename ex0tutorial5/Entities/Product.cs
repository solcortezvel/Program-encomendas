using System;
using System.Collections.Generic;
using System.Text;

namespace ex0tutorial5.Entities
{
    class Product
    {
        private string name; 
        private double price;
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"\n\n##### Dados do produto #####\n\tNome: {name}\n\tPreço: {price:f2}";
        }
    }
}
