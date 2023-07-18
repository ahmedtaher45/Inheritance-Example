



public class Developer: Employee
{
    protected bool TaskCompleted { set; get; }

    private const decimal Bonus = 0.03m;

    public Developer(int Id, string Name, decimal LoggedHours, decimal Wage, bool TaskCompleted) : base(Id, Name, LoggedHours, Wage)
    {
        this.TaskCompleted = TaskCompleted;
    }

    private decimal calcBonus()
    {
        return base.calculate() * Bonus;
    }
    protected override decimal calculate()
    {
        if(TaskCompleted == true)
             return base.calculate() + calcBonus();
        return 0;
    }
    public override string ToString()
    {
        return base.ToString() +
            $"\nHardship: {(TaskCompleted? "Yes" : "No")}" +
            $"\nBonus: {Math.Round(calcBonus(), 2):N0}" +
            $"\nNet salary: {Math.Round(this.calculate(), 2):N0}";
    }
}