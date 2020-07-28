﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerEnum_Composition.Entities
{
    class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        public OrderItem()
        {


        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

      /*  public OrderItem(int quantity, double price, double total)
        {
            Quantity = quantity;
            Price = price;
            Total = total;
        }   */


    

        public double Subtotal()
        {
           return  Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Nameprod 
            + " , $" + Price.ToString() 
            + "Quantity: " 
            + Quantity 
            + ", Subtotal: $" 
            + Subtotal().ToString();
        }
    }





}
