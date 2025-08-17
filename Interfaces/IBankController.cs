namespace BankLevel1.Interfaces;

public interface IBankController
{
    public Guid CreateAccount(string name);
    public IAccountController? GetAccount(Guid accountNumber);
}