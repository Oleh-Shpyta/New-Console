using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Account account = new Account("Основний рахунок: ", 100);
            account.Deposit(100);
            account.Whithdraw(50);
            Console.WriteLine($"Поточний баланс : {account.GetBalance()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка {ex.Message}");
        }
    }
}
public class Account
{
    public string Name { get; private set; }
    public decimal balance;

    public Account(string name, decimal initialbalance)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Назва рахунке не повинна бути порожньою.");
        }
        if (initialbalance < 0)
        {
            throw new ArgumentNullException("Початкова сума не може бути від'ємною");
        }
        Name = name;
        balance = initialbalance;
    }
    public decimal GetBalance()
    {
        return balance;
    }
    public void Deposit(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Сума повина бути більша за 0!");
        }
        balance += money;
        Console.WriteLine($"На {Name} додано {money}грн. Поточний баланс: {balance}грн.");
    }
    public void Whithdraw(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("Сума повинна бути більшою за 0!");
        }
        if (money > balance)
        {
            throw new InvalidOperationException("Недостатньо коштів на рахунку!");
        }
        balance -= money;
        Console.WriteLine($"З {Name} знято {money}грн. Поточний баланс: {balance}грн.");
    }
}
