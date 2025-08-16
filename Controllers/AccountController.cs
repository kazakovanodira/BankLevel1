using BankLevel1.Models;

namespace BankLevel1.Controllers;

public class AccountController
{
    private readonly Account _account;

    public AccountController(Account account)
    {
        _account = account;
    }
    
    
    
}