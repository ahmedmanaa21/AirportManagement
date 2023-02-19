namespace AM.Core.Domain;

public class Plane
{
    public int Capacity { get; set; }
    public DateTime ManucalfactureDate { get; set; }
    public String Planeid { get; set; }
    public PlaneType MyPlanetype { get; set; }
    
    public ICollection<Flight> Flights { get; set; }
    
    public override string ToString()
    {
        return $"Planeid: {Planeid}, Capacity: {Capacity}, ManucalfactureDate: {ManucalfactureDate}, MyPlanetype: {MyPlanetype}";
    }
     
    public Plane()
    {
    }
    public Plane(int capacity, DateTime manucalfactureDate, PlaneType myPlanetype)
    {
        Capacity = capacity;
        ManucalfactureDate = manucalfactureDate;
        MyPlanetype = myPlanetype;
    }
        
        
    

}