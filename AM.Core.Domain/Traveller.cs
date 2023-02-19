namespace AM.Core.Domain;

public class Traveller : Passenger
{   
    public String HealthInformation { get; set; }
    public  String Nationality { get; set; }
    
    public override string ToString()
    {
        return base.ToString()+
               "HealthInformation:" + HealthInformation + "" +
               "Nationality:" + Nationality;
    }
    public Traveller()
    {
    }
    public Traveller(String healthInformation, String nationality)
    {
        HealthInformation=healthInformation;
        Nationality=nationality;
        
            
    }
    
    
        public string GetPassengerType()
        {
            return base.GetPassengerTypes()+"Traveller";
        }



}