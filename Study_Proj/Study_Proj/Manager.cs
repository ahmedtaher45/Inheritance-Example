



public class Manager: Employee
{
    private const decimal AllowanceRate = 0.05m;

    public Manager(int Id, string Name, decimal LoggedHours, decimal Wage) :base( Id,  Name,  LoggedHours,  Wage)
    {
        
    }
    protected override decimal calculate()
    {
        return base.calculate() + calculateAllowance();
    }
    private decimal calculateAllowance()
    {
        return AllowanceRate * base.calculate();
    }
    public override string ToString()
    {
        return base.ToString() +
            $"\nAllowance: {Math.Round(calculateAllowance(),2):N0}"+
            $"\nNet salary: {Math.Round(this.calculate(), 2):N0}";
    }
}