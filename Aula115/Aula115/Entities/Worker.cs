using System;
using System.Collections.Generic;
using System.Text;
using Aula115.Entities.Enums;
using Aula115.Entities;

namespace Aula115.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //Propriedade WorkerLevel
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Propriedade Department do tipo Department

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        

        public Worker() // Contrutor
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)//Construtor com Argumentos
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)// Metodo para adicionar contrato .Add
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)// Metodo para Remover contrato .Remove
        {
            Contracts.Remove(contract);

        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
