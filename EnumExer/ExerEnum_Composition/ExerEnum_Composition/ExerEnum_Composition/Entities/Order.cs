﻿using System;
using System.Collections.Generic;
using System.Text;
using ExerEnum_Composition.Entities;
using ExerEnum_Composition.Entities.Enums;

namespace ExerEnum_Composition.Entities
{
    class Order
    {
       
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        public Client Cliente { get; set; }
      
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

      

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

      public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.Subtotal();
            }
            return sum;
        }
      

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " +Status);
            sb.AppendLine("Cliente: " +Cliente);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: R$ " + Total());
            return sb.ToString();
        }







        /*  public Order(DateTime moment, OrderStatus status, OrderItem item)
          {
              Moment = moment;
              Status = status;
              //Item = item;
          } */





    }
}
