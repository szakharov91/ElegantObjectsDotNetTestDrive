using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantObjectsDotNetTestDrive;

/// <summary>
/// Class encapsulate money behaviour
/// </summary>
public class Money: ICurrency
{
    private readonly decimal amount;

    public Money(decimal amount)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative!");

        this.amount = amount;
    }

    public ICurrency Add(ICurrency currency)
    {
        return new Money(amount + currency.Amount());
    }

    public ICurrency Subtract(ICurrency currency)
    {
        if (amount < currency.Amount())
            throw new InvalidOperationException("Not enough amount");

        return new Money(amount - currency.Amount());
    }

    /// <summary>
    /// Maybe it's the same as getter...not sure is it good in that philosophy
    /// </summary>
    public decimal Amount() => amount;

    string ICurrency.ToString()
    {
        return amount.ToString("C2");
    }
}
