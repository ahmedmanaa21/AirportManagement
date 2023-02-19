namespace AM.Core.Domain;

public class Flight
{
    public String Destination { get; set; }
    public DateTime Departure { get; set; }
    public DateTime FlightDate { get; set; }
    public String Flightid { get; set; }
    public DateTime EffectiveArrival { get; set; }
    public float EstimatedDuraction { get; set; }
    
    public ICollection<Passenger> Passengers { get; set; }
    public Plane Plane { get; set; }
    
    public override string ToString()
    {
        return $"Flight: {Flightid} - {Destination} - {Departure} - {FlightDate} - {EffectiveArrival} - {EstimatedDuraction}";
    }
    
    public Flight()
    {
    }

    public Flight(string destination, DateTime departure, DateTime flightDate, string flightid, DateTime effectiveArrival, float estimatedDuraction)
    {
        Destination = destination;
        Departure = departure;
        FlightDate = flightDate;
        Flightid = flightid;
        EffectiveArrival = effectiveArrival;
        EstimatedDuraction = estimatedDuraction;
    }

}