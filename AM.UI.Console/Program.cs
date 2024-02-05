// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using System;
using System.Numerics;
using Plane = AM.ApplicationCore.Domain.Plane;

Console.WriteLine("Hello, World!");
Console.WriteLine("---------------------------------------------------------");


Plane plane = new Plane();
plane.PlaneId = 200;
plane.PlaneType = PlaneType.Airbus;
plane.capacity = 10;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane.ToString());


Plane plane3 = new Plane{PlaneId = 300,
    PlaneType = PlaneType.Airbus,
    capacity = 30,
    ManufactureDate = DateTime.Now};
    Console.WriteLine(plane3.ToString());
Console.WriteLine("---------------------------------------------------------");

//CheckProfile
//PassengerType passenger
Passenger passenger = new Passenger();
passenger.BirthDate = DateTime.Now;
passenger.EmailAddress = "a@a.com";
passenger.FirstName = "A";
passenger.LastName = "B";
passenger.PassportNumber = "123";
passenger.TelNumber = "123";
Console.WriteLine(passenger.ToString());
Console.WriteLine("---------------------------------------------------------");
passenger.PassengerType();

//PassengerType staff
Staff staff = new Staff();
staff.BirthDate = DateTime.Now;
staff.EmailAddress = "a@a.com";
staff.FirstName = "A";
staff.LastName = "B";
staff.PassportNumber = "123";
staff.TelNumber = "123";
staff.EmploymentDate = DateTime.Now;
staff.Function = "Pilot";
staff.Salary = 1000;
Console.WriteLine(staff.ToString());
Console.WriteLine("---------------------------------------------------------");
staff.PassengerType();
//PassengerType staff
Traveller traveller = new Traveller();
traveller.BirthDate = DateTime.Now;
traveller.EmailAddress = "b@b.com";
traveller.FirstName = "B";
traveller.LastName = "C";
traveller.PassportNumber = "456";
traveller.TelNumber = "456";
traveller.HealthInformation = "Good";
//Console.WriteLine(traveller.ToString());
Console.WriteLine("---------------------------------------------------------");
traveller.PassengerType();
Console.WriteLine("---------------------------------------------------------");

