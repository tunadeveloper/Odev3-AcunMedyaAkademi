using Odev3_AcunMedyaAkademi;
using System;

class Program
{
    static void Main(string[] args)
    {
        Employee manager = new Manager { Id = 1, Name = "Tunahan", Salary = 5000, Department = "IT", TeamSize = 10 };
        Employee developer = new Developer { Id = 2, Name = "Cengiz", Salary = 4000, Department = "Development", About = "Backend Developer" };

        Console.WriteLine($"Yönetici {manager.Name} Bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"Geliştirici {developer.Name} Bonus: {developer.CalculateBonus()}");

        BankAccount savings = new SavingsAccount { AccountHolder = "Tunahan", Balance = 10000 };
        BankAccount checking = new CheckingAccount { AccountHolder = "Cengiz", Balance = 5000 };

        Console.WriteLine($"Vadeli Hesap Faiz: {savings.CalculateInterest()}");
        checking.CalculateInterest();
    }
}
