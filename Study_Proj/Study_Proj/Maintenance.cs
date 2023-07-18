



public class Maintenance: Employee
{
    private const decimal Hardship = 100m;

    public Maintenance(int Id, string Name, decimal LoggedHours, decimal Wage) : base(Id, Name, LoggedHours, Wage)
    {

    }
    protected override decimal calculate()
    {
        return base.calculate() + Hardship;
    }
    public override string ToString()
    {
        return base.ToString() +
             $"\nHardship: {Hardship}" +
             $"\nNet salary: {Math.Round(this.calculate(), 2):N0}";
    }
}