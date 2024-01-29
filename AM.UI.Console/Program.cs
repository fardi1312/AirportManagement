﻿// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using System.Numerics;
using Plane = AM.ApplicationCore.Domain.Plane;

Console.WriteLine("Hello, World!");

/*
Plane plane = new Plane();
plane.PlaneId = 200;
plane.PlaneType = PlaneType.Airbus;
plane.capacity = 10;
plane.ManufactureDate = DateTime.Now;
Console.WriteLine(plane.ToString());

Plane plane2 = new Plane(PlaneType.Boing, 20, DateTime.Now);
plane2.PlaneId = 450;
Console.WriteLine(plane2.ToString());*/

Plane plane3 = new Plane{PlaneId = 300, PlaneType = PlaneType.Airbus, capacity = 30, ManufactureDate = DateTime.Now};
Console.WriteLine(plane3.ToString());
