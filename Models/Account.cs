namespace BankLevel1.Models;

public class Account
{
    public string Name { get; set; } = string.Empty;
    public Guid AccountNumber { get; set; }
    public decimal Balance = 0;
}