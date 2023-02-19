namespace AM.Core.Domain;

public class Passenger
{
 
    public DateTime BirthDate { get; set; }
  
    public String PassportNumber { get; set; }
    public String EmailAddress { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String TelNumber { get; set; }
    
    public int Age { get; private set; }
    
    

    public ICollection<Flight> Flights { get; set; }
    
    
    public override string ToString()
    {
        return $"PassportNumber: {PassportNumber}, BirthDate: {BirthDate}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
    }

    public Passenger()
    {
    }
    public Passenger(DateTime birthDate, string passportNumber, string emailAddress, string firstName, string lastName, string telNumber)
    {
        BirthDate = birthDate;
        PassportNumber = passportNumber;
        EmailAddress = emailAddress;
        FirstName = firstName;
        LastName = lastName;
        TelNumber = telNumber;
    }

    bool CheckProfile(String Firstname, String Lastname)
    {
        if (Firstname == FirstName && Lastname == LastName)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    bool CheckProfile2(String Firstname, String Lastname, String Emailadress=null)
    {
        if (Firstname == FirstName && Lastname == LastName && Emailadress == EmailAddress)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    
    bool CheckProfileWithAll(String Firstname, String Lastname, String Emailadress=null)
    {
       if (Emailadress== null)
       {
           return CheckProfile(Firstname, Lastname);
       }
       else
       {
           return CheckProfile2(Firstname, Lastname, Emailadress);
       }
        
    }
    
    public string GetPassengerTypes()
    {
        if(typeof(Passenger)==typeof(Passenger))
        {
            return "im a passenger";
        }
        if(typeof(Passenger)==typeof(Staff))
        {
            return "iam a passenger i am a staff member";
        }
        else
        {
            return "iam a Traveler";
        }
    }
    
    
    public void GetAge(DateTime birthDate, int calculatedAge)
    {
        int age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
        {
            age--; //
        }
        if (age == calculatedAge)
        {
            Console.WriteLine("Age is correct");
        }
        else
        {
            Console.WriteLine("Age is not correct");
        }
    }
    
    
    
   public void GetAgeP(Passenger aPassenger)
    {
        int age = DateTime.Now.Year - aPassenger.BirthDate.Year;
        if (DateTime.Now.DayOfYear < aPassenger.BirthDate.DayOfYear)
        {
            age--; //
        }
        aPassenger.Age = age;
    }
    
     
    
}