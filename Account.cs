namespace test2024;

public  abstract class Account
{
    String _AccNo;
    String _Aname;
    double _Balance;
    // Ma'am I have used _naming convetion to differentiate the property and variable of the class

    static int isbn_no=12345789;
    static double _RateOfIntrest=1.5;

    public Account()
    {
        _AccNo = "";
        _Aname = "";
        _Balance = 0.0;
    }
    public Account(String AccNo, String Aname)
    {
        this.AccNo = AccNo;
        this.Aname = Aname;
        this.Balance = 0;
        isbn_no=12345;
        _RateOfIntrest = 1.5;
    }
    public String AccNo{
        get{
            return _AccNo;
        }
        set{
            _AccNo = value;
        }
    }
    public String Aname{
        get{
            return _Aname;
        }
        set{
            _Aname=value;
        }

    }
    public double Balance{
        get{
            return _Balance;
        }
        set{
            _Balance = value;
        }
    }
    public double RateOfIntrest{
        get{ return _RateOfIntrest; }
        set{ _RateOfIntrest = value; }
    }
    public virtual void Display(){
        
        Console.WriteLine("Account Number: " + AccNo);
        Console.WriteLine("Account Holder Name: " + Aname);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Isbn no: " + isbn_no);
        Console.WriteLine("rate of intrest: " + RateOfIntrest);

    }

    public virtual void Accept(){
        Console.WriteLine("Enter Account Number:");
        AccNo = Console.ReadLine();
        Console.WriteLine("Enter Account Holder Name:");
        Aname = Console.ReadLine();
        Console.WriteLine("Enter Balance:");
        Balance = double.Parse(Console.ReadLine());
        
    }
    public abstract void CalculateBalance();
    public override string ToString()
    {
        return "Account Number: " + AccNo + "\nAccount Holder Name: " + Aname + "\nBalance: " + Balance;
    }




}
