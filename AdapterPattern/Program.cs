// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");


IPlane plane = new Plane();

plane.Fly();

IVehicle vehicle = new PlaneToVehicleAdapter(plane);

vehicle.Move();


IVehicle car = new Car();

car.Move();