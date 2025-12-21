using System;
using System.Collections.Generic;
using System.Text;
using warehouse_operations_accounting_program.Interfaces;
using warehouse_operations_accounting_program.Models;

namespace warehouse_operations_accounting_program.Services
{
    public class ClientService : IClientService
    {
        private readonly List<Contractor> contractors = new();
        public ClientService(List<Contractor> loadedContractors)
        {
            contractors = loadedContractors ?? new List<Contractor>();
        }

        public IEnumerable<Contractor> GetAll()
        {
            return contractors;
        }

        public void CreateIndividual(string name, string contact, string passport)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(passport))
                throw new ArgumentException("Неполные данные");

            var сontractor = new Individual(name, contact, passport);
            contractors.Add(сontractor);
        }

        public void CreateCompany(string name, string contact, string inn, string kpp)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(inn))
                throw new ArgumentException("Неполные данные");

            var сontractor = new Company(name, contact, inn, kpp);
            contractors.Add(сontractor);
        }
    }
}
