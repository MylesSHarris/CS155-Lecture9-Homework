using System;
namespace Homework
{
    public class Homework
    {
        static void Main(string[] arguments)
        {
            Person person1 = new Person("John Doe");
            Person person2 = new Person(person1);

            Vehicle vehicle = new Vehicle(Vehicle.Manufacturer.Honda, 4, person1);
            Console.WriteLine(vehicle);

            Truck truck = new Truck(Vehicle.Manufacturer.Ford, 4, person1, 100, 300);
            Console.WriteLine(truck);
        }
    }
}
