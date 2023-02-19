// See https://aka.ms/new-console-template for more information


using AM.Core.Domain;

Console.WriteLine("Hello, World!");

Plane plane = new Plane();
plane.Capacity = 100;
plane.ManucalfactureDate = new DateTime(2021, 1, 1);
plane.MyPlanetype = PlaneType.Airbus;

Plane plane2 = new Plane(100, new DateTime(2021, 1, 1),PlaneType.Airbus);



Plane plane3 = new Plane()
{
    Capacity = 100,
    ManucalfactureDate = new DateTime(2021, 1, 1),
    MyPlanetype = PlaneType.Airbus

};

Passenger passenger = new Passenger()
{
    FirstName = "John",
    LastName = "Doe",
    EmailAddress = "john@esprit.tn",
    BirthDate = new DateTime(1990, 1, 1)
};
passenger.GetAgeP(passenger);
passenger.GetAge(new DateTime(9/8/1999), 23);

    
    
    



