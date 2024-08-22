namespace Classes;

public class BankAccount
{
  public string Number {get;}
  public string Owner {get;set;}

  public decimal Balance
  {
    get
    {
      decimal balance = 0;
      foreach (var item in _allTransactions)
      {
        balance += item.Amount;
      }
      return balance;
    }
  }

  private static int s_accountNumberSeed = 1234567890;

  public BankAccount(string name, decimal initialBalance)
  {
    Number = s_accountingNumberSeed.ToString();
    s_accountNumberSeed++;

    Owner = name;
    MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
  }

  private List<Transaction> _allTransactions = new List<Transaction>();

  public void MakeDeposit(decimal amount, DateTime date, string note)
  {
    if (amount <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
    }
    var deposit = new Transaction(amount, date, note);
    _allTransactions.Add(deposit);
  }
}