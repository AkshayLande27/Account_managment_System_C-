namespace test2024;

public class SavingAccount : Account
{
    double _SavingIntrest;
    public SavingAccount() : base()
    {
        _SavingIntrest = 0.0;
    }
    public SavingAccount(String AccNo, string Aname) : base(AccNo, Aname)
    {
        _SavingIntrest = 0.0;
    }
    public double SavingIntrest
    {
        get{
            return _SavingIntrest;
        }
        set{
            _SavingIntrest = value;
        }

    }

    public override void Accept()
    {
        base.Accept();
        Console.WriteLine("Enter Current Saving Intrest: ");
        _SavingIntrest = double.Parse(Console.ReadLine());
    }

    public override void CalculateBalance()
    {
        // anual intrest is considered for simplicity
        double TotalIntrest= RateOfIntrest+ SavingIntrest;
        Balance += Balance * TotalIntrest;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Saving Account Intrest: " + _SavingIntrest);
        Console.WriteLine();

    }
}
