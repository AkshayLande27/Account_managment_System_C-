namespace test2024;

public class CurrentAccount : Account
{
    double _CurrentCharges;


    public CurrentAccount() : base(){
        _CurrentCharges = 0.0;
    }
    public CurrentAccount(String AccNo, string Aname): base(AccNo, Aname)
    {
        _CurrentCharges = 0.0;
    }
    public double CurrentCharges
    {
        get{
            return _CurrentCharges;
        }
        set
        {
            _CurrentCharges = value;
        }
    }
    public override void Accept()
    {
        base.Accept();
        Console.WriteLine("Enter Current Charges:");
        _CurrentCharges = double.Parse(Console.ReadLine());
    }

    public override void CalculateBalance()
    {
        Balance += Balance - CurrentCharges;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Current Charges: " + _CurrentCharges);
        Console.WriteLine();
    }
}
