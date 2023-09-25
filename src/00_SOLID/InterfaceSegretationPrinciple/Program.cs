// Zasada segregacji interfejsów (Interface Segregation Principle) – ISP

// Kod nie powinien być zmuszany do polegania na metodach, których nie używa.


var atm = new SecondATM(1000);

if (atm is IWithdrawable)
{
    atm.Withdraw(100);
}

if (atm is IDepositable atmDepositable)
{
    atmDepositable.Deposit(50);
}


var balance = atm.CheckBalance();

Console.WriteLine(balance);



public interface IATM : ICheckBalance, IWithdrawable, IDepositable
{
}

public interface ICheckBalance
{
    decimal CheckBalance();
}

public interface IWithdrawable
{
    bool Withdraw(decimal amount); // Wypłata
}

public interface IDepositable
{
    void Deposit(decimal amount); // Wpłata
}

public class SecondATM : ICheckBalance, IWithdrawable
{
    private decimal balance;

    public SecondATM(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal CheckBalance()
    {
        return balance;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
            return false;
        }
    }
}

public class FirstATM : ICheckBalance, IWithdrawable, IDepositable
{
    private decimal balance;

    public FirstATM(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal CheckBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposit successful. New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid amount for deposit.");
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount.");
            return false;
        }
    }
}

// Przykład 2
public interface IMediaPlayer
{
    void PlayAudio();
    void PlayVideo();
    // void StreamContent();
}


