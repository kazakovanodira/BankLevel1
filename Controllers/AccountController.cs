using BankLevel1.Interfaces;
using BankLevel1.Models;

namespace BankLevel1.Controllers;

public class AccountController : IAccountController
{
    private readonly Account _account;

    public AccountController(Account account)
    {
        _account = account;
    }

    public decimal Deposit(decimal amount) => 
        _account.Balance += amount;

    public decimal Withdraw(decimal amount) =>
        _account.Balance -= amount;

    public decimal CheckBalance() => 
        _account.Balance;
}