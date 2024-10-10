using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegantObjectsDotNetTestDrive;

/// <summary>
/// Currency interface
/// </summary>
public interface ICurrency
{
    public ICurrency Add(ICurrency currency);
    public ICurrency Subtract(ICurrency currency);
    public decimal Amount();
    public string ToString();
}
