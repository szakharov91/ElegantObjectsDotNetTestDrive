using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantObjectsDotNetTestDrive;

/// <summary>
/// Interface of (Bank...or some different) Account
/// </summary>
public interface IAccount
{
    public ICurrency Balance();
    public IAccount Deposit(ICurrency amount);
    public IAccount Withdraw(ICurrency amount);
}
