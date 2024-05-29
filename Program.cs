namespace test2024;

class Program{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter the number of accounts Banks need:");
        int size = Convert.ToInt32(Console.ReadLine());
        BankAccount bankAccount = new BankAccount(size);

        // SavingAccount SA= new SavingAccount();
        // CurrentAccount CA = new CurrentAccount();
        // SA.Accept();
        // SA.CalculateBalance();
        // CA.Accept();
        // CA.CalculateBalance();
        
        bool c=true;
        while(c){
            Console.WriteLine("1.Add Account");
            Console.WriteLine("2.Search Account");
            Console.WriteLine("3.Display All Accounts");
            Console.WriteLine("4.Calculate balance of perticular Account");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    bankAccount.AddAccount();
                    break;
                case 2:
                    Console.WriteLine("Enter Account number:");
                    String AcNo = Console.ReadLine();
                    Account account = bankAccount.SearchAccount(AcNo);
                    if(account == null){    
                        Console.WriteLine("Account not found");
                    }
                    else{
                        account.Display();
                    }
                    break;
                case 3:
                    bankAccount.DisplayAllAccounts();
                    break;
                case 4:
                    Console.WriteLine("Enter Account number:");
                    String AcNo1 = Console.ReadLine();
                    Account account1 = bankAccount.SearchAccount(AcNo1);
                    if(account1 == null){
                        Console.WriteLine("Account not found");
                    }
                    else{
                        account1.CalculateBalance();
                    }
                    break;
                case 5:
                    c=false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}