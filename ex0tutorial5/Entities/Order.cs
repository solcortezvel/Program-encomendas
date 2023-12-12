using System;
using System.Collections.Generic;
using System.Text;
using ex0tutorial5.Entities.Enums;

namespace ex0tutorial5.Entities
{
    class Order
    {
        private List<OrderItem> listaItems = new List<OrderItem>();
        private DateTime moment;
        private OrderStatus orderStatus;
        private Client client;
        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            this.moment = moment;
            this.orderStatus = orderStatus;
            this.client = client;
        }
        public void AddItem(OrderItem orderItem)
        {
            listaItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            listaItems.Remove(orderItem);
        }
        public override string ToString()
        {
            string res = "\n\nProdutos encomendados: ";
            foreach (OrderItem item in listaItems)
                res += "\n\t" + item.ToString();
            return $"\n\n##### Dados da encomenda #####\n\t{client}\n\tData/hora: {moment.ToShortTimeString()}/{moment.ToShortTimeString()}\n\tEstado da encomeda: {(OrderStatus) orderStatus}\n\t{res}";
        }
    }
}
