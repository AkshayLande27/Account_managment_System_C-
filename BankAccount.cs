namespace test2024;

public class BankAccount
{
     Account[] accounts;
     public int currentIndex;

    public BankAccount(int size){
        accounts = new Account[size];
        currentIndex = 0;
    }

    // public int currentIndex
    // {
    //     get
    //     {
    //         return _currentIndex;
    //     }
    //     set
    //     {
    //         _currentIndex = value;
    //     }
    // }


    public void AddAccount(){
        if (currentIndex >= accounts.Length)
        {
            Console.WriteLine("No more accounts can be added.");
            return;
        }
        Console.WriteLine("Enter \n 1.for Savings Account \n 2.for Current Account:");
        int choice = Convert.ToInt32(Console.ReadLine());
        Account NewAccount;
        if (choice == 1)
        {
            NewAccount = new SavingAccount();
        }
        else if (choice == 2)
        {
            NewAccount = new CurrentAccount();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
        NewAccount.Accept();
        accounts[currentIndex] = NewAccount;
        currentIndex++;
        System.Console.WriteLine("Account added successfully.");
        System.Console.WriteLine("----------------------------");
    }
    public Account SearchAccount(String AcNo)
    {
        for (int i = 0; i < currentIndex; i++)
        {
            if (accounts[i].AccNo == AcNo)
            {
                return accounts[i];
            }
        }
        return null;
    }
    public void DisplayAllAccounts()
{
    for (int i = 0; i < currentIndex; i++)
    {
        accounts[i].Display();
    }
}
        
    }


