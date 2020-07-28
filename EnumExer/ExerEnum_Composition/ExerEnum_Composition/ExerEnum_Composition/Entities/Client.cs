using System;
using System.Collections.Generic;
using System.Text;
using ExerEnum_Composition.Entities.Enums;

namespace ExerEnum_Composition.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birth { get; set; }// public DateTime Bith = 03 / 07 / 1984 18:45:16;



        public Client()
        {

        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            Birth = birth;
        }

        public override string ToString()
        {
            return Name
            +", (" +Birth.ToString("dd/MM/yyyy")+") -  Your Email: @" +Email    ;
        }
    }

}
