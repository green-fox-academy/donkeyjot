using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get;set; }

        public BankAccount()
        {
        }

        public BankAccount(string name, decimal balance, string animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }
    }
}