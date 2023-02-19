namespace AM.Core.Domain;

public class Staff: Passenger
{
    
    public DateTime EmployementDate { get; set; }
    public String Function { get; set; }
    public float Salary { get; set; }
    
    public override string ToString()
    {
        return base.ToString() + $", EmployementDate: {EmployementDate}, Function: {Function}, Salary: {Salary}";
    }

    public Staff()
    {
    }
    public Staff(DateTime birthDate, string passportNumber, string emailAddress, string firstName, string lastName, string telNumber, DateTime employementDate, string function, float salary) : base(birthDate, passportNumber, emailAddress, firstName, lastName, telNumber)
    {
        EmployementDate = employementDate;
        Function = function;
        Salary = salary;
    }
    
    public string GetPassengerType()
    {
        return base.GetPassengerTypes()+"I am a Staff Member";
    }

    
}