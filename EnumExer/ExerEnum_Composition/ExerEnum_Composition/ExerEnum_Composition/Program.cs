using ExerEnum_Composition.Entities;
using ExerEnum_Composition.Entities.Enums;
using System;
using System.Collections.Generic;


namespace ExerEnum_Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Client data: ");
            DateTime Moment = DateTime.Now;
            Console.WriteLine(Moment);
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: @ ");
            string email = Console.ReadLine();
            Console.Write(" Your Fucking Birth data: (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cliente = new Client(name, email, birth);
            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)

            {
                Console.Write($"Enter # {i} Item data: ");
                Console.Write("Product Name: ");
                string nameprod = Console.ReadLine();
                Console.Write("Product Price R$:  ");
                double priceprod = double.Parse(Console.ReadLine());

                Product product = new Product(nameprod, priceprod);

                Console.Write("Quantity:  ");

                int quantidade = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(quantidade, priceprod, product);
                order.AddItem(orderitem);
                 
                Console.WriteLine();
                Console.WriteLine("Order Summary: - ");
                Console.WriteLine(order);
            }

           

        
           


           


       }



        
    }
}
