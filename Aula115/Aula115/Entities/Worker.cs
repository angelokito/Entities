using System;
using System.Collections.Generic;
using System.Text;
using Aula115.Entities.Enums;

namespace Aula115.Entities
{
    class Worker
    {

        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string nome, WorkerLevel level, double baseSalary, Department department)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);

        }

    }
}
