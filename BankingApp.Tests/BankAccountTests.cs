
using NUnit.Framework;
using BankingApp;

namespace BankingApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Deposit_ValidAmount_IncreasesBalance()
    {
        // Arrange
        BankAccount account = new BankAccount(500m);

        // Act
        account.Deposit(200m);

        // Assert
        Assert.That(account.Balance, Is.EqualTo(700m));
    }

    [Test]
    public void Deposit_ZeroAmount_ThrowsException()
    {
        // Arrange
        BankAccount account = new BankAccount(500m);

        // Act and Assert
        Assert.Throws<ArgumentException>(
            () => account.Deposit(0m));
    }

    [Test]
    public void Deposit_NegativeAmount_ThrowsException()
    {
        // Arrange
        BankAccount account = new BankAccount(500m);

        // Act and Assert
        Assert.Throws<ArgumentException>(
            () => account.Deposit(-100m));
    }

    [Test]
    public void CreateAccount_NegativeBalance_ThrowsException()
    {
        Assert.Throws<ArgumentException>(
            () => new BankAccount(-500m));
    }
}
