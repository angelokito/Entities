using System;
using System.Collections.Generic;
using System.Text;

namespace ExerEnum_Composition.Entities.Enums.Rascunho
{
    class Rascunho
    {

        /*
                double? x = 1000;
                double? y = 10.00;

                double a = x ?? 5;
                double b = y ?? 5; // Operador de coalescência nula ?? 

                Console.WriteLine(a);
                    Console.WriteLine(b);


                    Console.WriteLine(x.GetValueOrDefault());
                    Console.WriteLine(y.GetValueOrDefault());
                    Console.WriteLine(x.HasValue);
                    Console.WriteLine(y.HasValue);

                    if (x.HasValue)
                    {
                        Console.WriteLine(x.Value);
                    }

                    else
                        Console.WriteLine("X is fucking null");

                    if (y.HasValue)
                    {
                        Console.WriteLine(y.Value);
                    }
                    else
                        Console.WriteLine("Y is null");


                    Console.WriteLine("........................................................");

                    string[] vect = new string[]
                    {
                        "Natalia", "Cleo","Thais","Marie"
                    };

                    for (int i = 0; i<vect.Length; i++)
                    {
                        Console.WriteLine(vect[i]);
                    }
                    Console.WriteLine("..........//.................//.................//.......");

                    foreach (string obj in vect)
                    {
                        Console.WriteLine(obj);
                    }

                    int[] nuvect = new int[]
                    {
                        10,20,30,40,50,60,70,80,90,100
                    };

                    foreach (int cuzinho in nuvect)
                    {
                        Console.WriteLine(cuzinho);
                    }




                    List<string> lista = new List<string>();
        lista.Add("Natalia");
                    lista.Add("Cléo");
                    lista.Add("Lais");
                    lista.Add("Liliana");
                    lista.Insert(2, "Thais");
                    lista.Insert(3, "Patricia");
                    lista.Insert(4, "Izabel");
                    lista.Insert(5, "Liara");
                    lista.Insert(6, "Letícia");
                    lista.Insert(7, "Tiemi");




                    foreach (string obj in lista)
                    {

                        Console.WriteLine(obj);
                    }

                    List<string> list2 = new List<string> { "Maria", "Camélia", "Coimbra" };


        List<double> preco = new List<double>();
        preco.Add(120.00);
                    preco.Add(300.00);
                    preco.Add(500.00);
                    preco.Add(3.500);
                    preco.Add(12.00);
                    foreach (double obj1 in preco)
                    {
                        Console.WriteLine(obj1);
                    }

                    Console.WriteLine("List count " + lista.Count);

                    string s1 = lista.Find(d => d[0] == 'L');
        Console.WriteLine("First letter L : " +s1);


                    string s2 = lista.FindLast(a => a[0] == 'L');
        Console.WriteLine(s2);      */



        /*


    var x = 10;
    var y = 20.0;
    var z = "Angelo Antonio";


    Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

        int d = int.Parse(Console.ReadLine());
    string day;
        if (d == 1)
        {
            day = "Sunday";
        }
        else if (d == 2)
        {
             day = "Monday";
        }

       else if(d == 3)
        {


            day = "Tuesday";

        }


        else
        {
          day =  "Invalid value";
        }

        Console.WriteLine("O dia é: "+day); 

        */

        /*

        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);

            }
        }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
        Console.WriteLine(Moment);
        */


        /*
           //Relação de Composição 

            Order order = new Order { Id = 666 ,    Status = OrderStatus.PendingPayment, Moment = DateTime.Now,  };
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("......................................");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            
        
         Console.Write("Entre com um preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Expressão Condicional Ternária
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);



         TimeSpan t1 = new TimeSpan();
            Console.WriteLine(t1);

            DateTime Moment = DateTime.Now;
            TimeSpan t2 = new TimeSpan(Moment.Year);
            Console.WriteLine(Moment);
            Console.WriteLine(t2);

            DateTime de = new DateTime(2020,7,18, 20,25,30);
            Console.WriteLine(de);
            
         
         */

    }

}

