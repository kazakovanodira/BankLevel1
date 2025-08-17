using BankLevel1.Models;

namespace BankLevel1.Controllers;

public class BankController
{
    private readonly Bank _bank;

    public BankController(Bank bank)
    {
        _bank = bank;
    }
    
    
}