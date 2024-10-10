using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantObjectsDotNetTestDrive;

public class BankAccount<T>: IAccount 
    where T: ICurrency
{
    private readonly T balance;

    public BankAccount(T initialBalance)
    {
        balance = initialBalance ?? throw new ArgumentNullException(nameof(initialBalance));
    }

    public ICurrency Balance() => balance;

    public IAccount Deposit(ICurrency amount)
    {
        return new BankAccount<T>((T)balance.Add(amount));
    }

    public IAccount Withdraw(ICurrency amount)
    {
        return new BankAccount<T>((T)balance.Subtract(amount));
    }
}
