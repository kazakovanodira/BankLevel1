namespace BankLevel1.Interfaces;

public interface IAccountController
{
    public decimal Deposit(decimal amount);
    public decimal Withdraw(decimal amount);
    public decimal CheckBalance();
}