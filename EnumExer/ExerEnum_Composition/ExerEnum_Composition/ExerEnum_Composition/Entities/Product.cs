using ExerEnum_Composition.Entities.Enums;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;

namespace ExerEnum_Composition.Entities
{
    class Product
    { 
        public string Nameprod { get; set; }
        public double Priceprod { get; set; }

      //  public int Quantidade { get; set; }


        public Product()
        {

        }
     
     
        public Product(string nameprod, double priceprod)
        {
            Nameprod = nameprod;
            Priceprod = priceprod;
        }


        /*
        public Product(string nameprod, double priceprod, int quantidade):this(nameprod, priceprod)
        {
            Nameprod = nameprod;
            Priceprod = priceprod;
            Quantidade = quantidade;
        }

             


        public override string ToString()
        {
            return "OrderMoment:  " + DateTime.Now
            
            + OrderStatus.Processing;
           // +" Client: " +Name
           // +Email + Birth;

    
        }  */
    

    }
}
