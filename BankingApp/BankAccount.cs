
namespace BankingApp;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException(
                "Initial balance cannot be negative.");
        }

        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(
                "Deposit amount must be positive.");
        }

        Balance += amount;
    }
}