using BankLevel1.Interfaces;

namespace BankLevel1.Models;

public class Bank
{
    public Dictionary<Guid, IAccountController> Accounts { get; set; } = new();
}