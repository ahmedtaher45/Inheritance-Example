



public class Sale: Employee
{
    protected decimal SalesValume { set; get; }
    protected decimal Comission { set; get; }

    public Sale(int Id, string Name, decimal LoggedHours, decimal Wage, decimal SalesValume, decimal Comission) : base(Id, Name, LoggedHours, Wage)
    {
        this.SalesValume = SalesValume;
        this.Comission = Comission;
    }
    private decimal calcComission()
    {
        return SalesValume * Comission;
    }
    protected override decimal calculate()
    {
        return base.calculate() + calcComission();
    }
    public override string ToString()
    {
        return base.ToString() +
             $"\nHardship: {Comission}" +
            $"\nComission: {Math.Round(calcComission(), 2):N0}" +
            $"\nNet salary: {Math.Round(this.calculate(), 2):N0}";

    }
}