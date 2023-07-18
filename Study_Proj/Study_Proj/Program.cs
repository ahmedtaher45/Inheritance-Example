

Manager m = new Manager(1000, "Ahmed A.", 176m, 10m);

Maintenance ma = new Maintenance(1001, "Salim M.", 185m, 9m);

Sale s = new Sale(1002, "Reem A.", 176m, 8m, 10000m, 0.05m);

Developer d = new Developer(1003, "Ali T.", 180m, 14m, true);

Employee[] employees = {m , ma , s , d };

foreach (var employee in employees)
{
    Console.WriteLine(employee);
    Console.WriteLine("\n---------------------------");
}




public class Employee
{
    protected const int HoursRequired = 176;
    protected const decimal OvertimeRate = 1.25m;
    protected int Id { set; get; }

    protected string? Name { set; get; }

    protected decimal LoggedHours { set; get; }

    protected decimal Wage { set; get; }

    public Employee(int Id, string Name, decimal LoggedHours, decimal Wage)
    {
        this.Id = Id;
        this.Name = Name;
        this.LoggedHours = LoggedHours;
        this.Wage = Wage;
    }
    protected virtual decimal calculate()
    {

        return calcOvertime() + calcBasic();
    }

    protected decimal calcBasic()
    {
        return HoursRequired * Wage;
    }

    protected decimal calcOvertime()
    {
        var additionalHours = (LoggedHours - HoursRequired > 0 ? LoggedHours - HoursRequired : 0);
        return additionalHours * OvertimeRate * Wage;
    }
    public override string ToString()
    {
        return $"\nType: {GetType()}" +
               $"\nId: {Id}" +
               $"\nName: {Name}" +
               $"\nLogged Hours: {LoggedHours}" +
               $"\nWage: {Wage}" +
               $"\nBase salary: {Math.Round(calcBasic(),2):N0}" +
               $"\nOvertime salary: {Math.Round(calcOvertime(), 2):N0}"; 
    }

}
