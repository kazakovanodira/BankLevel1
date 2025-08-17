using BankLevel1.Interfaces;
using BankLevel1.Models;

namespace BankLevel1.Controllers;

public class BankController : IBankController
{
    private readonly Bank _bank;

    public BankController(Bank bank)
    {
        _bank = bank;
    }

    public Guid CreateAccount(string name)
    {
        Account newAccount = new Account
        {
            Name = name,
            AccountNumber = Guid.NewGuid(),
            Balance = 0
        };
        
        _bank.Accounts.Add(newAccount.AccountNumber, new AccountController(newAccount));

        return newAccount.AccountNumber;
    }

    public IAccountController? GetAccount(Guid accountNumber)
    {
        throw new NotImplementedException();
    }
}