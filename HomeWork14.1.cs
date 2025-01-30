using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Account account = new Account("�������� �������: ", 100);
            account.Deposit(100);
            account.Whithdraw(50);
            Console.WriteLine($"�������� ������ : {account.GetBalance()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"������� {ex.Message}");
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
            throw new ArgumentNullException("����� ������� �� ������� ���� ���������.");
        }
        if (initialbalance < 0)
        {
            throw new ArgumentNullException("��������� ���� �� ���� ���� ��'�����");
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
            throw new ArgumentException("���� ������ ���� ����� �� 0!");
        }
        balance += money;
        Console.WriteLine($"�� {Name} ������ {money}���. �������� ������: {balance}���.");
    }
    public void Whithdraw(decimal money)
    {
        if (money <= 0)
        {
            throw new ArgumentException("���� ������� ���� ������ �� 0!");
        }
        if (money > balance)
        {
            throw new InvalidOperationException("����������� ����� �� �������!");
        }
        balance -= money;
        Console.WriteLine($"� {Name} ����� {money}���. �������� ������: {balance}���.");
    }
}
